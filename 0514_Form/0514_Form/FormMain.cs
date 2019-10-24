using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0514_Form
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 初期化用のメソッド（読み込まれたタイミングで走る）
            this.Text = "製品名";

            // プロパティウィンドウで操作できる内容は、
            // コード（プログラム）ですべてできる。
            // minimizeをfalseにしてみよう
            this.MinimizeBox = true;

            // this 自インスタンス(オブジェクト)を指し示す
            // thisを利用するか、しないかは自由
            // this推奨
            // this.と定義されていると
            // ・自分の持ち物（プロパティorメソッド）と容易に判断できる
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
