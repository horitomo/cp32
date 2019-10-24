using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0924_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            this.progressBar1.Increment(20);
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.progressBar1.Value = this.progressBar1.Minimum;
            }
            this.progressBar1.PerformStep();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.progressBar2.Value == this.progressBar2.Maximum)
            {
                this.timer1.Stop();
            }
            this.progressBar2.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
