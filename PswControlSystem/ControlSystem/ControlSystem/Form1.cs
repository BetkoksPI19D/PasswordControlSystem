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
    }
}
