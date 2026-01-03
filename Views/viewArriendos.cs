using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockbuster.Views
{
    internal class viewArriendos : Panel
    {
        public Label lblCliente = new Label();
        public Label lblPelicula = new Label();

        public BindingSource peliculasBindingSource;
        public DataGridView peliculasDataGridView;
        public DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        public DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        public DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;

        public ComboBox barCliente;
        public Label Cliente;
        public Label Peliculas;
        public DataGridView peliculaDataGridViewE;
        public DataTable peliculaBindingSourceE;
        public Label PeliculasElegidas;
        public Button Arriendo;
        public Button Elegir;
        public Button Eliminar;
        public Button Devolver;
        public Button elegirCliente;
        public viewArriendos(Blockbuster.Controllers.conArriendo.ACCION accion)
        {
            peliculasBindingSource = new BindingSource();
            peliculasDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Arriendo = new Button();
            Elegir = new Button();
            Eliminar = new Button();
            Devolver = new Button();
            elegirCliente = new Button();
            PeliculasElegidas = new Label();
            Peliculas = new Label();
            Cliente = new Label();
            barCliente = new ComboBox();
            var barClienteD = new BindingSource();
            peliculaDataGridViewE = new DataGridView();
            peliculaBindingSourceE = new DataTable();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)peliculasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaDataGridViewE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSourceE).BeginInit();
            // 
            // peliculasBindingSource
            // 
            peliculasBindingSource.DataSource = typeof(Models.Peliculas);
            // 
            // barCliente
            // 
            barCliente.FormattingEnabled = true;
            barCliente.Location = new Point(27, 76);
            barCliente.Name = "barCliente";
            barCliente.Size = new Size(221, 33);
            barCliente.TabIndex = 0;
            barCliente.DataSource = barClienteD.DataSource;
            barCliente.DisplayMember = "nombre";
            barCliente.ValueMember = "id";
            //
            // lblCliente
            //
            Cliente.AutoSize = true;
            Cliente.Location = new Point(27, 48);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(65, 25);
            Cliente.TabIndex = 2;
            Cliente.Text = "Cliente";
            // 
            // peliculaDataGridView
            // 
            peliculasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            peliculasDataGridView.Location = new Point(27, 205);
            peliculasDataGridView.Name = "peliculaDataGridView";
            peliculasDataGridView.RowHeadersWidth = 62;
            peliculasDataGridView.RowTemplate.Height = 33;
            peliculasDataGridView.Size = new Size(488, 259);
            peliculasDataGridView.TabIndex = 3;
            // 
            // Peliculas
            // 
            Peliculas.AutoSize = true;
            Peliculas.Location = new Point(27, 163);
            Peliculas.Name = "Peliculas";
            Peliculas.Size = new Size(77, 25);
            Peliculas.TabIndex = 4;
            Peliculas.Text = "Peliculas";
            // 
            // peliculaDataGridViewE
            // 
            peliculaDataGridViewE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            peliculaDataGridViewE.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn });
            peliculaDataGridViewE.Location = new Point(668, 205);
            peliculaDataGridViewE.Name = "peliculaDataGridViewE";
            peliculaDataGridViewE.RowHeadersWidth = 62;
            peliculaDataGridViewE.RowTemplate.Height = 33;
            peliculaDataGridViewE.Size = new Size(488, 259);
            peliculaDataGridViewE.TabIndex = 3;
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
            // PeliculasElegidas
            // 
            PeliculasElegidas.AutoSize = true;
            PeliculasElegidas.Location = new Point(668, 163);
            PeliculasElegidas.Name = "PeliculasElegidas";
            PeliculasElegidas.Size = new Size(147, 25);
            PeliculasElegidas.TabIndex = 6;
            PeliculasElegidas.Text = "Peliculas Elegidas";
            // 
            // Arriendo
            // 
            Arriendo.Location = new Point(1044, 530);
            Arriendo.Name = "Arriendo";
            Arriendo.Size = new Size(112, 34);
            Arriendo.TabIndex = 7;
            Arriendo.Text = "Arrendar";
            Arriendo.UseVisualStyleBackColor = true;
            //
            // Elegir
            //
            Elegir.Location = new Point(27, 475);
            Elegir.Name = "Elegir";
            Elegir.Size = new Size(112, 34);
            Elegir.TabIndex = 8;
            Elegir.Text = "Elegir";
            Elegir.UseVisualStyleBackColor = true;
            //
            // Eliminar
            //
            Eliminar.Location = new Point(668, 475);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(112, 34);
            Eliminar.TabIndex = 9;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            //
            // Devoler
            //
            Devolver.Location = new Point(403, 475);
            Devolver.Name = "Devolver";
            Devolver.Size = new Size(112, 34);
            Devolver.TabIndex = 9;
            Devolver.Text = "Devolver";
            Devolver.UseVisualStyleBackColor = true;
            //
            // elegirCliente
            //
            elegirCliente.Location = new Point(255, 76);
            elegirCliente.Name = "Elegir Cliente";
            elegirCliente.Size = new Size(112, 25);
            elegirCliente.TabIndex = 10;
            elegirCliente.Text = "Elegir";
            elegirCliente.UseVisualStyleBackColor = true;

            if (accion == Blockbuster.Controllers.conArriendo.ACCION.ARRIENDO)
            {
                Controls.Add(Arriendo);
                Controls.Add(PeliculasElegidas);
                Controls.Add(peliculaDataGridViewE);
                Controls.Add(Peliculas);
                Controls.Add(peliculasDataGridView);
                Controls.Add(Cliente);
                Controls.Add(barCliente);
                Controls.Add(Elegir);
                Controls.Add(Eliminar);

            }else if(accion == Blockbuster.Controllers.conArriendo.ACCION.DEVOLUCION)
            {
                Controls.Add(Cliente);
                Controls.Add(barCliente);
                Controls.Add(peliculasDataGridView);
                Controls.Add(Devolver);
                Controls.Add(elegirCliente);
            }else if(accion == Blockbuster.Controllers.conArriendo.ACCION.REPORTEPA)
            {
                Controls.Add(peliculasDataGridView);
            }else if(accion == Blockbuster.Controllers.conArriendo.ACCION.REPORTEPP)
            {
                Controls.Add(peliculasDataGridView);
            }

            ((System.ComponentModel.ISupportInitialize)peliculasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaDataGridViewE).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSourceE).EndInit();

            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 33);
            this.Size = new Size(1214, 512);
            this.TabIndex = 10;

        }
    }
}
