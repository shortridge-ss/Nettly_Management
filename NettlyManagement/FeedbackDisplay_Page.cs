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
        private readonly NettlyBookingDbEntities1 _dbEntities;

        public Feedback_List()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();
        }

        private void PbHome_Click(object sender, EventArgs e)
        {

            var homePage = new Landing_Page();
            homePage.Show();
        }

        private void BtTnCreateFeedback_Click(object sender, EventArgs e)
        {
            var newFeedback = new AddFeedback();
            newFeedback.Show();
        }

        private void Feedback_List_Load(object sender, EventArgs e)
        {
            var feedback = _dbEntities.Feedbacks
                .Select( F => new { Comments = F.Comments, Ratings = F.Rating, DateSubmitted = F.DateSubmitted } )
                .ToList();
            GvFeedback.DataSource = feedback;
            GvFeedback.Columns[2].HeaderText = "Date Submitted";
        }
    }
}
