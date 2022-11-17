namespace Demo
{
    partial class Form1
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Str = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Str
            // 
            this.txt_Str.Location = new System.Drawing.Point(200, 60);
            this.txt_Str.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Str.Name = "txt_Str";
            this.txt_Str.ShortcutsEnabled = false;
            this.txt_Str.Size = new System.Drawing.Size(274, 28);
            this.txt_Str.TabIndex = 0;
            this.txt_Str.TextChanged += new System.EventHandler(this.txt_Str_TextChanged);
            this.txt_Str.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Str_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "只允许输入数字：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Str);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "只允许输入数字的TextBox控件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Str;
        private System.Windows.Forms.Label label1;
    }
}

