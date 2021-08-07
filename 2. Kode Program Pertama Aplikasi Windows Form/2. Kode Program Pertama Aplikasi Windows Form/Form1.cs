using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._Kode_Program_Pertama_Aplikasi_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Deklarasi dua variable interger
            int a;
            int b;
            int result;

            a = 10;
            b = 5;

            result = (a + b);

            //Menampilkan hasil dengan MessageBox
            MessageBox.Show("Hasil : " + result.ToString());
        }
    }
}
