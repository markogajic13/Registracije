using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RegistracijeApp.Models
{
    public class Registracije
    {
        internal static DataTable DohvatiRegistracije()
        {
            DataTable podaci = new DataTable();
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                SqlDataAdapter upit = new SqlDataAdapter("SELECT * FROM Registracije", konekcija);
                upit.Fill(podaci);
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return podaci;
        }

        internal static bool DodajNoviZapis(string reg,DateTime datum)
        {
            bool rezultat = false;
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                konekcija.Open();
                SqlCommand naredba = new SqlCommand("INSERT INTO Registracije (RegistarskaOznaka,DatumIstekaRegistracije) VALUES (@reg,@datum)", konekcija);
                naredba.Parameters.AddWithValue("@reg", reg);
                naredba.Parameters.AddWithValue("@datum", datum);
                int uspjesnoDodano = naredba.ExecuteNonQuery();
                if(uspjesnoDodano==1)
                {
                    rezultat = true;
                }
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return rezultat;
        }

        internal static List<object> DohvatiRegistracijuPoId(int id)
        {
            List<object> podaci = new List<object>();
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                konekcija.Open();
                SqlCommand upit = new SqlCommand("SELECT * FROM Registracije WHERE Id=@oznaka", konekcija);
                upit.Parameters.AddWithValue("@oznaka", id);
                SqlDataReader odgovor = upit.ExecuteReader();
                odgovor.Read();
                podaci.Add(odgovor.GetString(1));
                podaci.Add(odgovor.GetDateTime(2));
                odgovor.Close();
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return podaci;
        }

        internal static bool IzmjenaPodataka(int id,string reg,DateTime datum)
        {
            bool rezultat = false;
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                konekcija.Open();
                SqlCommand naredba = new SqlCommand("UPDATE Registracije SET RegistarskaOznaka=@reg, DatumIstekaRegistracije=@datum WHERE Id=@redniBroj", konekcija);
                naredba.Parameters.AddWithValue("@reg", reg);
                naredba.Parameters.AddWithValue("@datum", datum);
                naredba.Parameters.AddWithValue("@redniBroj", id);
                int uspjesnoIzmijenjeno = naredba.ExecuteNonQuery();
                if(uspjesnoIzmijenjeno==1)
                {
                    rezultat = true;
                }
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return rezultat;
        }

        internal static bool BrisanjePodataka(int id)
        {
            bool rezultat = false;
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                konekcija.Open();
                SqlCommand upit = new SqlCommand("DELETE FROM Registracije WHERE Id=@id", konekcija);
                upit.Parameters.AddWithValue("@id", id);
                int uspjesnoObrisano = upit.ExecuteNonQuery();
                if(uspjesnoObrisano==1)
                {
                    rezultat = true;
                }
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return rezultat;
        }
    }
}
