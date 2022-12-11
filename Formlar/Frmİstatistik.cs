using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbTEknikServisEntities db = new DbTEknikServisEntities();
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }

        private void labelControl36_Click(object sender, EventArgs e)
        {

        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                  orderby x.STOK descending
                                  select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = "10";
            labelControl24.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl33.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl28.Text = db.TBLURUN.Count(x=>x.KATEGORI==4).ToString();
            labelControl19.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl17.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl41.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl40.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl6.Text = db.makskategoriurun().FirstOrDefault();

        }

        private void labelControl41_Click(object sender, EventArgs e)
        {

        }

        private void labelControl40_Click(object sender, EventArgs e)
        {

        }
    }
}
