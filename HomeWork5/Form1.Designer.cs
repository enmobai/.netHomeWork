namespace HomeWork5
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstUrls = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(268, 115);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(245, 28);
            this.txtKeyword.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(599, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 47);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstUrls
            // 
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.ItemHeight = 18;
            this.lstUrls.Location = new System.Drawing.Point(54, 239);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(958, 508);
            this.lstUrls.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(351, 197);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(62, 18);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 759);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstUrls);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstUrls;
        private System.Windows.Forms.Label lblCount;
    }
}

