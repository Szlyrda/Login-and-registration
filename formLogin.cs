using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_and_registration
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }


        //metoda deszyfrująca
        static private byte[] DecryptRSA(byte[] userSendsText, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Decrypt(userSendsText, false);
            }
        }

        
        
        private void butLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                //kontener, w którym będą zapisywane utworzone klucze RSA
                var csp = new CspParameters
                {
                    KeyContainerName = "KontenerRSA"
                };
                string encryptedPassword = dr["password"].ToString();

                // Odszyfrowanie hasła
                byte[] encryptedMsg = Convert.FromBase64String(encryptedPassword);

                byte[] decryptedMsg = DecryptRSA(encryptedMsg, csp);

                string decryptedPassword = Encoding.UTF8.GetString(decryptedMsg);

                // Porównanie odszyfrowanego hasła z wprowadzonym hasłem
                if (decryptedPassword == txtPassword.Text)
                {
                    // Hasła są zgodne, wykonaj logowanie
                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    // Hasła się nie zgadzają
                    MessageBox.Show("Błędny login lub hasło, spróbuj ponownie", "Logowanie nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            else
            {
                // Użytkownik nie istnieje w bazie danych
                MessageBox.Show("Błędny login lub hasło, spróbuj ponownie", "Logowanie nieudane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

            con.Close();

            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void labelGoToRegister_Click(object sender, EventArgs e)
        {
            new formRegister().Show();
            this.Hide();
        }
    }
}
