using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private bool isEditMode;
        private string _roleName;
        private readonly NettlyBookingDbEntities1 _dbEntities;

        public Add_Booking()
        {
            InitializeComponent();
            LbHeading.Text = "Add Booking";
            this.Text = "Add Booking";
            isEditMode = false;
            _dbEntities = new NettlyBookingDbEntities1();
        }

        public Add_Booking(Appointment appointInfo)
        {
            InitializeComponent();
            LbHeading.Text = "Edit Appointment";
            this.Text = "Edit Booking";
            isEditMode = true;
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

        private void BtTnSave_Click(object sender, EventArgs e, DateTimePicker DtP_EndTime, TimeSpan? Etext, DateTimePicker dtP_StartTime, TimeSpan? Stext)
        {
            try
            {
                // Check if user is logged in
                if (_roleName != "Admin")
                {
                    MessageBox.Show("Please sign in with authorized credentials");
                    return; // Stop execution if not logged in
                }

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
                    var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                    appointInfo.AppointmentName = TbBookingName.Text;
                    appointInfo.AppointmentDate = McDatePicker.SelectionStart;
                    appointInfo.StartTime = DtP_StartTime.Value.TimeOfDay;
                    appointInfo.EndTime = DtP_EndTime.Value.TimeOfDay;
                    appointInfo.Details = TbAppDetails.Text;

                    _dbEntities.SaveChanges();

                    MessageBox.Show("Appointment updated successfully");
                }
                else
                {
                    MessageBox.Show("Please use the 'Book Now' button to make a new booking.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if user is logged in
                if (_roleName == "Admin")
                {
                    // Add new appointment
                    var newBooking = new Appointment
                    {
                        AppointmentName = TbBookingName.Text,
                        AppointmentDate = McDatePicker.SelectionStart,
                        StartTime = DtP_StartTime.Value.TimeOfDay,
                        EndTime = DtP_EndTime.Value.TimeOfDay,
                        Details = TbAppDetails.Text
                    };

                    _dbEntities.Appointments.Add(newBooking);
                    _dbEntities.SaveChanges();

                    MessageBox.Show("Appointment booked successfully");
                }
                else
                {
                    MessageBox.Show("Please sign in with authorized credentials to make a booking.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while booking the appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*if (_roleName != "Admin")
        {
            MessageBox.Show("Please sign in with authorized credentials");
        }
        if (isEditMode)
        {
            //edit code
            var id = int.Parse(LbId.Text);
            var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

            appointInfo.AppointmentName = TbBookingName.Text;
            DateTime? appointmentDate = appointInfo.AppointmentDate;
            appointInfo.AppointmentDate = McDatePicker.SelectionStart;
            appointInfo.StartTime = (TimeSpan)Stext;
            appointInfo.EndTime = (TimeSpan)Etext;
            appointInfo.Details = TbAppDetails.Text;

            _dbEntities.SaveChanges();
        }
        else
        {
            // add code
            var newBooking = new Appointment
            {
                AppointmentName = TbBookingName.Text,
                AppointmentDate = McDatePicker.SelectionStart,
                StartTime = DtP_StartTime.Value.TimeOfDay,
                EndTime = DtP_EndTime.Value.TimeOfDay,
                Details = TbAppDetails.Text

            };
            _dbEntities.Appointments.Add(newBooking);
            _dbEntities.SaveChanges();
        }

    }

    }*/
    }
    }



