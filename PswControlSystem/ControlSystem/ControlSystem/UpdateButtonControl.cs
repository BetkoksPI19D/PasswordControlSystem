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
    public partial class UpdateButtonControl : UserControl
    {
        Encryption encr = new Encryption();
        public UpdateButtonControl()
        {
            InitializeComponent();
        }

        private void DoneUpdateButton_Click(object sender, EventArgs e)
        {
            string psw1 = NewPassBox.Text;
            string psw2 = NewPassConfirmBox.Text;
            if (psw1 != psw2)
            {
                MessageBox.Show("Passwords should match!");
            }
            else
            {
                string newpsw = encr.Encrypt(psw1, "asd", true);
            }
        }
    }
}
