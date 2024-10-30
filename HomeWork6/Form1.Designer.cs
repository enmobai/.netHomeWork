namespace HomeWork6
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
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.btnEditSchool = new System.Windows.Forms.Button();
            this.btnDeleteSchool = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.dgvSchools = new System.Windows.Forms.DataGridView();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnViewClasses = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(45, 39);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(120, 65);
            this.btnAddSchool.TabIndex = 0;
            this.btnAddSchool.Text = "添加学校";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // btnEditSchool
            // 
            this.btnEditSchool.Location = new System.Drawing.Point(220, 42);
            this.btnEditSchool.Name = "btnEditSchool";
            this.btnEditSchool.Size = new System.Drawing.Size(116, 62);
            this.btnEditSchool.TabIndex = 1;
            this.btnEditSchool.Text = "编辑学校";
            this.btnEditSchool.UseVisualStyleBackColor = true;
            this.btnEditSchool.Click += new System.EventHandler(this.btnEditSchool_Click);
            // 
            // btnDeleteSchool
            // 
            this.btnDeleteSchool.Location = new System.Drawing.Point(397, 45);
            this.btnDeleteSchool.Name = "btnDeleteSchool";
            this.btnDeleteSchool.Size = new System.Drawing.Size(110, 59);
            this.btnDeleteSchool.TabIndex = 2;
            this.btnDeleteSchool.Text = "删除学校";
            this.btnDeleteSchool.UseVisualStyleBackColor = true;
            this.btnDeleteSchool.Click += new System.EventHandler(this.btnDeleteSchool_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(45, 178);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(120, 61);
            this.btnAddClass.TabIndex = 3;
            this.btnAddClass.Text = "增加班级";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(222, 176);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(114, 64);
            this.btnEditClass.TabIndex = 4;
            this.btnEditClass.Text = "编辑班级";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(397, 178);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(110, 61);
            this.btnDeleteClass.TabIndex = 5;
            this.btnDeleteClass.Text = "删除班级";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(45, 308);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(126, 58);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "添加学生";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(220, 308);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(116, 58);
            this.btnEditStudent.TabIndex = 7;
            this.btnEditStudent.Text = "编辑学生";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(397, 308);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(110, 58);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "删除学生";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Location = new System.Drawing.Point(563, 308);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(103, 58);
            this.btnViewLogs.TabIndex = 9;
            this.btnViewLogs.Text = "查看日志";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // dgvSchools
            // 
            this.dgvSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchools.Location = new System.Drawing.Point(23, 437);
            this.dgvSchools.Name = "dgvSchools";
            this.dgvSchools.RowHeadersWidth = 62;
            this.dgvSchools.RowTemplate.Height = 30;
            this.dgvSchools.Size = new System.Drawing.Size(679, 415);
            this.dgvSchools.TabIndex = 10;
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(732, 39);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 62;
            this.dgvClasses.RowTemplate.Height = 30;
            this.dgvClasses.Size = new System.Drawing.Size(720, 363);
            this.dgvClasses.TabIndex = 11;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(732, 437);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.Size = new System.Drawing.Size(720, 415);
            this.dgvStudents.TabIndex = 12;
            // 
            // btnViewClasses
            // 
            this.btnViewClasses.Location = new System.Drawing.Point(563, 39);
            this.btnViewClasses.Name = "btnViewClasses";
            this.btnViewClasses.Size = new System.Drawing.Size(103, 65);
            this.btnViewClasses.TabIndex = 13;
            this.btnViewClasses.Text = "查看班级";
            this.btnViewClasses.UseVisualStyleBackColor = true;
            this.btnViewClasses.Click += new System.EventHandler(this.btnViewClasses_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.Location = new System.Drawing.Point(563, 179);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(103, 61);
            this.btnViewStudents.TabIndex = 14;
            this.btnViewStudents.Text = "查看学生";
            this.btnViewStudents.UseVisualStyleBackColor = true;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 873);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.btnViewClasses);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.dgvSchools);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnDeleteSchool);
            this.Controls.Add(this.btnEditSchool);
            this.Controls.Add(this.btnAddSchool);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.Button btnEditSchool;
        private System.Windows.Forms.Button btnDeleteSchool;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.DataGridView dgvSchools;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnViewClasses;
        private System.Windows.Forms.Button btnViewStudents;
    }
}

