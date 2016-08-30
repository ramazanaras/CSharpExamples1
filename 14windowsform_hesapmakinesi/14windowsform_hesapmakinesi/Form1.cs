using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14windowsform_hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //this:bu form demek
            this.Text = "Hesap Makinesi";

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int toplam = sayi1 + sayi2;
          //  MessageBox.Show(string.Format("Sayıların toplamı: {0}",toplam));
            //MessageBox.Show("SAyıların toplamı" + toplam);
            MessageBox.Show(toplam.ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Dünyaya hoşgeldin");
        }




    }
}
