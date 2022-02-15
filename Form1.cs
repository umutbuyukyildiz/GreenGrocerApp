using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManavApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            listBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            listBox1.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            listBox1.Visible = false;
        }

        private void gosterbtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void kaydetstok_Click(object sender, EventArgs e)
        {
            if (stokmeyveradio.Checked)
            {
                stokcombobox.Items.Add(stokmeyvetxt.Text);

            }
            else if (stoksebzeradio.Checked)
            {
                stokcombobox.Items.Add(stoksebzetxt.Text);
            }
        }
    }
}
