using NettlyManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit.Sdk;

namespace NettlyManagement
{
    public partial class SignUp_Page : Form
    {
        private readonly NettlyBookingDbEntities1 _dbEntities;
        private bool isvalid;

        public SignUp_Page()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();
        }

        private void BtTnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
               
                var FirstName = TbFirstName.Text;
                var LastName = TbLastName.Text;
                var address = TbAddress.Text;
                var MobileNum = TbMobileNum.Text;
                var Email = TbEmail.Text;
                var userName = TbUserName.Text;
                var password = TbPassword.Text;
                var userId = (int)(int)LbUserID.TabIndex;
                var userProId = (int)(int)LbUserProId.TabIndex;


                var user = new UserProfile();
                {  user.FirstName = FirstName; 
                    user.LastName = LastName;
                    user.Address = address;
                    user.ContactNumber = MobileNum;
                    user.Email = Email;
                    user.UserName = userName;
                    user.Password = password;
                    user.UserID = userId;
                    user.UserProfileID = userProId;
                }
                /* var userPro = new User
                {
                    Username = userName,
                    Password = password,

                };*/

                _dbEntities.UserProfiles.Add(user);
              //  _dbEntities.Users.Add(userPro);
                _dbEntities.SaveChanges();

                MessageBox.Show("User profile created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, close the form after successful operation
                this.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}



       



