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
    public partial class NewPassControl : UserControl
    {
        Encryption Encr = new Encryption();
        public NewPassControl()
        {
            InitializeComponent();
            PassBox.PasswordChar = '*';
        }

        private void RandomPassButton_Click(object sender, EventArgs e)
        {
            int randPass = 10;
            string rand = CreatePassword(randPass);
            PassBox.Text = rand;
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890/!@#$%^&*";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void ShowPassButton_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassButton.Checked)
            {
                PassBox.PasswordChar = '\0';
            }
            else
            {
                PassBox.PasswordChar = '*';
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            String usern = UsrnameBox.Text + ",";
            String psw = Encr.Encrypt(PassBox.Text, "asd" ,true) + ",";
            String URL = URLBox.Text + ",";
            String comm = CommentBox.Text + "\n";

            var comb = String.Concat(usern, psw, URL, comm);

            File.AppendAllText($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt", comb);
        }
    }
}
