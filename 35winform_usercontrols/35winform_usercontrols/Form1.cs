using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35winform_usercontrols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlAdi.lblControl.Text = "Adı:";
            ctrlSoyadi.lblControl.Text = "Soyadı";
            ctrlAdres.lblControl.Text = "Adres";
            ctrlTelefon.lblControl.Text = "Telefon";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem lvi = new ListViewItem();
            lvi.Text = ctrlAdi.txtControl.Text;//ilk kolon
            lvi.SubItems.Add(ctrlSoyadi.txtControl.Text);//ikinci kolon
            lvi.SubItems.Add(ctrlAdres.txtControl.Text);//üçüncü kolon
            lvi.SubItems.Add(ctrlTelefon.txtControl.Text);//dördüncü kolon

            listView1.Items.Add(lvi);

        }
    }
}
