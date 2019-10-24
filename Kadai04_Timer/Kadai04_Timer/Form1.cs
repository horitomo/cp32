using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai04_Timer
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private Decimal cnt;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version1.0 Ⓒ 2017 horita", "バージョン情報", MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            this.label2.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = !this.button1.Enabled;
            this.button2.Enabled = !this.button2.Enabled;
            this.button3.Enabled = !this.button3.Enabled;
            this.timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = !this.button1.Enabled;
            this.button2.Enabled = !this.button2.Enabled;
            this.button3.Enabled = !this.button3.Enabled;
            this.timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            this.label2.Text = count.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cnt--;
            if (cnt >= 0)
            {
                this.label5.Text = cnt.ToString();
            }
            if(cnt <= 0)
            {
                this.timer2.Stop();
                DialogResult Result = MessageBox.Show("終了", "タイマー", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (Result.Equals(DialogResult.OK))
                {
                    this.button4.Enabled = true;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnt = this.numericUpDown1.Value;
            this.button4.Enabled = false;
            this.label5.Text = cnt.ToString();
            this.timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = "0";
            this.label5.Text = "0";
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }
    }
}
