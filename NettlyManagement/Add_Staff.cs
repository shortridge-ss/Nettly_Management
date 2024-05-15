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

    public partial class AddStaff : Form
    {

        private readonly NettlyBookingDbEntities1 _dbEntities;
        private bool isEditMode;
        private User userToUpdate;
        private int _userID;

        public AddStaff()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();
            isEditMode = false;
            LbHeading.Text = "Add Staff";

        }
        public AddStaff(User user) : this()
        {
            isEditMode = true;
            userToUpdate = user;
            LbHeading.Text = "Edit Credentials";
            PopulateFormFields(user);
        }

        private void PopulateFormFields(User user)
        {
            TbFName.Text = user.UserProfiles.FirstOrDefault()?.FirstName;
            TbLName.Text = user.UserProfiles.FirstOrDefault()?.LastName;
            TbMNum.Text = user.UserProfiles.FirstOrDefault()?.ContactNumber;
            TbEmail.Text = user.UserProfiles.FirstOrDefault()?.Email;
            TbAddress.Text = user.UserProfiles.FirstOrDefault()?.Address;
            TbUserName.Text = user.Username;
            TbPassword.Text = user.Password;

            
        }


        private void AddStaff_Load(object sender, EventArgs e)
        {
            var roles = _dbEntities.Roles.ToList();
            CbRoles.DataSource = roles;
            CbRoles.ValueMember = "RoleName";
            CbRoles.DisplayMember = "Name";

        }

        private bool ValidateInput()
        {
            // Check if required fields are filled out
            if (string.IsNullOrWhiteSpace(TbFName.Text) ||
                string.IsNullOrWhiteSpace(TbLName.Text) ||
                string.IsNullOrWhiteSpace(TbEmail.Text) ||
                string.IsNullOrWhiteSpace(TbUserName.Text) ||
                string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate email format
            if (!IsValidEmail(TbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Optionally, you can include more validation checks here...

            // If all checks pass, return true
            return true;


        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


            private void BtTnSave_Click(object sender, EventArgs e) 
        {

            try
            {
                if (ValidateInput())
                {
                    if (isEditMode)
                    {
                        // Update existing user
                        userToUpdate.UserProfiles.FirstOrDefault().FirstName = TbFName.Text;
                        userToUpdate.UserProfiles.FirstOrDefault().LastName = TbLName.Text;
                        userToUpdate.UserProfiles.FirstOrDefault().ContactNumber = TbMNum.Text;
                        userToUpdate.UserProfiles.FirstOrDefault().Email = TbEmail.Text;
                        userToUpdate.UserProfiles.FirstOrDefault().Address = TbAddress.Text;
                        userToUpdate.Username = TbUserName.Text;
                        userToUpdate.Password = TbPassword.Text;

                        _dbEntities.SaveChanges();

                        MessageBox.Show("Credentials updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); // Close the form
                    }
                    else
                    {
                        // Add new user

                        var firstName = TbFName.Text;
                        var lastName = TbLName.Text;
                        var contactNumber = TbMNum.Text;
                        var email = TbEmail.Text;
                        var address = TbAddress.Text;
                        var username = TbUserName.Text;
                        var password = TbPassword.Text;
                        var roleName = CbRoles.SelectedValue;

                        // Create instances of User and UserProfile
                        var user = new User
                        {
                            Username = username,
                            Password = password,
                            Status = true,
                            //     Roles = RoleName
                        };

                        var userProfile = new UserProfile
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            ContactNumber = contactNumber,
                            Email = email,
                            Address = address,
                            User = user // Establishing relationship
                        };

                        // Add both entities to the context
                        _dbEntities.Users.Add(user);
                        _dbEntities.UserProfiles.Add(userProfile);

                        // Save changes to the database
                        _dbEntities.SaveChanges();

                        MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); // Optionally, close the form after successful operation
                    

                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtTnCancel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }

    }
     
