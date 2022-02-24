namespace CC_WinFromsIntro_Lesson16
{
    partial class RegistrationForm
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
            this.lbl_ManLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbPsw = new System.Windows.Forms.TextBox();
            this.dtpBrthDay = new System.Windows.Forms.DateTimePicker();
            this.chxIsVeg = new System.Windows.Forms.CheckBox();
            this.pnlRdbGender = new System.Windows.Forms.Panel();
            this.RdbNotSet = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.pnlRdbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ManLbl
            // 
            this.lbl_ManLbl.AutoSize = true;
            this.lbl_ManLbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ManLbl.Font = new System.Drawing.Font("Segoe UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ManLbl.Location = new System.Drawing.Point(103, 20);
            this.lbl_ManLbl.Margin = new System.Windows.Forms.Padding(80, 50, 3, 0);
            this.lbl_ManLbl.Name = "lbl_ManLbl";
            this.lbl_ManLbl.Size = new System.Drawing.Size(140, 47);
            this.lbl_ManLbl.TabIndex = 0;
            this.lbl_ManLbl.Text = "הרשמה";
            this.lbl_ManLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "כתובת מייל:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "סיסמה:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "תאריך לידה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 242);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 295);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "מין";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(12, 108);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(151, 23);
            this.txbMail.TabIndex = 6;
            // 
            // txbPsw
            // 
            this.txbPsw.Location = new System.Drawing.Point(12, 167);
            this.txbPsw.Name = "txbPsw";
            this.txbPsw.PasswordChar = '*';
            this.txbPsw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbPsw.Size = new System.Drawing.Size(151, 23);
            this.txbPsw.TabIndex = 7;
            this.txbPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpBrthDay
            // 
            this.dtpBrthDay.Location = new System.Drawing.Point(15, 226);
            this.dtpBrthDay.Name = "dtpBrthDay";
            this.dtpBrthDay.Size = new System.Drawing.Size(200, 23);
            this.dtpBrthDay.TabIndex = 8;
            // 
            // chxIsVeg
            // 
            this.chxIsVeg.AutoSize = true;
            this.chxIsVeg.Location = new System.Drawing.Point(19, 265);
            this.chxIsVeg.Name = "chxIsVeg";
            this.chxIsVeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chxIsVeg.Size = new System.Drawing.Size(87, 19);
            this.chxIsVeg.TabIndex = 9;
            this.chxIsVeg.Text = "האם צמחוני";
            this.chxIsVeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chxIsVeg.UseVisualStyleBackColor = true;
            // 
            // pnlRdbGender
            // 
            this.pnlRdbGender.Controls.Add(this.RdbNotSet);
            this.pnlRdbGender.Controls.Add(this.rdbFemale);
            this.pnlRdbGender.Controls.Add(this.rdbMale);
            this.pnlRdbGender.Location = new System.Drawing.Point(14, 318);
            this.pnlRdbGender.Name = "pnlRdbGender";
            this.pnlRdbGender.Size = new System.Drawing.Size(165, 59);
            this.pnlRdbGender.TabIndex = 10;
            // 
            // RdbNotSet
            // 
            this.RdbNotSet.AutoSize = true;
            this.RdbNotSet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RdbNotSet.Checked = true;
            this.RdbNotSet.Location = new System.Drawing.Point(91, 3);
            this.RdbNotSet.Name = "RdbNotSet";
            this.RdbNotSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RdbNotSet.Size = new System.Drawing.Size(54, 19);
            this.RdbNotSet.TabIndex = 2;
            this.RdbNotSet.TabStop = true;
            this.RdbNotSet.Text = "None";
            this.RdbNotSet.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RdbNotSet.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbFemale.Location = new System.Drawing.Point(83, 39);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbFemale.Size = new System.Drawing.Size(63, 19);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbMale.Location = new System.Drawing.Point(94, 21);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbMale.Size = new System.Drawing.Size(51, 19);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.Text = "Male";
            this.rdbMale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(103, 387);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 36);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "הרשמה";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(364, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 12;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(364, 108);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 13;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(364, 137);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 14;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(364, 166);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 15;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(554, 436);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnlRdbGender);
            this.Controls.Add(this.chxIsVeg);
            this.Controls.Add(this.dtpBrthDay);
            this.Controls.Add(this.txbPsw);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ManLbl);
            this.Name = "RegistrationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "חלון הרשמה";
            this.pnlRdbGender.ResumeLayout(false);
            this.pnlRdbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbPsw;
        private System.Windows.Forms.DateTimePicker dtpBrthDay;
        private System.Windows.Forms.CheckBox chxIsVeg;
        private System.Windows.Forms.Panel pnlRdbGender;
        private System.Windows.Forms.RadioButton RdbNotSet;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}
