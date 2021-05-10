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
    public partial class DeletePassControl : UserControl
    {
        public DeletePassControl()
        {
            InitializeComponent();
        }

        private void ShowAllPassButton_Click(object sender, EventArgs e)
        {
            DeletePassView.Rows.Clear();
            string[] lines = File.ReadAllLines($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt");
            string[] lineSplit;
            for (int i = 0; i < lines.Length; i++)
            {
                lineSplit = lines[i].Split(",");
                DeletePassView.Rows.Add(new object[] { lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3] });
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.DeletePassView.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    File.WriteAllText($@"C:\Users\njusp\OneDrive - Vilniaus kolegija\2 kursas\Informacijos Saugumas\PswControlSystem\Users\{LogInControl.loggedInUsername}.txt", "");
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                }
            }
            else
            {
                MessageBox.Show("Select ROW first");
            }
        }
    }
}
