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
        
        private int _userID; // Field to store the UserID

        private readonly NettlyBookingDbEntities1 _dbEntities;

        private Login_page _login;

       // public AddFeedback(int userID) // Constructor to receive the UserID

        public string _roleName;
        public AddFeedback()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();
            
        }

        public AddFeedback(Login_page login, string RoleName, int userID)
        {
            InitializeComponent();
            _login = login;
            _roleName = RoleName;
            _userID = userID; // Store the UserID
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

        private void BtTnSubmit_Click(object sender, EventArgs e)
        {
            if (_roleName != "User")
            {
                MessageBox.Show("Please sign in with authorized credentials");
            }

            // Get the selected rating
            int rating = 0;
            foreach (Control control in Controls)
            {
                if (control is Button ratingButton && ratingButton.Name.StartsWith("BtTnRating"))
                {
                    if (ratingButton.Text == "1" || ratingButton.Text == "2" || ratingButton.Text == "3" ||
                        ratingButton.Text == "4" || ratingButton.Text == "5" || ratingButton.Text == "6" ||
                        ratingButton.Text == "7" || ratingButton.Text == "8" || ratingButton.Text == "9" ||
                        ratingButton.Text == "10")
                    {
                        rating = int.Parse(ratingButton.Text);
                        break;
                    }
                }
            }

            // Get the comments
            string comments = TbReview.Text;

            // Insert the feedback into the database
            try
            {
                using (var dbEntities = new NettlyBookingDbEntities1())
                {
                    Feedback feedback = new Feedback
                    {
                        UserID = _userID, // Assuming you have stored the UserID of the logged-in user
                        Comments = comments,
                        Rating = rating,
                        DateSubmitted = DateTime.Now // Current date and time
                    };

                    dbEntities.Feedbacks.Add(feedback);
                    dbEntities.SaveChanges();

                    MessageBox.Show("Feedback submitted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

