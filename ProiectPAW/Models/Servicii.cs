using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Models
{

    public class Servicii
    {
        public Servicii(int id, string domeniu, string tip)
        {
            Domeniu = domeniu;
            Tip = tip;
        }

        public Servicii()
        {

        }

        public int Id { get; set; }
        public string Domeniu { get; set; }
        public string Tip { get; set; }

    }
}
