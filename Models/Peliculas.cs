using System;

namespace Blockbuster.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Peliculas (int id, string nombre, int precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }
    }
}