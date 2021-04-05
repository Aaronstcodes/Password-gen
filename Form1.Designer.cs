
namespace Password_Generator
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
            this.Passwd_tb = new System.Windows.Forms.TextBox();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.UpperCaseLetters_chBox = new System.Windows.Forms.CheckBox();
            this.LowerCaseLetters_chBox = new System.Windows.Forms.CheckBox();
            this.Digits_chBox = new System.Windows.Forms.CheckBox();
            this.Underline_chBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharacters_chBox = new System.Windows.Forms.CheckBox();
            this.Space_chBox = new System.Windows.Forms.CheckBox();
            this.passwdLength_lbl = new System.Windows.Forms.Label();
            this.Settings_groupBox = new System.Windows.Forms.GroupBox();
            this.PasswdLength_numUpDwn = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.excludeChars_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyToClipboard_btn = new System.Windows.Forms.Button();
            this.Settings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswdLength_numUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // Passwd_tb
            // 
            this.Passwd_tb.Location = new System.Drawing.Point(13, 41);
            this.Passwd_tb.Name = "Passwd_tb";
            this.Passwd_tb.Size = new System.Drawing.Size(281, 20);
            this.Passwd_tb.TabIndex = 0;
            this.Passwd_tb.Text = "Click the Generate Password button";
            // 
            // Generate_btn
            // 
            this.Generate_btn.Location = new System.Drawing.Point(13, 12);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(134, 23);
            this.Generate_btn.TabIndex = 1;
            this.Generate_btn.Text = "Generate Password";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // UpperCaseLetters_chBox
            // 
            this.UpperCaseLetters_chBox.AutoSize = true;
            this.UpperCaseLetters_chBox.Checked = true;
            this.UpperCaseLetters_chBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCaseLetters_chBox.Location = new System.Drawing.Point(6, 19);
            this.UpperCaseLetters_chBox.Name = "UpperCaseLetters_chBox";
            this.UpperCaseLetters_chBox.Size = new System.Drawing.Size(117, 17);
            this.UpperCaseLetters_chBox.TabIndex = 2;
            this.UpperCaseLetters_chBox.Text = "Upper Case Letters";
            this.UpperCaseLetters_chBox.UseVisualStyleBackColor = true;
            this.UpperCaseLetters_chBox.CheckedChanged += new System.EventHandler(this.UpperCaseLetters_chBox_CheckedChanged);
            // 
            // LowerCaseLetters_chBox
            // 
            this.LowerCaseLetters_chBox.AutoSize = true;
            this.LowerCaseLetters_chBox.Checked = true;
            this.LowerCaseLetters_chBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCaseLetters_chBox.Location = new System.Drawing.Point(6, 42);
            this.LowerCaseLetters_chBox.Name = "LowerCaseLetters_chBox";
            this.LowerCaseLetters_chBox.Size = new System.Drawing.Size(117, 17);
            this.LowerCaseLetters_chBox.TabIndex = 3;
            this.LowerCaseLetters_chBox.Text = "Lower Case Letters";
            this.LowerCaseLetters_chBox.UseVisualStyleBackColor = true;
            this.LowerCaseLetters_chBox.CheckedChanged += new System.EventHandler(this.LowerCaseLetters_chBox_CheckedChanged);
            // 
            // Digits_chBox
            // 
            this.Digits_chBox.AutoSize = true;
            this.Digits_chBox.Checked = true;
            this.Digits_chBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Digits_chBox.Location = new System.Drawing.Point(6, 65);
            this.Digits_chBox.Name = "Digits_chBox";
            this.Digits_chBox.Size = new System.Drawing.Size(52, 17);
            this.Digits_chBox.TabIndex = 4;
            this.Digits_chBox.Text = "Digits";
            this.Digits_chBox.UseVisualStyleBackColor = true;
            this.Digits_chBox.CheckedChanged += new System.EventHandler(this.Digits_chBox_CheckedChanged);
            // 
            // Underline_chBox
            // 
            this.Underline_chBox.AutoSize = true;
            this.Underline_chBox.Location = new System.Drawing.Point(6, 134);
            this.Underline_chBox.Name = "Underline_chBox";
            this.Underline_chBox.Size = new System.Drawing.Size(71, 17);
            this.Underline_chBox.TabIndex = 8;
            this.Underline_chBox.Text = "Underline";
            this.Underline_chBox.UseVisualStyleBackColor = true;
            this.Underline_chBox.CheckedChanged += new System.EventHandler(this.Underline_chBox_CheckedChanged);
            // 
            // SpecialCharacters_chBox
            // 
            this.SpecialCharacters_chBox.AutoSize = true;
            this.SpecialCharacters_chBox.Checked = true;
            this.SpecialCharacters_chBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpecialCharacters_chBox.Location = new System.Drawing.Point(6, 111);
            this.SpecialCharacters_chBox.Name = "SpecialCharacters_chBox";
            this.SpecialCharacters_chBox.Size = new System.Drawing.Size(115, 17);
            this.SpecialCharacters_chBox.TabIndex = 7;
            this.SpecialCharacters_chBox.Text = "Special Characters";
            this.SpecialCharacters_chBox.UseVisualStyleBackColor = true;
            this.SpecialCharacters_chBox.CheckedChanged += new System.EventHandler(this.specialCharacters_chBox_CheckedChanged);
            // 
            // Space_chBox
            // 
            this.Space_chBox.AutoSize = true;
            this.Space_chBox.Location = new System.Drawing.Point(6, 88);
            this.Space_chBox.Name = "Space_chBox";
            this.Space_chBox.Size = new System.Drawing.Size(57, 17);
            this.Space_chBox.TabIndex = 6;
            this.Space_chBox.Text = "Space";
            this.Space_chBox.UseVisualStyleBackColor = true;
            this.Space_chBox.CheckedChanged += new System.EventHandler(this.Space_chBox_CheckedChanged);
            // 
            // passwdLength_lbl
            // 
            this.passwdLength_lbl.AutoSize = true;
            this.passwdLength_lbl.Location = new System.Drawing.Point(3, 180);
            this.passwdLength_lbl.Name = "passwdLength_lbl";
            this.passwdLength_lbl.Size = new System.Drawing.Size(89, 13);
            this.passwdLength_lbl.TabIndex = 10;
            this.passwdLength_lbl.Text = "Password Length";
            // 
            // Settings_groupBox
            // 
            this.Settings_groupBox.Controls.Add(this.PasswdLength_numUpDwn);
            this.Settings_groupBox.Controls.Add(this.textBox3);
            this.Settings_groupBox.Controls.Add(this.excludeChars_lbl);
            this.Settings_groupBox.Controls.Add(this.label1);
            this.Settings_groupBox.Controls.Add(this.UpperCaseLetters_chBox);
            this.Settings_groupBox.Controls.Add(this.LowerCaseLetters_chBox);
            this.Settings_groupBox.Controls.Add(this.passwdLength_lbl);
            this.Settings_groupBox.Controls.Add(this.Digits_chBox);
            this.Settings_groupBox.Controls.Add(this.Underline_chBox);
            this.Settings_groupBox.Controls.Add(this.Space_chBox);
            this.Settings_groupBox.Controls.Add(this.SpecialCharacters_chBox);
            this.Settings_groupBox.Location = new System.Drawing.Point(13, 67);
            this.Settings_groupBox.Name = "Settings_groupBox";
            this.Settings_groupBox.Size = new System.Drawing.Size(288, 233);
            this.Settings_groupBox.TabIndex = 12;
            this.Settings_groupBox.TabStop = false;
            this.Settings_groupBox.Text = "Settings";
            // 
            // PasswdLength_numUpDwn
            // 
            this.PasswdLength_numUpDwn.Location = new System.Drawing.Point(108, 178);
            this.PasswdLength_numUpDwn.Name = "PasswdLength_numUpDwn";
            this.PasswdLength_numUpDwn.Size = new System.Drawing.Size(170, 20);
            this.PasswdLength_numUpDwn.TabIndex = 18;
            this.PasswdLength_numUpDwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswdLength_numUpDwn.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.PasswdLength_numUpDwn.ValueChanged += new System.EventHandler(this.PasswdLength_numUpDwn_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "NOT YET IMPLEMENTED";
            // 
            // excludeChars_lbl
            // 
            this.excludeChars_lbl.AutoSize = true;
            this.excludeChars_lbl.Location = new System.Drawing.Point(3, 206);
            this.excludeChars_lbl.Name = "excludeChars_lbl";
            this.excludeChars_lbl.Size = new System.Drawing.Size(99, 13);
            this.excludeChars_lbl.TabIndex = 14;
            this.excludeChars_lbl.Text = "Exclude Characters";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 2);
            this.label1.TabIndex = 13;
            // 
            // CopyToClipboard_btn
            // 
            this.CopyToClipboard_btn.Location = new System.Drawing.Point(153, 12);
            this.CopyToClipboard_btn.Name = "CopyToClipboard_btn";
            this.CopyToClipboard_btn.Size = new System.Drawing.Size(141, 23);
            this.CopyToClipboard_btn.TabIndex = 13;
            this.CopyToClipboard_btn.Text = "Copy To Clipboard";
            this.CopyToClipboard_btn.UseVisualStyleBackColor = true;
            this.CopyToClipboard_btn.Click += new System.EventHandler(this.CopyToClipboard_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 306);
            this.Controls.Add(this.CopyToClipboard_btn);
            this.Controls.Add(this.Settings_groupBox);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.Passwd_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Settings_groupBox.ResumeLayout(false);
            this.Settings_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswdLength_numUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passwd_tb;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.CheckBox UpperCaseLetters_chBox;
        private System.Windows.Forms.CheckBox LowerCaseLetters_chBox;
        private System.Windows.Forms.CheckBox Digits_chBox;
        private System.Windows.Forms.CheckBox Underline_chBox;
        private System.Windows.Forms.CheckBox SpecialCharacters_chBox;
        private System.Windows.Forms.CheckBox Space_chBox;
        private System.Windows.Forms.Label passwdLength_lbl;
        private System.Windows.Forms.GroupBox Settings_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PasswdLength_numUpDwn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label excludeChars_lbl;
        private System.Windows.Forms.Button CopyToClipboard_btn;
    }
}

