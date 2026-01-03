using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blockbuster.Controllers;

namespace Blockbuster.Views
{
    public partial class viewPrincipal : Form
    {
        public viewPrincipal()
        {
            InitializeComponent();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            conCliente cc = new conCliente(Blockbuster.Controllers.conCliente.ACCION.AGREGAR);

            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(cc.fncTraerVista());
            Controls.Add(menu);
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conCliente cc = new conCliente(Blockbuster.Controllers.conCliente.ACCION.ELIMINAR);

            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(cc.fncTraerVista());
            Controls.Add(menu);
        }

        private void agregarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conPeliculas cp = new conPeliculas(Blockbuster.Controllers.conPeliculas.ACCION.AGREGAR);

            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(cp.fncTraerVista());
            Controls.Add(menu);
        }

        private void eliminarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conPeliculas cp = new conPeliculas(Blockbuster.Controllers.conPeliculas.ACCION.ELIMINAR);

            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(cp.fncTraerVista());
            Controls.Add(menu);
        }

        private void arriendoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conArriendo ca = new conArriendo(Blockbuster.Controllers.conArriendo.ACCION.ARRIENDO);

            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(ca.fncTraerVista());
            Controls.Add(menu);
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conArriendo conArriendo = new conArriendo(Blockbuster.Controllers.conArriendo.ACCION.DEVOLUCION);
            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(conArriendo.fncTraerVista());
            Controls.Add(menu);
        }

        private void peliculasArrendadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conArriendo conArriendo = new conArriendo(Blockbuster.Controllers.conArriendo.ACCION.REPORTEPA);
            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(conArriendo.fncTraerVista());
            Controls.Add(menu);
        }

        private void peliculasPopularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conArriendo conArriendo = new conArriendo(Blockbuster.Controllers.conArriendo.ACCION.REPORTEPP);
            MenuStrip menu = new MenuStrip();
            menu = menuStrip1;
            Controls.Clear();
            Controls.Add(conArriendo.fncTraerVista());
            Controls.Add(menu);
        }
    }
}
