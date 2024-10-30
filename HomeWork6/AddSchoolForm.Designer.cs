namespace HomeWork6
{
    partial class AddSchoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.btnSaveSchool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(134, 85);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(154, 28);
            this.txtSchoolName.TabIndex = 0;
            // 
            // btnSaveSchool
            // 
            this.btnSaveSchool.Location = new System.Drawing.Point(162, 161);
            this.btnSaveSchool.Name = "btnSaveSchool";
            this.btnSaveSchool.Size = new System.Drawing.Size(102, 39);
            this.btnSaveSchool.TabIndex = 1;
            this.btnSaveSchool.Text = "保存";
            this.btnSaveSchool.UseVisualStyleBackColor = true;
            this.btnSaveSchool.Click += new System.EventHandler(this.btnSaveSchool_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "学校名称";
            // 
            // AddSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveSchool);
            this.Controls.Add(this.txtSchoolName);
            this.Name = "AddSchoolForm";
            this.Text = "AddSchoolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Button btnSaveSchool;
        private System.Windows.Forms.Label label1;
    }
}