namespace Login_and_registration
{
    partial class formLogin
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
            this.labelGoToRegister = new System.Windows.Forms.Label();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGoToRegister
            // 
            this.labelGoToRegister.AutoSize = true;
            this.labelGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelGoToRegister.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelGoToRegister.Location = new System.Drawing.Point(62, 399);
            this.labelGoToRegister.Name = "labelGoToRegister";
            this.labelGoToRegister.Size = new System.Drawing.Size(90, 16);
            this.labelGoToRegister.TabIndex = 23;
            this.labelGoToRegister.Text = "Stwórz konto";
            this.labelGoToRegister.Click += new System.EventHandler(this.labelGoToRegister_Click);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDontHaveAcc.Location = new System.Drawing.Point(62, 383);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(112, 16);
            this.labelDontHaveAcc.TabIndex = 22;
            this.labelDontHaveAcc.Text = "Nie masz konta?";
            this.labelDontHaveAcc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonClear.Location = new System.Drawing.Point(30, 311);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(216, 35);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "WYCZYŚĆ";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(30, 270);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(216, 35);
            this.butLogin.TabIndex = 20;
            this.butLogin.Text = "ZALOGUJ";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPass.Location = new System.Drawing.Point(86, 233);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(100, 20);
            this.checkBoxShowPass.TabIndex = 19;
            this.checkBoxShowPass.Text = "Pokaż hasło";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(30, 179);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hasło";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(30, 110);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Logowanie";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.labelGoToRegister);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGoToRegister;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}