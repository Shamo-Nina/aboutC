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

        private void button1_Click(object sender, EventArgs e)
        {
            string c;
            c = textBox1.Text;

            int a, b;
            a = Convert.ToInt16(c);
            b = 1911;
            b = b + a;
            MessageBox.Show(b.ToString());

        }
    }
}
