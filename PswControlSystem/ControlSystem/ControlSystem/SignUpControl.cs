using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;

namespace ControlSystem
{
    public partial class SignUpControl : UserControl
    {
        FileCryption fcrypt = new FileCryption();
        private string psw = "key";
        public SignUpControl()
        {
            InitializeComponent();
            PasswordSignUpBox.PasswordChar = '*';
            ComfirmPassSignUpBox.PasswordChar = '*';
        }

        private void SignUpButtonInControl_Click(object sender, EventArgs e)
        {
            string databasePath = "C:\\Users\\njusp\\OneDrive - Vilniaus kolegija\\2 kursas\\Informacijos Saugumas\\PswControlSystem\\Database.txt";
            string file = File.ReadAllText(databasePath);
            if (file.Contains(UsernameSignUpBox.Text))
            {
                MessageBox.Show("Username already exists");
            }
            else if (PasswordSignUpBox.Text != ComfirmPassSignUpBox.Text)
            {
                MessageBox.Show("Password should mach!");
            }
            else
            {
                string username = UsernameSignUpBox.Text;
                string passw = PasswordSignUpBox.Text;
                

                string s1 = username + "\n";
                string s2 = GetStringSha256Hash(passw) + "\n";
                var sv = String.Concat(s1, s2);

                File.AppendAllText(databasePath, sv);

                string usersPath = @"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\" + username + ".txt";


                File.WriteAllText(usersPath, null);

                fcrypt.FileEcnryption(usersPath, psw);

                MessageBox.Show("Registred!");
                UsernameSignUpBox.Text = "";
                PasswordSignUpBox.Text = "";
                ComfirmPassSignUpBox.Text = "";
            }
        }
        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        public static byte[] SaltGenerator()
        {
            byte[] input = new byte[32];
            using (RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider())
            {
                rngProvider.GetBytes(input);
            }
            return input;
        }
        
    }
}
