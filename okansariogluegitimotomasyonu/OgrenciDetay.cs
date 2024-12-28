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

    public partial class OgrenciDetay : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");
        public OgrenciDetay()
        {
            InitializeComponent();
        }


        private void OgrenciDetay_Load(object sender, EventArgs e)
        {
            ogrencidtySinifBilgileri.Items.Clear();
            ogrencidtySinifBilgileri.View = View.Details;
            ogrencidtySinifBilgileri.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand sinifiklistele = new SqlCommand("SELECT * FROM SinifSecimTBL WHERE SinifOgrencileri = '" + ogrencidtyTC.Text + "'", sqlBaglanti);
            SqlDataReader oku = sinifiklistele.ExecuteReader();
            while (oku.Read())
            {
                txtogrencidtySinif.Text = oku["SinifAdi"].ToString();
            }
            sqlBaglanti.Close();

            sqlBaglanti.Open();
            SqlCommand devamsizliklistele = new SqlCommand("SELECT * FROM DevamsizlikTBL WHERE TC = '" + ogrencidtyTC.Text + "'", sqlBaglanti);
            SqlDataReader oku2 = devamsizliklistele.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem item = new ListViewItem(oku2["DevamsizlikTarih"].ToString());
                item.SubItems.Add(oku2["DevamsizlikNeden"].ToString());
                ogrencidtySinifBilgileri.Items.Add(item);
            }
            sqlBaglanti.Close();

            sqlBaglanti.Open();
            SqlCommand kutuphanegetir = new SqlCommand("SELECT * FROM KutuphaneTBL WHERE OduncAlanTC = '" +ogrencidtyTC.Text+ "'" ,sqlBaglanti);
            SqlDataReader oku3 = kutuphanegetir.ExecuteReader();
            while (oku3.Read())
            {
                ListViewItem item = new ListViewItem(oku3["ISBN"].ToString());
                item.SubItems.Add(oku3["KitapAd"].ToString());
                item.SubItems.Add(oku3["OduncTarih"].ToString());
                ogrencidtyKutuphaneBilgileriListe.Items.Add(item);
            }
            sqlBaglanti.Close();

            sqlBaglanti.Open();
            SqlCommand sinavortgetir = new SqlCommand("SELECT * FROM SinavSonucTBL WHERE KatilanOgrenciTC = '"+ ogrencidtyTC.Text +"'",sqlBaglanti);
            SqlDataReader oku4 = sinavortgetir.ExecuteReader();
            while (oku4.Read())
            {
                GenelNotOrtYonlendirme.Text = oku4["Ortalama"].ToString();
            }
            sqlBaglanti.Close();
        }
    }
}
