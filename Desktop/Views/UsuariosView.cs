﻿using Firebase.Auth;
using Firebase.Auth.Providers;
using Service.Enums;
using Service.Models;
using Service.Services;
using System.Data;
using System.Net.Http.Headers;

namespace Desktop.Views
{
    public partial class UsuariosView : Form
    {
        GenericService<Usuario> _usuarioService = new();

        Usuario _currentUsuario;
        List<Usuario>? _usuario;
        FirebaseAuthClient _firebaseAuthClient;

        public UsuariosView()
        {
            InitializeComponent();
            _ = GetAllData();
            SettingFirebase();
            checkVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;

        }
        private void SettingFirebase()
        {
            var config = new FirebaseAuthConfig()
            {
                ApiKey = Service.Properties.Resources.ApiKeyFirebase,
                AuthDomain = Service.Properties.Resources.AuthDomainFirebase,
                Providers = new FirebaseAuthProvider[]
                {
            new EmailProvider()
                }
            };
            _firebaseAuthClient = new FirebaseAuthClient(config);
        }

        private void DisplayHideControlsRestoreButton(object? sender, EventArgs e)
        {
            BtnRestaurar.Visible = checkVerEliminados.Checked;
            TxtBuscar.Enabled = !checkVerEliminados.Checked;
            BtnModificar.Enabled = !checkVerEliminados.Checked;
            BtnEliminar.Enabled = !checkVerEliminados.Checked;
            BtnAgregar.Enabled = !checkVerEliminados.Checked;
            BtnBuscar.Enabled = !checkVerEliminados.Checked;
        }

        private async Task GetAllData()
        {
            if (checkVerEliminados.Checked)
                _usuario = await _usuarioService.GetAllDeletedAsync();
            else
                _usuario = await _usuarioService.GetAllAsync();

            DataGrid.DataSource = _usuario;
            DataGrid.Columns["Id"].Visible = false; // Ocultar la columna Pais
            DataGrid.Columns["IsDeleted"].Visible = false; // Ocultar la columna Eliminado
            DataGrid.Columns["DeleteDate"].Visible = false; // Ocultar la columna Fecha de Eliminación
            await GetComboTiposDeUsuaio();

        }

