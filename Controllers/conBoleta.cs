using Blockbuster.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster.Controllers
{
    abstract class conBoleta
    {
        DataTable Cl = new modelCliente().GetTablaClientes();
        abstract public int Crea_Boleta(int idCliente);
        public void ImprimirBoleta(Arriendos arriendo)
        {
            int total = 0;
            foreach (Peliculas p in arriendo.Peliculas)
            {
                total += p.Precio;
            }

            string nombreArchivo = "Boleta" + arriendo.Boleta + ".txt";

            try
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\mferr\\OneDrive\\Documentos\\Blockbuster\\Blockbuster\\Boletas\\" + nombreArchivo, true))
                {
                    sw.WriteLine("   Boleta Electronica N° " + arriendo.Boleta + "    ");
                    sw.WriteLine("   SJF Blockbuster                               ");
                    foreach (Peliculas p in arriendo.Peliculas)
                    {
                        sw.WriteLine("   " + p.Id + " " + p.Nombre + " $" + p.Precio);
                    }
                    sw.WriteLine("                                  Total: $" + total);
                    sw.WriteLine("                                                 ");
                    sw.WriteLine("                                                 ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
