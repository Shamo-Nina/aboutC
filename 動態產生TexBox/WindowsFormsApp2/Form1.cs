using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Button a = new Button();
        TextBox t = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point(117, 114);
            a.Location = p;
            Size s = new Size(100, 52);
            a.Size = s;
            a.Text = "button2";
            Point p1 = new Point(117, 184);
            t.Location = p1;
            Size s1 = new Size(100, 22);
            t.Size = s1;

            //a.Visible = true;
            a.Enabled = true;
            t.Enabled = false;
            this.Controls.Add(a);
            this.Controls.Add(t);

            a.Click += A_Click;

        }

        private void A_Click(object sender, EventArgs e)
        {
            t.Enabled = true;
            t.Text = "input";
            //throw new NotImplementedException();
        }
    }
}
