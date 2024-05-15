namespace NettlyManagement
{
    partial class Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            this.BtTnSignIn = new System.Windows.Forms.Button();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.PbMan = new System.Windows.Forms.PictureBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.lLbSingUp = new System.Windows.Forms.LinkLabel();
            this.lLbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.CHbRememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbMan)).BeginInit();
            this.SuspendLayout();
            // 
            // BtTnSignIn
            // 
            this.BtTnSignIn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTnSignIn.Location = new System.Drawing.Point(630, 350);
            this.BtTnSignIn.Name = "BtTnSignIn";
            this.BtTnSignIn.Size = new System.Drawing.Size(192, 47);
            this.BtTnSignIn.TabIndex = 0;
            this.BtTnSignIn.Text = "Sign In";
            this.BtTnSignIn.UseVisualStyleBackColor = true;
            this.BtTnSignIn.Click += new System.EventHandler(this.BtTnSignIn_Click);
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LbHeading.Location = new System.Drawing.Point(607, 31);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(215, 57);
            this.LbHeading.TabIndex = 1;
            this.LbHeading.Text = "Sign In";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(559, 177);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(91, 18);
            this.LbEmail.TabIndex = 2;
            this.LbEmail.Text = "User Name";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(559, 244);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(80, 18);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Password";
            // 
            // PbMan
            // 
            this.PbMan.BackColor = System.Drawing.Color.Transparent;
            this.PbMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbMan.BackgroundImage")));
            this.PbMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMan.Location = new System.Drawing.Point(339, 21);
            this.PbMan.Name = "PbMan";
            this.PbMan.Size = new System.Drawing.Size(825, 659);
            this.PbMan.TabIndex = 4;
            this.PbMan.TabStop = false;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(562, 198);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(239, 22);
            this.TbEmail.TabIndex = 5;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(562, 265);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(239, 22);
            this.TbPassword.TabIndex = 6;
            // 
            // lLbSingUp
            // 
            this.lLbSingUp.AutoSize = true;
            this.lLbSingUp.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLbSingUp.Location = new System.Drawing.Point(754, 290);
            this.lLbSingUp.Name = "lLbSingUp";
            this.lLbSingUp.Size = new System.Drawing.Size(57, 16);
            this.lLbSingUp.TabIndex = 7;
            this.lLbSingUp.TabStop = true;
            this.lLbSingUp.Text = "Sign Up";
            this.lLbSingUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLbSingUp_LinkClicked);
            // 
            // lLbForgotPassword
            // 
            this.lLbForgotPassword.AutoSize = true;
            this.lLbForgotPassword.Location = new System.Drawing.Point(663, 331);
            this.lLbForgotPassword.Name = "lLbForgotPassword";
            this.lLbForgotPassword.Size = new System.Drawing.Size(109, 16);
            this.lLbForgotPassword.TabIndex = 8;
            this.lLbForgotPassword.TabStop = true;
            this.lLbForgotPassword.Text = "Forgot Password";
            // 
            // CHbRememberMe
            // 
            this.CHbRememberMe.AutoSize = true;
            this.CHbRememberMe.Font = new System.Drawing.Font("Verdana", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHbRememberMe.Location = new System.Drawing.Point(562, 290);
            this.CHbRememberMe.Name = "CHbRememberMe";
            this.CHbRememberMe.Size = new System.Drawing.Size(87, 17);
            this.CHbRememberMe.TabIndex = 9;
            this.CHbRememberMe.Text = "Remember Me";
            this.CHbRememberMe.UseVisualStyleBackColor = true;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1501, 745);
            this.Controls.Add(this.CHbRememberMe);
            this.Controls.Add(this.lLbForgotPassword);
            this.Controls.Add(this.lLbSingUp);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.BtTnSignIn);
            this.Controls.Add(this.PbMan);
            this.DoubleBuffered = true;
            this.Name = "Login_page";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtTnSignIn;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.PictureBox PbMan;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.LinkLabel lLbSingUp;
        private System.Windows.Forms.LinkLabel lLbForgotPassword;
        private System.Windows.Forms.CheckBox CHbRememberMe;
    }
}