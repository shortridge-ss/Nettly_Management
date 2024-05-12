    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace NettlyManagement
    {
        public partial class Login_page : Form
        {
            // Private field to store the UserID
            private int _userID;

            // Public property to access the stored UserID
            public int UserID => _userID;

            private bool _rememberMeChecked;

            private readonly NettlyBookingDbEntities1 _dbEntities;
            public Login_page()
            {
                InitializeComponent();
                _dbEntities = new NettlyBookingDbEntities1();
            }

            private void Login_page_Load(object sender, EventArgs e)
            {
                // Load the checkbox state when the form loads
                CHbRememberMe.Checked = Properties.Settings.Default.RememberMeChecked;
            }

            private void lLbSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                var signUp = new SignUp_Page();
                signUp.ShowDialog();
            }

            private void BtTnSignIn_Click(object sender, EventArgs e)
            {
                try
                {

               
                    SHA256 sha = SHA256.Create();   

                     //retrieve from text box 
                     var username = TbEmail.Text.Trim();
                     var password = TbPassword.Text;

                     //convert input string to byte array and comute hash.
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
                 

                    //compare textbox with db
                    var user = _dbEntities.Users.FirstOrDefault(u =>  u.Username == username && u.Password == hashedPassword);
                    if (user == null) 
                    {
                        MessageBox.Show("Please provide valid credenitals");

                    }
               
                    else 
                    {
                    

                        var role = user.Roles.FirstOrDefault();
                        var roleName = role.RoleName;
                        var userID = user.UserID;
                        Landing_Page homepage = new Landing_Page(this, roleName, userID);
                        homepage.Show();
                        Hide();
                    
                   
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Please try again");

                }


            }
        }
    }
