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
    public partial class Form2 : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        private ComboBox cmbMjestaMain;
        private ComboBox cmbDrzaveMain;
        public static string unosTxt;
        public static string unosTxtDrzava;

        public Form2(Form1 mainForma)
        {
            InitializeComponent();
            cmbMjestaMain = mainForma.mjestocmbBox;
            cmbDrzaveMain = mainForma.drzavacmbBox;



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            drzavaCombo.DataSource = db.Drzaves
                                      .Select(p => p.Naziv)
                                      .ToArray();
            drzavaCombo.SelectedIndex = -1;

            mjestoText.Text = cmbMjestaMain.Text;
            drzavaCombo.Text = cmbDrzaveMain.Text;


        }

        private void unosPodataka()
        {
                if (!db.Drzaves.Any(g => g.Naziv.ToString().ToLower() == drzavaCombo.Text.ToLower()))   
            {
                Drzave drzava = new Drzave();
                drzava.Naziv = drzavaCombo.Text;
                db.Drzaves.InsertOnSubmit(drzava);
                db.SubmitChanges();
            }


                Mjesta mjesto = new Mjesta();
                mjesto.Naziv = mjestoText.Text;

                var dr = db.Drzaves.Where(m => m.Naziv.ToString().ToLower() == drzavaCombo.Text.ToLower()).FirstOrDefault();
                 mjesto.DrzaveId = dr.DrzaveId;
                
                db.Mjestas.InsertOnSubmit(mjesto);
                db.SubmitChanges();
                this.Close();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            if(drzavaCombo.Text=="" || mjestoText.Text=="")
            {
                MessageBox.Show("Ne mozete ostaviti prazan unos");

            }
            else
            {
                unosPodataka();
                unosTxt = mjestoText.Text;
                unosTxtDrzava = drzavaCombo.Text;


            }





        }


    }
}
