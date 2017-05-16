using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForme_Zadatak
{
    public partial class Form3 : Form
    {

        DataClasses1DataContext db;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshAll();
            UpdateImena();
            
        }

        private void RefreshAll()
        {
            UpdateTable();
            UpdateComboBoxDrzave();
            dataGridView1.ClearSelection();
        }

        private void UpdateTable()
        {
            db = new DataClasses1DataContext();
            var t = (from mjesta in db.Mjestas
                     join drzave in db.Drzaves
                     on mjesta.DrzaveId equals drzave.DrzaveId
                     orderby mjesta.Naziv
                     where (mjesta.DrzaveId == drzave.DrzaveId) && (mjesta.Deleted == false) && (drzave.Deleted == false)

                     select new
                     {
                         n1 = drzave.Naziv,
                         n2 = mjesta.Naziv,
                         drzave.DrzaveId

                     }).ToList();
            dataGridView1.DataSource = t;
        }

        private void UpdateComboBoxDrzave()
        {
            db = new DataClasses1DataContext();
            comboBoxDrzave.DataSource = db.Drzaves
                                      .Where(p =>p.Deleted==false)
                                      .Select(p => p.Naziv)
                                      .Distinct().ToArray();
            comboBoxDrzave.SelectedIndex = -1;

        }

        private void UpdateImena()
        {
            dataGridView1.Columns[0].HeaderText = "Država";
            dataGridView1.Columns[1].HeaderText = "Mjesto";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxDrzave.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBoxMjesta.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
        }

        private void updateRecord()
        {
            db = new DataClasses1DataContext();
            if (!db.Drzaves.Any(g => g.Naziv.ToString().ToLower() == comboBoxDrzave.Text.ToLower()))
            {
                Drzave drzava = new Drzave();
                drzava.Naziv = comboBoxDrzave.Text;
                db.Drzaves.InsertOnSubmit(drzava);
                db.SubmitChanges();
            }


            Mjesta mjesto = new Mjesta();
            mjesto.Naziv = comboBoxMjesta.Text;
            var dr = db.Drzaves.Where(m => m.Naziv.ToString().ToLower() == comboBoxDrzave.Text.ToLower()).FirstOrDefault();
            mjesto.DrzaveId = dr.DrzaveId;
            if (db.Mjestas.Any(g => g.Naziv.ToString().ToLower() == comboBoxMjesta.Text.ToLower() && g.DrzaveId == dr.DrzaveId))
            {
                MessageBox.Show("Država s tim gradom već postoji");

                if (!db.Mjestas.Any(g => g.Naziv.ToString().ToLower() == comboBoxMjesta.Text.ToLower()))
                {
                    db.Mjestas.InsertOnSubmit(mjesto);
                    db.SubmitChanges();
                }


                
            }
            else
            { 
                string drzavaString = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string mjestoString = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                var drza = db.Drzaves.Where(d => d.Naziv.ToString().ToLower() == drzavaString.ToLower()).FirstOrDefault();
                var query = db.Mjestas.Where(g => g.Naziv.ToString().ToLower() == mjestoString.ToLower() && g.DrzaveId == drza.DrzaveId).FirstOrDefault();
                query.Naziv = comboBoxMjesta.Text;
                query.DrzaveId = dr.DrzaveId;
                db.SubmitChanges();
                RefreshAll();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (comboBoxDrzave.Text == "" || comboBoxMjesta.Text == "")
            {
                MessageBox.Show("Ne mozete unijeti prazno");
            }
            else
                updateRecord();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (db.Drzaves.Any(g => g.Naziv.ToString().ToLower() == comboBoxDrzave.Text.ToLower()))
            {

            }

            else
            {
                Drzave drzava = new Drzave();
                drzava.Naziv = comboBoxDrzave.Text;
                db.Drzaves.InsertOnSubmit(drzava);
                db.SubmitChanges();
            }

                Mjesta mjesto = new Mjesta();
                mjesto.Naziv = comboBoxMjesta.Text;

            
                var mj = db.Drzaves.Where(m => m.Naziv.ToString().ToLower() == comboBoxDrzave.Text.ToLower()).FirstOrDefault();
                mjesto.DrzaveId = mj.DrzaveId;


                if (db.Mjestas.Any(g => g.Naziv.ToString().ToLower() == comboBoxMjesta.Text.ToLower() && g.DrzaveId==mjesto.DrzaveId ))
                {
                    MessageBox.Show("U toj državi već postoji grad s takvim imenom");
                }
                else
                {
                    db.Mjestas.InsertOnSubmit(mjesto);
                    db.SubmitChanges();
                    RefreshAll();
                }

            

            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            string drzavaString = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mjestoString = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var drza = db.Drzaves.Where(d => d.Naziv.ToString().ToLower() == drzavaString.ToLower()).FirstOrDefault();
            var query = db.Mjestas.Where(g => g.Naziv.ToString().ToLower() == mjestoString.ToLower() && g.DrzaveId == drza.DrzaveId).FirstOrDefault();
            query.Deleted = true;
            db.SubmitChanges();
            RefreshAll();
        }

        }
    }


