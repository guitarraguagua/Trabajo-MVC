using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blockbuster.Views;
using Blockbuster.Models;
using System.Windows.Forms;
using System.Data;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Blockbuster.Controllers
{
    internal class conArriendo : conBoleta
    {
        List<Peliculas> peliculas = new List<Peliculas>();
        public enum ACCION
        {
            ARRIENDO,
            DEVOLUCION,
            REPORTEPA,
            REPORTEPP
        }

        viewArriendos vista;
        modelArriendos modeloArriendo = new modelArriendos();
        modelCliente modeloCliente = new modelCliente();
        modelBoleta modeloBoleta = new modelBoleta();

        public conArriendo(ACCION accion)
        {
                
            vista = new viewArriendos(accion);
            vista.Arriendo.Click += Arriendo_Click;
            vista.Elegir.Click += Elegir_Click;
            vista.Eliminar.Click += Eliminar_Click;
            vista.Devolver.Click += Devolver_Click;
            vista.elegirCliente.Click += ElegirCliente_Click;


            if(accion == ACCION.ARRIENDO)
            {
                vista.peliculasDataGridView.DataSource = modeloArriendo.GetTablaPeliculas();
                vista.barCliente.DataSource = modeloCliente.GetTablaClientes();
            }
            if(accion == ACCION.DEVOLUCION)
            {
                vista.barCliente.DataSource = modeloCliente.GetTablaClientes();
            }
            if(accion == ACCION.REPORTEPA)
            {
                vista.peliculasDataGridView.DataSource = modeloArriendo.GetTablaArriendos();
            }
            if(accion == ACCION.REPORTEPP)
            {
                vista.peliculasDataGridView.DataSource = modeloArriendo.GetPeliculasPopulares();
            }

        }

        private void Arriendo_Click(object? sender, EventArgs e)
        {
            int idCliente = int.Parse(vista.barCliente.SelectedValue.ToString());

            Arriendos arriendos = new Arriendos(idCliente, peliculas, DateTime.Now, Crea_Boleta(idCliente), 1);
            modeloArriendo.AddArriendo(arriendos);

            ImprimirBoleta(arriendos);
            MessageBox.Show("Arriendo realizado");
            vista.Dispose();
        }

        private void Elegir_Click(object? sender, EventArgs e)
        {
            int idPelicula = int.Parse(vista.peliculasDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            string nombrePelicula = vista.peliculasDataGridView.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            int precioPelicula = int.Parse(vista.peliculasDataGridView.SelectedCells[0].OwningRow.Cells[2].Value.ToString());

            vista.peliculasDataGridView.Rows.RemoveAt(vista.peliculasDataGridView.SelectedCells[0].RowIndex);
            

            peliculas.Add(new Peliculas(idPelicula, nombrePelicula, precioPelicula));

            vista.peliculaDataGridViewE.DataSource = modeloArriendo.peliculasElegidas(peliculas);
            vista.peliculaDataGridViewE.Refresh();
            vista.peliculasDataGridView.Refresh();

        }

        private void Eliminar_Click(object? sender, EventArgs e)
        {
            int idPelicula = int.Parse(vista.peliculaDataGridViewE.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            string nombrePelicula = vista.peliculaDataGridViewE.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            int precioPelicula = int.Parse(vista.peliculaDataGridViewE.SelectedCells[0].OwningRow.Cells[2].Value.ToString());

            vista.peliculaDataGridViewE.Rows.RemoveAt(vista.peliculaDataGridViewE.SelectedCells[0].RowIndex);

            peliculas.RemoveAt(peliculas.FindIndex(p => p.Id == idPelicula));
            if(peliculas.Count > 0)
            {
                vista.peliculaDataGridViewE.DataSource = modeloArriendo.peliculasElegidas(peliculas);
            }

            DataTable tmpTabla = new DataTable();
            tmpTabla = (DataTable)vista.peliculasDataGridView.DataSource;
            tmpTabla.Rows.Add(idPelicula, nombrePelicula, precioPelicula);

            vista.peliculasDataGridView.DataSource = tmpTabla;

            vista.peliculaDataGridViewE.Refresh();
            vista.peliculasDataGridView.Refresh();
        }

        private void Devolver_Click(object? sender, EventArgs e)
        {
            int idCliente = int.Parse(vista.barCliente.SelectedValue.ToString());
            modeloArriendo.DevolverPeliculas(idCliente);
            MessageBox.Show("Peliculas devueltas");
            vista.Dispose();
        }

        private void ElegirCliente_Click(object? sender, EventArgs e)
        {
            int idCliente = int.Parse(vista.barCliente.SelectedValue.ToString());
            vista.peliculasDataGridView.DataSource = modeloArriendo.GetPeliculasClientes(idCliente);
            vista.peliculasDataGridView.Refresh();
        }

        public override int Crea_Boleta(int idCliente)
        {
            
            int total = 0;
            foreach (Peliculas p in peliculas)
            {
                total += p.Precio;
            }       

            Boleta boleta = new Boleta(0, total);
            
            return modeloBoleta.AddBoleta(boleta);

        }

        public Panel fncTraerVista()
        {
            return vista;
        }
    }
}
