namespace FindKey
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.plotRed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 103);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // plotRed
            // 
            this.plotRed.Location = new System.Drawing.Point(238, 108);
            this.plotRed.Name = "plotRed";
            this.plotRed.Size = new System.Drawing.Size(45, 23);
            this.plotRed.TabIndex = 2;
            this.plotRed.Text = "描红";
            this.plotRed.UseVisualStyleBackColor = true;
            this.plotRed.Click += new System.EventHandler(this.plotRed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "关键字：";
            // 
            // keyWord
            // 
            this.keyWord.Location = new System.Drawing.Point(75, 110);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(157, 21);
            this.keyWord.TabIndex = 0;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 145);
            this.Controls.Add(this.plotRed);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.keyWord);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Main";
            this.Text = "在RichTextBox中实现关键字描红";
            this.Load += new System.EventHandler(this.KeyWordsPlotRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button plotRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyWord;
    }
}

