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

        }
    }
}
