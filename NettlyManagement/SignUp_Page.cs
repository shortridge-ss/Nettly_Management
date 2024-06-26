﻿using NettlyManagement;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NettlyManagement
{
    public partial class SignUp_Page : Form
    {
        private readonly NettlyBookingDbEntities1 _dbEntities;
        //private bool isvalid;

        public SignUp_Page()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();
        }

        private void BtTnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                 SHA256 sha = SHA256.Create();


                // Validate input fields
                if (string.IsNullOrWhiteSpace(TbFirstName.Text) ||
                    string.IsNullOrWhiteSpace(TbLastName.Text) ||
                    string.IsNullOrWhiteSpace(TbAddress.Text) ||
                    string.IsNullOrWhiteSpace(TbMobileNum.Text) ||
                    string.IsNullOrWhiteSpace(TbEmail.Text) ||
                    string.IsNullOrWhiteSpace(TbUserName.Text) ||
                    string.IsNullOrWhiteSpace(TbPassword.Text) ||
                    string.IsNullOrWhiteSpace(TbConfirmPassword.Text))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm password
                if (TbPassword.Text != TbConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }





                var roleName = "User"; 
                var role = _dbEntities.Roles.FirstOrDefault(r => r.RoleName == roleName);
                if (role == null)
                {
                    // Handle error: Role not found
                }
                var roleId = role.RoleID;

                var FirstName = TbFirstName.Text;
                var LastName = TbLastName.Text;
                var address = TbAddress.Text;
                var MobileNum = TbMobileNum.Text;
                var Email = TbEmail.Text;
                var userName = TbUserName.Text;
                var password = TbPassword.Text;
                var userId = (int)(int)LbUserID.TabIndex;
                var userProId = (int)(int)LbUserProId.TabIndex;
                // Validate MobileNum to ensure it contains only numbers
                
                if (!IsNumeric(MobileNum))
                {
                    MessageBox.Show("Mobile Number must contain only numeric digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var user = new UserProfile();
                {  user.FirstName = FirstName; 
                    user.LastName = LastName;
                    user.Address = address;
                    user.ContactNumber = MobileNum;
                    user.Email = Email;
                    user.UserName = userName;
                    
                    user.UserProfileID = userProId;
                }

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                //create string builder to collect byte and create string
                StringBuilder sb = new StringBuilder();


                //loop through each byte of hashed data and format each
                //one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }

                var hashedPassword = sb.ToString();

                var userPro = new User
                {

                    Username = userName,
                    Password = hashedPassword,
                    Role = roleId,
                    Status = true,
                    ContactNumber = MobileNum,
                    Email = Email


            };


                _dbEntities.UserProfiles.Add(user);
                _dbEntities.Users.Add(userPro);
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

        }
        // Helper method to check if a string contains only numeric digits
        private bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}



       



