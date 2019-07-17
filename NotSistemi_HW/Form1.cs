using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSistemi_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70
            //"BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..

            




        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
            int not = int.Parse(txtNot.Text);
            txtNot.Focus();
            txtNot.Clear();

            if (not<30 && not>0)
            {
                MessageBox.Show("FF Aldınız");
            }
            if (not<50 && not>= 30)
            {
                MessageBox.Show("DD Aldınız");
            }
            if (not<70 && not>=50)
            {
                MessageBox.Show("BB Aldınız");
            }
            if (not<100 && not>=70)
            {
                MessageBox.Show("AA ALdınız");
            }
            

        }


    


    }
}

