using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster.Models
{
    public class Boleta
    {
        public int Id { get; set; }
        public int Total { get; set; }

        public Boleta(int id, int total)
        {
            this.Id = id;
            this.Total = total;
        }
    }
}
