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

        private void PbHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.nettlyBookingDbDataSet.Appointments);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.UserProfiles' table. You can move, or remove it, as needed.
            this.userProfilesTableAdapter.Fill(this.nettlyBookingDbDataSet.UserProfiles);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.nettlyBookingDbDataSet.Feedback);
            //select * from userprofiles
            var nettlyUsersProfiles = _dbEntities.UserProfiles.ToList();
            GvAdminPage.AutoGenerateColumns = false;
            // Remove ID column if it exists
            if (GvAdminPage.Columns.Contains("ID"))
            {
                GvAdminPage.Columns.Remove("UserID");
                GvAdminPage.Columns.Remove("UserProfileID");
            }

            GvAdminPage.DataSource = nettlyUsersProfiles;

            //GvAdminPage.DisplayMember = "FirstName";
            //GvAdminPage.ValueMember = "id";
            //GvAdminPage.DataSource = nettlyUsersProfiles;
        }

        private void BtTnAllbookings_Click(object sender, EventArgs e)
        {
            // Select data from the Appointments table using Entity Framework
            var allAppointments = _dbEntities.Appointments.ToList();

            // Set up DataGridView properties
            GvAdminPage.AutoGenerateColumns = false;

            // Remove ID column if it exists
            if (GvAdminPage.Columns.Contains("ID"))
            {
                GvAdminPage.Columns.Remove("ID");
            }

            // Bind the Appointment data to the DataGridView
            GvAdminPage.DataSource = allAppointments;
        }
    }
}
