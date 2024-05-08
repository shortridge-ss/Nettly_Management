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
        private Login_page _login;
        private User _user;
        public string _roleName;

        public Login_page Login_page { get; }
        public User User { get; }

        public Landing_Page(Login_page login_page, string roleName)
        {
            InitializeComponent();
            _login = login_page;
            _roleName = roleName;
        }

        public Landing_Page(Login_page login, User user)
        {
            InitializeComponent();
            _login = login; 
            _user = user;
            _roleName = user.Roles.FirstOrDefault().RoleName;
        }

        public Landing_Page(User user)
        {
            _roleName = user.Roles.FirstOrDefault()?.RoleName; // Extract roleName from user.Roles
        }

        public Landing_Page()
        {
        }

        private void BtTnSignUp_Click(object sender, EventArgs e)
        {
            //if(!Utils.FormIsOpen("SignUp_Page"))
            var signUpPage = new SignUp_Page();
            //signUpPage.Mdiparent = this;
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
            if ((_roleName != "Admin" && _roleName != "User"))
            {
                //adminHomeToolStripMenuItem.Enabled = false;
                MessageBox.Show("Please sign in with authorized credentials");
            }
            else
            { 
                var viewBooking = new User_Dashboard();
            viewBooking.Show();
            }
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
            if (_roleName != "Admin")
            {
                MessageBox.Show("Please sign in with authorized credentials");
            }
            else
            {
                var adminHome = new Admin_Page();
                adminHome.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Landing_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create a copy of the Forms collection to avoid modifying it while iterating
            var formsToClose = Application.OpenForms.Cast<Form>().ToList();

            // Close all forms except the current landing page
            foreach (var form in formsToClose)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            // Stop the application
            Application.Exit();
        }

        private void adminSignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_roleName != "Admin")
            {
                MessageBox.Show("Please sign in with authorized credentials");
            }
            else
            { 
                var addStaff = new AddStaff();
                addStaff.MdiParent = this.MdiParent;
                addStaff.Show();
                
            }
        }
    }
}
