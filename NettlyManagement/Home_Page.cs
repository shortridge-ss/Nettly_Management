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
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();

        }

        private void BtTnSignUp_Click(object sender, EventArgs e)
        {
            var signUpPage = new SignUp_Page();
            signUpPage.Show();
        }

        private void BtTnSignIn_Click(object sender, EventArgs e)
        {
            var loginPage = new Login_page();
            loginPage.Show();
        }

        private void AddBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add_Booking = new Add_Booking();
            add_Booking.Show();
        }

        private void ViewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewBooking = new User_Dashboard();
            viewBooking.Show();
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var giveFeedback = new AddFeedback();
            giveFeedback.Show();
        }

        private void viewFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DisplayFeedback = new Feedback_List();
            DisplayFeedback.Show();
        }

        private void adminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminHome = new Admin_Page();
            adminHome.Show();
        }
    }
}
