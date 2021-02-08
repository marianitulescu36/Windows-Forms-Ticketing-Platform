using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Models
{
    public class Oferte
    {
        public int Id { get; set; }
        public string Destinatie { get; set; }
        public string Serviciu { get; set; }
        public string Pret { get; set; }
        public string Detalii { get; set; }

        public Oferte(string destinatie, string serviciu, string pret, string detalii)
        {
            Destinatie = destinatie;
            Serviciu = serviciu;
            Pret = pret;
            Detalii = detalii;
        }

        public Oferte()
        {

        }

    }
}
