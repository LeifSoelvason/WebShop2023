using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TECs_WebShop
{
    public class Kunde
    {
        public int KundeID { get; set; }

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Adresse MinAdresse { get; set; }

        public Konto MinKonto { get; set; }

        public Indkøbskurv MinKurv { get; set; }

        public List<Kunde> MineKunder { get; set; }

        public Kunde(string fornavn, string efternavn, string username, string password)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Username = username;
            Password = password;

        }


        public List<Kunde> PasswordValidation(string Username, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("TEC_DB")))
            {
                var output = connection.Query<Kunde>("dbo.sp_ValidateCustomer @Username,@Password", new { Username = Username, Password = Password }).ToList();
                return output;
            }
        }

        //CRUD


        //CREATE:

        public void TilføjKunde(Kunde kunde)
        {
            MineKunder.Add(kunde);  // Et objekt tilføjes liste af objekter.
        }

        //READ
        public List<Kunde> HentListeafKunder()
        {
            return MineKunder;   //Hent listen 'MineKunder'
        }

        //UPDATE
        public void OpdaterKunde(Kunde kunde)
        {
            int index = MineKunder.FindIndex(k => k.KundeID == kunde.KundeID);
            if (index != -1)
            {
                MineKunder[index] = kunde;
            }
        }

        //DELETE
        public void SletKunde(Kunde kunde)
        {
            MineKunder.Remove(kunde);
        }

    }
}