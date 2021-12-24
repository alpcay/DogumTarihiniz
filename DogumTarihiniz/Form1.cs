using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogumTarihiniz
{
    public partial class Form1 : Form
    {
        DateTime dogumTarihi;
        public Form1()
        {
            InitializeComponent();
            Hesapla();
        }

        private void Hesapla()
        {
            dogumTarihi = dtpDogumTarihi.Value;
            lblYas.Text = "Yaşınız: " + YasHesapla(dogumTarihi.Year);
            lblGun.Text = "Yaşadığınız Gün: " + GunHesapla(dogumTarihi);
            lblBurc.Text = "Burcunuz: " + BurcHesapla(dogumTarihi.Month,dogumTarihi.Day);
        }

        private string BurcHesapla(int month, int day)
        {
            string burc = "";
            if ((month==1 && day>=21)||(month==2&&day<=19))
            {
                burc = "Kova";
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
            {
                burc = "Balık";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                burc = "Koç";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                burc = "Boğa";
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                burc = "İkizler";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 23))
            {
                burc = "Yengeç";
            }
            else if ((month == 7 && day >= 24) || (month == 8 && day <= 23))
            {
                burc = "Aslan";
            }
            else if ((month == 8 && day >= 24) || (month == 9 && day <= 22))
            {
                burc = "Başak";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
            {
                burc = "Terazi";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                burc = "Akrep";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
            {
                burc = "Yay";
            }
            else
            {
                burc = "Oğlak";
            }
            return burc;
        }

        private string GunHesapla(DateTime dogumTarihi)
        {
            TimeSpan gecenSure = DateTime.Now - dogumTarihi;
            int toplamGun = (int)gecenSure.TotalDays;
            return toplamGun.ToString();
        }

        private string YasHesapla(int year)
        {
            return (DateTime.Now.Year - year).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //DateTime dt = dtpDogumTarihi.Value;
            ////MessageBox.Show(dt.Year.ToString());
            //TimeSpan gecenSure = DateTime.Now - dt;
            //MessageBox.Show(((int)gecenSure.TotalDays).ToString());
            //int yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            //MessageBox.Show(yas.ToString());
            Hesapla();

        }
    }
}
