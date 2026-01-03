using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockbuster.Views
{
    internal class viewCliente : Panel
    {

        public Button btnNombreCliente = new Button();
        public Label lblNombreCliente = new Label();
        public TextBox tbxNombreCliente = new TextBox();

        public BindingSource clientesBindingSource;
        public DataGridView clientesDataGridView;
        public DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        public DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public Button btnBorrarCliente = new Button();


        public viewCliente(Blockbuster.Controllers.conCliente.ACCION accion){

            clientesBindingSource = new BindingSource();
            clientesDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnBorrarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)clientesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            // 
            // clientesBindingSource
            // 
            clientesBindingSource.DataSource = typeof(Models.Clientes);
            // 
            // dataGridView1
            // 
            clientesDataGridView.AutoGenerateColumns = false;
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            clientesDataGridView.DataSource = clientesBindingSource;
            clientesDataGridView.Location = new Point(21, 48);
            clientesDataGridView.Name = "dataGridView1";
            clientesDataGridView.RowHeadersWidth = 62;
            clientesDataGridView.RowTemplate.Height = 33;
            clientesDataGridView.Size = new Size(1046, 329);
            clientesDataGridView.TabIndex = 1;
            clientesDataGridView.AllowUserToAddRows = false;
            clientesDataGridView.AllowUserToDeleteRows = false;
            clientesDataGridView.AllowUserToOrderColumns = true;
            clientesDataGridView.AllowUserToResizeColumns = true;
            clientesDataGridView.ReadOnly = true;
            clientesDataGridView.MultiSelect = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Location = new Point(955, 397);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(112, 34);
            btnBorrarCliente.TabIndex = 2;
            btnBorrarCliente.Text = "Borrar";
            btnBorrarCliente.UseVisualStyleBackColor = true;




            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(21, 59);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(136, 25);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre Cliente";
            // 
            // tbxNombreCliente
            // 
            tbxNombreCliente.Location = new Point(21, 108);
            tbxNombreCliente.Name = "tbxNombreCliente";
            tbxNombreCliente.Size = new Size(883, 31);
            tbxNombreCliente.TabIndex = 1;
            // 
            // btnNombreCliente
            // 
            btnNombreCliente.Location = new Point(792, 166);
            btnNombreCliente.Name = "btnNombreCliente";
            btnNombreCliente.Size = new Size(112, 34);
            btnNombreCliente.TabIndex = 2;
            btnNombreCliente.Text = "Guardar";
            btnNombreCliente.UseVisualStyleBackColor = true;

            if(accion == Controllers.conCliente.ACCION.AGREGAR)
            {
                this.Controls.Add(btnNombreCliente);
                this.Controls.Add(lblNombreCliente);
                this.Controls.Add(tbxNombreCliente);
            } else if(accion == Controllers.conCliente.ACCION.ELIMINAR)
            {
                this.Controls.Add(btnBorrarCliente);
                this.Controls.Add(clientesDataGridView);
            }
            
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 33);
            this.Size = new Size(1214, 512);
            this.TabIndex = 10;

        }
    }
}
