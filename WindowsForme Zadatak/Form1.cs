using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForme_Zadatak
{

    public partial class Form1 : Form
    {
        DataClasses1DataContext db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshAll();
            UpdateImena();

        }

        private void UpdateComboBoxDrzave()
        {
            db = new DataClasses1DataContext();
            drzavacmbBox.DataSource = db.Drzaves
                                      .Where(p => p.Deleted == false)
                                      .Select(p => p.Naziv)
                                      .Distinct().ToArray();
            drzavacmbBox.SelectedIndex = -1;

        }

        





        private void UpdateImena()
        {
            dataGridView1.Columns[0].HeaderText = "Naziv";
            dataGridView1.Columns[1].HeaderText = "Tip poduzeća";
            dataGridView1.Columns[2].HeaderText = "Država";
            dataGridView1.Columns[3].HeaderText = "Adresa";
            dataGridView1.Columns[4].HeaderText = "Mjesto";
            dataGridView1.Columns[5].HeaderText = "OIB";
            dataGridView1.Columns[6].HeaderText = "Telefon";
            dataGridView1.Columns[7].HeaderText = "Telefaks";
            dataGridView1.Columns[8].HeaderText = "Email";
            dataGridView1.Columns[9].HeaderText = "Web stranica";
            dataGridView1.Columns[10].HeaderText = "Napomena";
        }

        private void PlaceHolder()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (string.IsNullOrWhiteSpace(c.Text))
                {
                    c.Text = "*";
                    c.ForeColor = Color.Red;
                }
            }
        }

        private void RefreshAll()
        {
            
            GetPartneriResult();
            UpdateComboBoxDrzave();
            dataGridView1.ClearSelection();
            Clear();

        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(tipcmbBox.Text) ||
                string.IsNullOrWhiteSpace(adresatxtBox.Text) ||
                string.IsNullOrWhiteSpace(mjestocmbBox.Text) ||
                string.IsNullOrWhiteSpace(oibtxtBox.Text) ||
                string.IsNullOrWhiteSpace(telefontxtBox.Text) ||
                string.IsNullOrWhiteSpace(fakstxtBox.Text) ||
                string.IsNullOrWhiteSpace(mailtxtBox.Text) ||
                string.IsNullOrWhiteSpace(webtxtBox.Text) ||
                string.IsNullOrWhiteSpace(napomenatxtBox.Text)
                )
            {
                MessageBox.Show("Polja za unos ne mogu biti prazna");
                return false;
            }

            try
            {
                mailtxtBox.Text = (new MailAddress(mailtxtBox.Text).ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Email adresa nije ispravnog oblika");
                return false;
            }
            return true;

        }

        public void GetPartneriResult()
        {
            db = new DataClasses1DataContext();
            var q = (from partneri in db.Partneris
                     join mjesta in db.Mjestas
                     on partneri.MjestaId equals mjesta.MjestaId
                     join drzave in db.Drzaves
                     on mjesta.DrzaveId equals drzave.DrzaveId

                     where (partneri.MjestaId == mjesta.MjestaId) && (partneri.Deleted == false)
                     orderby partneri.Naziv
                     select new
                     {
                         m1 = partneri.Naziv,
                         partneri.TipPoduzeca,
                         drzave.Naziv,
                         partneri.Adresa,
                         m2 = mjesta.Naziv,
                         partneri.OIB,
                         partneri.Telefon,
                         partneri.Telefaks,
                         partneri.Email,
                         partneri.WebStranica,
                         partneri.Napomena,

                     }).ToList();
            dataGridView1.DataSource = q;



        }

        private void NovoMjesto()
        {
            try
            {

                db = new DataClasses1DataContext();
                Partneri partner = new Partneri();
                partner.Naziv = nazivtextBox.Text;
                partner.TipPoduzeca = tipcmbBox.Text;
                partner.Adresa = adresatxtBox.Text;
                var drzava = db.Drzaves.Where(m => m.Naziv.ToString().ToLower() == drzavacmbBox.Text.ToLower()).FirstOrDefault();
                var mjesto = db.Mjestas.Where(m => m.Naziv.ToString().ToLower() == mjestocmbBox.Text.ToLower() && 
                m.DrzaveId == drzava.DrzaveId &&
                m.Deleted == false).FirstOrDefault();
                partner.MjestaId = mjesto.MjestaId;
                partner.OIB = oibtxtBox.Text;
                partner.Telefon = telefontxtBox.Text;
                partner.Telefaks = fakstxtBox.Text;
                partner.Email = mailtxtBox.Text;
                partner.WebStranica = nazivtextBox.Text;
                partner.Napomena = nazivtextBox.Text;
                db.Partneris.InsertOnSubmit(partner);
                db.SubmitChanges();
                RefreshAll();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("referenfc");
            }


        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (db.Partneris.Any(g => g.OIB.ToString().ToLower() == oibtxtBox.Text.ToLower()))
                {
                    MessageBox.Show("Morate unijet različiti OIB");

                }
                else
                {

                    if (!db.Mjestas.Any(g => g.Naziv.ToString().ToLower() == mjestocmbBox.Text.ToLower()) || 
                        !db.Drzaves.Any(g => g.Naziv.ToString().ToLower() == drzavacmbBox.Text.ToLower()))
                    {
                        Form2 f2 = new Form2(this);
                        f2.ShowDialog();
                        mjestocmbBox.Text = Form2.unosTxt;
                        drzavacmbBox.Text = Form2.unosTxtDrzava;
                        NovoMjesto();
                    }
                    else
                    {
                        NovoMjesto();
                    }
                }

            }
        }
        private void UpdateMjesto()
        {
            string oib = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            var query = db.Partneris.Where(p => p.OIB.ToString() == oib).FirstOrDefault();
            query.Naziv = nazivtextBox.Text;
            query.TipPoduzeca = tipcmbBox.Text;
            query.Adresa = adresatxtBox.Text;

            var drzava = db.Drzaves.Where(m => m.Naziv.ToString().ToLower() == drzavacmbBox.Text.ToLower()).FirstOrDefault();
            var mjesto = db.Mjestas.Where(m => m.Naziv.ToString().ToLower() == mjestocmbBox.Text.ToLower() &&
            m.DrzaveId == drzava.DrzaveId &&
            m.Deleted == false).FirstOrDefault();
            query.MjestaId = mjesto.MjestaId;
            query.OIB = oibtxtBox.Text;
            query.Telefon = telefontxtBox.Text;
            query.Telefaks = fakstxtBox.Text;
            query.Email = mailtxtBox.Text;
            query.WebStranica = webtxtBox.Text;
            query.Napomena = napomenatxtBox.Text;
            db.SubmitChanges();
            RefreshAll();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (!db.Drzaves.Any(g => g.Naziv.ToString().ToLower() == drzavacmbBox.Text.ToLower()) ||
                    !db.Mjestas.Any(g => g.Naziv.ToString().ToLower() == mjestocmbBox.Text.ToLower()))
                {
                    Form2 f2 = new Form2(this);
                    f2.ShowDialog();
                    mjestocmbBox.Text = Form2.unosTxt;
                    drzavacmbBox.Text = Form2.unosTxtDrzava;
                    UpdateMjesto();
                    Clear();
                }

                else
                {

                    UpdateMjesto();
                    Clear();

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nazivtextBox.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            tipcmbBox.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            drzavacmbBox.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            adresatxtBox.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            mjestocmbBox.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            oibtxtBox.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            telefontxtBox.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            fakstxtBox.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            mailtxtBox.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            webtxtBox.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
            napomenatxtBox.Text = dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString();
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Želite li sigurno izbrisati ovaj unos?", "Brisanje unosa", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db = new DataClasses1DataContext();
                string oib = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                var query = db.Partneris.Where(p => p.OIB.ToString() == oib).FirstOrDefault();
                query.Deleted = true;
                db.SubmitChanges();
                RefreshAll();
                Clear();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            RefreshAll();
        }

        private void Clear()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox)
                    c.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void oibtxtBox_TextChanged(object sender, EventArgs e)
        {
            if (oibtxtBox.Text.Length !=0)
            {
                char last = oibtxtBox.Text.Last();
                if (!Char.IsNumber(last))
                {
                    MessageBox.Show("OIB mora biti u brojačnom zapisu!");
                    oibtxtBox.Text = oibtxtBox.Text.Remove(oibtxtBox.Text.Length - 1);

                }
            }
            if (oibtxtBox.Text.Length > 11)
            {
                MessageBox.Show("OIB ne smije biti duži od 11 znakova!");
                oibtxtBox.Text = oibtxtBox.Text.Remove(oibtxtBox.Text.Length - 1);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           

                    


            var q = (from partneri in db.Partneris
                     join mjesta in db.Mjestas
                     on partneri.MjestaId equals mjesta.MjestaId
                     join drzave in db.Drzaves
                     on mjesta.DrzaveId equals drzave.DrzaveId
                     where (partneri.MjestaId == mjesta.MjestaId) && (partneri.Deleted == false)
                     &&
                         partneri.Naziv.ToLower().Contains(nazivtextBox.Text.ToLower()) &&
                         partneri.TipPoduzeca.ToLower().Contains(tipcmbBox.Text.ToLower()) &&
                         drzave.Naziv.ToLower().Contains(adresatxtBox.Text.ToLower()) &&
                         partneri.Adresa.ToLower().Contains(adresatxtBox.Text.ToLower()) &&
                         partneri.Mjesta.Naziv.ToLower().Contains(mjestocmbBox.Text.ToLower()) &&
                         partneri.OIB.ToLower().Contains(oibtxtBox.Text.ToLower()) &&
                         partneri.Telefon.ToLower().Contains(telefontxtBox.Text.ToLower()) &&
                         partneri.Telefaks.ToLower().Contains(fakstxtBox.Text.ToLower()) &&
                         partneri.Email.ToLower().Contains(mailtxtBox.Text.ToLower()) &&
                         partneri.WebStranica.ToLower().Contains(webtxtBox.Text.ToLower()) &&
                         partneri.Napomena.ToLower().Contains(napomenatxtBox.Text.ToLower())
                     orderby partneri.Naziv
                     select new
                     {
                         m1 = partneri.Naziv,
                         partneri.TipPoduzeca,
                         drzave.Naziv,
                         partneri.Adresa,
                         m2 = mjesta.Naziv,
                         partneri.OIB,
                         partneri.Telefon,
                         partneri.Telefaks,
                         partneri.Email,
                         partneri.WebStranica,
                         partneri.Napomena,


                     }).ToList();
            dataGridView1.DataSource = q;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshAll();
            Clear();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentCellAddress.ToString());
        }

        private void drzavacmbBox_TextChanged(object sender, EventArgs e)
        {
            var d = db.Drzaves.Where(x => x.Naziv.ToString().ToLower() == drzavacmbBox.Text.ToLower()).FirstOrDefault();

            if (d != null)
            {
                mjestocmbBox.DataSource = db.Mjestas
                              .Where(p => p.Deleted == false && p.DrzaveId == d.DrzaveId)
                              .Select(p => p.Naziv)
                              .Distinct().ToArray();
            }
            else
            {
                mjestocmbBox.DataSource = null;
            }
        }
    }
    }


