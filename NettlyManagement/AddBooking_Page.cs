using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NettlyManagement
{
    public partial class Add_Booking : Form
    {
        

        private int _userID;
        private readonly NettlyBookingDbEntities1 _dbEntities;

        private Login_page _login;

        private string _roleName;

        

        public Add_Booking(Login_page login, string RoleName, int UserID)
        {
            InitializeComponent();
            LbHeading.Text = "Add Booking";
            this.Text = "Add Booking";
            isEditMode = false;
            _login = login;
            _roleName = RoleName;
            _userID = UserID;
            _dbEntities = new NettlyBookingDbEntities1();
        }
        private bool isEditMode;

        public Add_Booking(Appointment appointInfo, Login_page login, int UserID)
        {
            InitializeComponent();
            LbHeading.Text = "Edit Appointment";
            this.Text = "Edit Booking";
            isEditMode = true;
            

            _dbEntities = new NettlyBookingDbEntities1();
            PopulateFields(appointInfo);




        }

        private void PopulateFields(Appointment appointInfo)
        {
            LbId.Text = appointInfo.AppointmentID.ToString();
            TbBookingName.Text = appointInfo.AppointmentName;
            McDatePicker.BoldedDates = new DateTime[] { (DateTime)appointInfo.AppointmentDate };
            DtP_StartTime.Text = appointInfo.StartTime.ToString();
            DtP_EndTime.Text = appointInfo.EndTime.ToString();
            TbAppDetails.Text = appointInfo.Details;
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
            this.Close();
        }

        private void BtTnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTimePicker GetDtP_EndTime()
        {
            return DtP_EndTime;
        }

        private DateTimePicker GetDtP_StartTime()
        {
            return DtP_StartTime;
        }

        

        private void BtTnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(TbBookingName.Text))
                {
                    MessageBox.Show("Please enter a booking name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop execution if booking name is empty
                }

                if (McDatePicker.SelectionStart < DateTime.Now.Date)
                {
                    MessageBox.Show("Appointment date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop execution if appointment date is in the past
                }

                if (DtP_StartTime.Value.TimeOfDay >= DtP_EndTime.Value.TimeOfDay)
                {
                    MessageBox.Show("End time must be after start time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop execution if end time is not after start time
                }

                // Other booking logic...
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }

                MessageBox.Show($"Validation errors occurred:\n{sb.ToString()}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                var appointmentName = TbBookingName.Text;
                var appointmentDate = McDatePicker.SelectionStart;
                var StartTime = DtP_StartTime.Value.TimeOfDay;
                var endTime = DtP_EndTime.Value.TimeOfDay;
                var Details = TbAppDetails.Text;
                var UserID = _userID;

                {

                    using (var dbEntities = new NettlyBookingDbEntities1())
                    {

                        // Add new appointment
                        Appointment newBooking = new Appointment
                        {
                            AppointmentName = appointmentName,
                            AppointmentDate = appointmentDate,
                            StartTime = StartTime,
                            EndTime = endTime,
                            Details = Details,
                            UserID = UserID

                        };

                        _dbEntities.Appointments.Add(newBooking);
                        _dbEntities.SaveChanges();

                        MessageBox.Show("Appointment booked successfully");
                        this.Close();
                    }

                }
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }

                MessageBox.Show($"Validation errors occurred:\n{sb.ToString()}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            

        private void BtTnSave_Click_1(object sender, EventArgs e)
            {
                try
                {
                    

                    // Validate input fields
                      if (string.IsNullOrWhiteSpace(TbBookingName.Text))
                      {
                          MessageBox.Show("Please enter a booking name");
                          return; // Stop execution if booking name is empty
                      }

                      if (McDatePicker.SelectionStart < DateTime.Now.Date)
                      {
                          MessageBox.Show("Appointment date cannot be in the past");
                          return; // Stop execution if appointment date is in the past
                      }

                      if (DtP_StartTime.Value.TimeOfDay >= DtP_EndTime.Value.TimeOfDay)
                      {
                          MessageBox.Show("End time must be after start time");
                          return; // Stop execution if end time is not after start time
                      }   

                    // Save appointment
                    if (isEditMode)
                    {
                        // Edit appointment
                        var id = int.Parse(LbId.Text);
                        var newBooking = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                        newBooking.AppointmentName = TbBookingName.Text;
                        newBooking.AppointmentDate = McDatePicker.SelectionStart;
                        newBooking.StartTime = DtP_StartTime.Value.TimeOfDay;
                        newBooking.EndTime = DtP_EndTime.Value.TimeOfDay;
                        newBooking.Details = TbAppDetails.Text;

                        _dbEntities.Appointments.AddOrUpdate(newBooking);
                        _dbEntities.SaveChanges();

                        MessageBox.Show("Appointment updated successfully");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please use the 'Book Now' button to make a new booking.");
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            sb.AppendLine($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                        }
                    }

                    MessageBox.Show($"Validation errors occurred:\n{sb.ToString()}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }





