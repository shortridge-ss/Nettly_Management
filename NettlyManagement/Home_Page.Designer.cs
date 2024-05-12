namespace NettlyManagement
{
    partial class Landing_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            this.LbHeading = new System.Windows.Forms.Label();
            this.PbNettlyLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminSignUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LbHeading.Location = new System.Drawing.Point(287, 140);
            this.LbHeading.MaximumSize = new System.Drawing.Size(650, 1800);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(580, 195);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "Nettley Advanced Appointment Booking System";
            // 
            // PbNettlyLogo
            // 
            this.PbNettlyLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbNettlyLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbNettlyLogo.BackgroundImage")));
            this.PbNettlyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNettlyLogo.Location = new System.Drawing.Point(1056, 67);
            this.PbNettlyLogo.Name = "PbNettlyLogo";
            this.PbNettlyLogo.Size = new System.Drawing.Size(149, 109);
            this.PbNettlyLogo.TabIndex = 5;
            this.PbNettlyLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.administrationManagementToolStripMenuItem,
            this.administrationManagementToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookingsToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // addBookingsToolStripMenuItem
            // 
            this.addBookingsToolStripMenuItem.Name = "addBookingsToolStripMenuItem";
            this.addBookingsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addBookingsToolStripMenuItem.Text = "Add Bookings";
            this.addBookingsToolStripMenuItem.Click += new System.EventHandler(this.AddBookingsToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.ViewBookingsToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveFeedbackToolStripMenuItem,
            this.viewFeedbackToolStripMenuItem});
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // giveFeedbackToolStripMenuItem
            // 
            this.giveFeedbackToolStripMenuItem.Name = "giveFeedbackToolStripMenuItem";
            this.giveFeedbackToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.giveFeedbackToolStripMenuItem.Text = "Give Feedback";
            this.giveFeedbackToolStripMenuItem.Click += new System.EventHandler(this.giveFeedbackToolStripMenuItem_Click);
            // 
            // viewFeedbackToolStripMenuItem
            // 
            this.viewFeedbackToolStripMenuItem.Name = "viewFeedbackToolStripMenuItem";
            this.viewFeedbackToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.viewFeedbackToolStripMenuItem.Text = "View Feedback";
            this.viewFeedbackToolStripMenuItem.Click += new System.EventHandler(this.viewFeedbackToolStripMenuItem_Click);
            // 
            // administrationManagementToolStripMenuItem
            // 
            this.administrationManagementToolStripMenuItem.Name = "administrationManagementToolStripMenuItem";
            this.administrationManagementToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.administrationManagementToolStripMenuItem.Text = "About Application";
            // 
            // administrationManagementToolStripMenuItem1
            // 
            this.administrationManagementToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminSignUpToolStripMenuItem,
            this.adminHomeToolStripMenuItem});
            this.administrationManagementToolStripMenuItem1.Name = "administrationManagementToolStripMenuItem1";
            this.administrationManagementToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.administrationManagementToolStripMenuItem1.Text = "Administration Management";
            // 
            // adminSignUpToolStripMenuItem
            // 
            this.adminSignUpToolStripMenuItem.Name = "adminSignUpToolStripMenuItem";
            this.adminSignUpToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.adminSignUpToolStripMenuItem.Text = "Admin Sign Up";
            this.adminSignUpToolStripMenuItem.Click += new System.EventHandler(this.adminSignUpToolStripMenuItem_Click);
            // 
            // adminHomeToolStripMenuItem
            // 
            this.adminHomeToolStripMenuItem.Name = "adminHomeToolStripMenuItem";
            this.adminHomeToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.adminHomeToolStripMenuItem.Text = "Admin Home";
            this.adminHomeToolStripMenuItem.Click += new System.EventHandler(this.adminHomeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Landing_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 575);
            this.Controls.Add(this.PbNettlyLogo);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Landing_Page";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Landing_Page_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.PictureBox PbNettlyLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminSignUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

