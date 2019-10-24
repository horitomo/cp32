using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0521_LabelTextBoxButton
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // テキストボックスの入力内容で、ラベルを書き換える
            this.label1.Text = this.textBox1.Text;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            // label2にピリオドを追加
            this.label2.Text = this.label2.Text + ".";
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.label1.Text = String.Empty;
            // String.Empty = ""; の意味
        }

        private void button2Bai_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(
                this.textBox1.Text, out num
                )
            )
            {
                this.label1.Text = (num * 2).ToString();
            }
            else
            {
                this.label1.Text = "数字ではありませんよ？";
            }
        }
    }
}
