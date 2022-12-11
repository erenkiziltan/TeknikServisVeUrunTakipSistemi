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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTEknikServisEntities db = new DbTEknikServisEntities();
        void liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON


                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON


                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.AD,
                                                    x.ID
                                                }).ToList();




            string ad1, soyad1,ad2, soyad2,ad3,soyad3,ad4,soyad4;

            //1.PERSONEL
            ad1=db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl18.Text = ad1 + "" + soyad1;
            labelControl20.Text = db.TBLPERSONEL.First(x=>x.ID==1).TBLDEPARTMAN.AD;
            labelControl21.Text = db.TBLPERSONEL.First(x=>x.ID==1).MAIL;
            //2.PERSONEL
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl25.Text = ad2 + "" + soyad2;
            labelControl26.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl27.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            //3.PERSONEL
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl30.Text = ad3 + "" + soyad3;
            labelControl28.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl29.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            //4.PERSONEL
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl31.Text = ad4 + "" + soyad4;
            labelControl32.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl33.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;


        }

        

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = TxtMail.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Eklendi");
            liste();
                                

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }
    }
}
