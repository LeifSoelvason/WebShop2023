using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace TECs_WebShop
{
    public partial class KundeForm : Form
    {
        private IDbConnection db;

        public KundeForm()
        {
            InitializeComponent();
            db = new SqlConnection(Helper.CnnVal("TEC_DB"));
        }

        void Clear()
        {
            txt_fornavn.Text = txt_efternavn.Text = txt_gadenavn.Text = txt_gadenummer.Text = txt_postnummer.Text = txt_bynavn.Text = txt_username.Text = txt_password.Text = "";
        }

        private void btn_nykunde_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txt_gadenummer.Text, out int gadenummer);

                int.TryParse(txt_postnummer.Text, out int postnummer);

                var kunde = new Kunde(txt_fornavn.Text, txt_efternavn.Text, txt_username.Text, txt_password.Text);
                TilføjKundeTilDatabase(kunde);

                var adresse = new Adresse(txt_gadenavn.Text, gadenummer, postnummer, txt_bynavn.Text);
                TilføjAdresseTilDatabase(adresse, kunde.KundeID);

                // Opdater kundeobjektet med den oprettede adresse
                kunde.MinAdresse = adresse;

                MessageBox.Show("Kunde oprettet.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der er sket en fejl, prøv igen eller kontakt kundeservice, hvis problemet forsætter." + Environment.NewLine + ex.Message);
            }
        }


        private void TilføjKundeTilDatabase(Kunde kunde)
        {
            var query = "INSERT INTO Kunde (Fornavn, Efternavn, Username, Password) " +
                        "VALUES (@Fornavn, @Efternavn, @Username, @Password);" +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";

            var parameters = new
            {
                kunde.Fornavn,
                kunde.Efternavn,
                kunde.Username,
                kunde.Password
            };

            kunde.KundeID = db.Query<int>(query, parameters).Single();


        }

        private void TilføjAdresseTilDatabase(Adresse adresse, int kundeID)
        {
            var query = "INSERT INTO Adresse (Gadenavn, Gadenummer, Postnummer, ByNavn, KundeID) " +
                        "VALUES (@Gadenavn, @Gadenummer, @Postnummer, @ByNavn, @KundeID)";

            var parameters = new
            {
                adresse.Gadenavn,
                adresse.Gadenummer,
                adresse.Postnummer,
                adresse.ByNavn,
                KundeID = kundeID
            };

            db.Execute(query, parameters);

            Clear();
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
