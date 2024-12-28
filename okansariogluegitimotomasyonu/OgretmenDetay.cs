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

namespace okansariogluegitimotomasyonu
{
    public partial class OgretmenDetay : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");
        public OgretmenDetay()
        {
            InitializeComponent();
        }
        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand ogretmenKutuphanegetir = new SqlCommand("SELECT * FROM KutuphaneTBL WHERE OduncAlanTC = '"+ ogretmendtyTC.Text + "'",sqlBaglanti);
            SqlDataReader oku = ogretmenKutuphanegetir.ExecuteReader();
            while (oku.Read()) 
            {
                ListViewItem item = new ListViewItem(oku["ISBN"].ToString());
                item.SubItems.Add(oku["KitapAd"].ToString());
                item.SubItems.Add(oku["OduncTarih"].ToString());
                ogretmendtyKutuphaneListe.Items.Add(item);
            }
        }
    }
}
