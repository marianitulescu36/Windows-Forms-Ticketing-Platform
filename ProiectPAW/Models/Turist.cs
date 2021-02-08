using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW.Models
{
    public class Turist
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Turist(string nume, string prenume, string username, string password)
        {
            Nume = nume;
            Prenume = prenume;
            Username =username;
            Password = password;
        }

        public Turist()
        {
        }

    }
}