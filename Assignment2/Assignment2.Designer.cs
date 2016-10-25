namespace Assignment2
{
    partial class frmAssignment2
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
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.lblGrade3 = new System.Windows.Forms.Label();
            this.lblGrade4 = new System.Windows.Forms.Label();
            this.lblGrade5 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtGrade4 = new System.Windows.Forms.TextBox();
            this.txtGrade5 = new System.Windows.Forms.TextBox();
            this.lblStatment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Location = new System.Drawing.Point(13, 125);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(40, 13);
            this.lblGrade1.TabIndex = 2;
            this.lblGrade1.Text = "Mark 1";
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(13, 153);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(40, 13);
            this.lblGrade2.TabIndex = 3;
            this.lblGrade2.Text = "Mark 2";
            // 
            // lblGrade3
            // 
            this.lblGrade3.AutoSize = true;
            this.lblGrade3.Location = new System.Drawing.Point(12, 178);
            this.lblGrade3.Name = "lblGrade3";
            this.lblGrade3.Size = new System.Drawing.Size(40, 13);
            this.lblGrade3.TabIndex = 4;
            this.lblGrade3.Text = "Mark 3";
            // 
            // lblGrade4
            // 
            this.lblGrade4.AutoSize = true;
            this.lblGrade4.Location = new System.Drawing.Point(13, 202);
            this.lblGrade4.Name = "lblGrade4";
            this.lblGrade4.Size = new System.Drawing.Size(40, 13);
            this.lblGrade4.TabIndex = 5;
            this.lblGrade4.Text = "Mark 4";
            // 
            // lblGrade5
            // 
            this.lblGrade5.AutoSize = true;
            this.lblGrade5.Location = new System.Drawing.Point(12, 228);
            this.lblGrade5.Name = "lblGrade5";
            this.lblGrade5.Size = new System.Drawing.Size(40, 13);
            this.lblGrade5.TabIndex = 6;
            this.lblGrade5.Text = "Mark 5";
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 328);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(243, 116);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 267);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Average!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(76, 122);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(100, 20);
            this.txtGrade1.TabIndex = 9;
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(76, 150);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(100, 20);
            this.txtGrade2.TabIndex = 10;
            // 
            // txtGrade3
            // 
            this.txtGrade3.Location = new System.Drawing.Point(76, 175);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(100, 20);
            this.txtGrade3.TabIndex = 11;
            // 
            // txtGrade4
            // 
            this.txtGrade4.Location = new System.Drawing.Point(76, 199);
            this.txtGrade4.Name = "txtGrade4";
            this.txtGrade4.Size = new System.Drawing.Size(100, 20);
            this.txtGrade4.TabIndex = 12;
            // 
            // txtGrade5
            // 
            this.txtGrade5.Location = new System.Drawing.Point(76, 225);
            this.txtGrade5.Name = "txtGrade5";
            this.txtGrade5.Size = new System.Drawing.Size(100, 20);
            this.txtGrade5.TabIndex = 13;
            // 
            // lblStatment
            // 
            this.lblStatment.AutoSize = true;
            this.lblStatment.Location = new System.Drawing.Point(12, 70);
            this.lblStatment.Name = "lblStatment";
            this.lblStatment.Size = new System.Drawing.Size(154, 13);
            this.lblStatment.TabIndex = 14;
            this.lblStatment.Text = "Please enter your class grades.";
            // 
            // frmAssignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 518);
            this.Controls.Add(this.lblStatment);
            this.Controls.Add(this.txtGrade5);
            this.Controls.Add(this.txtGrade4);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblGrade5);
            this.Controls.Add(this.lblGrade4);
            this.Controls.Add(this.lblGrade3);
            this.Controls.Add(this.lblGrade2);
            this.Controls.Add(this.lblGrade1);
            this.Name = "frmAssignment2";
            this.Text = "Avarge of Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.Label lblGrade3;
        private System.Windows.Forms.Label lblGrade4;
        private System.Windows.Forms.Label lblGrade5;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.TextBox txtGrade5;
        private System.Windows.Forms.Label lblStatment;
    }
}

