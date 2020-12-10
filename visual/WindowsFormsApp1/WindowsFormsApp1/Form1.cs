using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string massage = $"{textBox1.Text}, {textBox2.Text}";
            //string massage = "hello world";

            //1
            string one = "string" + 123 + "   " + 456;
            //2
            //string two = string.Format()

            string massage = $"{textBox2.Text},{textBox1.Text}";
            MessageBox.Show(massage);
        }
    }
}
