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
 

    public partial class Admin_Page : Form
    

    {
        private readonly NettlyBookingDbEntities1 _dbEntities;
        public Admin_Page()
        {
            InitializeComponent();
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

        private void Admin_Page_Load(object sender, EventArgs e)
        {
   /*         // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.nettlyBookingDbDataSet.Appointments);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.UserProfiles' table. You can move, or remove it, as needed.
            this.userProfilesTableAdapter.Fill(this.nettlyBookingDbDataSet.UserProfiles);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.nettlyBookingDbDataSet.Feedback);
            //select * from userprofiles
        */        var nettlyUsersProfiles = _dbEntities.UserProfiles
                    .Select( UsPro => new 
                    {
                        FirstName = UsPro.FirstName,
                        LastName = UsPro.LastName,
                        PhoneNumber = UsPro.ContactNumber,
                        Email = UsPro.Email,
                        Address = UsPro.Address,
                        UserName = UsPro.User.Username, // Accessing Username through the navigation property
                        UpId = UsPro.UserProfileID,
                        UiD = UsPro.UserID
                    }).ToList();

            GvAdminPage.DataSource = nettlyUsersProfiles;
            GvAdminPage.Columns[0].HeaderText = "First Name";
            GvAdminPage.Columns[1].HeaderText = "Last Name";
            GvAdminPage.Columns[2].HeaderText = "Contact Number";
            GvAdminPage.Columns[3].HeaderText = "Email";
            GvAdminPage.Columns[4].HeaderText = "Address";
            GvAdminPage.Columns[5].HeaderText = "User name"; // Set the header text for the Username column
            GvAdminPage.Columns[6].Visible = false;
            GvAdminPage.Columns[7].Visible = false;
        }


        private void BtTnAddEntry_Click(object sender, EventArgs e)
        {
            var addEntry = new SignUp_Page();
            addEntry.MdiParent = this.MdiParent;    
            addEntry.Show();

        }

        private void BtTnEditEntry_Click(object sender, EventArgs e)
        {
            if (GvAdminPage.SelectedRows.Count > 0)
            { 
            // Get Id of selected row
            
            var id =  (int) GvAdminPage.SelectedRows[0].Cells["UpID"].Value;

            // Query Database for record

            var userInfo = _dbEntities.UserProfiles.FirstOrDefault( UsPro => UsPro.UserProfileID == id );
           
            // Launch AddEdit window with data 
            
            var editEntry = new AddEdit_Window(userInfo);
            editEntry.MdiParent = this.MdiParent;
            editEntry.Show();

            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtTnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (GvAdminPage.SelectedRows.Count > 0)
            {
                // Get Id of selected row
                var id = (int)GvAdminPage.SelectedRows[0].Cells["UpId"].Value;

                try
                {
                    // Query Database for record
                    var userInfo = _dbEntities.UserProfiles.FirstOrDefault(UsPro => UsPro.UserProfileID == id);

                    // Delete entry from table
                    _dbEntities.UserProfiles.Remove(userInfo);
                    _dbEntities.SaveChanges();

                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the grid
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

        private void BtTnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the grid
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var nettlyUsersProfiles = _dbEntities.UserProfiles
                .Select(UsPro => new
                {
                    FirstName = UsPro.FirstName,
                    LastName = UsPro.LastName,
                    PhoneNumber = UsPro.ContactNumber,
                    Email = UsPro.Email,
                    Address = UsPro.Address,
                    UserName = UsPro.User.Username, // Accessing Username through the navigation property
                    UpId = UsPro.UserProfileID,
                    UiD = UsPro.UserID
                }).ToList();

            GvAdminPage.DataSource = nettlyUsersProfiles;
            GvAdminPage.Columns[0].HeaderText = "First Name";
            GvAdminPage.Columns[1].HeaderText = "Last Name";
            GvAdminPage.Columns[2].HeaderText = "Contact Number";
            GvAdminPage.Columns[3].HeaderText = "Email";
            GvAdminPage.Columns[4].HeaderText = "Address";
            GvAdminPage.Columns[5].HeaderText = "User name"; // Set the header text for the Username column
            GvAdminPage.Columns[6].Visible = false;
            GvAdminPage.Columns[7].Visible = false;
        }

       

        private void BtTnAllBookings_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Select data from the Appointments table using Entity Framework
                var allAppointments = _dbEntities.Appointments
                    .Select(Aa => new
                    {
                        UName = Aa.User.Username.ToString(),
                        AName = Aa.AppointmentName,
                        ADate = Aa.AppointmentDate,
                        Stime = Aa.StartTime,
                        Etime = Aa.EndTime,
                        Status = Aa.Status,
                        Aid = Aa.AppointmentID,
                        Uid = Aa.UserID
                    }).ToList();
                GvAdminPage.DataSource = allAppointments;
                GvAdminPage.Columns[0].HeaderText = "User Name";
                GvAdminPage.Columns[1].HeaderText = "Appointmant Name";
                GvAdminPage.Columns[2].HeaderText = "Appointmant Date";
                GvAdminPage.Columns[3].HeaderText = "Start Period";
                GvAdminPage.Columns[4].HeaderText = "End Period";
                GvAdminPage.Columns[6].Visible = false;
                GvAdminPage.Columns[7].Visible = false;

                // Set up DataGridView properties
                GvAdminPage.AutoGenerateColumns = true;

                // Bind the Appointment data to the DataGridView
                GvAdminPage.DataSource = allAppointments;

                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTnAllCredentials_Click(object sender, EventArgs e)
        {
            try
            {
                // Select data from the Users table using Entity Framework
                var allUsers = _dbEntities.Users
                    .Select(Au => new
                    {
                        UName = Au.Username,
                        Email = Au.Email,
                        Cnum = Au.ContactNumber,
                        Status = Au.Status,
                        Password = Au.Password,
                        Uid = Au.UserID
                    }).ToList();
                GvAdminPage.DataSource = allUsers;
                GvAdminPage.Columns[0].HeaderText = "User Name";
                GvAdminPage.Columns[2].HeaderText = "Contact Number";
                
                GvAdminPage.Columns[4].HeaderText = "Encrypted Password";
                
                GvAdminPage.Columns[5].Visible = false;
                //GvAdminPage.Columns[7].Visible = false;
                    
                    
                // Set up DataGridView properties
                GvAdminPage.AutoGenerateColumns = true;

                // Bind the User data to the DataGridView
                GvAdminPage.DataSource = allUsers;

                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Encryption method for password
        private string EncryptPassword(string password)
        {
            // Implement your encryption logic here
            // For example, you can use hashing algorithms like SHA256 or encryption libraries like AES
            // Ensure to use a secure encryption method and never store plaintext passwords
            return "EncryptedValue"; // Replace with actual encryption result
        }

        private void BtTnAllUsers_Click(object sender, EventArgs e)
        {
            try
            {
                // Select data from the Appointments table using Entity Framework
                var nettlyUsersProfiles = _dbEntities.UserProfiles
                    .Select(UsPro => new
                    {
                        FirstName = UsPro.FirstName,
                        LastName = UsPro.LastName,
                        PhoneNumber = UsPro.ContactNumber,
                        Email = UsPro.Email,
                        Address = UsPro.Address,
                        UserName = UsPro.User.Username, // Accessing Username through the navigation property
                        UpId = UsPro.UserProfileID,
                        UiD = UsPro.UserID
                    }).ToList();

                GvAdminPage.DataSource = nettlyUsersProfiles;
                GvAdminPage.Columns[0].HeaderText = "First Name";
                GvAdminPage.Columns[1].HeaderText = "Last Name";
                GvAdminPage.Columns[2].HeaderText = "Contact Number";
                GvAdminPage.Columns[3].HeaderText = "Email";
                GvAdminPage.Columns[4].HeaderText = "Address";
                GvAdminPage.Columns[5].HeaderText = "User name"; // Set the header text for the Username column
                GvAdminPage.Columns[6].Visible = false;
                GvAdminPage.Columns[7].Visible = false;
            

                // Set up DataGridView properties
                GvAdminPage.AutoGenerateColumns = true;

                // Bind the Appointment data to the DataGridView
                GvAdminPage.DataSource = nettlyUsersProfiles;

                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTnAllFeedback_Click(object sender, EventArgs e)
        {
            try 
            { 
            // Select data from the Appointments table using Entity Framework
            var allFeedback = _dbEntities.Feedbacks
                .Select(Af => new
                {
                    UName = Af.User.Username.ToString(),
                    fDetails = Af.Comments,
                    fRatings = Af.Rating,
                    fDate = Af.DateSubmitted,
                    fId = Af.FeedbackID,
                    UiD = Af.UserID

                }).ToList();
            GvAdminPage.DataSource = allFeedback;
            GvAdminPage.Columns[0].HeaderText = "User Name";
            GvAdminPage.Columns[1].HeaderText = "Comments";
            GvAdminPage.Columns[2].HeaderText = "Rating 1 - 10";
            GvAdminPage.Columns[3].HeaderText = "Date Submitted";
            
            GvAdminPage.Columns[4].Visible = false;
            GvAdminPage.Columns[5].Visible = false;

            // Set up DataGridView properties
            GvAdminPage.AutoGenerateColumns = true;

            // Bind the Appointment data to the DataGridView
            GvAdminPage.DataSource = allFeedback;

                // ...
            }
        
         catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
