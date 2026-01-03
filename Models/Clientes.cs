using System;

namespace Blockbuster.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Clientes(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}