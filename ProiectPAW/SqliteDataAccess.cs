using Dapper;
using Microsoft.Data.Sqlite;
using ProiectPAW.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class SqliteDataAccess
    {
        #region TURISTI
        public static List<Models.Turist> LoadTurists() //lista cu toti turistii
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString())) // nu lasa conexiuni deschise catre baza de date
            {
                var output = cnn.Query<Models.Turist>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }

        public static Models.Turist SearchTurist(string username, string password) //cauta turistul si imi spune daca are parola corecta
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                Models.Turist tulist = null;
                var output = cnn.Query<Models.Turist>("select * from Users", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Username == username && output[i].Password == password) tulist = output[i];
                }
                return tulist;
            }
        }

        public static Models.Turist SearchTuristUsername(string username) //cauta turist dupa username
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                Models.Turist tulist = null;
                var output = cnn.Query<Models.Turist>("select * from Users", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Username == username) tulist = output[i];
                }
                return tulist;
            }
        }

        public static void SaveTurist(Models.Turist turist) //adauga turist in database
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (NAME, PRENUME, USERNAME, PASSWORD) values (@Nume, @Prenume, @Username, @Password)", turist);
                
            }
        }
        #endregion

        #region SERVICII
        public static List<string> LoadServicii() // lista cu domeniul si tipul serviciilor
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<string> servicii = new List<string>();
                servicii.Add("None");
                var output = cnn.Query<Models.Servicii>("select * from Servicii", new DynamicParameters()).ToList();
                for (int i = 0; i < output.Count; i++)
                {
                    servicii.Add(output[i].Domeniu + " - " + output[i].Tip);
                }
                return servicii;
            }
        }

        public static List<string> LoadDomenii() // lista cu domeniul serviciilor
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<string> servicii = new List<string>();

                var output = cnn.Query<Models.Servicii>("select distinct DOMENIU from Servicii", new DynamicParameters()).ToList();
                for (int i = 0; i < output.Count; i++)
                {
                    servicii.Add(output[i].Domeniu);
                }
                return servicii;
            }
        }
        #endregion

        #region OFERTE
        public static List<Models.Oferte> LoadOferte() // lista cu toate ofertele
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Models.Oferte>("select * from Oferte", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Models.Oferte> SearchOferte(string destinatie) //cauta oferta dupa destinatie
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<Models.Oferte> oferta = new List<Models.Oferte>();
                var output = cnn.Query<Models.Oferte>("select * from Oferte", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    string lower = output[i].Destinatie.ToLower();
                    string tblower = destinatie.ToLower();
                    if(lower.Contains(tblower)) oferta.Add(output[i]);
                }
                return oferta;
            }
        }

        public static List<Models.Oferte> SearchOferteDestServ(string destinatie, string serviciu) //cauta oferta dupa destinatie + servicii
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<Models.Oferte> oferta = new List<Models.Oferte>();
                var output = cnn.Query<Models.Oferte>("select * from Oferte", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    string lower = output[i].Destinatie.ToLower();
                    string tblower = destinatie.ToLower();
                    if ( lower.Contains(tblower) && output[i].Serviciu.Contains(serviciu) ) oferta.Add(output[i]);
                }
                return oferta;
            }
        }

        public static Models.Oferte SearchOferteId(int id) //cauta o oferta dupa id 
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                Models.Oferte oferta = new Models.Oferte();
                var output = cnn.Query<Models.Oferte>("select * from Oferte", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Id == id) oferta = output[i];
                }
                return oferta;
            }
        }

        public static void CreateOferta(Models.Oferte oferta) //adauga oferta in database
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Oferte (DESTINATIE, SERVICIU, PRET, DETALII) values (@Destinatie, @Serviciu, @Pret, @Detalii)", oferta);
            }
        }

        public static void UpdateOferta(Models.Oferte oferta) // update oferta in database
        {
            using (SqliteConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                using (SqliteCommand cmd = new SqliteCommand("",cnn))
                {
                    cmd.CommandText = "UPDATE [Oferte] SET DESTINATIE=@Destinatie, SERVICIU=@Serviciu, PRET=@Pret, DETALII=@Detalii WHERE ID=@Id";
                    cmd.Parameters.Add("@Destinatie", SqliteType.Text).Value = oferta.Destinatie;
                    cmd.Parameters.Add("@Serviciu", SqliteType.Text).Value = oferta.Serviciu;
                    cmd.Parameters.Add("@Pret", SqliteType.Text).Value = oferta.Pret;
                    cmd.Parameters.Add("@Detalii", SqliteType.Text).Value = oferta.Detalii;
                    cmd.Parameters.Add("@Id", SqliteType.Integer).Value = oferta.Id;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public static int SearchNrServicii(string serviciu) // cauta de cate ori apare in lista de oferte serviciul respectiv
        {
            using (SqliteConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<Models.Oferte> oferta = new List<Models.Oferte>();
                var output = cnn.Query<Models.Oferte>("select * from Oferte", new DynamicParameters()).ToList();
                int contor = 0;
                for (int i = 0; i < output.Count; i++)
                {
                    string lower = output[i].Serviciu.ToLower();
                    string servlower = serviciu.ToLower();
                    if (lower.Contains(servlower)) contor = contor + 1;
                }
                return contor;
            }
        }

        public static void DeleteOferta(int id) // sterge oferta in database
        {
            using (SqliteConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                using (SqliteCommand cmd = new SqliteCommand("", cnn))
                {
                    cmd.CommandText = "DELETE FROM [Oferte] WHERE ID=@Id";
                    cmd.Parameters.Add("@Id", SqliteType.Integer).Value = id;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        public static List<Models.Oferte> OrdoneazaOferteAlf() // ordoneaza ofertele A-Z in functie de destinatie
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Models.Oferte>("select * from Oferte order by DESTINATIE asc", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Models.Oferte> OrdoneazaOferteAlfDesc() // ordoneaza ofertele Z-A in functie de destinatie
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Models.Oferte>("select * from Oferte order by DESTINATIE desc", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Models.Oferte> OrdoneazaOferteNum() // ordoneaza ofertele crescator in functie de pret
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Models.Oferte>("select * from Oferte order by PRET asc", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Models.Oferte> OrdoneazaOferteNumDesc() // ordoneaza ofertele descrescator in functie de pret
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Models.Oferte>("select * from Oferte order by PRET desc", new DynamicParameters());
                return output.ToList();
            }
        }
        #endregion

        #region TRANZACTII
        public static void SaveTranzactie(Models.Tranzactii tranzactie) //adauga tranzactie in database
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Tranzactii (IDUSER, IDOFERTA, CONTIBAN, DETALIITRANZACTIE, SUMA, DATATRANZACTIE) values (@IdUser, @IdOferta, @ContIBAN, @DetaliiTranzactie, @Suma, @DataTranzactie)", tranzactie);

            }
        }

        public static List<Models.Tranzactii> SearchTranzactieId(int iduser) //cauta tranzactie dupa username-ul turistului
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                List<Models.Tranzactii> tranz = new List<Tranzactii>();
                var output = cnn.Query<Models.Tranzactii>("select * from Tranzactii", new DynamicParameters()).ToList();

                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].IdUser == iduser) tranz.Add(output[i]);
                }
                return tranz;
            }
        }
        #endregion

        public static string LoadConnectionString(string id="Default") // seteaza id-ul ca default - vezi configurari
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
