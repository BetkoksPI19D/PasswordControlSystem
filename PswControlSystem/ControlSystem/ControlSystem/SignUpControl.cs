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
        string path = "C:\\Users\\njusp\\OneDrive - Vilniaus kolegija\\2 kursas\\Informacijos Saugumas\\PswControlSystem\\Database.txt";
        private string psw = "key";
        public SignUpControl()
        {
            InitializeComponent();
            PasswordSignUpBox.PasswordChar = '*';
            ComfirmPassSignUpBox.PasswordChar = '*';
        }

        private void SignUpButtonInControl_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText(path);
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
                File.AppendAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Database.txt", sv);
                File.WriteAllText(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\" + username + ".txt", null);
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
        private void FileEcnryption(string psw)
        {
            string username = UsernameSignUpBox.Text;
            string inputFiles = @"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\" + username + ".txt";
            byte[] salt = SaltGenerator();
            byte[] keys = Encoding.UTF8.GetBytes(psw);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.Padding = PaddingMode.PKCS7;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(psw, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;

            using (FileStream fStream = new FileStream(inputFiles + ".aes", FileMode.Create))
            {
                fStream.Write(salt, 0, salt.Length);
                using (CryptoStream cStream = new CryptoStream(fStream, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (FileStream fStreamIN = new FileStream(inputFiles, FileMode.Open))
                    {
                        byte[] buff = new byte[100000];
                        int a;
                        while ((a = fStreamIN.Read(buff, 0, buff.Length)) > 0)
                        {
                            cStream.Write(buff, 0, a);
                        }
                    }
                }
            }
        }
        private void MD5Hash(string hash)
        {
            StreamWriter sWriter = new StreamWriter(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Daugiagijis\AES_FolderToUse\hash.txt", true);
            sWriter.WriteLine(hash);
            sWriter.Close();
        }
        public void Encryption()
        {
            MD5 MD5 = MD5.Create();
            byte[] md5;
            var files = Directory.GetFiles(@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\");
            string hash;
            foreach (var file in files)
            {
                
                FileEcnryption(psw);
                md5 = MD5.ComputeHash(File.ReadAllBytes(file + ".aes"));
                hash = BitConverter.ToString(md5).Replace("-", string.Empty);
                File.Delete(file);
                MD5Hash(hash);
                Thread.Sleep(500);

            }
        }
    }
}
