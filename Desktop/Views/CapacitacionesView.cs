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
        }

        private async Task GetAllData()
        {
            if (checkVerEliminados.Checked)
            {
                _capacitaciones = await _capacitacionService.GetAllDeletedAsync("");
            }
            else
            {
                _capacitaciones = await _capacitacionService.GetAllAsync();

            }
            
            GridPeliculas.DataSource = _capacitaciones;
            GridPeliculas.Columns["Id"].Visible = false;
            GridPeliculas.Columns["IsDeleted"].Visible = false; // Ocultamos la columna eliminar

}
        private void GridPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                //    Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //    FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //checkeamos que haya peliculas seleccionadas
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridPeliculas.SelectedRows[0].DataBoundItem;
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
            //    LimpiarControlAgregar();
            //    tabAgregarEliminar.SelectTab("tabPageAgregar");
        }
        private void LimpiarControlAgregar()
        {
            titulo2.Text = string.Empty;
            NumericDuracion.Value = 0;
            txtPortada2.Text = string.Empty;
            FilmPicture.ImageLocation = null;
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            tabAgregarEliminar.SelectTab("tabPageLista");
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            //    Pelicula PeliculaAGuardar = new Pelicula
            //    {
            //        id = peliculaModificada?.id ?? null,
            //        titulo = titulo2.Text,
            //        duracion = (int)NumericDuracion.Value,
            //        portada = txtPortada2.Text,
            //        calificacion = (double)NumericCalificacion.Value,
            //        // Asignamos el PaisId del combo seleccionado

            //        PaisId = (int?)comboPaises.SelectedValue
            //    };
            //    bool response;
            //    if (peliculaModificada != null)
            //    {
            //        response = await peliculaService.UpdateAsync(PeliculaAGuardar);
            //    }
            //    else
            //    {
            //        response = await peliculaService.AddAsync(
            //           PeliculaAGuardar);
            //    }
            //    if (response)
            //    {
            //        peliculaModificada = null;
            //        MessageBox.Show("Pelicula se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        obtenemosPeliculas();
            //        tabAgregarEliminar.SelectTab("TabPageLista");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al modificar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //    if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            //    {
            //        peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
            //        titulo2.Text = peliculaModificada.titulo;
            //        NumericDuracion.Value = peliculaModificada.duracion;
            //        txtPortada2.Text = peliculaModificada.portada;
            //        NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
            //        tabAgregarEliminar.SelectTab("tabPageAgregar");
            //        //asigna el pais seleccionado al combo
            //        if (peliculaModificada.PaisId != null)
            //        {
            //            comboPaises.SelectedValue = peliculaModificada.PaisId;
            //        }
            //        else
            //        {
            //            comboPaises.SelectedIndex = -1; // Si no hay PaisId, deselecciona el combo
            //        }
            //    }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GridPeliculas.DataSource = _capacitaciones.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //    if (String.IsNullOrWhiteSpace(TxtBuscar.Text))
            //    {
            //        BtnBuscar.PerformClick();
        }

        //}

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            //    LabelStatusMessage.Text = string.Empty;
            //    TimerStatusBar.Stop();
            //}
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!checkVerEliminados.Checked) return;

            //checkeamos que haya peliculas seleccionadas
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridPeliculas.SelectedRows[0].DataBoundItem;
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