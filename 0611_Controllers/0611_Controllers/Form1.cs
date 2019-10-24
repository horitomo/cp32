using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0611_Controllers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.checkBox1.Checked.ToString();
            if (this.checkBox1.Checked)
            {
                this.label1.Text += "!";
            }else
            {
                this.label1.Text += "?";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text = String.Empty;
            if (this.radioButton1.Checked)
            {
                this.label2.Text += "1";
            }else if (this.radioButton2.Checked)
            {
                this.label2.Text += "2";
            }else if (this.radioButton3.Checked)
            {
                this.label2.Text += "3";
            }
        }

        private void close_CheckedChanged(object sender, EventArgs e)
        {
            if (this.close.Checked)
            {
                this.Height -= 100;
            }else if (!this.close.Checked)
            {
                this.Height += 100;
            }
        }
    }
}
