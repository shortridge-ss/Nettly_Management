using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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
        public AddFeedback(Login_page login, string RoleName, int UserID)
        {
            InitializeComponent();
            _login = login;
            _roleName = RoleName;
            _userID = UserID;
            _dbEntities = new NettlyBookingDbEntities1();
            // Call the LoadRatingOptions method when the form is loaded
            this.Load += AddFeedback_Load;

        }


        private void AddFeedback_Load(object sender, EventArgs e)
        {
            // Load rating options from the database and populate the CheckedListBox
            LoadRatingOptions();
        }
        public AddFeedback()
        {
            InitializeComponent();
            
            _dbEntities = new NettlyBookingDbEntities1 ();
        }

        private void LoadRatingOptions()
        {
            try
            {
                using (var dbEntities = new NettlyBookingDbEntities1())
                {
                    var ratingOptions = dbEntities.RatingOptions.ToList();
                    foreach (var option in ratingOptions)
                    {
                        // Add rating options to the CheckedListBox
                        ChLbRatingOptions.Items.Add(option.OptionName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading rating options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Get the selected rating options
            List<string> selectedOptions = new List<string>();
            foreach (var item in ChLbRatingOptions.CheckedItems)
            {
                selectedOptions.Add(item.ToString());
            }

            // Get the comments
            var comments = TbReview.Text;

            // Insert the feedback into the database
            try
            {
                using (var dbEntities = new NettlyBookingDbEntities1())
                {
                    Feedback feedback = new Feedback
                    {
                        UserID = _userID, 
                        Comments = comments,
                        RatingOptionID = GetSelectedRatingOptionID(selectedOptions),
                        DateSubmitted = DateTime.Now // Current date and time
                    };

                    dbEntities.Feedbacks.Add(feedback);
                    dbEntities.SaveChanges();

                    MessageBox.Show("Feedback submitted successfully");
                    this.Close();
                }
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                    }
                }

                MessageBox.Show($"Validation errors occurred:\n{sb.ToString()}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int? GetSelectedRatingOptionID(List<string> selectedOptions)
        {
            try
            {
                using (var dbEntities = new NettlyBookingDbEntities1())
                {
                    foreach (var optionName in selectedOptions)
                    {
                        var option = dbEntities.RatingOptions.FirstOrDefault(o => o.OptionName == optionName);
                        if (option != null)
                        {
                            return option.RatingOptionID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the selected rating option: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void BtTnBack_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
    }

