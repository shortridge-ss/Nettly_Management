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
        private readonly NettlyBookingDbEntities1 _dbEntities;

        public Add_Booking()
        {
            InitializeComponent();
            LbHeading.Text = "Add Booking";
            isEditMode = false;
            _dbEntities = new NettlyBookingDbEntities1();
        }

        public Add_Booking(Appointment appointInfo)
        {
            InitializeComponent();
            LbHeading.Text = "Edit Appointment";
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

        private void PbHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
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
            if (isEditMode)
            {
                //edit code
                var id = int.Parse(LbId.Text);
                var appointInfo = _dbEntities.Appointments.FirstOrDefault(A => A.AppointmentID == id);

                appointInfo.AppointmentName = TbBookingName.Text;
                DateTime? appointmentDate = appointInfo.AppointmentDate;
                appointInfo.AppointmentDate = McDatePicker.SelectionStart;
                appointInfo.StartTime =Stext;
                appointInfo.EndTime =Etext;
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
        
        }
    }

