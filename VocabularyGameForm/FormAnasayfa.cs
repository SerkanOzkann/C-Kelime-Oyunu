using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using  System.Data.SqlClient;

namespace VocabularyGameForm
{
    public partial class formAnasayfa : Form
    {
        Db db = new Db();
        int sure = 240;
        int tahminSure = 20;
        Oyun oyun;
        Etap mevcutEtap;

        public formAnasayfa()
        {
            InitializeComponent();
        }

        private void formAnasayfa_Load(object sender, EventArgs e)
        {
            oyun = new Oyun();
            lbl_aktif.Text = Girisform.sendData;
            lbl_soru.Text = "OYUNU BAŞLATINIZ";
            oyun.OyuncuAdi = lbl_aktif.Text;
            oyun.Tarih = DateTime.Now;
            lbl_date.Text = DateTime.Now.ToLongDateString();
            oyun.Etaplar = db.etapListesiAl();
            /* Buton üstüne açıklama yazısı*/
            ToolTip aciklamaTip = new ToolTip();
            aciklamaTip.SetToolTip(btn_basla, "BAŞLA");
            aciklamaTip.SetToolTip(btn_cevapla, "CEVAPLA");
            aciklamaTip.SetToolTip(btn_cikis, "ÇIKIŞ");
            aciklamaTip.SetToolTip(btn_harfal, "HARF AL");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            int dakika = sure / 60;
            lbl_dakika.Text = dakika.ToString();
            lbl_saniye.Text = (sure - (dakika * 60)).ToString();
            lbl_date.Text = DateTime.Now.ToString();
            if (sure==0||oyun.oyunBittiMi())
            {
                sure = 0;
                OyunBitti();
            }
        }
        private void OyunBitti()
        {
            oyun.KalanSure = sure;
            timer1.Stop();
            timer2.Stop();
            btn_cevapla.Enabled = false;
            btn_harfal.Enabled = false;
            btn_basla.Enabled = false;
            MessageBox.Show("Oyun Bitti!");
            MessageBox.Show("Oyuncu: " + oyun.OyuncuAdi + " | Puan: " + oyun.Puan.ToString());
            MessageBox.Show("Kalan Süre: " + oyun.KalanSure + "saniye | Oynama Tarihi: " + oyun.Tarih.ToString());
            Application.Exit();
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            btn_basla.Enabled = false;
            btn_harfal.Enabled = true;
            btn_cevapla.Enabled = true;
            timer1.Start();
            sonrakiEtap();

        }
        private void sonrakiEtap()
        {
            if (!oyun.oyunBittiMi())
            {
                mevcutEtap = oyun.sonrakiSoru();
                if (mevcutEtap==null)
                {
                    OyunBitti();
                }
                else
                {
                    ekranGuncelle();
                    btn_harfal.Enabled = true;
                    btn_cevapla.Enabled = true;
                }
            }
        }
        private void ekranGuncelle()
        {
            lbl_soru.Text = mevcutEtap.Soru;
            lbl_puan.Text = oyun.Puan.ToString();
            string tmp = "";
            for (int i = 0; i < mevcutEtap.HarfSayisi; i++)
            {
                if (mevcutEtap.Acilan[i])
                {
                    tmp += mevcutEtap.Cevap[i];
                }
                else
                {
                    tmp += "_";
                }
            }
            tbKelime.Text = tmp;
        }
        private void btn_cevapla_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btn_cevapla.Enabled = false;
            btn_harfal.Enabled = false;
            timer1.Stop();
            timer2.Start();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_harfal_Click(object sender, EventArgs e)
        {
            mevcutEtap.harfAl();
            if (mevcutEtap.acildiMi())
            {
                oyun.Puan -= mevcutEtap.alinanHarf() * 100;
                sonrakiEtap();
            }
            if (!oyun.oyunBittiMi())
            {
                ekranGuncelle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_cevap.Text.ToUpper()==mevcutEtap.Cevap)
            {
                oyun.Puan += mevcutEtap.skorDegeri() - ((mevcutEtap.HarfSayisi - mevcutEtap.acilmayanHarfSayisi()) * 100);
                sonrakiEtap();
                timer1.Start();
                timer2.Stop();
                tahminSure = 20;
                button1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tahminSure--;
            lbl_tahmintime.Text = tahminSure.ToString();
            if (tahminSure==0)
            {
                oyun.Puan -= mevcutEtap.acilmayanHarfSayisi() * 100;
                tahminSure = 20;
                sonrakiEtap();
                button1.Enabled = false;
                timer1.Start();
                timer2.Stop();
                
            }

           
        }

        private void formAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_aktif_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ikinokta_Click(object sender, EventArgs e)
        {

        }
    }
}
