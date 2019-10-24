using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0618_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.random = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = random.Next(0, 11).ToString();
        }
    }
}
