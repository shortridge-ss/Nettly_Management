using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NettlyManagement
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void lLbSingIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUp = new SignUp_Page();
            signUp.ShowDialog();
        }
    }
}
