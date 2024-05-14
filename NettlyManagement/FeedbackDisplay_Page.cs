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
    public partial class Feedback_List : Form
    {
        private int _userID;

        private readonly NettlyBookingDbEntities1 _dbEntities;

        private Login_page _login;

        private string _roleName;


        public Feedback_List(Login_page login, string RoleName, int UserID)
        {
            InitializeComponent();
            _login = login;
            _roleName = RoleName;
            _userID = UserID;
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

        private void BtTnCreateFeedback_Click(object sender, EventArgs e)
        {
            var newFeedback = new AddFeedback(_login, _roleName, _userID);
            newFeedback.Show();
        }

        private void Feedback_List_Load(object sender, EventArgs e)
        {
            var feedback = _dbEntities.Feedbacks
                .Select( F => new { Comments = F.Comments, Ratings = F.RatingOption.OptionName, DateSubmitted = F.DateSubmitted } )
                .ToList();
            GvFeedback.DataSource = feedback;
            GvFeedback.Columns[2].HeaderText = "Date Submitted";
        }

        private void BtTnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
