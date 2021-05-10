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
    public partial class FindPassControl : UserControl
    {
        public FindPassControl()
        {
            InitializeComponent();
        }

        private void ShowAllPassButton_Click(object sender, EventArgs e)
        {
            FindPswView.Rows.Clear();
            string[] lines = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
            string[] lineSplit;
            for (int i = 0; i < lines.Length; i++)
            {
                lineSplit = lines[i].Split(",");
                FindPswView.Rows.Add(new object[] { lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3] });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FindPswView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(this.FindPswView.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                }
            }
            else
            {
                MessageBox.Show("Select PASSWORD first");
            }
        }

        private void ShowByNameButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string[] txt = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
            if (username == "" || username == " ")
            {
                MessageBox.Show("Type your username in text box");
            }
            else
            {
            }
        }
    }
}
