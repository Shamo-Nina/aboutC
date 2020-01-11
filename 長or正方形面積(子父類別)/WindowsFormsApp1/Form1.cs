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
            square s = new square();
            rect r = new rect();
            s.aa = Convert.ToInt16(textBox1.Text);
            int ans;
            ans = s.run();
            MessageBox.Show("正方形 = " + ans.ToString());
            r.aa = Convert.ToInt16(textBox1.Text);
            r.bb = Convert.ToInt16(textBox2.Text);
            ans = r.run();
            MessageBox.Show("長方形 = " + ans.ToString());
        }
    }
}
