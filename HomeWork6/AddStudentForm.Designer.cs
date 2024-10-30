namespace HomeWork6
{
    partial class AddStudentForm
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(181, 61);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(136, 28);
            this.txtStudentName.TabIndex = 0;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(183, 132);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 28);
            this.nudAge.TabIndex = 1;
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(183, 202);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(121, 26);
            this.cmbClasses.TabIndex = 2;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(183, 273);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(106, 38);
            this.btnSaveStudent.TabIndex = 3;
            this.btnSaveStudent.Text = "保存学生";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "所在班级";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtStudentName);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}