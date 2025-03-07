using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }



        }
    }
}

