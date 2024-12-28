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



    public partial class OgretmenKayitForm : Form
    {
        public int Numara;
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");

        public OgretmenKayitForm()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            txtOgretmenTC.Text = "";
            txtOgretmenAd.Text = "";
            txtOgretmenSoyad.Text = "";
            txtOgretmenBrans.Text = "";
            txtOgretmenCinsiyet.Text = "";
            txtOgretmenTel.Text = "";
            txtOgretmenEposta.Text = "";
            txtOgretmenTC.Focus();
        }
        private void ogretmenListele()
        {
            ogretmenListe.Items.Clear();
            ogretmenListe.View = View.Details;
            ogretmenListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM OgretmenKayitTBL", sqlBaglanti);
            SqlDataReader oku = listele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["OgretmenTC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["Brans"].ToString());
                item.SubItems.Add(oku["Eposta"].ToString());
                item.SubItems.Add(oku["Cinsiyet"].ToString());
                item.SubItems.Add(oku["Telefon"].ToString());
                ogretmenListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void OgretmenAra()
        {
            ogretmenListe.Items.Clear();
            ogretmenListe.View = View.Details;
            ogretmenListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand ogretmenAra = new SqlCommand("SELECT * FROM OgretmenKayitTBL WHERE ogretmenTC = '" + txtOgretmenTC.Text + "'", sqlBaglanti);
            SqlDataReader oku = ogretmenAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["OgretmenTC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["Brans"].ToString());
                item.SubItems.Add(oku["Eposta"].ToString());
                item.SubItems.Add(oku["Cinsiyet"].ToString());
                item.SubItems.Add(oku["Telefon"].ToString());
                ogretmenListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }








        private void OgretmenKayitForm_Load(object sender, EventArgs e)
        {
            ogretmenListele();
            temizle();
        }
        private void ogretmenAra_Click(object sender, EventArgs e)
        {
            OgretmenAra();
        }
        private void duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand duzenleme = new SqlCommand("UPDATE OgretmenKayitTBL SET Ad = '" + txtOgretmenAd.Text
                    + "', Soyad= '" + txtOgretmenSoyad.Text + "', Brans= '" + txtOgretmenBrans.Text + "', Cinsiyet = '" + txtOgretmenCinsiyet.Text + "', Telefon = '"
                    + txtOgretmenTel.Text + "', Eposta = '" + txtOgretmenEposta.Text
                    + "' WHERE OgretmenTC = '" + txtOgretmenTC.Text + "'", sqlBaglanti);
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
            ogretmenListele();
            temizle();
        }
        private void ekle_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string ogretmenkayit = "insert into OgretmenKayitTBL (OgretmenTC, Ad, Soyad, Brans, Eposta ,Cinsiyet , Telefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                SqlCommand ekle = new SqlCommand(ogretmenkayit, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", txtOgretmenTC.Text);
                ekle.Parameters.AddWithValue("@p2", txtOgretmenAd.Text);
                ekle.Parameters.AddWithValue("@p3", txtOgretmenSoyad.Text);
                ekle.Parameters.AddWithValue("@p4", txtOgretmenBrans.Text);
                ekle.Parameters.AddWithValue("@p5", txtOgretmenEposta.Text);
                ekle.Parameters.AddWithValue("@p6", txtOgretmenCinsiyet.Text);
                ekle.Parameters.AddWithValue("@p7", txtOgretmenTel.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Öğretmen kaydı başarıyla gerçekleşti");
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
            ogretmenListele();
            temizle();
        }
        private void sil_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From OgretmenKayitTBL where OgretmenTC = '" + txtOgretmenTC.Text + "'", sqlBaglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Öğretmen kaydı başarıyla silindi");
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
            ogretmenListele();
            temizle();
        }
       
        private void ogretmenListe_MouseClick(object sender, MouseEventArgs e)
        {
            txtOgretmenTC.Text = ogretmenListe.SelectedItems[0].SubItems[0].Text;
            txtOgretmenAd.Text = ogretmenListe.SelectedItems[0].SubItems[1].Text;
            txtOgretmenSoyad.Text = ogretmenListe.SelectedItems[0].SubItems[2].Text;
            txtOgretmenBrans.Text = ogretmenListe.SelectedItems[0].SubItems[3].Text;
            txtOgretmenEposta.Text = ogretmenListe.SelectedItems[0].SubItems[4].Text;
            txtOgretmenCinsiyet.Text = ogretmenListe.SelectedItems[0].SubItems[5].Text;
            txtOgretmenTel.Text = ogretmenListe.SelectedItems[0].SubItems[6].Text;
        }
        
        private void ogretmenListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OgretmenDetay frmogretmendty = new OgretmenDetay();
            frmogretmendty.ogretmendtyTC.Text = ogretmenListe.SelectedItems[0].SubItems[0].Text;
            frmogretmendty.ogretmendtyAd.Text = ogretmenListe.SelectedItems[0].SubItems[1].Text;
            frmogretmendty.ogretmendtySoyad.Text = ogretmenListe.SelectedItems[0].SubItems[2].Text;
            frmogretmendty.ogretmendtyBrans.Text = ogretmenListe.SelectedItems[0].SubItems[3].Text;
            frmogretmendty.ogretmendtyEposta.Text = ogretmenListe.SelectedItems[0].SubItems[4].Text;
            frmogretmendty.ogretmendtyCinsiyet.Text = ogretmenListe.SelectedItems[0].SubItems[5].Text;
            frmogretmendty.ogretmendtyTelefon.Text = ogretmenListe.SelectedItems[0].SubItems[6].Text;
            frmogretmendty.Show();
        }

       
    }
}
