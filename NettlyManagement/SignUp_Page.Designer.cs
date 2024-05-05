namespace NettlyManagement
{
    partial class SignUp_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Page));
            this.LbHeading = new System.Windows.Forms.Label();
            this.PdMan = new System.Windows.Forms.PictureBox();
            this.PanSignUp = new System.Windows.Forms.Panel();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.TbConfirmPassword = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbMobileNum = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.BtTnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PdMan)).BeginInit();
            this.PanSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LbHeading.Location = new System.Drawing.Point(84, 18);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(153, 36);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "Sign Up ";
            // 
            // PdMan
            // 
            this.PdMan.BackColor = System.Drawing.Color.Transparent;
            this.PdMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PdMan.BackgroundImage")));
            this.PdMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PdMan.Location = new System.Drawing.Point(234, 32);
            this.PdMan.Name = "PdMan";
            this.PdMan.Size = new System.Drawing.Size(484, 344);
            this.PdMan.TabIndex = 1;
            this.PdMan.TabStop = false;
            // 
            // PanSignUp
            // 
            this.PanSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanSignUp.BackgroundImage")));
            this.PanSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanSignUp.Controls.Add(this.LbHeading);
            this.PanSignUp.Controls.Add(this.TbUserName);
            this.PanSignUp.Controls.Add(this.TbConfirmPassword);
            this.PanSignUp.Controls.Add(this.TbPassword);
            this.PanSignUp.Controls.Add(this.TbMobileNum);
            this.PanSignUp.Controls.Add(this.TbLastName);
            this.PanSignUp.Controls.Add(this.TbEmail);
            this.PanSignUp.Controls.Add(this.TbFirstName);
            this.PanSignUp.Controls.Add(this.BtTnSignUp);
            this.PanSignUp.Location = new System.Drawing.Point(144, 32);
            this.PanSignUp.Name = "PanSignUp";
            this.PanSignUp.Size = new System.Drawing.Size(314, 379);
            this.PanSignUp.TabIndex = 2;
            // 
            // TbUserName
            // 
            this.TbUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbUserName.Location = new System.Drawing.Point(31, 245);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(242, 22);
            this.TbUserName.TabIndex = 9;
            this.TbUserName.Text = "Create User Name";
            // 
            // TbConfirmPassword
            // 
            this.TbConfirmPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbConfirmPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbConfirmPassword.Location = new System.Drawing.Point(31, 217);
            this.TbConfirmPassword.Name = "TbConfirmPassword";
            this.TbConfirmPassword.Size = new System.Drawing.Size(242, 23);
            this.TbConfirmPassword.TabIndex = 5;
            this.TbConfirmPassword.Text = "Confirm Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbPassword.Location = new System.Drawing.Point(31, 189);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(242, 23);
            this.TbPassword.TabIndex = 8;
            this.TbPassword.Text = "Password";
            // 
            // TbMobileNum
            // 
            this.TbMobileNum.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMobileNum.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbMobileNum.Location = new System.Drawing.Point(31, 161);
            this.TbMobileNum.Name = "TbMobileNum";
            this.TbMobileNum.Size = new System.Drawing.Size(242, 23);
            this.TbMobileNum.TabIndex = 7;
            this.TbMobileNum.Text = "Mobile Number";
            // 
            // TbLastName
            // 
            this.TbLastName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbLastName.Location = new System.Drawing.Point(31, 105);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(242, 23);
            this.TbLastName.TabIndex = 6;
            this.TbLastName.Text = "Last Name";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbEmail.Location = new System.Drawing.Point(31, 133);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(242, 23);
            this.TbEmail.TabIndex = 5;
            this.TbEmail.Text = "Email";
            // 
            // TbFirstName
            // 
            this.TbFirstName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbFirstName.Location = new System.Drawing.Point(31, 77);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(242, 23);
            this.TbFirstName.TabIndex = 4;
            this.TbFirstName.Text = "First Name";
            // 
            // BtTnSignUp
            // 
            this.BtTnSignUp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTnSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtTnSignUp.Location = new System.Drawing.Point(71, 293);
            this.BtTnSignUp.Name = "BtTnSignUp";
            this.BtTnSignUp.Size = new System.Drawing.Size(153, 36);
            this.BtTnSignUp.TabIndex = 3;
            this.BtTnSignUp.Text = "Sign Up";
            this.BtTnSignUp.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanSignUp);
            this.Controls.Add(this.PdMan);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.PdMan)).EndInit();
            this.PanSignUp.ResumeLayout(false);
            this.PanSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.PictureBox PdMan;
        private System.Windows.Forms.Panel PanSignUp;
        private System.Windows.Forms.Button BtTnSignUp;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbMobileNum;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbConfirmPassword;
        private System.Windows.Forms.TextBox TbUserName;
    }
}