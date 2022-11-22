using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Text;
using System.Xml;

namespace GUI_Basis_xml
{
    public partial class Form1 : Form
    {
        List<Persoon> personenLijst = new List<Persoon>();
        bool unsaved = true;

        const byte GEEN_FOUTEN = 0x00;
        const byte ID_ERROR = 0x01;
        const byte GEBOORTEDATUM_ERROR = 0x02;
        const byte NAAM_ERROR = 0x04;
        const byte VOORNAAM_ERROR = 0X08;

        public Form1()
        {
            InitializeComponent();
            geboortedatumDtp.MaxDate = DateTime.Now;
        }

        private byte TestIngevoerdeGegevens(string id, string naam, string voornaam, DateTime geboortedatum )
        {
            byte errors = GEEN_FOUTEN;


            if (!Persoon.TestID(id) == true)
            {
                errors |= ID_ERROR;

            }

            if (naamTb.Text == string.Empty)
            {
                errors |= NAAM_ERROR;
            } 

            if (voornaamTb.Text == string.Empty)
            {
                errors |= VOORNAAM_ERROR;
            }

            if (!Persoon.TestGeboorteDatum(geboortedatum))
            {
                errors |= GEBOORTEDATUM_ERROR;
            }

            return errors;
        }

        private void MeldFouten(byte errors)
        {
            StringBuilder errmsg = new StringBuilder();
            errmsg.Append("Volgend fouten vastgesteld : ");
            errmsg.Append(Environment.NewLine);

                if ((errors & NAAM_ERROR) == NAAM_ERROR)
                {
                    errmsg.Append("- Ontbrekende naam");
                    errmsg.Append(Environment.NewLine);
                    naamTb.BackColor = Color.Red;
                }

                if ((errors & VOORNAAM_ERROR) == VOORNAAM_ERROR)
                {
                    errmsg.Append("- Ontbrekende voornaam");
                    errmsg.Append(Environment.NewLine);
                    voornaamTb.BackColor = Color.Red;
                }

                if ((errors & GEBOORTEDATUM_ERROR) == GEBOORTEDATUM_ERROR)
                {
                    errmsg.Append("- Fout in geboortedatum");
                    errmsg.Append(Environment.NewLine);
                    geboortedatumDtp.CalendarForeColor= Color.Red;
                }

                if ((errors & ID_ERROR) == ID_ERROR)
                {
                    errmsg.Append("- Fout in ID-nummer ");
                    errmsg.Append(Environment.NewLine);
                    idTb.BackColor = Color.Red;
                }

                MessageBox.Show(errmsg.ToString(),"FOUT",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        

        private void voegPersoonToeBtn_Click(object sender, EventArgs e)
        {
            string id = idTb.Text;
            string naam = naamTb.Text;
            string voornaam = voornaamTb.Text;
            DateTime geboortedatum = geboortedatumDtp.Value;

            byte errors = TestIngevoerdeGegevens(id, naam, voornaam, geboortedatum);

            if (errors!= GEEN_FOUTEN)
            {
                MeldFouten(errors);
                return;
            }

            Persoon pers = new Persoon(id, naam, voornaam, geboortedatum);
            personenLijst.Add(pers);
            personenBox.DataSource = null;
            personenBox.DataSource = personenLijst;
            bewaarPersonenBtn.Enabled = true;
        }

        private void TextInvoerGewijzigd(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = SystemColors.Window;
            }

            if (sender is DateTimePicker)
            {
                (sender as DateTimePicker).CalendarForeColor = SystemColors.Control;
            }
        }

        private void wisVeldenBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Velden wissen?", "Opgelet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (dr==DialogResult.OK)
            {
                foreach (Control c in invoerBox.Controls)
                {
                    if (c is TextBox) (c as TextBox).Text = String.Empty;
                }

                geboortedatumDtp.MaxDate = DateTime.Now;
            }
        }

        private void wisGeselecteerdeBtn_Click(object sender, EventArgs e)
        {
            int index = personenBox.SelectedIndex;

            if (index >= 0 && index < personenLijst.Count)
            {
                string naam = personenLijst[index].Naam;
                string voornaam = personenLijst[index].Voornaam;
                string id = personenLijst[index].ID;
                string geboortedatum = personenLijst[index].GeboorteDatum.Date.ToString();

                string msg = "record wissen ?\n"+
                    $"naam : {naam}\n" +
                    $" voornaam : {voornaam}\n" +
                    $" geboortedatum : {geboortedatum}\n" +
                    $"id : {id}";

                DialogResult dr = MessageBox.Show(msg, "Opgelet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    personenLijst.RemoveAt(index);
                    personenBox.DataSource = null;
                    personenBox.DataSource = personenLijst;
                    bewaarPersonenBtn.Enabled = true;
                }
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Toepassing afsluiten?", "Opgelet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                if (unsaved==true)
                {
                    dr = MessageBox.Show("Gegevens opslaan?", "Opgelet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dr==DialogResult.OK)
                    {
                        gegevensOpslaanToolStripMenuItem_Click(this, new EventArgs());
                    }
                }
                Application.Exit();
            }
        }

        private void gegevensOpslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hier moeten de gegevens worden opgeslagen", "Opdracht", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}