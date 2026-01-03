using Blockbuster.Views;
using Blockbuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Blockbuster.Controllers
{
    internal class conCliente
    {
        public enum ACCION
        {
            AGREGAR,
            ELIMINAR
        }

        viewCliente vista;
        modelCliente modelo = new modelCliente();

        public conCliente(ACCION accion) {

            vista = new viewCliente(accion);

            vista.btnNombreCliente.Click += btnNombreCliente_Click;
            vista.btnBorrarCliente.Click += btnBorrarCliente_Click;

            if(accion == ACCION.ELIMINAR)
            {
                vista.clientesDataGridView.DataSource = modelo.GetTablaClientes();
            }
        }

        private void btnNombreCliente_Click(object? sender, EventArgs e)
        {
            Clientes cliente = new Clientes(0, vista.tbxNombreCliente.Text);
            modelo.AddCliente(cliente);
            MessageBox.Show("Cliente Agregado");
            vista.tbxNombreCliente.Clear();
        }

        private void btnBorrarCliente_Click(object? sender, EventArgs e)
        {
            int id = int.Parse(vista.clientesDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            modelo.DelCliente(id);
            MessageBox.Show("Cliente eliminado");
            vista.clientesDataGridView.Rows.RemoveAt(vista.clientesDataGridView.SelectedCells[0].RowIndex);
        }

        public Panel fncTraerVista()
        {
            return vista;
        }
    }
}
