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
using System.Threading;

namespace Kadai05_Installer
{
    public partial class MyInstaller : Form
    {
        public MyInstaller()
        {
            InitializeComponent();
        }

        int page = 0;
        Control[] p = new System.Windows.Forms.Control[8];
        int progressCnt = 0;

        private void MyInstaller_Load(object sender, EventArgs e)
        {
            this.prevBtn.Enabled = false;
            int i = 7;
            foreach(Control c2 in this.panel3.Controls)
            {
                c2.Dock = DockStyle.Fill;
                c2.Visible = false;
                p[i] = (Control)c2;
                i--;
            }
            this.panel4.BringToFront();
            this.panel4.Visible = true; 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("インストールをキャンセルしてもよろしいですか？", "MyInstaller", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            p[page].Visible = false;
            if (page > 0)
            {
                page--;
            }
            p[page].Visible = true;
            p[page].BringToFront();

            if(page == 0)
            {
                this.prevBtn.Enabled = false;
            }
            this.nextBtn.Text = "次へ(&N) >";
            this.nextBtn.Enabled = true;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (this.nextBtn.Text == "完了")
            {
                this.Close();
            }
            else if (page == 4)
            {
                string dirname = this.dirBox.Text;
                bool flagOK = false;
                if (!System.IO.Directory.Exists(dirname))
                {
                    DialogResult result = MessageBox.Show("指定されたディレクトリが存在しません。自動で作成してもよろしいですか？", "MyInstaller", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                    {
                        if (IsValidFileName(dirname))
                        {
                            if (Path.GetFullPath(dirname).Equals(dirname))
                            {
                                Directory.CreateDirectory(dirname);
                                flagOK = true;
                            }
                            else
                            {
                                DialogResult ok = MessageBox.Show("ディレクトリの作成に失敗しました。絶対パスを入力してください！", "MyInstaller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DialogResult ok =MessageBox.Show("ディレクトリの作成に失敗しました。ディレクトリパスを見直してください。", "MyInstaller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else
                    {
                        this.dirBox.Focus();
                    }
                }else
                {
                    flagOK = true;
                }
                if (flagOK)
                {
                    p[page].Visible = false;
                    page++;
                    p[page].Visible = true;
                    p[page].BringToFront();
                    String error;
                    if (errorCheckBox.Checked == true)
                    {
                        error = "する";
                    }
                    else
                    {
                        error = "しない";
                    }
                    this.userLabel.Text = "利用者名：" + this.userBox.Text;
                    this.errorLabel.Text = "エラー情報の自動送信：" + error;
                    this.dirLabel.Text = "インストールディレクトリ：" + this.dirBox.Text;
                    nextBtn.Text = "インストール";
                }
            }else
            {
                p[page].Visible = false;
                if (page < 8)
                {
                    page++;
                }
                p[page].Visible = true;
                p[page].BringToFront();
                prevBtn.Enabled = true;


                if (page == 1)
                {
                    if (checkBox1.Checked == false)
                    {
                        checkBox1.Focus();
                        nextBtn.Enabled = false;
                    }
                }
                else if (page == 2)
                {
                    if (userBox.Text.Length == 0)
                    {
                        userBox.Focus();
                        nextBtn.Enabled = false;
                    }
                }
                else if (page == 4)
                {
                    if (dirBox.Text.Length == 0)
                    {
                        dirBox.Focus();
                        nextBtn.Enabled = false;
                    }
                }
                else if (page == 6)
                {
                    nextBtn.Enabled = false;
                }

                if (page == 6)
                {
                    nextBtn.Enabled = false;
                    prevBtn.Enabled = false;
                    this.timer1.Start();
                }
                else
                {
                    nextBtn.Text = "次へ(&N) >";
                }
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                nextBtn.Enabled = true;
            }else
            {
                nextBtn.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String user = userBox.Text;
            if(user.Length != 0)
            {
                nextBtn.Enabled = true;
            }else
            {
                nextBtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "インストール先のディレクトリを指定してください";
            DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                this.dirBox.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(dirBox.Text.Length != 0)
            {
                nextBtn.Enabled = true;
            }else
            {
                nextBtn.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressCnt == 10)
            {
                this.timer1.Interval = 1;
            }else if(this.progressCnt == 11) { 
                this.timer1.Stop();
                Thread.Sleep(100);
                // ファイルを作成する
                string filename = this.dirBox.Text + "\\install.txt";
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Close();
                }
                p[page].Visible = false;
                this.page++;
                p[page].Visible = true;
                p[this.page].BringToFront();
                this.nextBtn.Text = "完了";
                this.nextBtn.Enabled = true;
                this.cancelBtn.Enabled = false;
            }
            this.progressBar1.Increment(10);
            this.progressCnt++;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 指定されたファイル名に不正がないかチェックする
        /// </summary>
        /// <param name="fileName">チェックするファイル名。</param>
        /// <returns>不正がないと判断された場合は、True。それ以外は、False。</returns>
        public static bool IsValidFileName(string fileName)
        {
            try
            {
                //GetFullPathメソッドに渡して、例外がスローされるか確かめる
                System.IO.Path.GetFullPath(fileName);
            }
            catch (ArgumentException)
            {
                //ファイル名に不正な文字が含まれている場合など
                return false;
            }
            catch (System.Security.SecurityException)
            {
                //アクセスできない場合
                return false;
            }
            catch (NotSupportedException)
            {
                //ボリューム識別子以外に「:」がある場合
                return false;
            }
            catch (System.IO.PathTooLongException)
            {
                //パス名が長すぎる場合
                return false;
            }

            return true;
        }
    }
}
