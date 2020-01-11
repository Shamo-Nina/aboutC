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
        Button a = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Point p = new Point(126, 188);
            a.Location = p;
            Size s = new Size(82, 46);
            a.Size = s;
            a.Text = "button3";

            //a.Visible = true;
            a.Enabled = false;
            this.Controls.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Enabled = true;
        }
    }
}
