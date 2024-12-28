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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace okansariogluegitimotomasyonu
{
    public partial class DersProgrami : Form
    {

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-OJP51CN;Initial Catalog=EgitimOtomasyon;Integrated Security=True;");

        public DersProgrami()
        {
            InitializeComponent();
        }
        private void dersplanTemizle()
        {
            dersplanOgrenciTC.Text = "";
            dersplanDersKodu.Text = "";
            dersplanDersAdi.Text = "";
            dersplanDersOgretmeni.Text = "";
            dersplanDersSaati.Text = "";
            dersplanDersGunu.Text = "";
            dersplanOgrenciTC.Focus();
        }
        private void dersplaniListele()
        {
            if (dersplanDersGunu.Text == "Pazartesi")
            {
                dersplaniPazartesiListele.Items.Clear();
                dersplaniPazartesiListele.View = View.Details;
                dersplaniPazartesiListele.FullRowSelect = true;

                sqlBaglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT * FROM PazartesiDersProgramiTBL", sqlBaglanti);
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["OgrenciTC"].ToString());
                    item.SubItems.Add(oku["DersKod"].ToString());
                    item.SubItems.Add(oku["DersAd"].ToString());
                    item.SubItems.Add(oku["DersSaat"].ToString());
                    item.SubItems.Add(oku["DersOgretmeni"].ToString());
                    dersplaniPazartesiListele.Items.Add(item);
                }
                sqlBaglanti.Close();
            }
            if (dersplanDersGunu.Text == "Salı")
            {
                dersplaniSaliListele.Items.Clear();
                dersplaniSaliListele.View = View.Details;
                dersplaniSaliListele.FullRowSelect = true;

                sqlBaglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT * FROM SaliDersProgramiTBL", sqlBaglanti);
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["OgrenciTC"].ToString());
                    item.SubItems.Add(oku["DersKod"].ToString());
                    item.SubItems.Add(oku["DersAd"].ToString());
                    item.SubItems.Add(oku["DersSaat"].ToString());
                    item.SubItems.Add(oku["DersOgretmeni"].ToString());
                    dersplaniSaliListele.Items.Add(item);
                }
                sqlBaglanti.Close();
            }
            if (dersplanDersGunu.Text == "Çarşamba")
            {
                dersplaniCarsambaListele.Items.Clear();
                dersplaniCarsambaListele.View = View.Details;
                dersplaniCarsambaListele.FullRowSelect = true;

                sqlBaglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT * FROM CarsambaDersProgramiTBL", sqlBaglanti);
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["OgrenciTC"].ToString());
                    item.SubItems.Add(oku["DersKod"].ToString());
                    item.SubItems.Add(oku["DersAd"].ToString());
                    item.SubItems.Add(oku["DersSaat"].ToString());
                    item.SubItems.Add(oku["DersOgretmeni"].ToString());
                    dersplaniCarsambaListele.Items.Add(item);
                }
                sqlBaglanti.Close();
            }
            if (dersplanDersGunu.Text == "Perşembe")
            {
                dersplaniPersembeListele.Items.Clear();
                dersplaniPersembeListele.View = View.Details;
                dersplaniPersembeListele.FullRowSelect = true;

                sqlBaglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT * FROM PersembeDersProgramiTBL", sqlBaglanti);
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["OgrenciTC"].ToString());
                    item.SubItems.Add(oku["DersKod"].ToString());
                    item.SubItems.Add(oku["DersAd"].ToString());
                    item.SubItems.Add(oku["DersSaat"].ToString());
                    item.SubItems.Add(oku["DersOgretmeni"].ToString());
                    dersplaniPersembeListele.Items.Add(item);
                }
                sqlBaglanti.Close();
            }
            if (dersplanDersGunu.Text == "Cuma")
            {
                dersplaniCumaListele.Items.Clear();
                dersplaniCumaListele.View = View.Details;
                dersplaniCumaListele.FullRowSelect = true;

                sqlBaglanti.Open();
                SqlCommand listele = new SqlCommand("SELECT * FROM CumaDersProgramiTBL", sqlBaglanti);
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["OgrenciTC"].ToString());
                    item.SubItems.Add(oku["DersKod"].ToString());
                    item.SubItems.Add(oku["DersAd"].ToString());
                    item.SubItems.Add(oku["DersSaat"].ToString());
                    item.SubItems.Add(oku["DersOgretmeni"].ToString());
                    dersplaniCumaListele.Items.Add(item);
                }
                sqlBaglanti.Close();
            }
        }







        private void DersProgrami_Load(object sender, EventArgs e)
        {
            sqlBaglanti.Open();
            SqlCommand ogrenciTCgetir = new SqlCommand("SELECT * FROM OgrenciKayitTBL", sqlBaglanti);
            SqlDataReader oku = ogrenciTCgetir.ExecuteReader();
            while (oku.Read())
            {
                dersplanOgrenciTC.Items.Add(oku["TC"]);
            }
            sqlBaglanti.Close();
            sqlBaglanti.Open();
            SqlCommand ogretmenAdgetir = new SqlCommand("SELECT * FROM OgretmenKayitTBL", sqlBaglanti);
            SqlDataReader oku2 = ogretmenAdgetir.ExecuteReader();
            while (oku2.Read())
            {
                dersplanDersOgretmeni.Items.Add(oku2["Ad"] + " " + oku2["Soyad"]);
            }
            sqlBaglanti.Close();
            dersplaniListele();
        }

        private void dersplanEkle_Click(object sender, EventArgs e)
        {
            if (dersplanDersGunu.Text == "Pazartesi")
            {
                try
                {
                    sqlBaglanti.Open();
                    string dersEkle = "insert into PazartesiDersProgramiTBL (OgrenciTC,DersKod, DersAd, DersSaat, DersOgretmeni) values (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand ekle = new SqlCommand(dersEkle, sqlBaglanti);
                    ekle.Parameters.AddWithValue("@p1", dersplanOgrenciTC.Text);
                    ekle.Parameters.AddWithValue("@p2", dersplanDersKodu.Text);
                    ekle.Parameters.AddWithValue("@p3", dersplanDersAdi.Text);
                    ekle.Parameters.AddWithValue("@p4", dersplanDersSaati.Text);
                    ekle.Parameters.AddWithValue("@p5", dersplanDersOgretmeni.Text);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla gerçekleşti");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Salı")
            {
                try
                {
                    sqlBaglanti.Open();
                    string dersEkle2 = "insert into SaliDersProgramiTBL (OgrenciTC,DersKod, DersAd, DersSaat, DersOgretmeni) values (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand ekle = new SqlCommand(dersEkle2, sqlBaglanti);
                    ekle.Parameters.AddWithValue("@p1", dersplanOgrenciTC.Text);
                    ekle.Parameters.AddWithValue("@p2", dersplanDersKodu.Text);
                    ekle.Parameters.AddWithValue("@p3", dersplanDersAdi.Text);
                    ekle.Parameters.AddWithValue("@p4", dersplanDersSaati.Text);
                    ekle.Parameters.AddWithValue("@p5", dersplanDersOgretmeni.Text);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla gerçekleşti");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Çarşamba")
            {
                try
                {
                    sqlBaglanti.Open();
                    string dersEkle3 = "insert into CarsambaDersProgramiTBL (OgrenciTC,DersKod, DersAd, DersSaat, DersOgretmeni) values (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand ekle = new SqlCommand(dersEkle3, sqlBaglanti);
                    ekle.Parameters.AddWithValue("@p1", dersplanOgrenciTC.Text);
                    ekle.Parameters.AddWithValue("@p2", dersplanDersKodu.Text);
                    ekle.Parameters.AddWithValue("@p3", dersplanDersAdi.Text);
                    ekle.Parameters.AddWithValue("@p4", dersplanDersSaati.Text);
                    ekle.Parameters.AddWithValue("@p5", dersplanDersOgretmeni.Text);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla gerçekleşti");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Perşembe")
            {
                try
                {
                    sqlBaglanti.Open();
                    string dersEkle4 = "insert into PersembeDersProgramiTBL (OgrenciTC,DersKod, DersAd, DersSaat, DersOgretmeni) values (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand ekle = new SqlCommand(dersEkle4, sqlBaglanti);
                    ekle.Parameters.AddWithValue("@p1", dersplanOgrenciTC.Text);
                    ekle.Parameters.AddWithValue("@p2", dersplanDersKodu.Text);
                    ekle.Parameters.AddWithValue("@p3", dersplanDersAdi.Text);
                    ekle.Parameters.AddWithValue("@p4", dersplanDersSaati.Text);
                    ekle.Parameters.AddWithValue("@p5", dersplanDersOgretmeni.Text);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla gerçekleşti");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Cuma")
            {
                try
                {
                    sqlBaglanti.Open();
                    string dersEkle5 = "insert into CumaDersProgramiTBL (OgrenciTC,DersKod, DersAd, DersSaat, DersOgretmeni) values (@p1,@p2,@p3,@p4,@p5)";
                    SqlCommand ekle = new SqlCommand(dersEkle5, sqlBaglanti);
                    ekle.Parameters.AddWithValue("@p1", dersplanOgrenciTC.Text);
                    ekle.Parameters.AddWithValue("@p2", dersplanDersKodu.Text);
                    ekle.Parameters.AddWithValue("@p3", dersplanDersAdi.Text);
                    ekle.Parameters.AddWithValue("@p4", dersplanDersSaati.Text);
                    ekle.Parameters.AddWithValue("@p5", dersplanDersOgretmeni.Text);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla gerçekleşti");
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
                dersplaniListele();
                dersplanTemizle();
            }
        }

        private void dersplanDuzenle_Click(object sender, EventArgs e)
        {
            if (dersplanDersGunu.Text == "Pazartesi")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand duzenleme = new SqlCommand("UPDATE PazartesiDersProgramiTBL SET DersKod = '" + dersplanDersKodu.Text + "', DersAd= '" + dersplanDersAdi.Text + "', DersSaat = '" + dersplanDersSaati.Text + "', DersOgretmeni = '"
                        + dersplanDersOgretmeni.Text + "' WHERE OgrenciTC = '" + dersplanOgrenciTC.Text + "'", sqlBaglanti);
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Salı")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand duzenleme = new SqlCommand("UPDATE SaliDersProgramiTBL SET OgrenciTC = '" + dersplanOgrenciTC.Text
                        + "', DersKod = '" + dersplanDersKodu.Text + "', DersAd= '" + dersplanDersAdi.Text + "', DersSaat = '" + dersplanDersSaati.Text + "', DersOgretmeni = '"
                        + dersplanDersOgretmeni.Text + "' WHERE OgrenciTC = '" + dersplanOgrenciTC.Text + "'", sqlBaglanti);
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Çarşamba")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand duzenleme = new SqlCommand("UPDATE CarsambaDersProgramiTBL SET OgrenciTC = '" + dersplanOgrenciTC.Text
                        + "', DersKod = '" + dersplanDersKodu.Text + "', DersAd= '" + dersplanDersAdi.Text + "', DersSaat = '" + dersplanDersSaati.Text + "', DersOgretmeni = '"
                        + dersplanDersOgretmeni.Text + "' WHERE OgrenciTC = '" + dersplanOgrenciTC.Text + "'", sqlBaglanti);
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Perşembe")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand duzenleme = new SqlCommand("UPDATE PersembeDersProgramiTBL SET OgrenciTC = '" + dersplanOgrenciTC.Text
                        + "', DersKod = '" + dersplanDersKodu.Text + "', DersAd= '" + dersplanDersAdi.Text + "', DersSaat = '" + dersplanDersSaati.Text + "', DersOgretmeni = '"
                        + dersplanDersOgretmeni.Text + "' WHERE OgrenciTC = '" + dersplanOgrenciTC.Text + "'", sqlBaglanti);
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Cuma")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand duzenleme = new SqlCommand("UPDATE CumaDersProgramiTBL SET OgrenciTC = '" + dersplanOgrenciTC.Text
                        + "', DersKod = '" + dersplanDersKodu.Text + "', DersAd= '" + dersplanDersAdi.Text + "', DersSaat = '" + dersplanDersSaati.Text + "', DersOgretmeni = '"
                        + dersplanDersOgretmeni.Text + "' WHERE OgrenciTC = '" + dersplanOgrenciTC.Text + "'", sqlBaglanti);
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
                dersplaniListele();
                dersplanTemizle();
            }
        }

        private void dersplanSil_Click(object sender, EventArgs e)
        {
            if (dersplanDersGunu.Text == "Pazartesi")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand dersplanSil = new SqlCommand("Delete From PazartesiDersProgramiTBL where OgrenciTC = '" + dersplanOgrenciTC.Text + "' and DersKod = '" + dersplanDersKodu.Text + "'", sqlBaglanti);
                    dersplanSil.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla silindi");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Salı")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From SaliDersProgramiTBL where OgrenciTC = '" + dersplanOgrenciTC.Text + "' and DersKod = '" + dersplanDersKodu.Text + "'", sqlBaglanti);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla silindi");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Çarşamba")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From CarsambaDersProgramiTBL where OgrenciTC = '" + dersplanOgrenciTC.Text + "' and DersKod = '" + dersplanDersKodu.Text + "'", sqlBaglanti);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla silindi");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Perşembe")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From PersembeDersProgramiTBL where OgrenciTC = '" + dersplanOgrenciTC.Text + "' and DersKod = '" + dersplanDersKodu.Text + "'", sqlBaglanti);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla silindi");
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
                dersplaniListele();
                dersplanTemizle();
            }
            if (dersplanDersGunu.Text == "Cuma")
            {
                try
                {
                    sqlBaglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From CumaDersProgramiTBL where OgrenciTC = '" + dersplanOgrenciTC.Text + "' and DersKod = '" + dersplanDersKodu.Text + "'", sqlBaglanti);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Ders kaydı başarıyla silindi");
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
                dersplaniListele();
                dersplanTemizle();
            }
        }

        private void dersplanListele_Click(object sender, EventArgs e)
        {
            dersplaniListele();
        }

    }
}
