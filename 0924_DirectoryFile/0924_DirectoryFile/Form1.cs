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

namespace _0924_DirectoryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Directory情報
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\");
            foreach(FileInfo fileinfo in directoryInfo.GetFiles())
            {
                this.label1.Text += fileinfo.Name + Environment.NewLine;
            }


            // ファイルの存在確認だけで、
            // FileInfoオブジェクトを生成するのは
            // 無駄が多い

            // インスタンス生成が不要なのがstatic
            // イメージ、FileInfoのstatic番がFile
            if (!File.Exists(@"C:\a.txt"))
            {
                this.label1.Text += "ないなら作る";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }

        /// <summary>
        /// ボタン２がクリックされたときの処理
        /// ファイルの作成とxxxをします
        /// </summary>
        /// <param name="sender">ｘｘ</param>
        /// <param name="e">イベントパラメータ</param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter sw = new StreamWriter(@"C:\hal\CP32\a.txt"))
            {
                sw.WriteLine("aaa");
                sw.WriteLine("bbb");
                sw.WriteLine("ccc");
            }

            using (StreamReader sr = new StreamReader(@"c:\hal\CP32\a.txt"))
            {
                while (!sr.EndOfStream)
                {
                    this.label1.Text += sr.ReadLine();
                }
            }
            File.Delete(@"c:\hal\CP32\a.txt");
        }
    }
}
