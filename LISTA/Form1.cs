using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkWed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            if (chkMon.Checked)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            if (chkTue.Checked)
            {
                listBox2.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            if (chkWed.Checked)
            {
                listBox3.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            if (chkThu.Checked)
            {
                listBox4.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            if (chkFri.Checked)
            {
                listBox5.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            if (chkSat.Checked)
            {
                listBox6.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = true;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = true;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = true;
            listBox5.Visible = false;
            listBox6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = true;
            listBox6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Focus();

            listBox2.Items.Clear();
            textBox1.Focus();

            listBox3.Items.Clear();
            textBox1.Focus();

            listBox4.Items.Clear();
            textBox1.Focus();

            listBox5.Items.Clear();
            textBox1.Focus();

            listBox6.Items.Clear();
            textBox1.Focus();
        }
    }
}
