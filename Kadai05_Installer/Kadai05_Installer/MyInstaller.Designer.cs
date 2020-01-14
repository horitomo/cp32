namespace Kadai05_Installer
{
    partial class MyInstaller
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dirLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.errorCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Myインストーラー";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prevBtn);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 39);
            this.panel2.TabIndex = 2;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(386, 4);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "< 戻る(&B)";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(474, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "次へ(&N) >";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(593, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "キャンセル";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 208);
            this.panel3.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(625, 36);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(43, 32);
            this.panel11.TabIndex = 7;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "インストールが正常に完了しました。";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.progressBar1);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(574, 35);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(45, 46);
            this.panel10.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "インストール中";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dirLabel);
            this.panel9.Controls.Add(this.errorLabel);
            this.panel9.Controls.Add(this.userLabel);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(527, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(39, 32);
            this.panel9.TabIndex = 5;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(14, 52);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(53, 12);
            this.dirLabel.TabIndex = 3;
            this.dirLabel.Text = "[dirLabel]";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(13, 36);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(64, 12);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "[errorLabel]";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(62, 12);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "[userLabel]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "以下の内容でインストールします。よろしければインストールをクリックしてください";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.dirBox);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(465, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(56, 53);
            this.panel8.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(127, 31);
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(200, 19);
            this.dirBox.TabIndex = 2;
            this.dirBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "インストールディレクトリ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "インストール先のディレクトリを指定してください。";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.errorCheckBox);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(625, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(39, 29);
            this.panel7.TabIndex = 3;
            // 
            // errorCheckBox
            // 
            this.errorCheckBox.AutoSize = true;
            this.errorCheckBox.Checked = true;
            this.errorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorCheckBox.Location = new System.Drawing.Point(25, 27);
            this.errorCheckBox.Name = "errorCheckBox";
            this.errorCheckBox.Size = new System.Drawing.Size(258, 16);
            this.errorCheckBox.TabIndex = 1;
            this.errorCheckBox.Text = "問題が生じたとき、エラー情報を自動で送信する。";
            this.errorCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "アプリケーション品質向上に協力してください。";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userBox);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(572, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 31);
            this.panel6.TabIndex = 2;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(89, 27);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(200, 19);
            this.userBox.TabIndex = 2;
            this.userBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "利用者名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "利用者名を入力してください。";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(527, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 29);
            this.panel5.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "同意します。";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "利用許諾契約書・・・";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "次の使用許諾契約書をお読みください。続行するには、利用許諾契約書に同意する必要があります。";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(481, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 29);
            this.panel4.TabIndex = 0;
            this.panel4.Tag = "panel5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "インストールするには次へをクリックしてください。";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 299);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyInstaller";
            this.Text = "MyInsteller";
            this.Load += new System.EventHandler(this.MyInstaller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox errorCheckBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

