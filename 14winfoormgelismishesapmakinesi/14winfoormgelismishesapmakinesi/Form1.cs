using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14winfoormgelismishesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslem.SelectedIndex = 0;//form açıldığında ilk eleman seçili olsun.
        }

        private void btnSonuç_Click(object sender, EventArgs e)
        {
            //decimal:ondalıklı sayı(virgüllü sayı)
            decimal s1 = nudSayi1.Value;//numericup down geeriye decimal döndürür.
            decimal s2 = nudSayi2.Value;
            decimal toplam = 0;

            switch (cmbIslem.Text)
            {
                case "+": toplam = s1 + s2; break;

                case "-": toplam = s1 - s2; break;

                case "*": toplam = s1 * s2; break;

                case "/": toplam = s1 / s2; break;
                case "%": toplam = s1 % s2; break;


                default://hiçbirşey gelmezse
                    break;
            }
            //lblSonuc.Text = toplam.ToString();
            lblSonuc.Text = Convert.ToString(toplam);
            switch (switch_on)
            {

                default:
            }
        }
    }
}
