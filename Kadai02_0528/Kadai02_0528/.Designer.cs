namespace Kadai02_0528
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.prevTx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nextTx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divided = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.resultLb = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.formulaLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "値１：";
            // 
            // prevTx
            // 
            this.prevTx.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.prevTx.Location = new System.Drawing.Point(97, 23);
            this.prevTx.Name = "prevTx";
            this.prevTx.Size = new System.Drawing.Size(138, 27);
            this.prevTx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "値２：";
            // 
            // nextTx
            // 
            this.nextTx.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextTx.Location = new System.Drawing.Point(97, 69);
            this.nextTx.Name = "nextTx";
            this.nextTx.Size = new System.Drawing.Size(138, 27);
            this.nextTx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "演算：";
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus.Location = new System.Drawing.Point(97, 128);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(30, 23);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minus.Location = new System.Drawing.Point(133, 128);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(30, 23);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.multiply.Location = new System.Drawing.Point(169, 128);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(30, 23);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divided
            // 
            this.divided.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.divided.Location = new System.Drawing.Point(205, 128);
            this.divided.Name = "divided";
            this.divided.Size = new System.Drawing.Size(30, 23);
            this.divided.TabIndex = 8;
            this.divided.Text = "/";
            this.divided.UseVisualStyleBackColor = true;
            this.divided.Click += new System.EventHandler(this.divided_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result.Location = new System.Drawing.Point(32, 176);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 20);
            this.result.TabIndex = 9;
            this.result.Text = "結果：";
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultLb.Location = new System.Drawing.Point(97, 176);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(76, 20);
            this.resultLb.TabIndex = 10;
            this.resultLb.Text = "[Empty]";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.formula.Location = new System.Drawing.Point(32, 223);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(79, 20);
            this.formula.TabIndex = 11;
            this.formula.Text = "計算式：";
            // 
            // formulaLb
            // 
            this.formulaLb.AutoSize = true;
            this.formulaLb.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.formulaLb.Location = new System.Drawing.Point(117, 223);
            this.formulaLb.Name = "formulaLb";
            this.formulaLb.Size = new System.Drawing.Size(76, 20);
            this.formulaLb.TabIndex = 12;
            this.formulaLb.Text = "[Empty]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 279);
            this.Controls.Add(this.formulaLb);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.result);
            this.Controls.Add(this.divided);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextTx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prevTx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "課題０２　電卓";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prevTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nextTx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divided;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.Label formulaLb;
    }
}

