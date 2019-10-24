namespace _0521_LabelTextBoxButton
{
    partial class main
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
            this.labelForm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonP = new System.Windows.Forms.Button();
            this.button2Bai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(13, 13);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(39, 12);
            this.labelForm.TabIndex = 0;
            this.labelForm.Text = "データ：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 19);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(181, 8);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "実行";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "[label1]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(62, 110);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(75, 23);
            this.buttonP.TabIndex = 5;
            this.buttonP.Text = "ピリオド追加";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // button2Bai
            // 
            this.button2Bai.Location = new System.Drawing.Point(181, 38);
            this.button2Bai.Name = "button2Bai";
            this.button2Bai.Size = new System.Drawing.Size(75, 23);
            this.button2Bai.TabIndex = 6;
            this.button2Bai.Text = "2倍";
            this.button2Bai.UseVisualStyleBackColor = true;
            this.button2Bai.Click += new System.EventHandler(this.button2Bai_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2Bai);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelForm);
            this.Name = "main";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button button2Bai;
    }
}

