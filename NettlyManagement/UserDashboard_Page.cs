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
        public User_Dashboard()
        {
            InitializeComponent();
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
    }
}
