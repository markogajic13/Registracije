using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RegistracijeApp.Models
{
    public class Users
    {
        internal static bool ProvjeraPodataka(string ime, string lozinka)
        {
            bool dopustiPrijavu = false;
            SqlConnection konekcija = new SqlConnection(Startup.konekcijskiString);
            try
            {
                konekcija.Open();
                SqlCommand naredba = new SqlCommand("SELECT Username FROM Users WHERE Username = @ime AND Password = @lozinka", konekcija);
                naredba.Parameters.AddWithValue("@ime", ime);
                naredba.Parameters.AddWithValue("@lozinka", lozinka);
                SqlDataReader podaci = naredba.ExecuteReader();
                if (podaci.HasRows == true)
                {
                    dopustiPrijavu = true;
                }
            }
            catch { }
            finally
            {
                konekcija.Close();
            }
            return dopustiPrijavu;
        }
    }
}
