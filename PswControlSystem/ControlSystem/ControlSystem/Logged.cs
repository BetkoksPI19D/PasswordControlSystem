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
    public partial class Logged : Form
    {
        public Logged()
        {
            InitializeComponent();
        }

        private void NewPassButton_Click(object sender, EventArgs e)
        {
            PasswControlPanel.Controls.Clear();
            NewPassControl npc = new NewPassControl();
            PasswControlPanel.Controls.Add(npc);
        }

        private void UpdatePassButton_Click(object sender, EventArgs e)
        {
            PasswControlPanel.Controls.Clear();
            UpdatePassControl upc = new UpdatePassControl();
            PasswControlPanel.Controls.Add(upc);
        }

        private void FindPassButton_Click(object sender, EventArgs e)
        {
            PasswControlPanel.Controls.Clear();
            FindPassControl fpc = new FindPassControl();
            PasswControlPanel.Controls.Add(fpc);
        }

        private void DeletePassButton_Click(object sender, EventArgs e)
        {
            PasswControlPanel.Controls.Clear();
            DeletePassControl dpc = new DeletePassControl();
            PasswControlPanel.Controls.Add(dpc);
        }

    }
}
