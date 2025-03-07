using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
        class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Son
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car ...");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            grandSon.maruthicar();
            grandSon.MBCar();
            grandSon.BMWCar();

        }
    }
}
