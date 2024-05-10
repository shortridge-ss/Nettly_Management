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

        public User_Dashboard()
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

        private void BtTnHome_Click(object sender, EventArgs e)
        {
            OpenLandingPage();
            this.Close();
        }

        private void BtTnBookNow_Click(object sender, EventArgs e)
        {
            var addBooking = new Add_Booking();
            addBooking.Show();
        }


        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            /*  try
              {
                  // Retrieve the current user's profile based on the logged-in user's ID
                  int loggedInUserId = GetCurrentUserId(); // You need to implement this method to get the current user's ID
                  var userProfile = _dbEntities.UserProfiles.FirstOrDefault(u => u.UserID == loggedInUserId);

                  // Display user profile data in the textboxes
                  if (userProfile != null)
                  {
                      TbFirstName.Text = userProfile.FirstName;
                      TbLastName.Text = userProfile.LastName;
                      TbMobileNum.Text = userProfile.ContactNumber;
                      TbEmail.Text = userProfile.Email;
                  }
                  else
                  {
                      MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }

                  // Load appointments data into the DataGridView
                  LoadAppointmentsData();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }

          private int GetCurrentUserId()
          {
              throw new NotImplementedException();
          }
          */
            //private void LoadAppointmentsData()

            {
                //  int loggedInUserId = GetCurrentUserId();


                

                var appointments = _dbEntities.Appointments
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


            private void BtTnEdit_Click(object sender, EventArgs e)
            {
                if (GvDashboard.SelectedRows.Count > 0)
                {
                    // Get Id of selected row

                    var id = (int)GvDashboard.SelectedRows[0].Cells["Aid"].Value;

                    // Query Database for record

                    var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                    // Launch AddEdit window with data 

                    var editEntry = new Add_Booking(appointInfo);
                    editEntry.MdiParent = this.MdiParent;
                    editEntry.Show();

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

                    // Query Database for record

                    var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                    // Delete entry from table

                    _dbEntities.Appointments.Remove(appointInfo);
                    _dbEntities.SaveChanges();

                    GvDashboard.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

      
    }
    }

