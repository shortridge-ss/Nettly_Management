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
   /*         // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.nettlyBookingDbDataSet.Appointments);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.UserProfiles' table. You can move, or remove it, as needed.
            this.userProfilesTableAdapter.Fill(this.nettlyBookingDbDataSet.UserProfiles);
            // TODO: This line of code loads data into the 'nettlyBookingDbDataSet.Feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter.Fill(this.nettlyBookingDbDataSet.Feedback);
            //select * from userprofiles
        */        var nettlyUsersProfiles = _dbEntities.UserProfiles
                    .Select( UsPro => new 
                    { FirstName = UsPro.FirstName,
                        LastName = UsPro.LastName,
                        PhoneNumber = UsPro.ContactNumber,
                        Email = UsPro.Email,
                        Address = UsPro.Address,
                        UpId = UsPro.UserProfileID,
                        UiD = UsPro.UserID  }
                    ).ToList();
         
            GvAdminPage.DataSource = nettlyUsersProfiles;
            GvAdminPage.Columns[0].HeaderText = "First Name";
            GvAdminPage.Columns[1].HeaderText = "Last Name";
            GvAdminPage.Columns[2].HeaderText = "Contact Number";
            GvAdminPage.Columns[5].Visible = false;
            GvAdminPage.Columns[6].Visible = false;
        }

        private void BtTnAllbookings_Click(object sender, EventArgs e)
        {
            // Select data from the Appointments table using Entity Framework
            var allAppointments = _dbEntities.Appointments.ToList();

            // Set up DataGridView properties
            GvAdminPage.AutoGenerateColumns = true;

            // Bind the Appointment data to the DataGridView
            GvAdminPage.DataSource = allAppointments;
        }

        private void BtTnAddEntry_Click(object sender, EventArgs e)
        {
            var addEntry = new AddEdit_Window();
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
            
            var addEntry = new AddEdit_Window(userInfo);
            addEntry.MdiParent = this.MdiParent;
            addEntry.Show();

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
                var id = (int)GvAdminPage.SelectedRows[0].Cells["UpID"].Value;

                // Query Database for record

                var userInfo = _dbEntities.UserProfiles.FirstOrDefault(UsPro => UsPro.UserProfileID == id);

                // Delete entry from table

                _dbEntities.UserProfiles.Remove(userInfo);
                _dbEntities.SaveChanges();

                GvAdminPage.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtTnRefresh_Click(object sender, EventArgs e)
        {
            //simple refresh
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
                    UpId = UsPro.UserProfileID,
                    UiD = UsPro.UserID
                }
                ).ToList();
            GvAdminPage.DataSource = nettlyUsersProfiles;
            GvAdminPage.Columns[0].HeaderText = "First Name";
            GvAdminPage.Columns[1].HeaderText = "Last Name";
            GvAdminPage.Columns[2].HeaderText = "Contact Number";
            GvAdminPage.Columns[5].Visible = false;
            GvAdminPage.Columns[6].Visible = false;
        }
    }
}
