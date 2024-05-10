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

        public AddStaff()
        {
            InitializeComponent();
            _dbEntities = new NettlyBookingDbEntities1();

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            var roles = _dbEntities.Roles.ToList();
            CbRoles.DataSource = roles;
            CbRoles.ValueMember = "RoleName";
            CbRoles.DisplayMember = "Name";

        }


        private void BtTnSave_Click(object sender, EventArgs e) 
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        /* try
         {
             var FirstName = TbFName.Text;
             var LastName = TbLName.Text;
             var ContactNumber = TbMNum.Text;
             var Email = TbEmail.Text;
             var Address = TbAddress.Text;
             var Username = TbUserName.Text;
             var Password = TbPassword.Text;
             var roleId = (int)CbRoles.SelectedValue;
             var userProfile = new UserProfile

         }
         {
             Username = Username,
             Password = Password,
             Status = true
         };
         _dbEntities.UserProfiles.Add(userProfile);
         _dbEntities.SaveChangesAsync(); 
     }*/

        //  var UserProfileId = User.Id;
    }
        private void BtTnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

   //     private void BtTnSave_Click(object sender, EventArgs e)
     //   {

       // }
    }
}
