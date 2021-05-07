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
    public partial class UpdatePassControl : UserControl
    {
        Encryption decr = new Encryption();
        public UpdatePassControl()
        {
            InitializeComponent();
        }

        private void ShowAllPassButton_Click(object sender, EventArgs e)
        {
            ShowPassView.Rows.Clear();
            string[] lines = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
            string[] lineSplit;
            for (int i = 0; i < lines.Length; i++)
            {
                lineSplit = lines[i].Split(",");
                ShowPassView.Rows.Add(new object[] { lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3] });
                if (ShowPassBox.Checked)
                {

                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ControllerForUpdatePass.Controls.Clear();
            UpdateButtonControl ubc = new UpdateButtonControl();
            ControllerForUpdatePass.Controls.Add(ubc);
        }
    }
}
