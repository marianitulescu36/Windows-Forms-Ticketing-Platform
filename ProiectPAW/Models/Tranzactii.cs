using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Models
{
    public class Tranzactii
    {
        public int IdTranzactie { get; set; }
        public int IdUser { get; set; }
        public int IdOferta { get; set; }
        public string ContIBAN { get; set; }
        public string DetaliiTranzactie { get; set; } //pentru cate persoane s-a achizitionat oferta, data check-in, email la care sunt trimise biletele
        public double Suma { get; set; }
        public string DataTranzactie { get; set; }

        public Tranzactii()
        {
        }

        public Tranzactii(int idUser, int idOferta, string contIBAN, string detaliiTranzactie, double suma, string dataTranzactie)
        {
            IdUser = idUser;
            IdOferta = idOferta;
            ContIBAN = contIBAN;
            DetaliiTranzactie = detaliiTranzactie;
            Suma = suma;
            DataTranzactie = dataTranzactie;
        }

    }
}
