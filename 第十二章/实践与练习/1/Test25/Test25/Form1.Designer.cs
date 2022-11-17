namespace Test25
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntInfo = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txtBookInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvBook = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntInfo);
            this.groupBox2.Location = new System.Drawing.Point(166, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 62);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息提示";
            // 
            // bntInfo
            // 
            this.bntInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntInfo.Location = new System.Drawing.Point(11, 20);
            this.bntInfo.Name = "bntInfo";
            this.bntInfo.Size = new System.Drawing.Size(107, 23);
            this.bntInfo.TabIndex = 0;
            this.bntInfo.Text = "信息提示";
            this.bntInfo.UseVisualStyleBackColor = true;
            this.bntInfo.Visible = false;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(166, 70);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(113, 23);
            this.bntAdd.TabIndex = 8;
            this.bntAdd.Text = "添加书名(&D)";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtBookInfo
            // 
            this.txtBookInfo.Location = new System.Drawing.Point(166, 34);
            this.txtBookInfo.Name = "txtBookInfo";
            this.txtBookInfo.Size = new System.Drawing.Size(124, 21);
            this.txtBookInfo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "书名目录：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "书名目录";
            // 
            // lvBook
            // 
            this.lvBook.Location = new System.Drawing.Point(5, 14);
            this.lvBook.Name = "lvBook";
            this.lvBook.Size = new System.Drawing.Size(135, 130);
            this.lvBook.TabIndex = 0;
            this.lvBook.UseCompatibleStateImageBehavior = false;
            this.lvBook.View = System.Windows.Forms.View.Tile;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 174);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtBookInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntInfo;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.TextBox txtBookInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvBook;
        private System.Windows.Forms.ImageList imageList1;
    }
}

