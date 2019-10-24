using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0917_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const String MY_FILE = "a.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            // Javaでのtry-with-resources
            // 自動でクローズしてくれる
            using (StreamWriter sw = new StreamWriter(MY_FILE))
            {
                sw.WriteLine("test");
                sw.WriteLine("日本語は？");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ファイル存在確認
            if (!File.Exists(MY_FILE))
            {
                // ファイルが存在しない
                // エラー
                return;
            }
            using (StreamReader sr = new StreamReader(MY_FILE))
            {
                this.label1.Text = sr.ReadToEnd();
            }

        }
    }
}
