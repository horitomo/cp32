using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadai02_0528
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int prev;
            int next;
            if (int.TryParse(this.prevTx.Text, out prev) && int.TryParse(this.nextTx.Text, out next))
            {

                int result = prev - next;
                this.resultLb.Text = result.ToString();
                this.formulaLb.Text = prev.ToString() + "-" + next.ToString();
            }
            else
            {
                this.resultLb.Text = "数値を入力してください！";
                this.formulaLb.Text = String.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.resultLb.Text = String.Empty;
            this.formulaLb.Text = String.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int prev;
            int next;
            if(int.TryParse(this.prevTx.Text,out prev) && int.TryParse(this.nextTx.Text, out next))
            {
                int result = prev + next;
                this.resultLb.Text = result.ToString();
                this.formulaLb.Text = prev.ToString() + "+" + next.ToString();
            }else
            {
                this.resultLb.Text = "数値を入力してください！";
                this.formulaLb.Text = String.Empty;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int prev;
            int next;
            if (int.TryParse(this.prevTx.Text, out prev) && int.TryParse(this.nextTx.Text, out next))
            {
                int result = prev * next;
                this.resultLb.Text = result.ToString();
                this.formulaLb.Text = prev.ToString() + "*" + next.ToString();
            }
            else
            {
                this.resultLb.Text = "数値を入力してください！";
                this.formulaLb.Text = String.Empty;
            }
        }

        private void divided_Click(object sender, EventArgs e)
        {
            int prev;
            int next;
            if (int.TryParse(this.prevTx.Text, out prev) && int.TryParse(this.nextTx.Text, out next))
            {
                if (next != 0)
                {
                    int result = prev / next;
                    this.resultLb.Text = result.ToString();
                    this.formulaLb.Text = prev.ToString() + "/" + next.ToString();
                }else
                {
                    this.resultLb.Text = "0で割ることはできません。";
                    this.formulaLb.Text = String.Empty;
                }
            }
            else
            {
                this.resultLb.Text = "数値を入力してください！";
                this.formulaLb.Text = String.Empty;
            }
        }
    }
}
