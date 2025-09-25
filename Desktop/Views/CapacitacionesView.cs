using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {

        GenericService<Capacitacion> _capacitacionService = new GenericService<Capacitacion>();
        Capacitacion _currentCapacitacion;
        List<Capacitacion>? _capacitaciones;
        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
            checkVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
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
            {
                _capacitaciones = await _capacitacionService.GetAllDeletedAsync();
            }
            else
            {
                _capacitaciones = await _capacitacionService.GetAllAsync();

            }
            
            GridData.DataSource = _capacitaciones;
            GridData.Columns["Id"].Visible = false;
            GridData.Columns["IsDeleted"].Visible = false; // Ocultamos la columna eliminar

        }
        private void GridPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (GridData.RowCount > 0 && GridData.SelectedRows.Count > 0)
            {
                //    Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //    FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //checkeamos que haya peliculas seleccionadas
            if (GridData.RowCount > 0 && GridData.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridData.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar la capacitacion ?{entitySelected.Nombre}", "Borrar Pelicula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {


                    if (await _capacitacionService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"capacitacion {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar la Capacitacion", "Borrar Capcitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay peliculas seleccionadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
              LimpiarControlAgregar();
               TabControl.SelectedTab = tabPageAgregar_Editar;
        }
        private void LimpiarControlAgregar()
        {
            //limpiamos todo
            TxtNombre.Clear();
            TxtDetalle.Clear();
            dateTimeFechaHora.Value = DateTime.Now;
            TxtExponente.Clear();
            checkInscripcionAbierta.Checked = false;
            NumericCupo.Value = 0;
 
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = tabPageAgregar_Editar;
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            Capacitacion CapacitacionAGuardar = new Capacitacion
            {
                Id = _currentCapacitacion?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Detalle = TxtDetalle.Text,
                Ponente = TxtExponente.Text,
                FechaHora = dateTimeFechaHora.Value,
                Cupo = (int)NumericCupo.Value,
                InscripcionAbierta = checkInscripcionAbierta.Checked
            };
             bool response = false;
            if (_currentCapacitacion != null)
            {
                 response = await _capacitacionService.UpdateAsync(CapacitacionAGuardar);
            }
            else
            {
                var nuevacapacitacion = await _capacitacionService.AddAsync(
                   CapacitacionAGuardar);
                response = nuevacapacitacion != null;
            }
            if (response)
            {
                _currentCapacitacion = null;
                MessageBox.Show($"Capacitacion {CapacitacionAGuardar.Nombre} guardo correctamente");
                await GetAllData();
                TabControl.SelectedTab=tabPageLista;
            }
            else
            {
                MessageBox.Show("Error al modificar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
                if (GridData.RowCount > 0 && GridData.SelectedRows.Count > 0)
                {
                    _currentCapacitacion = (Capacitacion)GridData.SelectedRows[0].DataBoundItem;
                    TxtNombre.Text = _currentCapacitacion.Nombre;
                    TxtDetalle.Text = _currentCapacitacion.Detalle;
                    dateTimeFechaHora.Value = _currentCapacitacion.FechaHora;
                    TxtExponente.Text = _currentCapacitacion.Ponente;
                    NumericCupo.Value = _currentCapacitacion.Cupo;
                    checkInscripcionAbierta.Checked = _currentCapacitacion.InscripcionAbierta;

                    TabControl.SelectedTab = tabPageAgregar_Editar;
                }
        }

        private async Task iconButton1_Click(object sender, EventArgs e)
        {
            GridData.DataSource = await _capacitacionService.GetAllAsync(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
              BtnBuscar.PerformClick();
        }

        //}

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

            //checkeamos que haya peliculas seleccionadas
            if (GridData.RowCount > 0 && GridData.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridData.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres recuperar la capacitacion ?{entitySelected.Nombre}", "Confirmar Restauracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {


                    if (await _capacitacionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"capacitacion {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }


                    else
                    {
                        MessageBox.Show("No hay Capacitacion seleccionadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}