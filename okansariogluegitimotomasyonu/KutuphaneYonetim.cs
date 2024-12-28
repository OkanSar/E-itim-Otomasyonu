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
    public partial class KutuphaneYonetim : Form
    {
        public int Numara;

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");
        public KutuphaneYonetim()
        {
            InitializeComponent();
        }
        private void KitapArama()
        {
            kutuphaneListe.Items.Clear();
            kutuphaneListe.View = View.Details;
            kutuphaneListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand kitapAra = new SqlCommand("SELECT * FROM KutuphaneTBL WHERE ISBN = '" + txtISBN.Text + "'", sqlBaglanti);
            SqlDataReader oku = kitapAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["ISBN"].ToString());
                item.SubItems.Add(oku["KitapAd"].ToString());
                item.SubItems.Add(oku["Yazar"].ToString());
                item.SubItems.Add(oku["KitapDurum"].ToString());
                item.SubItems.Add(oku["OduncAlanTC"].ToString());
                item.SubItems.Add(oku["OduncTarih"].ToString());
                item.SubItems.Add(oku["IadeTarih"].ToString());
                kutuphaneListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void KitapVeriListele()
        {
            kutuphaneListe.Items.Clear();
            kutuphaneListe.View = View.Details;
            kutuphaneListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand kitapListele = new SqlCommand("SELECT * FROM KutuphaneTBL", sqlBaglanti);
            SqlDataReader oku = kitapListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["ISBN"].ToString());
                item.SubItems.Add(oku["KitapAd"].ToString());
                item.SubItems.Add(oku["Yazar"].ToString());
                item.SubItems.Add(oku["KitapDurum"].ToString());
                item.SubItems.Add(oku["OduncAlanTC"].ToString());
                item.SubItems.Add(oku["OduncTarih"].ToString());
                item.SubItems.Add(oku["IadeTarih"].ToString());
                kutuphaneListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void KutuphaneTemizle()
        {
            txtISBN.Text = "";
            txtKitapAdi.Text = "";
            txtYazar.Text = "";
            txtKitapDurumu.Text = "";
            txtKitapOduncTC.Text = "";
            txtKitapOduncTarih.Text = "";
            txtKitapiadeTarih.Text = "";
            txtISBN.Focus();
        }




        private void KutuphaneYonetim_Load(object sender, EventArgs e)
        {
            KitapVeriListele();
            anasayfaAnlikSaatTarih.Start();
        }

        private void KitapAra_Click(object sender, EventArgs e)
        {
            KitapArama();
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string kitapEkle = "insert into KutuphaneTBL (ISBN, KitapAd, Yazar, KitapDurum ,OduncAlanTC , OduncTarih, IadeTarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                SqlCommand ekle = new SqlCommand(kitapEkle, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", txtISBN.Text);
                ekle.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
                ekle.Parameters.AddWithValue("@p3", txtYazar.Text);
                ekle.Parameters.AddWithValue("@p4", txtKitapDurumu.Text);
                ekle.Parameters.AddWithValue("@p5", txtKitapOduncTC.Text);
                ekle.Parameters.AddWithValue("@p6", txtKitapOduncTarih.Text);
                ekle.Parameters.AddWithValue("@p7", txtKitapiadeTarih.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Kitap kaydı başarıyla gerçekleşti");
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
            KitapVeriListele();
            KutuphaneTemizle();
        }

        private void kitapDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand kitapDuzenle = new SqlCommand("UPDATE KutuphaneTBL SET ISBN = '" + txtISBN.Text
                    + "', KitapAd= '" + txtKitapAdi.Text + "', Yazar= '" + txtYazar.Text + "', KitapDurum = '" + txtKitapDurumu.Text + "', OduncAlanTC = '"
                    + txtKitapOduncTC.Text + "', OduncTarih = '" + txtKitapOduncTarih.Text + "', IadeTarih = '" + txtKitapiadeTarih.Text
                    + "' WHERE ISBN = '" + txtISBN.Text + "'", sqlBaglanti);
                kitapDuzenle.ExecuteNonQuery();
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
            KitapVeriListele();
            KutuphaneTemizle();
        }

        private void KitapSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand kitapSil = new SqlCommand("Delete From KutuphaneTBL where ISBN = '" + txtISBN.Text + "'", sqlBaglanti);
                kitapSil.ExecuteNonQuery();
                MessageBox.Show("Kitap kaydı başarıyla silindi");
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
            KitapVeriListele();
            KutuphaneTemizle();
        }

        private void kutuphaneListe_MouseClick(object sender, MouseEventArgs e)
        {
            Numara = int.Parse(txtISBN.Text = kutuphaneListe.SelectedItems[0].SubItems[0].Text);
            txtKitapAdi.Text = kutuphaneListe.SelectedItems[0].SubItems[1].Text;
            txtYazar.Text = kutuphaneListe.SelectedItems[0].SubItems[2].Text;
            txtKitapDurumu.Text = kutuphaneListe.SelectedItems[0].SubItems[3].Text;
            txtKitapOduncTC.Text = kutuphaneListe.SelectedItems[0].SubItems[4].Text;
            txtKitapOduncTarih.Text = kutuphaneListe.SelectedItems[0].SubItems[5].Text;
            txtKitapiadeTarih.Text = kutuphaneListe.SelectedItems[0].SubItems[6].Text;
        }

        private void anasayfaAnlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anliktarih.Text = DateTime.Now.ToLongDateString();
        }

        private void anliktarih_MouseClick(object sender, MouseEventArgs e)
        {
            txtKitapOduncTarih.Text = anliktarih.Text;
        }
    }
}
