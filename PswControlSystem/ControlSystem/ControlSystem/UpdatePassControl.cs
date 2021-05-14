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
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.ShowPassView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    string npsw = NewPassBox.Text;
                    
                    int selectedrowindex = ShowPassView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = ShowPassView.Rows[selectedrowindex];

                    List<string> lines = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt").ToList();
                    int index = 0;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string username = selectedRow.Cells[0].Value.ToString();
                        string pass = selectedRow.Cells[1].Value.ToString();
                        string url = selectedRow.Cells[2].Value.ToString();
                        string comm = selectedRow.Cells[3].Value.ToString();
                        int unameL = username.Length;
                        string str = lines[i].Substring(0, unameL);
                        if (str.Contains(username))
                        {
                            File.Delete($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
                            String un = "\n" + username + ",";
                            String p = decr.Encrypt(npsw, "asd", true) + ",";
                            String u = url + ",";
                            String c = comm + "\n";
                            var con = String.Concat(un, p, u, c);
                            lines.Add(con);
                            index = i;
                            break;
                        }
                    }
                    lines.RemoveAt(index);
                    foreach (string line in lines)
                    {
                        File.AppendAllText($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt", line);
                    }
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                }
            }
            else
            {
                MessageBox.Show("Select USERNAME first to replace a password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ShowPassView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(this.ShowPassView.GetClipboardContent());
                    MessageBox.Show("Copied!");
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

        private void ShowPassBox_CheckedChanged(object sender, EventArgs e)
        {
            int selectedrowindex = ShowPassView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = ShowPassView.Rows[selectedrowindex];

            string pass = selectedRow.Cells[1].Value.ToString();
            if (this.ShowPassView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                if (ShowPassBox.Checked)
                {
                    string showpass = decr.Decrypt(pass, "asd", true);
                    selectedRow.Cells[1].Value = showpass;
                }
                else
                {
                    string hidepass = decr.Encrypt(pass, "asd", true);
                    selectedRow.Cells[1].Value = hidepass;
                }
            }
        }
    }
}
