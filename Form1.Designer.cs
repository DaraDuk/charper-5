namespace Student_Population
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAnnualgrowth = new System.Windows.Forms.TextBox();
            this.txtNumberofyears = new System.Windows.Forms.TextBox();
            this.txtProjected = new System.Windows.Forms.TextBox();
            this.tbnProjectStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of student today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual growth rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Projected of student";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(266, 41);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(185, 26);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnnualgrowth
            // 
            this.txtAnnualgrowth.Location = new System.Drawing.Point(266, 111);
            this.txtAnnualgrowth.Name = "txtAnnualgrowth";
            this.txtAnnualgrowth.Size = new System.Drawing.Size(185, 26);
            this.txtAnnualgrowth.TabIndex = 5;
            this.txtAnnualgrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberofyears
            // 
            this.txtNumberofyears.Location = new System.Drawing.Point(266, 182);
            this.txtNumberofyears.Name = "txtNumberofyears";
            this.txtNumberofyears.Size = new System.Drawing.Size(185, 26);
            this.txtNumberofyears.TabIndex = 6;
            this.txtNumberofyears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProjected
            // 
            this.txtProjected.Location = new System.Drawing.Point(266, 253);
            this.txtProjected.Name = "txtProjected";
            this.txtProjected.ReadOnly = true;
            this.txtProjected.Size = new System.Drawing.Size(185, 26);
            this.txtProjected.TabIndex = 7;
            // 
            // tbnProjectStudent
            // 
            this.tbnProjectStudent.Location = new System.Drawing.Point(43, 332);
            this.tbnProjectStudent.Name = "tbnProjectStudent";
            this.tbnProjectStudent.Size = new System.Drawing.Size(181, 54);
            this.tbnProjectStudent.TabIndex = 8;
            this.tbnProjectStudent.Text = "&Project \r\nStudent \r\nPopulation";
            this.tbnProjectStudent.UseVisualStyleBackColor = true;
            this.tbnProjectStudent.Click += new System.EventHandler(this.tbnProjectStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 54);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 408);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbnProjectStudent);
            this.Controls.Add(this.txtProjected);
            this.Controls.Add(this.txtNumberofyears);
            this.Controls.Add(this.txtAnnualgrowth);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAnnualgrowth;
        private System.Windows.Forms.TextBox txtNumberofyears;
        private System.Windows.Forms.TextBox txtProjected;
        private System.Windows.Forms.Button tbnProjectStudent;
        private System.Windows.Forms.Button btnExit;
    }
}

