using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blockbuster.Views;
using Blockbuster.Models;

namespace Blockbuster.Controllers
{
    internal class conPeliculas
    {
        public enum ACCION
        {
            AGREGAR,
            ELIMINAR
        }

        viewPeliculas vista;
        modelPelicula modelo = new modelPelicula();

        public conPeliculas(ACCION accion)
        {

            vista = new viewPeliculas(accion);

            vista.btnNombrePelicula.Click += btnNombrePelicula_Click;
            vista.btnBorrarPelicula.Click += btnBorrarPelicula_Click;

            if(accion == ACCION.ELIMINAR)
            {
                vista.peliculasDataGridView.DataSource = modelo.GetTablaPeliculas();
            }
        }

        private void btnNombrePelicula_Click(object? sender, EventArgs e)
        {
            Peliculas pelicula = new Peliculas(0, vista.tbxNombrePelicula.Text, int.Parse(vista.tbxPrecioPelicula.Text));
            modelo.AddPelicula(pelicula);
            MessageBox.Show("Pelicula Agregada");
            vista.tbxNombrePelicula.Clear();
            vista.tbxPrecioPelicula.Clear();
        }

        private void btnBorrarPelicula_Click(object? sender, EventArgs e)
        {
            int id = int.Parse(vista.peliculasDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            modelo.DelPelicula(id);
            MessageBox.Show("Pelicula eliminada");
            vista.peliculasDataGridView.Rows.RemoveAt(vista.peliculasDataGridView.SelectedCells[0].RowIndex);
        }

        public Panel fncTraerVista()
        {
            return vista;
        }
    }
}
