using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace жкх
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.a=Convert.ToInt32(textBox1.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.f =Data.a * 40+Data.b*10+ Data.c * 10+Data.d*35+Data.e*20;
            textBox6.Text =Convert.ToString( Data.f);
            if (Data.g == true)
            {

                Form4 form4 = new Form4();
                form4.Show();
                Data.g = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.b = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Data.c = Convert.ToInt32( textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Data.d = Convert.ToInt32( textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Data.e = Convert.ToInt32( textBox5.Text);
        }
    }
}
