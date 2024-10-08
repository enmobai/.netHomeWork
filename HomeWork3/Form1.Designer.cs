namespace HomeWork3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtOriginalStats = new System.Windows.Forms.TextBox();
            this.txtFormattedStats = new System.Windows.Forms.TextBox();
            this.lstWordCount = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(227, 59);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 30);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtOriginalStats
            // 
            this.txtOriginalStats.Location = new System.Drawing.Point(96, 141);
            this.txtOriginalStats.Multiline = true;
            this.txtOriginalStats.Name = "txtOriginalStats";
            this.txtOriginalStats.ReadOnly = true;
            this.txtOriginalStats.Size = new System.Drawing.Size(360, 80);
            this.txtOriginalStats.TabIndex = 1;
            // 
            // txtFormattedStats
            // 
            this.txtFormattedStats.Location = new System.Drawing.Point(96, 265);
            this.txtFormattedStats.Multiline = true;
            this.txtFormattedStats.Name = "txtFormattedStats";
            this.txtFormattedStats.ReadOnly = true;
            this.txtFormattedStats.Size = new System.Drawing.Size(360, 80);
            this.txtFormattedStats.TabIndex = 2;
            // 
            // lstWordCount
            // 
            this.lstWordCount.FormattingEnabled = true;
            this.lstWordCount.ItemHeight = 18;
            this.lstWordCount.Location = new System.Drawing.Point(96, 396);
            this.lstWordCount.Name = "lstWordCount";
            this.lstWordCount.Size = new System.Drawing.Size(360, 220);
            this.lstWordCount.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(609, 664);
            this.Controls.Add(this.lstWordCount);
            this.Controls.Add(this.txtFormattedStats);
            this.Controls.Add(this.txtOriginalStats);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "C# 源文件格式化与统计程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtOriginalStats;
        private System.Windows.Forms.TextBox txtFormattedStats;
        private System.Windows.Forms.ListBox lstWordCount;
    }
}
