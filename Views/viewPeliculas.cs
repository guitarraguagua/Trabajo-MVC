using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockbuster.Views
{
    internal class viewPeliculas : Panel
    {

        public Button btnNombrePelicula = new Button();
        public Label lblNombrePelicula = new Label();
        public TextBox tbxNombrePelicula = new TextBox();
        public Label lblPrecioPelicula = new Label();
        public TextBox tbxPrecioPelicula = new TextBox();

        public BindingSource peliculasBindingSource;
        public DataGridView peliculasDataGridView;
        public DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        public DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        public Button btnBorrarPelicula = new Button();


        public viewPeliculas(Blockbuster.Controllers.conPeliculas.ACCION accion){

            peliculasBindingSource = new BindingSource();
            peliculasDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnBorrarPelicula = new Button();
            ((System.ComponentModel.ISupportInitialize)peliculasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculasDataGridView).BeginInit();
            // 
            // peliculasBindingSource
            // 
            peliculasBindingSource.DataSource = typeof(Models.Peliculas);
            // 
            // dataGridView1
            // 
            peliculasDataGridView.AutoGenerateColumns = false;
            peliculasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            peliculasDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            peliculasDataGridView.DataSource = peliculasBindingSource;
            peliculasDataGridView.Location = new Point(21, 48);
            peliculasDataGridView.Name = "dataGridView1";
            peliculasDataGridView.RowHeadersWidth = 62;
            peliculasDataGridView.RowTemplate.Height = 33;
            peliculasDataGridView.Size = new Size(1046, 329);
            peliculasDataGridView.TabIndex = 1;
            peliculasDataGridView.AllowUserToAddRows = false;
            peliculasDataGridView.AllowUserToDeleteRows = false;
            peliculasDataGridView.AllowUserToOrderColumns = true;
            peliculasDataGridView.AllowUserToResizeColumns = true;
            peliculasDataGridView.ReadOnly = true;
            peliculasDataGridView.MultiSelect = false;
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
            // precioDataGridViewTextBoxColumn
            //
            precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            precioDataGridViewTextBoxColumn.HeaderText = "precio";
            precioDataGridViewTextBoxColumn.MinimumWidth = 8;
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnBorrarPelicula
            // 
            btnBorrarPelicula.Location = new Point(955, 397);
            btnBorrarPelicula.Name = "btnBorrarPelicula";
            btnBorrarPelicula.Size = new Size(112, 34);
            btnBorrarPelicula.TabIndex = 2;
            btnBorrarPelicula.Text = "Borrar";
            btnBorrarPelicula.UseVisualStyleBackColor = true;




            // 
            // lblNombrePelicula
            // 
            lblNombrePelicula.AutoSize = true;
            lblNombrePelicula.Location = new Point(21, 59);
            lblNombrePelicula.Name = "lblNombrePelicula";
            lblNombrePelicula.Size = new Size(136, 25);
            lblNombrePelicula.TabIndex = 0;
            lblNombrePelicula.Text = "Nombre Pelicula";
            // 
            // tbxNombrePelicula
            // 
            tbxNombrePelicula.Location = new Point(21, 108);
            tbxNombrePelicula.Name = "tbxNombrePelicula";
            tbxNombrePelicula.Size = new Size(883, 31);
            tbxNombrePelicula.TabIndex = 1;
            // 
            // btnNombrePelicula
            // 
            btnNombrePelicula.Location = new Point(792, 250);
            btnNombrePelicula.Name = "btnNombrePelicula";
            btnNombrePelicula.Size = new Size(112, 34);
            btnNombrePelicula.TabIndex = 2;
            btnNombrePelicula.Text = "Guardar";
            btnNombrePelicula.UseVisualStyleBackColor = true;
            //
            // lblPrecioPelicula
            //
            lblPrecioPelicula.AutoSize = true;
            lblPrecioPelicula.Location = new Point(21, 150);
            lblPrecioPelicula.Name = "lblPrecioPelicula";
            lblPrecioPelicula.Size = new Size(136, 25);
            lblPrecioPelicula.TabIndex = 0;
            lblPrecioPelicula.Text = "Precio Pelicula";
            //
            // tbxPrecioPelicula
            //
            tbxPrecioPelicula.Location = new Point(21, 200);
            tbxPrecioPelicula.Name = "tbxPrecioPelicula";
            tbxPrecioPelicula.Size = new Size(883, 31);
            tbxPrecioPelicula.TabIndex = 1;


            if(accion == Controllers.conPeliculas.ACCION.AGREGAR)
            {
                this.Controls.Add(btnNombrePelicula);
                this.Controls.Add(lblNombrePelicula);
                this.Controls.Add(tbxNombrePelicula);
                this.Controls.Add(lblPrecioPelicula);
                this.Controls.Add(tbxPrecioPelicula);

            } else if(accion == Controllers.conPeliculas.ACCION.ELIMINAR)
            {
                this.Controls.Add(btnBorrarPelicula);
                this.Controls.Add(peliculasDataGridView);
            }
            
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 33);
            this.Size = new Size(1214, 512);
            this.TabIndex = 10;


        }
    }
}
