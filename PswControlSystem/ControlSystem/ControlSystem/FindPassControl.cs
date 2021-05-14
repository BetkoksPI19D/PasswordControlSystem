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
        Encryption decr = new Encryption();
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
                FindPswView.Rows.Add(new object[] { lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3]});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.FindPswView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(this.FindPswView.GetClipboardContent());
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

        private void ShowByNameButton_Click(object sender, EventArgs e)
        {
            //int selectedrowindex = FindPswView.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = FindPswView.Rows[selectedrowindex];

           // string usernameInGridView = selectedRow.Cells[0].Value.ToString();

            string username = UsernameBox.Text;

            if (username == "" || username == " ")
            {
                MessageBox.Show("Type your username in text box");
            }
            else
            {
                FindPswView.Rows.Clear();
                List<string> lines = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt").ToList();
                string[] lineSplit;
                for (int i = 0; i < lines.Count; i++)
                {
                    int unameL = username.Length;
                    string str = lines[i].Substring(0, unameL);
                    if (str.Contains(username))
                    {
                        lineSplit = lines[i].Split(",");
                        FindPswView.Rows.Add(new object[] { lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3] });
                    }
                }
            }
        }

        private void ShowPassBox_CheckedChanged(object sender, EventArgs e)
        {
            int selectedrowindex = FindPswView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = FindPswView.Rows[selectedrowindex];

            string pass = selectedRow.Cells[1].Value.ToString();
            if (this.FindPswView.GetCellCount(DataGridViewElementStates.Selected) > 0)
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

        //private void FindPswView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var sGrid = (DataGridView)sender;
        //    if(sGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 )
        //    {
        //        DataGridViewButtonColumn butn = FindPswView.Rows[e.RowIndex].Cells[1] as DataGridViewButtonCell;

        //        CheckBox cb = (CheckBox)butn.Value;
        //    }
        //}
    }
}