        private async Task GetComboTiposDeUsuaio()
        {
            //Cargo el combo de tipos con el enum TipoUsuario
            ComboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                //Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Usuario entitySelected = (Usuario)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el usuario {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _usuarioService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Usuario {entitySelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab = TabPageAgregarEditar;
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
            TxtDni.Clear();
            TxtEmail.Clear();
            TxtApellido.Clear();
            TextPassword.Clear();
            TxtPassword2.Clear();
            GetComboTiposDeUsuaio();
            LabelPassword.Text = "Contraseña:";
            LabelPassword2.Text = "Repetir de Contraseña:";
            TextPassword.PlaceholderText = "Minimo 6 Caracteres";
            TxtPassword2.PlaceholderText = "Minimo 6 Caracteres";



        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPageLista;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!DataControl())
                return;
            {
                Usuario usuarioAGuardar = GetUserDataFromScreen();
                bool responseSuccessfull = false;
                if (_currentUsuario != null)
                {
                    responseSuccessfull = await _usuarioService.UpdateAsync(usuarioAGuardar);
                    if (responseSuccessfull && !string.IsNullOrWhiteSpace(TextPassword.Text) && !string.IsNullOrWhiteSpace(TxtPassword2.Text))
                    {
                        await UpdatePasswordInFirebase(usuarioAGuardar);
                    }
                    if (_currentUsuario == null)//agregando un nuevo usuario
                    {
                        try
                        {
                            var nuevoUsuario = await _usuarioService.AddAsync(usuarioAGuardar);
                            responseSuccessfull = nuevoUsuario != null;
                            if (responseSuccessfull)
                                await CreateUserInFirebase(nuevoUsuario);// Crear el usuario en Firebase Authentication
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al crear el usuario en Firebase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                      
                    }
                }
                else
                {
                    
                    var nuevoUsuario = await _usuarioService.AddAsync(usuarioAGuardar);
                    responseSuccessfull = nuevoUsuario != null;
                    if (responseSuccessfull)
                    {
                        // Crear el usuario en Firebase Authentication
                        try
                        {
                            var userCredential = await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(
                                nuevoUsuario.Email,
                                TxtPassword2.Text.Trim(),
                                nuevoUsuario.Nombre + " " + nuevoUsuario.Apellido// Contraseña por defecto, se recomienda cambiarla luego
                            );
                            //cambio de contraseña al crear el usuario

                            await SendVerificationEmailAsync(userCredential.User.GetIdTokenAsync().Result); // Enviar correo de verificación
                        }
                        catch (FirebaseAuthException ex)
                        {
                            MessageBox.Show($"Error al crear el usuario en Firebase: {ex.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (!responseSuccessfull)
                {
                    MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                { 

                    _currentUsuario = null; // Reset the modified movie after saving
                    LabelStatusMessage.Text = $"Usuario {usuarioAGuardar.Nombre} guardado correctamente";
                    TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                    await GetAllData();
                    LimpiarControlesAgregarEditar();
                    TabControl.SelectedTab = TabPageLista;
                }

                
               
            }
        }


        private async Task UpdatePasswordInFirebase(Usuario usuarioAGuardar)
        {
            try
            {
                var userCredential = await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(
                    usuarioAGuardar.Email,
                    TxtPassword2.Text.Trim()
                );
                await userCredential.User.ChangePasswordAsync(TxtPassword2.Text.Trim());
                

            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show($"Error al actualizar la contraseña en Firebase: {ex.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CreateUserInFirebase(Usuario? nuevoUsuario)
        {
            try
            {
                var userCredential = await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(
                    nuevoUsuario.Email,
                    TxtPassword2.Text.Trim(),
                    nuevoUsuario.Nombre + " " + nuevoUsuario.Apellido// Contraseña por defecto, se recomienda cambiarla luego
                );
                await SendVerificationEmailAsync(userCredential.User.GetIdTokenAsync().Result); // Enviar correo de verificación
            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show($"Error al crear el usuario en Firebase: {ex.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Usuario GetUserDataFromScreen()
        {
           return new Usuario
            {
                Id = _currentUsuario != null ? _currentUsuario.Id : 0,
                Nombre = TxtNombre.Text.Trim(),
                Apellido = TxtApellido.Text.Trim(),
                Dni = TxtDni.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
                TipoUsuario = (TipoUsuarioEnum)ComboTipoUsuario.SelectedItem
            };
        }

        private bool DataControl()
        {
            // Validaciones simples
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtDni.Text))
            {
                MessageBox.Show("El DNI no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("El email no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_currentUsuario == null && (TextPassword.Text != TxtPassword2.Text))
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_currentUsuario == null && (string.IsNullOrWhiteSpace(TextPassword.Text) || string.IsNullOrWhiteSpace(TxtPassword2.Text)))
            {
                MessageBox.Show("Debe completar el campo contraseña y verificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_currentUsuario != null && (string.IsNullOrWhiteSpace(TextPassword.Text) && string.IsNullOrWhiteSpace(TxtPassword2.Text)))//moificacion que no cambia la contraseña
            {
                return true;
            }

            if (_currentUsuario != null && (string.IsNullOrWhiteSpace(TextPassword.Text) || string.IsNullOrWhiteSpace(TxtPassword2.Text)))
            {
                MessageBox.Show("Para modificar la contraseña debe completar la contraseña anterior y nueva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((TextPassword.Text.Length<6) || (TxtPassword2.Text.Length<6))
            {
                MessageBox.Show("las contraseñas deben tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya una capacitación seleccionada
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                _currentUsuario = (Usuario)DataGrid.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentUsuario.Nombre;
                TxtApellido.Text = _currentUsuario.Apellido;
                TxtDni.Text = _currentUsuario.Dni;
                TxtEmail.Text = _currentUsuario.Email;
                ComboTipoUsuario.SelectedItem = _currentUsuario.TipoUsuario;



                LabelPassword.Text = "Contraseña anterior:";
                LabelPassword2.Text = "Nueva Contraseña:";
                TextPassword.PlaceholderText = "Dejar en blanco para no midificar";
                TxtPassword2.PlaceholderText = "Dejar en blanco para no midificar";
                TabControl.SelectedTab = TabPageAgregarEditar;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = await _usuarioService.GetAllAsync(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!checkVerEliminados.Checked) return;
            //checheamos que haya peliculas seleccionadas
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Usuario entitySelected = (Usuario)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que recuper el usuario {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _usuarioService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Usuario {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario para restaurarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task SendVerificationEmailAsync(string idToken)
        {
            // Se crea una instancia de HttpClient dentro de un bloque using.
            // Esto asegura que los recursos utilizados por HttpClient se liberen correctamente al finalizar.
            using (var client = new HttpClient())
            {
                var FirebaseApiKey = Service.Properties.Resources.ApiKeyFirebase;
                var RequestUri = "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + FirebaseApiKey; 
                // Se agrega un encabezado HTTP para indicar que la solicitud acepta respuestas en formato JSON.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Se crea el contenido de la solicitud en formato JSON.
                // Este JSON incluye:
                // - "requestType": Especifica que el tipo de solicitud es para verificar un correo electrónico.
                // - "idToken": El token de identificación del usuario autenticado, necesario para autorizar la solicitud.
                var content = new StringContent("{\"requestType\":\"VERIFY_EMAIL\",\"idToken\":\"" + idToken + "\"}");
                
                // Se establece el tipo de contenido como "application/json" para que el servidor lo interprete correctamente.
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Se envía una solicitud HTTP POST a la URL especificada en "RequestUri" con el contenido JSON.
                var response = await client.PostAsync(RequestUri, content);

                // Se asegura que la respuesta HTTP tenga un código de estado exitoso (2xx).
                // Si no es exitoso, se lanza una excepción.
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
