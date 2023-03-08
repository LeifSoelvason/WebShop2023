using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace TECs_WebShop
{
    public partial class IndkøbskurvForm : Form
    {
        private IDbConnection db;
        private Indkøbskurv indkøbskurv = new Indkøbskurv();

        public IndkøbskurvForm()
        {
            InitializeComponent();
            db = new SqlConnection(Helper.CnnVal("TEC_DB"));

            // Hent produkter fra databasen og vis dem i DataGridView
            string query = "SELECT ProduktID, ProduktNavn, Pris, Antal FROM Produkt";
            var produkter = db.Query<Produkt>(query).ToList();
            dataGridView1.DataSource = produkter;
            dataGridView1.Columns["ProduktID"].Visible = false; // Skjul ProduktID-kolonnen // Skjul ProduktID-kolonnen
        }

        private void IndkøbskurvForm_Load(object sender, EventArgs e)
        {
            // Vis antal af produkter i indkøbskurven
            lbl_antalvarer.Text = "Antal varer i kurven: " + indkøbskurv.AntalProdukter().ToString();

        }


        private void btn_tilføj_Click(object sender, EventArgs e)
        {
            var valgteRækker = dataGridView1.SelectedRows;
            if (valgteRækker.Count > 0)
            {
                foreach (DataGridViewRow række in valgteRækker)
                {
                    try
                    {
                        int produktID = Convert.ToInt32(række.Cells["ProduktID"].Value);
                        MessageBox.Show("Selected ProduktID: " + produktID); // Debugging statement
                        var produkt = db.Query<Produkt>("SELECT * FROM Produkt WHERE ProduktID = @ProduktID", new { ProduktID = produktID }).SingleOrDefault();
                        if (produkt != null)
                        {
                            indkøbskurv.TilføjProdukt(produkt);
                            MessageBox.Show("Produkt tilføjet: ");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Der skete en fejl under tilføjelse af produktet: " + ex.Message);
                    }
                }



                // Opdater antallet af produkter i indkøbskurven
                lbl_antalvarer.Text = "Antal varer i kurven: " + indkøbskurv.AntalProdukter().ToString();


            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (indkøbskurv.AntalProdukter() > 0)
            {
                try
                {
                    // Opret en ny Ordre
                    Ordre nyOrdre = new Ordre();
                    nyOrdre.MineProdukter = indkøbskurv.Produkter;
                    nyOrdre.Total = indkøbskurv.TotalPris();

                    // Gem Ordren i databasen
                    string query = "INSERT INTO Ordre (KundeID, ProduktID, Antal, TotalPris) VALUES (@KundeID, @ProduktID, @Antal, @TotalPris)";
                    foreach (Produkt produkt in indkøbskurv.Produkter)
                    {
                        var parameters = new { KundeID = 1, ProduktID = produkt.ProduktID, Antal = 1, TotalPris = produkt.Pris };
                        db.Execute(query, parameters);
                    }

                    // Ryd indkøbskurven
                    indkøbskurv.Produkter.Clear();

                    // Opdater antallet af produkter i indkøbskurven
                    lbl_antalvarer.Text = "Antal varer i kurven: " + indkøbskurv.AntalProdukter().ToString();

                    MessageBox.Show("Ordre oprettet.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Der er sket en fejl, prøv igen eller kontakt kundeservice, hvis problemet forsætter: " + ex.Message);
                }
            }
        }

    }
}
