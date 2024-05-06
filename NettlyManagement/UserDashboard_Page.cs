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

        private void PbHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void BtTnHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void BtTnBookNow_Click(object sender, EventArgs e)
        {
            var addBooking = new Add_Booking();
            addBooking.Show();
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            var appointments = _dbEntities.Appointments
                .Select( A => new 
                { ADate = A.AppointmentDate,
                Stime = A.StartTime,
                Etime = A.EndTime,
                Status = A.Status,
                Aid = A.AppointmentID,
                Uid = A.UserID
                }).ToList();

            GvDashboard.DataSource = appointments;
            GvDashboard.Columns[0].HeaderText = "Appointmant Date";
            GvDashboard.Columns[1].HeaderText = "Start Period";
            GvDashboard.Columns[2].HeaderText = "End Period";
            GvDashboard.Columns[4].Visible = false;
            GvDashboard.Columns[5].Visible = false;
        }
    }
}
