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

    public partial class SinifSecimTakip : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");
        public SinifSecimTakip()
        {
            InitializeComponent();
        }
        private void sinifsecimOgrenciAra()
        {
            sinifsecimListe.Items.Clear();
            sinifsecimListe.View = View.Details;
            sinifsecimListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand devamsizlikAra = new SqlCommand("SELECT * FROM SinifSecimTBL WHERE SinifOgrencileri ='" + sinifsecimOgrenciTC.Text + "'", sqlBaglanti);
            SqlDataReader oku = devamsizlikAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["SinifOgrencileri"].ToString());
                item.SubItems.Add(oku["SinifAdi"].ToString());
                sinifsecimListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void SinifSecimTemizle()
        {
            sinifsecimSinifAdi.Text = "";
            sinifsecimOgrenciTC.Text = "";
            sinifsecimOgrenciTC.Focus();
        }
        private void SinifSecimListele()
        {
            sinifsecimListe.Items.Clear();
            sinifsecimListe.View = View.Details;
            sinifsecimListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand devamsizlikAra = new SqlCommand("SELECT * FROM SinifSecimTBL", sqlBaglanti);
            SqlDataReader oku = devamsizlikAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["SinifOgrencileri"].ToString());
                item.SubItems.Add(oku["SinifAdi"].ToString());
                sinifsecimListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }





        private void SinifSecimTakip_Load(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand ogretmenAra = new SqlCommand("SELECT * FROM OgrenciKayitTBL", sqlBaglanti);
            SqlDataReader oku = ogretmenAra.ExecuteReader();
            while (oku.Read())
            {
                sinifsecimOgrenciTC.Items.Add(oku["TC"]);
            }
            sqlBaglanti.Close();
        }

        private void sinifsecimAra_Click(object sender, EventArgs e)
        {
            sinifsecimOgrenciAra();
        }

        private void sinifsecimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string ogretmenkayit = "insert into SinifSecimTBL (SinifOgrencileri, SinifAdi) values (@p1,@p2)";
                SqlCommand ekle = new SqlCommand(ogretmenkayit, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", sinifsecimOgrenciTC.Text);
                ekle.Parameters.AddWithValue("@p2", sinifsecimSinifAdi.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Sınıf kaydı başarıyla gerçekleşti");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme esnasında bir hata gerçekleşti !" + ex.ToString());
            }
            finally
            {
                if (sqlBaglanti != null)
                {
                    sqlBaglanti.Close();
                }
            }
            SinifSecimListele();
            SinifSecimTemizle();
        }

        private void sinifsecimDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand duzenleme = new SqlCommand("UPDATE SinifSecimTBL SET SinifOgrencileri = '" + sinifsecimOgrenciTC.Text
                    + "', SinifAdi= '" + sinifsecimSinifAdi.Text
                    + "' WHERE SinifOgrencileri = '" + sinifsecimOgrenciTC.Text + "'", sqlBaglanti);
                duzenleme.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarıyla gerçekleşti");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Düzenleme esnasında bir hata gerçekleşti !" + ex.ToString());
            }
            finally
            {
                if (sqlBaglanti != null)
                {
                    sqlBaglanti.Close();
                }
            }
            SinifSecimListele();
            SinifSecimTemizle();
        }

        private void sinifsecimSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From SinifSecimTBL where SinifOgrencileri = '" + sinifsecimOgrenciTC.Text + "'", sqlBaglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Ogrenci sınıf kaydı başarıyla silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silinme esnasında bir hata gerçekleşti !" + ex.ToString());
            }
            finally
            {
                if (sqlBaglanti != null)
                {
                    sqlBaglanti.Close();
                }
            }
            SinifSecimListele();
            SinifSecimTemizle();
        }

        private void sinifsecimListele_Click(object sender, EventArgs e)
        {
            SinifSecimListele();
        }

        private void sinifsecimListe_MouseClick(object sender, MouseEventArgs e)
        {
            sinifsecimOgrenciTC.Text = sinifsecimListe.SelectedItems[0].SubItems[0].Text;
            sinifsecimSinifAdi.Text = sinifsecimListe.SelectedItems[0].SubItems[1].Text;
        }

      
    }
}
