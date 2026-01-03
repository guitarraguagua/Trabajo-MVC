using System;

namespace Blockbuster.Models
{
    public class Arriendos
    {       
        public int IdCliente { get; set; }
        public List<Peliculas> Peliculas { get; set; }
        public DateTime FechaArriendo { get; set; }
        public int Boleta { get; set; }
        public int Estado { get; set; }

        public Arriendos(int idCliente, List<Peliculas> Peliculas, DateTime fechaArriendo, int boleta, int estado)
        {
            IdCliente = idCliente;
            this.Peliculas = Peliculas;
            FechaArriendo = fechaArriendo;
            Boleta = boleta;
            Estado = estado;
        }
    }
}