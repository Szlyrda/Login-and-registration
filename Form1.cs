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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        // Połączenie z bazą danych
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Metoda szyfrująca dane za pomocą algorytmu RSA
        static private byte[] EncryptRSA(byte[] userSendsText, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Encrypt(userSendsText, false);
            }
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                // Sprawdzanie, czy pola są puste
                MessageBox.Show("Pola są puste, spróbuj ponownie.", "Rejestracja nie powiodła się.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                try
                {
                    string userSendsText = txtPassword.Text;

                    // Kontener, w którym będą zapisywane utworzone klucze RSA
                    var csp = new CspParameters
                    {
                        KeyContainerName = "KontenerRSA"
                    };

                    // Szyfrowanie hasła za pomocą RSA
                    byte[] encryptedMsg = EncryptRSA(Encoding.UTF8.GetBytes(userSendsText), csp);

                    string dataToDB = Convert.ToBase64String(encryptedMsg); // Zamiana na Base64

                    con.Open();
                    string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + dataToDB + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    


                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConPassword.Text = "";

                    MessageBox.Show("Konto zostało utworzone", "Rejestracja zakończona",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Łapanie wyjątku gdy użytkownik o takiej nazwie juz istnieje.
                catch (System.Data.OleDb.OleDbException)
                {
                    MessageBox.Show("Taki użytkownik już istnieje", "Rejestracja nie powiodła się.", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                // Hasła nie są identyczne
                MessageBox.Show("Hasła nie są identyczne", "Rejestracja nie powiodła się.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                // Wyświetlanie hasła w formie tekstowej
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                // Ukrywanie hasła
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void labelBackToLog_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}