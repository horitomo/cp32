using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0625_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label a = this.label1;
            a.Text = "aaa";

            // オブジェクト指向では
            // 上位クラスにて、下位クラスを
            // 格納することができる

            Object o = this.label1;

            // 逆はできない
            // Label l = o;

            // Label TextboxなどはControlクラス
            // が上位クラスとして存在する
            Control c = this.label1;
            c.Text = "bbb";

            // Controlにて、Textプロパティ
            // が定義されている
            // 上位クラスの性質は
            // 下位クラスに引き継がれる
            // よって、Labelに.Textが存在する

            // cの実態は、Label
            // でも今のタイミングでは
            // Control
            // キャストを用いれば、Labelとして
            // 操作をすることができる

            Label l = (Label)c;
            l.Text = "ccc";

            foreach (Control c2 in this.panel1.Controls)
            {
                Label l2 = (Label)c2;
                l2.Text = "d";
            }
        }
    }
}
