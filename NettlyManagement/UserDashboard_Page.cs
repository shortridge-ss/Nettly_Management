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
    public partial class User_Dashboard : Form
    {
        private readonly NettlyBookingDbEntities1 _dbEntities;

        private int _userID;

        private Login_page _login;

        public string _roleName;

        public User_Dashboard(Login_page login, string RoleName, int UserID)
        {
            InitializeComponent();
            _login = login;
            _roleName = RoleName;
            _userID = UserID;
            _dbEntities = new NettlyBookingDbEntities1();
        }



        private void OpenLandingPage()
        {
            // Check if Landing_Page is already open
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Landing_Page)
                {
                    openForm.BringToFront();
                    return;
                }
            }

            // Landing_Page is not open, create a new instance and show it
            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void PbHome_Click(object sender, EventArgs e)
        {
            OpenLandingPage();
        }

        private void BtTnHome_Click(object sender, EventArgs e)
        {
            OpenLandingPage();
            this.Close();
        }

        private void BtTnBookNow_Click(object sender, EventArgs e)
        {
            var addBooking = new Add_Booking(_login, _userID);
            addBooking.Show();
        }


        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int loggedInUserId = GetCurrentUserId(); // Get the ID of the logged-in user
                var userProfile = _dbEntities.UserProfiles.FirstOrDefault(u => u.UserID == loggedInUserId); // Fetch user profile

                if (userProfile != null)
                {
                    // Populate user information fields with user profile data
                    TbFirstName.Text = userProfile.FirstName;
                    TbLastName.Text = userProfile.LastName;
                    TbMobileNum.Text = userProfile.ContactNumber;
                    TbEmail.Text = userProfile.Email;
                }
                else
                {
                    MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PopulateGrid(); // Load appointments data into the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCurrentUserId()
        {
            // Return the ID of the logged-in user
            return _userID;



        }


        private void BtTnEdit_Click(object sender, EventArgs e)
        {
            if (GvDashboard.SelectedRows.Count > 0)
            {
                // Get Id of selected row

                var id = (int)GvDashboard.SelectedRows[0].Cells["Aid"].Value;

                // Query Database for record

                var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                // Launch AddEdit window with data 

                var editEntry = new Add_Booking(appointInfo, _login, _userID );
                editEntry.MdiParent = this.MdiParent;
                editEntry.Show();
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void BtTnDelete_Click(object sender, EventArgs e)
        {
            if (GvDashboard.SelectedRows.Count > 0)
            {
                // Get Id of selected row
                var id = (int)GvDashboard.SelectedRows[0].Cells["Aid"].Value;
                try
                {
                    // Query Database for record

                    var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                    // Delete entry from table

                    _dbEntities.Appointments.Remove(appointInfo);
                    _dbEntities.SaveChanges();

                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PopulateGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void PopulateGrid()
        {
            int loggedInUserId = GetCurrentUserId(); // Get the ID of the logged-in user

             var appointments = _dbEntities.Appointments
                .Where(a => a.UserID == loggedInUserId)
                .Select(A => new
               {
                   AName = A.AppointmentName,
                   ADate = A.AppointmentDate,
                   Stime = A.StartTime,
                   Etime = A.EndTime,
                   Status = A.Status,
                   Aid = A.AppointmentID,
                   Uid = A.UserID
               }).ToList();


            GvDashboard.DataSource = appointments;
            GvDashboard.Columns[0].HeaderText = "Appointmant Name";
            GvDashboard.Columns[1].HeaderText = "Appointmant Date";
            GvDashboard.Columns[2].HeaderText = "Start Period";
            GvDashboard.Columns[3].HeaderText = "End Period";
            GvDashboard.Columns[5].Visible = false;
            GvDashboard.Columns[6].Visible = false;

        }
    }
}




