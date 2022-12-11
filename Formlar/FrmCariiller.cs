using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TeknikServis.Formlar
{
    public partial class FrmCariiller : Form
    {
        public FrmCariiller()
        {
            InitializeComponent();
        }
        DbTEknikServisEntities db = new DbTEknikServisEntities();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1803T0D\SQLEXPRESS;Initial Catalog=DbTEknikServis;Integrated Security=True");
        private void FrmCariiller_Load(object sender, EventArgs e)
        {

            gridControl1.DataSource = db.TBLCARI.OrderBy(X => X.IL).
                GroupBy(y => y.IL).
                Select(z => new
            {
                İL = z.Key,TOPLAM = z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM TBLCARI group by IL  ",baglanti  );
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series "].Points.AddPoint(Convert.ToString( dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

        }
    }
}
