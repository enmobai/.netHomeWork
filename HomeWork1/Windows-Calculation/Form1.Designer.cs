using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HomeWork1
{
    partial class Form1
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(486, 456);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 89);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 1;
            label1.Text = "题目如下";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 234);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(792, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(659, 231);
            label5.Name = "label5";
            label5.Size = new Size(23, 24);
            label5.TabIndex = 6;
            label5.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 353);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 743);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;


        
    }


}