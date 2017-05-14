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
    public partial class Form1 : Form
    {
        DataClasses1DataContext db;

        public Form1()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            GetPartneriResult();

        }

        public void GetPartneriResult()
        {
            db = new DataClasses1DataContext();
            var q = (from partneri in db.GetTable<Partneri>()
                     from mjesta in db.GetTable<Mjesta>()

                     select new
                     {
                         m = partneri.Naziv,
                         partneri.TipPoduzeca,
                         partneri.Adresa,
                         m2 = mjesta.Naziv,
                         partneri.OIB,
                         partneri.Telefon,
                         partneri.Telefaks,
                         partneri.Email,
                         partneri.WebStranica,
                         partneri.Napomena,

                     }).ToList();
            db.Connection.Close();
            dataGridView1.DataSource = q;



        }

    }
}
