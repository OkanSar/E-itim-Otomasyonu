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
    public partial class OgrenciKayitForm : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");
        public OgrenciKayitForm()
        {
            InitializeComponent();
        }


        private void temizle()
        {
            TC.Text = "";
            txtOgrenciAd.Text = "";
            txtOgrenciSoyad.Text = "";
            DtpDogumTarihi.Text = "";
            txtOgrenciCinsiyet.Text = "";
            veliTel.Text = "";
            veliEposta.Text = "";
            adres.Text = "";
            TC.Focus();
        }
        private void Liste()
        {
            ogrenciListe.Items.Clear();
            ogrenciListe.View = View.Details;
            ogrenciListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM OgrenciKayitTBL", sqlBaglanti);
            SqlDataReader oku = listele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["TC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["Dogum_Tarihi"].ToString());
                item.SubItems.Add(oku["Cinsiyet"].ToString());
                item.SubItems.Add(oku["Telefon"].ToString());
                item.SubItems.Add(oku["Eposta"].ToString());
                item.SubItems.Add(oku["Adres"].ToString());
                ogrenciListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void OgrenciAra()
        {
            ogrenciListe.Items.Clear();
            ogrenciListe.View = View.Details;
            ogrenciListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand ogrenciAra = new SqlCommand("SELECT * FROM OgrenciKayitTBL WHERE TC = '" + TC.Text + "'", sqlBaglanti);
            SqlDataReader oku = ogrenciAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["TC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["Dogum_Tarihi"].ToString());
                item.SubItems.Add(oku["Cinsiyet"].ToString());
                item.SubItems.Add(oku["Telefon"].ToString());
                item.SubItems.Add(oku["Eposta"].ToString());
                item.SubItems.Add(oku["Adres"].ToString());
                ogrenciListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }


        private void OgrenciKayitForm_Load(object sender, EventArgs e)
        {
            Liste();
        }
        private void ogrenciAra_Click(object sender, EventArgs e)
        {
            OgrenciAra();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string ogrencikayit = "insert into OgrenciKayitTBL (TC, Ad, Soyad, Dogum_Tarihi, Cinsiyet, Telefon, Eposta, Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand ekle = new SqlCommand(ogrencikayit, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", TC.Text);
                ekle.Parameters.AddWithValue("@p2", txtOgrenciAd.Text);
                ekle.Parameters.AddWithValue("@p3", txtOgrenciSoyad.Text);
                ekle.Parameters.AddWithValue("@p4", DtpDogumTarihi.Text);
                ekle.Parameters.AddWithValue("@p5", txtOgrenciCinsiyet.Text);
                ekle.Parameters.AddWithValue("@p6", veliTel.Text);
                ekle.Parameters.AddWithValue("@p7", veliEposta.Text);
                ekle.Parameters.AddWithValue("@p8", adres.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Öğrenci kaydı başarıyla gerçekleşti");
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
            Liste();
            temizle();
        }
        private void duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand duzenleme = new SqlCommand("UPDATE OgrenciKayitTBL SET Ad = '" + txtOgrenciAd.Text + "', Soyad= '" + txtOgrenciSoyad.Text + "',  Dogum_Tarihi = '"
                    + DtpDogumTarihi.Text + "', Cinsiyet = '" + txtOgrenciCinsiyet.Text + "', Telefon = '"
                    + veliTel.Text + "', Eposta = '" + veliEposta.Text + "', Adres = '" + adres.Text
                    + "' WHERE TC = '" + TC.Text + "'", sqlBaglanti);
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
            Liste();
            temizle();
        }
        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From OgrenciKayitTBL where TC = '" + TC.Text + "'", sqlBaglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Öğrenci kaydı başarıyla silindi");
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
            Liste();
            temizle();
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void ogrenciListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OgrenciDetay frmogrencidty = new OgrenciDetay();
            frmogrencidty.ogrencidtyTC.Text = ogrenciListe.SelectedItems[0].SubItems[0].Text;
            frmogrencidty.ogrencidtyAd.Text = ogrenciListe.SelectedItems[0].SubItems[1].Text;
            frmogrencidty.ogrencidtySoyad.Text = ogrenciListe.SelectedItems[0].SubItems[2].Text;
            frmogrencidty.ogrencidtyDogumTarihi.Text = ogrenciListe.SelectedItems[0].SubItems[3].Text;
            frmogrencidty.ogrencidtyCinsiyet.Text = ogrenciListe.SelectedItems[0].SubItems[4].Text;
            frmogrencidty.ogrencidtyTelefon.Text = ogrenciListe.SelectedItems[0].SubItems[5].Text;
            frmogrencidty.ogrencidtyEposta.Text = ogrenciListe.SelectedItems[0].SubItems[6].Text;
            frmogrencidty.ogrencidtyAdres.Text = ogrenciListe.SelectedItems[0].SubItems[7].Text;
            frmogrencidty.Show();
        }
        private void ogrenciListe_MouseClick(object sender, MouseEventArgs e)
        {
            TC.Text = ogrenciListe.SelectedItems[0].SubItems[0].Text;
            txtOgrenciAd.Text = ogrenciListe.SelectedItems[0].SubItems[1].Text;
            txtOgrenciSoyad.Text = ogrenciListe.SelectedItems[0].SubItems[2].Text;
            DtpDogumTarihi.Text = ogrenciListe.SelectedItems[0].SubItems[3].Text;
            txtOgrenciCinsiyet.Text = ogrenciListe.SelectedItems[0].SubItems[4].Text;
            veliTel.Text = ogrenciListe.SelectedItems[0].SubItems[5].Text;
            veliEposta.Text = ogrenciListe.SelectedItems[0].SubItems[6].Text;
            adres.Text = ogrenciListe.SelectedItems[0].SubItems[7].Text;
        }
    }
}
