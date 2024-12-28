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
    public partial class SinavYonetim : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");

        public SinavYonetim()
        {
            InitializeComponent();
        }

        private void sinavtarihAra()
        {
            sinavtakvimiListe.Items.Clear();
            sinavtakvimiListe.View = View.Details;
            sinavtakvimiListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand sinavAra = new SqlCommand("SELECT * FROM SinavYonetimTBL where KatilanOgrenciTC = '" + sinavtakipOgrenciTC.Text + "'", sqlBaglanti);
            SqlDataReader oku = sinavAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["KatilanOgrenciTC"].ToString());
                item.SubItems.Add(oku["DersKod"].ToString());
                item.SubItems.Add(oku["DersAd"].ToString());
                item.SubItems.Add(oku["SinavTarihi"].ToString());
                sinavtakvimiListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void sinavtarihListele()
        {
            sinavtakvimiListe.Items.Clear();
            sinavtakvimiListe.View = View.Details;
            sinavtakvimiListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand sinavListele = new SqlCommand("SELECT * FROM SinavYonetimTBL", sqlBaglanti);
            SqlDataReader oku = sinavListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["KatilanOgrenciTC"].ToString());
                item.SubItems.Add(oku["DersKod"].ToString());
                item.SubItems.Add(oku["DersAd"].ToString());
                item.SubItems.Add(oku["SinavTarihi"].ToString());
                sinavtakvimiListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void sinavgirilensonucListele()
        {
            sinavsonucListe.Items.Clear();
            sinavsonucListe.View = View.Details;
            sinavsonucListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand sonuclarilistele = new SqlCommand("SELECT * FROM SinavSonucTBL", sqlBaglanti);
            SqlDataReader oku = sonuclarilistele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["KatilanOgrenciTC"].ToString());
                item.SubItems.Add(oku["DersKod"].ToString());
                item.SubItems.Add(oku["Vize"].ToString());
                item.SubItems.Add(oku["Final"].ToString());
                item.SubItems.Add(oku["Ortalama"].ToString());
                sinavsonucListe.Items.Add(item);
            }
            sqlBaglanti.Close();

        }
        private void sinavtarihTemizleme()
        {
            sinavtakipOgrenciTC.Text = "";
            sinavtakipDersKodu.Text = "";
            sinavtakipDersAdi.Text = "";
            sinavtakipSinavTarih.Text = "";
            sinavtakipOgrenciTC.Focus();
        }
        private void sinavsonucTemizleme()
        {
            sinavtakipOgrenciTC.Text = "";
            sinavtakipsonucDersKodu.Text = "";
            sinavtakipsonucVize.Text = "";
            sinavtakipsonucFinal.Text = "";
            sinavtakipOgrenciTC.Focus();
        }




        private void SinavYonetim_Load(object sender, EventArgs e)
        {
            sinavgirilensonucListele();
            sinavtarihListele();
        }

        private void sinavAra_Click(object sender, EventArgs e)
        {
            sinavtarihAra();
        }

        private void sinavEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string sinavEkle = "insert into SinavYonetimTBL (KatilanOgrenciTC,DersKod, DersAd, SinavTarihi) values (@p1,@p2,@p3,@p4)";
                SqlCommand ekle = new SqlCommand(sinavEkle, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", sinavtakipOgrenciTC.Text);
                ekle.Parameters.AddWithValue("@p2", sinavtakipDersKodu.Text);
                ekle.Parameters.AddWithValue("@p3", sinavtakipDersAdi.Text);
                ekle.Parameters.AddWithValue("@p4", sinavtakipSinavTarih.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Sınav kaydı başarıyla gerçekleşti");

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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavtarihTemizleme();
        }

        private void sinavDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sinavDuzenle = new SqlCommand("UPDATE SinavYonetimTBL SET DersKod = '" + sinavtakipDersKodu.Text + "', DersAd= '" + sinavtakipDersAdi.Text + "', SinavTarihi = '" + sinavtakipSinavTarih.Text
                    + "' WHERE KatilanOgrenciTC = '" + sinavtakipOgrenciTC.Text + "'", sqlBaglanti);
                sinavDuzenle.ExecuteNonQuery();
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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavtarihTemizleme();
        }

        private void sinavSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sinavSil = new SqlCommand("Delete From SinavYonetimTBL where KatilanOgrenciTC = '" + sinavtakipOgrenciTC.Text + "' and DersKod = '" + sinavtakipDersKodu.Text + "'", sqlBaglanti);
                sinavSil.ExecuteNonQuery();
                MessageBox.Show("Sınav kaydı başarıyla silindi");

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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavtarihTemizleme();
        }

        private void sinavsonucEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string sonucEkle = "insert into SinavSonucTBL (KatilanOgrenciTC,DersKod, Vize, Final) values (@p1,@p2,@p3,@p4)";
                SqlCommand ekle = new SqlCommand(sonucEkle, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", sinavtakipOgrenciTC.Text);
                ekle.Parameters.AddWithValue("@p2", sinavtakipsonucDersKodu.Text);
                ekle.Parameters.AddWithValue("@p3", sinavtakipsonucVize.Text);
                ekle.Parameters.AddWithValue("@p4", sinavtakipsonucFinal.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Sınav sonuç kaydı başarıyla gerçekleşti");
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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavsonucTemizleme();
        }

        private void sinavsonucDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sonucDuzenle = new SqlCommand("UPDATE SinavSonucTBL SET DersKod = '" + sinavtakipsonucDersKodu.Text + "', Vize= '" + sinavtakipsonucVize.Text + "', Final = '" + sinavtakipsonucFinal.Text
                    + "' WHERE KatilanOgrenciTC = '" + sinavtakipOgrenciTC.Text + "'", sqlBaglanti);
                sonucDuzenle.ExecuteNonQuery();
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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavsonucTemizleme();
        }

        private void sinavsonucSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sonucSil = new SqlCommand("Delete From SinavSonucTBL where KatilanOgrenciTC = '" + sinavtakipOgrenciTC.Text + "' and DersKod = '" + sinavtakipsonucDersKodu.Text + "'", sqlBaglanti);
                sonucSil.ExecuteNonQuery();
                MessageBox.Show("Sınav sonuç kaydı başarıyla silindi");
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
            sinavgirilensonucListele();
            sinavtarihListele();
            sinavsonucTemizleme();
        }

        private void sinavtakvimiListe_MouseClick(object sender, MouseEventArgs e)
        {
            sinavtakipOgrenciTC.Text = sinavtakvimiListe.SelectedItems[0].SubItems[0].Text;
            sinavtakipDersKodu.Text = sinavtakvimiListe.SelectedItems[0].SubItems[1].Text;
            sinavtakipDersAdi.Text = sinavtakvimiListe.SelectedItems[0].SubItems[2].Text;
            sinavtakipSinavTarih.Text = sinavtakvimiListe.SelectedItems[0].SubItems[3].Text;
            sinavtakipsonucDersKodu.Text = "";
            sinavtakipsonucVize.Text = "";
            sinavtakipsonucFinal.Text = "";
        }

        private void sinavsonucListe_MouseClick(object sender, MouseEventArgs e)
        {
            sinavtakipOgrenciTC.Text = sinavsonucListe.SelectedItems[0].SubItems[0].Text;
            sinavtakipsonucDersKodu.Text = sinavsonucListe.SelectedItems[0].SubItems[1].Text;
            sinavtakipsonucVize.Text = sinavsonucListe.SelectedItems[0].SubItems[2].Text;
            sinavtakipsonucFinal.Text = sinavsonucListe.SelectedItems[0].SubItems[3].Text;
            sinavtakipDersKodu.Text = "";
            sinavtakipDersAdi.Text = "";
            sinavtakipSinavTarih.Text = "";
        }

    }
}
