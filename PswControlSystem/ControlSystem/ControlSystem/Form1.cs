using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class Form1 : Form
    {
        FileCryption fcrypt = new FileCryption();
        LogInControl lic = new LogInControl();
        string databasePathAes = "C:\\Users\\njusp\\OneDrive - Vilniaus kolegija\\2 kursas\\Informacijos Saugumas\\PswControlSystem\\Database.txt.aes";
        string databasePath = "C:\\Users\\njusp\\OneDrive - Vilniaus kolegija\\2 kursas\\Informacijos Saugumas\\PswControlSystem\\Database.txt";

        private string psw = "key";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindomPanel.Controls.Clear();
            LogInControl lic = new LogInControl();
            MainWindomPanel.Controls.Add(lic);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            MainWindomPanel.Controls.Clear();
            SignUpControl suc = new SignUpControl();
            MainWindomPanel.Controls.Add(suc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fcrypt.FileEcnryption(databasePath, psw);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            fcrypt.FileDecryption(databasePathAes, databasePath, psw);
        }
    }
}
