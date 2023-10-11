using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYP_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Text = "Ödev";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Nesne Yönelimli Programlama";
            notifyIcon1.BalloonTipText = "Ödev 1";
            notifyIcon1.ShowBalloonTip(100);

            int Sayi1, Sayi2;
            Sayi1 = Convert.ToInt32(mtbBaslangic.Text);
            Sayi2 = Convert.ToInt32(mtbBitis.Text);
            try
            {
                if (Sayi1 < 1 || Sayi2 < 1)
                {
                    MessageBox.Show(":( Lütfen Başlangıç değerini ve\n Bitiş değerini 1'den büyük giriniz");
                }
                else if (Sayi1 > Sayi2)
                {
                    MessageBox.Show(":( Lütfen Başlangıç değerini Bitiş değerinden küçük giriniz");
                }
            }
            catch
            {
                MessageBox.Show(":( Lüfen Başlangıç ve Bitiş değerlerini Boş bırakmayınız ");
            }

            int TekToplam = 0, TekCarpim = 1;
            int CiftToplam = 0, CiftCarpim = 1;

            for (int i = Sayi1; i <= Sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    CiftToplam += i;
                    CiftCarpim *= i;
                    listViewCift.Items.Add(i.ToString());
                }
                else
                {
                    TekToplam += i;
                    TekCarpim *= i;
                    listViewTek.Items.Add(i.ToString());
                }
            }
            listViewTekToplam.Items.Add(TekToplam.ToString());
            listViewTekCarpim.Items.Add(TekCarpim.ToString());
            listViewCiftToplam.Items.Add(CiftToplam.ToString());
            listViewCiftCarpim.Items.Add(CiftCarpim.ToString());
            AsalSayi(Sayi1, Sayi2);
            MukemmelSayiKontrol(Sayi1, Sayi2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewAsal.Clear();
            listViewAsalCarpim.Clear();
            listViewAsalToplam.Clear();
            listViewCift.Clear();
            listViewCiftCarpim.Clear();
            listViewCiftToplam.Clear();
            listViewTek.Clear();
            listViewTekToplam.Clear();
            listViewTekCarpim.Clear();
            listViewMukemmel.Clear();
            listViewMukemmelToplam.Clear();
            listViewMukemmelCarpim.Clear();
            mtbBaslangic.Clear();
            mtbBitis.Clear();
        }
        public void AsalSayi(int Sayi1, int Sayi2)
        {
            int  AsalToplam = 0, AsalCarpim = 1;
            for (int i = Sayi1; i <= Sayi2; i++)
            {
                int kontrol = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol != 1)
                {
                    AsalToplam += i;
                    AsalCarpim *= i;
                    listViewAsal.Items.Add(i.ToString());
                }
            }
            listViewAsalToplam.Items.Add(AsalToplam.ToString());
            listViewAsalCarpim.Items.Add(AsalCarpim.ToString());
        }
        private void MukemmelSayiKontrol(int Sayi1, int Sayi2)
        {
            int TumToplam = 0, Carpim = 1;
            for (int i = Sayi1; i <= Sayi2; i++)
            {
                int toplam = 0;
                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        toplam += j;
                    }
                }
                if (i == toplam)
                {
                    TumToplam += i;
                    Carpim *= i;
                    listViewMukemmel.Items.Add(i.ToString());
                }
            }
            listViewMukemmelToplam.Items.Add(TumToplam.ToString());
            listViewMukemmelCarpim.Items.Add(Carpim.ToString());
        }
    }
}
