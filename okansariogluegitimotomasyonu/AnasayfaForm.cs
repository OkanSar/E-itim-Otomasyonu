namespace okansariogluegitimotomasyonu
{
    public partial class AnasayfaForm : Form
    {
        private bool kayitdown;
        private bool digerdown;
        private bool dersdown;


        public AnasayfaForm()
        {
            InitializeComponent();
        }
        private void btnOgrenciKayit_Click_1(object sender, EventArgs e)
        {
            OgrenciKayitForm frm = new OgrenciKayitForm();
            frm.Show();
        }
        private void btnOgretmenKayit_Click(object sender, EventArgs e)
        {
            OgretmenKayitForm frm = new OgretmenKayitForm();
            frm.Show();

        }
        private void DersProgrami_Click(object sender, EventArgs e)
        {
            DersProgrami frm = new DersProgrami();
            frm.Show();
        }
        private void btnSinavYonetim_Click(object sender, EventArgs e)
        {
            SinavYonetim frm = new SinavYonetim();
            frm.Show();
        }
        private void DevamsizlikTakip_Click(object sender, EventArgs e)
        {
            DevamsizlikTakip frm = new DevamsizlikTakip();
            frm.Show();
        }
        private void btnKutuphaneYonetim_Click(object sender, EventArgs e)
        {
            KutuphaneYonetim frm = new KutuphaneYonetim();
            frm.Show();
        }
        private void sinifSecim_Click(object sender, EventArgs e)
        {
            SinifSecimTakip frm = new SinifSecimTakip();
            frm.Show();
        }




        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            anasayfaAnlikSaatTarih.Start();
        }
        private void kayitislemZamanlayici_Tick_1(object sender, EventArgs e)
        {
            if (kayitdown)
            {
                kayitislemleripanel.Height -= 10;
                if (kayitislemleripanel.Size == kayitislemleripanel.MinimumSize)
                {
                    kayitislemZamanlayici.Stop();
                    kayitdown = false;
                }
            }
            else
            {
                kayitislemleripanel.Height += 10;
                if (kayitislemleripanel.Size == kayitislemleripanel.MaximumSize)
                {
                    kayitislemZamanlayici.Stop();
                    kayitdown = true;
                }
            }
        }
        private void dersislemZamanlayici_Tick(object sender, EventArgs e)
        {
            if (dersdown)
            {
                dersislemleripanel.Height -= 10;
                if (dersislemleripanel.Size == dersislemleripanel.MinimumSize)
                {
                    dersislemZamanlayici.Stop();
                    dersdown = false;
                }
            }
            else
            {
                dersislemleripanel.Height += 10;
                if (dersislemleripanel.Size == dersislemleripanel.MaximumSize)
                {
                    dersislemZamanlayici.Stop();
                    dersdown = true;
                }

            }
        }
        private void digerislemZamanlayici_Tick(object sender, EventArgs e)
        {
            if (digerdown)
            {
                digerislemlerpanel.Height -= 10;
                if (digerislemlerpanel.Size == digerislemlerpanel.MinimumSize)
                {
                    digerislemZamanlayici.Stop();
                    digerdown = false;
                }
            }
            else
            {
                digerislemlerpanel.Height += 10;
                if (digerislemlerpanel.Size == digerislemlerpanel.MaximumSize)
                {
                    digerislemZamanlayici.Stop();
                    digerdown = true;
                }
            }
        }
        private void digerislemButon_Click(object sender, EventArgs e)
        {
            digerislemZamanlayici.Start();
        }
        private void dersislemButon_Click(object sender, EventArgs e)
        {
            dersislemZamanlayici.Start();
        }
        private void kayitislemButon_Click(object sender, EventArgs e)
        {
            kayitislemZamanlayici.Start();
        }
        private void anasayfaAnlikSaatTarih_Tick(object sender, EventArgs e)
        {
            anliksaat.Text = DateTime.Now.ToLongTimeString();
            anliktarih.Text = DateTime.Now.ToLongDateString();
        }

    }
}
