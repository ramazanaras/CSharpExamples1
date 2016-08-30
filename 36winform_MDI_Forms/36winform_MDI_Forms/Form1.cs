using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36winform_MDI_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //NOT:mdi form ana formun içinde kalır dışarı çıkamaz
        //ismdicontainer true yapmalıyız.(yani içerisinde form barındırabilir.)
        //mdi formlar showdialog olarak gösterilemez
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //eğer herhangi bir formu mdi form olarak açmak istiyorsak Show metodu ile açmalıyız
            PersonelForm pf = new PersonelForm();//turquaz renkli(referans tipli olduğu için new ile tanımlıyoruz)
            pf.MdiParent = this;//bu formdur.
            pf.Show();


        }


        MusteriForm mf = new MusteriForm();//ramde birkere oluşturmuş oluyoruz eğer aşağıda metodun içerisinde tanımlasaydık her müşteriler sekmesine bastığımızda ramde yeni bir yer açıcaktı ve yeni bir müşteri form oluşturucaktı biz bunu engellemek için bu şekilde yaparak sadece bir kere ramde yer ayırmış oluruz.
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
         
          
            if (mf.IsDisposed == true)//dispos etmek ramden kaldırmak demek.(mf.IsDisposed==false ile !mf.IsDisposed aynı şeydir.)
            {
                mf = new MusteriForm();//ramde yeni bir yer açıyoruz.
           
            }
            mf.MdiParent = this;
            mf.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
