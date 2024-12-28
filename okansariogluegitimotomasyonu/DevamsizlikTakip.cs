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
    public partial class DevamsizlikTakip : Form
    {

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");

        public DevamsizlikTakip()
        {
            InitializeComponent();
        }
        private void DevamsizlikOgrenciAra()
        {
            devamsizlikListe.Items.Clear();
            devamsizlikListe.View = View.Details;
            devamsizlikListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand devamsizlikAra = new SqlCommand("SELECT * FROM DevamsizlikTBL WHERE TC ='" + txtDevamsizlikTC.Text + "'", sqlBaglanti);
            SqlDataReader oku = devamsizlikAra.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["TC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["DevamsizlikTarih"].ToString());
                item.SubItems.Add(oku["DevamsizlikNeden"].ToString());
                devamsizlikListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }
        private void DevamsizlikTemizle()
        {
            txtDevamsizlikTC.Text = "";
            txtDevamsizlikAd.Text = "";
            txtDevamsizlikSoyad.Text = "";
            txtDevamsizlikTarih.Text = "";
            txtDevamsizlikNeden.Text = "";
            txtDevamsizlikTC.Focus();
        }
        private void DevamsizlikOgrenciListele()
        {
            devamsizlikListe.Items.Clear();
            devamsizlikListe.View = View.Details;
            devamsizlikListe.FullRowSelect = true;

            sqlBaglanti.Open();
            SqlCommand devamsizlikListele = new SqlCommand("SELECT * FROM DevamsizlikTBL", sqlBaglanti);
            SqlDataReader oku = devamsizlikListele.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["TC"].ToString());
                item.SubItems.Add(oku["Ad"].ToString());
                item.SubItems.Add(oku["Soyad"].ToString());
                item.SubItems.Add(oku["DevamsizlikTarih"].ToString());
                item.SubItems.Add(oku["DevamsizlikNeden"].ToString());
                devamsizlikListe.Items.Add(item);
            }
            sqlBaglanti.Close();
        }



        private void DevamsizlikTakip_Load_1(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand ogrenciGetir = new SqlCommand("SELECT * FROM OgrenciKayitTBL", sqlBaglanti);
            SqlDataReader oku = ogrenciGetir.ExecuteReader();
            while (oku.Read())
            {
                txtDevamsizlikTC.Items.Add(oku["TC"]);
            }
            sqlBaglanti.Close();
            DevamsizlikOgrenciListele();
        }

        private void DevamsizlikAra_Click(object sender, EventArgs e)
        {
            DevamsizlikOgrenciAra();
        }

        private void DevamsizlikEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                string devamsizlikEkle = "insert into DevamsizlikTBL (TC, Ad, Soyad, DevamsizlikTarih, DevamsizlikNeden) values (@p1,@p2,@p3,@p4,@p5)";
                SqlCommand ekle = new SqlCommand(devamsizlikEkle, sqlBaglanti);
                ekle.Parameters.AddWithValue("@p1", txtDevamsizlikTC.Text);
                ekle.Parameters.AddWithValue("@p2", txtDevamsizlikAd.Text);
                ekle.Parameters.AddWithValue("@p3", txtDevamsizlikSoyad.Text);
                ekle.Parameters.AddWithValue("@p4", txtDevamsizlikTarih.Text);
                ekle.Parameters.AddWithValue("@p5", txtDevamsizlikNeden.Text); 
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
            DevamsizlikOgrenciListele();
            DevamsizlikTemizle();
        }

        private void DevamsizlikDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand devamsizlikDuzenle = new SqlCommand("UPDATE DevamsizlikTBL SET TC = '" + txtDevamsizlikTC.Text
                    + "', Ad = '" + txtDevamsizlikAd.Text + "', Soyad = '" + txtDevamsizlikSoyad.Text + "', DevamsizlikNeden= '" + txtDevamsizlikNeden.Text
                    + "' WHERE TC = '" + txtDevamsizlikTC.Text + "'", sqlBaglanti);
                devamsizlikDuzenle.ExecuteNonQuery();
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
            DevamsizlikOgrenciListele();
            DevamsizlikTemizle();
        }

        private void DevamsizlikSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();
                SqlCommand devamsizlikSil = new SqlCommand("Delete From DevamsizlikTBL where TC = '" + txtDevamsizlikTC.Text + "'", sqlBaglanti);
                devamsizlikSil.ExecuteNonQuery();
                MessageBox.Show("Devamsizlik kaydı başarıyla silindi");
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
            DevamsizlikOgrenciListele();
            DevamsizlikTemizle();
        }

        private void devamsizlikListe_MouseClick(object sender, MouseEventArgs e)
        {
            txtDevamsizlikTC.Text = devamsizlikListe.SelectedItems[0].SubItems[0].Text;
            txtDevamsizlikAd.Text = devamsizlikListe.SelectedItems[0].SubItems[1].Text;
            txtDevamsizlikSoyad.Text = devamsizlikListe.SelectedItems[0].SubItems[2].Text;
            txtDevamsizlikTarih.Text = devamsizlikListe.SelectedItems[0].SubItems[3].Text;
            txtDevamsizlikNeden.Text = devamsizlikListe.SelectedItems[0].SubItems[4].Text;
        }
    }
}
