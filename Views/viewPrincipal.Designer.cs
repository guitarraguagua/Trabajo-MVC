namespace Blockbuster.Views
{
    partial class viewPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            eliminarClienteToolStripMenuItem = new ToolStripMenuItem();
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            agregarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            eliminarPeliculaToolStripMenuItem = new ToolStripMenuItem();
            arriendoToolStripMenuItem = new ToolStripMenuItem();
            arriendoToolStripMenuItem1 = new ToolStripMenuItem();
            devolucionToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            peliculasArrendadasToolStripMenuItem = new ToolStripMenuItem();
            peliculasPopularesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, peliculaToolStripMenuItem, arriendoToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(947, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, eliminarClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(157, 22);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // eliminarClienteToolStripMenuItem
            // 
            eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            eliminarClienteToolStripMenuItem.Size = new Size(157, 22);
            eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            eliminarClienteToolStripMenuItem.Click += eliminarClienteToolStripMenuItem_Click;
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarPeliculaToolStripMenuItem, eliminarPeliculaToolStripMenuItem });
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(60, 22);
            peliculaToolStripMenuItem.Text = "Pelicula";
            // 
            // agregarPeliculaToolStripMenuItem
            // 
            agregarPeliculaToolStripMenuItem.Name = "agregarPeliculaToolStripMenuItem";
            agregarPeliculaToolStripMenuItem.Size = new Size(161, 22);
            agregarPeliculaToolStripMenuItem.Text = "Agregar Pelicula";
            agregarPeliculaToolStripMenuItem.Click += agregarPeliculaToolStripMenuItem_Click;
            // 
            // eliminarPeliculaToolStripMenuItem
            // 
            eliminarPeliculaToolStripMenuItem.Name = "eliminarPeliculaToolStripMenuItem";
            eliminarPeliculaToolStripMenuItem.Size = new Size(161, 22);
            eliminarPeliculaToolStripMenuItem.Text = "Eliminar Pelicula";
            eliminarPeliculaToolStripMenuItem.Click += eliminarPeliculaToolStripMenuItem_Click;
            // 
            // arriendoToolStripMenuItem
            // 
            arriendoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arriendoToolStripMenuItem1, devolucionToolStripMenuItem });
            arriendoToolStripMenuItem.Name = "arriendoToolStripMenuItem";
            arriendoToolStripMenuItem.Size = new Size(65, 22);
            arriendoToolStripMenuItem.Text = "Arriendo";
            // 
            // arriendoToolStripMenuItem1
            // 
            arriendoToolStripMenuItem1.Name = "arriendoToolStripMenuItem1";
            arriendoToolStripMenuItem1.Size = new Size(134, 22);
            arriendoToolStripMenuItem1.Text = "Arriendo";
            arriendoToolStripMenuItem1.Click += arriendoToolStripMenuItem1_Click;
            // 
            // devolucionToolStripMenuItem
            // 
            devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            devolucionToolStripMenuItem.Size = new Size(134, 22);
            devolucionToolStripMenuItem.Text = "Devolucion";
            devolucionToolStripMenuItem.Click += devolucionToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { peliculasArrendadasToolStripMenuItem, peliculasPopularesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // peliculasArrendadasToolStripMenuItem
            // 
            peliculasArrendadasToolStripMenuItem.Name = "peliculasArrendadasToolStripMenuItem";
            peliculasArrendadasToolStripMenuItem.Size = new Size(183, 22);
            peliculasArrendadasToolStripMenuItem.Text = "Peliculas Arrendadas";
            peliculasArrendadasToolStripMenuItem.Click += peliculasArrendadasToolStripMenuItem_Click;
            // 
            // peliculasPopularesToolStripMenuItem
            // 
            peliculasPopularesToolStripMenuItem.Name = "peliculasPopularesToolStripMenuItem";
            peliculasPopularesToolStripMenuItem.Size = new Size(183, 22);
            peliculasPopularesToolStripMenuItem.Text = "Peliculas Populares";
            peliculasPopularesToolStripMenuItem.Click += peliculasPopularesToolStripMenuItem_Click;
            // 
            // viewPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 502);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "viewPrincipal";
            Text = "viewPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem agregarPeliculaToolStripMenuItem;
        private ToolStripMenuItem eliminarPeliculaToolStripMenuItem;
        private ToolStripMenuItem arriendoToolStripMenuItem;
        private ToolStripMenuItem arriendoToolStripMenuItem1;
        private ToolStripMenuItem devolucionToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem peliculasArrendadasToolStripMenuItem;
        private ToolStripMenuItem peliculasPopularesToolStripMenuItem;
    }
}