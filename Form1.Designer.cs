namespace Login_and_registration
{
    partial class formRegister
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.butRegister = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelAlreadyHaveAcc = new System.Windows.Forms.Label();
            this.labelBackToLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa użykownika";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(28, 106);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(28, 175);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasło";
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(28, 243);
            this.txtConPassword.Multiline = true;
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '•';
            this.txtConPassword.Size = new System.Drawing.Size(216, 28);
            this.txtConPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Powtórz hasło";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPass.Location = new System.Drawing.Point(84, 288);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(100, 20);
            this.checkBoxShowPass.TabIndex = 7;
            this.checkBoxShowPass.Text = "Pokaż hasło";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // butRegister
            // 
            this.butRegister.BackColor = System.Drawing.Color.GreenYellow;
            this.butRegister.FlatAppearance.BorderSize = 0;
            this.butRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.butRegister.ForeColor = System.Drawing.Color.White;
            this.butRegister.Location = new System.Drawing.Point(28, 325);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(216, 35);
            this.butRegister.TabIndex = 8;
            this.butRegister.Text = "REJESTRACJA";
            this.butRegister.UseVisualStyleBackColor = false;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonClear.Location = new System.Drawing.Point(28, 366);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(216, 35);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "WYCZYŚĆ";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelAlreadyHaveAcc
            // 
            this.labelAlreadyHaveAcc.AutoSize = true;
            this.labelAlreadyHaveAcc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAlreadyHaveAcc.Location = new System.Drawing.Point(66, 438);
            this.labelAlreadyHaveAcc.Name = "labelAlreadyHaveAcc";
            this.labelAlreadyHaveAcc.Size = new System.Drawing.Size(118, 16);
            this.labelAlreadyHaveAcc.TabIndex = 10;
            this.labelAlreadyHaveAcc.Text = "Posiadasz konto?";
            // 
            // labelBackToLog
            // 
            this.labelBackToLog.AutoSize = true;
            this.labelBackToLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBackToLog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBackToLog.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelBackToLog.Location = new System.Drawing.Point(66, 454);
            this.labelBackToLog.Name = "labelBackToLog";
            this.labelBackToLog.Size = new System.Drawing.Size(143, 16);
            this.labelBackToLog.TabIndex = 11;
            this.labelBackToLog.Text = "Powrót do logowania";
            this.labelBackToLog.Click += new System.EventHandler(this.labelBackToLog_Click);
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 505);
            this.Controls.Add(this.labelBackToLog);
            this.Controls.Add(this.labelAlreadyHaveAcc);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelAlreadyHaveAcc;
        private System.Windows.Forms.Label labelBackToLog;
    }
}

