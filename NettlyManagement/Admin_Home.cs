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
        private readonly NettlyBookingDbEntities nettlyBookingDbEntities;

        public Admin_Page()
        {
            InitializeComponent();

            nettlyBookingDbEntities = new NettlyBookingDbEntities();

        }

        private void PbHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            var UsersList = new nettlyBookingDbEntities.UserProfiles.ToList();
            GvAdminPage.DataSource = UsersList; 
        }
    }
}
