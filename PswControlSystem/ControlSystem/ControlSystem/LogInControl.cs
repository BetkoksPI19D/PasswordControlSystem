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

namespace ControlSystem
{
    public partial class LogInControl : UserControl
    {
        string path = "C:\\Users\\njusp\\OneDrive - Vilniaus kolegija\\2 kursas\\Informacijos Saugumas\\PswControlSystem\\Database.txt";
        public LogInControl()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }

        private void LogInButtonInControl_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText(path);
            string psw = PasswordBox.Text;
            string hpsw = GetStringSha256Hash(psw);
            if(UsernameBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Username or password sould be filled");
            }
            else if (file.Contains(UsernameBox.Text) && file.Contains(hpsw))
            {
                Logged logd = new Logged();
                logd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
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
       
    }

}
