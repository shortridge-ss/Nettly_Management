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
    public partial class AddFeedback : Form
    {
        public AddFeedback()
        {
            InitializeComponent();
        }

        private void PbHome_Click(object sender, EventArgs e)
        {
            var homePage = new Landing_Page();
            homePage.Show();
        }
    }
}
