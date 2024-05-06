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
            isEditMode = false;
            _dbEntities = new NettlyBookingDbEntities1();
        }

        public AddEdit_Window(UserProfile userProfile)
        {
            InitializeComponent();
            LbHeading.Text = "Edit User";
            isEditMode=true;
            PopulateFields(userProfile);
        }

        private void PopulateFields(UserProfile userProfile)
        {
            LbId.Text = userProfile.UserProfileID.ToString();
            TbFName.Text = userProfile.FirstName;
            TbLName.Text = userProfile.LastName;
            TbMNum.Text = userProfile.ContactNumber.ToString();
            TbEmail.Text = userProfile.Email;
            TbAddress.Text = userProfile.Address;

        }

        private void BtTnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void BtTnSave_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                //edit code
                var id = int.Parse(LbId.Text);
                var userProfile = _dbEntities.UserProfiles.FirstOrDefault(UsPro => UsPro.UserProfileID == id);
                userProfile.FirstName = TbFName.Text;
                userProfile.LastName = TbLName.Text;
                userProfile.ContactNumber = TbMNum.Text;
                userProfile.Email = TbEmail.Text;
                userProfile.Address = TbAddress.Text;

                _dbEntities.SaveChanges();  
            }
            else
            {
                // add code
                var newUser = new UserProfile
                {
                    FirstName = TbFName.Text,
                    LastName = TbLName.Text,
                    ContactNumber = TbMNum.Text,
                    Email = TbEmail.Text,
                    Address = TbAddress.Text

                };
                _dbEntities.UserProfiles.Add(newUser);
                _dbEntities.SaveChanges();
            }
        }
    }
}
