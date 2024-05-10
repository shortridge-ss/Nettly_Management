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
    public partial class AddEdit_Window : Form
    {
        private bool isEditMode;
        private readonly NettlyBookingDbEntities1 _dbEntities;

        public AddEdit_Window()
        {
            InitializeComponent();
            LbHeading.Text = "Add New User";
            this.Text = "Add User";
            isEditMode = false;
            _dbEntities = new NettlyBookingDbEntities1();
        }

        public AddEdit_Window(UserProfile userProfile)
        {
            InitializeComponent();
            LbHeading.Text = "Edit User";
            this.Text = "Edit User";
            isEditMode = true;
            PopulateFields(userProfile);
            _dbEntities = new NettlyBookingDbEntities1();
        }

        private void PopulateFields(UserProfile userProfile)
        {
            LbId.Text = userProfile.UserProfileID.ToString();
            TbFName.Text = userProfile.FirstName;
            TbLName.Text = userProfile.LastName;
            TbMNum.Text = userProfile.ContactNumber.ToString();
            TbEmail.Text = userProfile.Email;
            TbAddress.Text = userProfile.Address;
            TbUserName.Text = userProfile.User.Username;

        }

        private void BtTnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtTnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput()) // Validate input before saving
                {
                    if (isEditMode)
                    {
                        // Edit code
                        var id = int.Parse(LbId.Text);
                        var userProfile = _dbEntities.UserProfiles.FirstOrDefault(UsPro => UsPro.UserProfileID == id);
                        userProfile.FirstName = TbFName.Text;
                        userProfile.LastName = TbLName.Text;
                        userProfile.ContactNumber = TbMNum.Text;
                        userProfile.Email = TbEmail.Text;
                        userProfile.Address = TbAddress.Text;
                        userProfile.User.Username = TbUserName.Text;

                        _dbEntities.SaveChanges();

                        MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Add code
                        var newUser = new UserProfile
                        {
                            FirstName = TbFName.Text,
                            LastName = TbLName.Text,
                            ContactNumber = TbMNum.Text,
                            Email = TbEmail.Text,
                            Address = TbAddress.Text,
                            User = new User // Create a new User entity
                            {
                                Username = TbUserName.Text // Assign the Username property
                            }

                        };
                        _dbEntities.UserProfiles.Add(newUser);
                        _dbEntities.SaveChanges();

                        MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close(); // Close the form after successful operation
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Validate text boxes for empty values
            if (string.IsNullOrWhiteSpace(TbFName.Text) ||
                string.IsNullOrWhiteSpace(TbLName.Text) ||
                string.IsNullOrWhiteSpace(TbMNum.Text) ||
                string.IsNullOrWhiteSpace(TbEmail.Text) ||
                string.IsNullOrWhiteSpace(TbAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           

            return true;
        }
    }
}   

