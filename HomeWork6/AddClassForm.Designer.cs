namespace HomeWork6
{
    partial class AddClassForm
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cmbSchools = new System.Windows.Forms.ComboBox();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(131, 26);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(165, 28);
            this.txtClassName.TabIndex = 0;
            // 
            // cmbSchools
            // 
            this.cmbSchools.FormattingEnabled = true;
            this.cmbSchools.Location = new System.Drawing.Point(153, 101);
            this.cmbSchools.Name = "cmbSchools";
            this.cmbSchools.Size = new System.Drawing.Size(121, 26);
            this.cmbSchools.TabIndex = 1;
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Location = new System.Drawing.Point(164, 172);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(95, 54);
            this.btnSaveClass.TabIndex = 2;
            this.btnSaveClass.Text = "保存班级";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "班级名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "所属学校";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.cmbSchools);
            this.Controls.Add(this.txtClassName);
            this.Name = "AddClassForm";
            this.Text = "AddClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox cmbSchools;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}