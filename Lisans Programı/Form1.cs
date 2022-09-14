using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisans_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lisanstextbox_TextChanged(object sender, EventArgs e)
        {
            if (lisanstextbox.Text.Length >= 30)
            {
                MessageBox.Show("Lisans anahtarı en fazla 20 harf'den oluşmaktadır.", "Lisans Programı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Properties.Settings.Default.lisansdurumu == false)
            {
                DialogResult secenek = MessageBox.Show("Geçerli bir lisans anahtarı giriniz ya da deneme sürümünü başlatınız.", "Lisans Programı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    lisanstextbox.Focus();
                }
                else 
                {
                    MessageBox.Show("Kullandığınız program lisansız kullanılmamaktadır.", "Lisans Programı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        private void denemesurumubtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lisansdurumu == false)
            {
                DateTime bugunTarihi = DateTime.Now;
                Properties.Settings.Default.denemesurumubaslangıcı = bugunTarihi;
                Properties.Settings.Default.denemesurumusonu = DateTime.Now.AddDays(30);
                Properties.Settings.Default.lisansdurumu = true;
                Properties.Settings.Default.Save();
                TimeSpan ts = Properties.Settings.Default.denemesurumusonu - Properties.Settings.Default.denemesurumubaslangıcı;
                MessageBox.Show("Deneme sürümü lisansınız başlatılmıştır. Size verilen deneme sürümü günü 30 gündür bitiş tarihi: " + Properties.Settings.Default.denemesurumusonu);
                kalangünlabel.Text = ts.Days.ToString();
            }
            else
            {
                MessageBox.Show("Deneme sürümünüz zaten başlamız durumdadır.", "Lisans Programı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimeSpan ts = Properties.Settings.Default.denemesurumusonu - Properties.Settings.Default.denemesurumubaslangıcı;
                kalangünlabel.Text = ts.Days.ToString();
            }
        }

        private void lisansbtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = Properties.Settings.Default.denemesurumusonu - Properties.Settings.Default.denemesurumubaslangıcı;
            kalangünlabel.Text = ts.Days.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugüntarihi = DateTime.Now.AddDays(30).ToString("dd" + "," + " MMMM yyyy");
            WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("https://bookeder.com/time/istanbul-18319");
            WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
            StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
            string KaynakKodlar = CevapOku.ReadToEnd();
            int IcerikBaslangicIndex = KaynakKodlar.IndexOf("<p>") + 12;
            int IcerikBitisIndex = KaynakKodlar.Substring(IcerikBaslangicIndex).IndexOf("<nobr>");
            string sonuc = KaynakKodlar.Substring(IcerikBaslangicIndex, IcerikBitisIndex);
            TimeSpan ts = bugüntarihi - sonuc;
            MessageBox.Show( ts.Days.ToString());

        }
    }
}
