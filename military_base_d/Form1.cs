using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_base_d
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        private Form5 form5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Visible = true;
        }
    }
}
