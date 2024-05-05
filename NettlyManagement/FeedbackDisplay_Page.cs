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
        public Feedback_List()
        {
            InitializeComponent();
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
    }
}
