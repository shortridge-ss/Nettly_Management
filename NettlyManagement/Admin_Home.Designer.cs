namespace NettlyManagement
{
    partial class Admin_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
            this.LbHeading = new System.Windows.Forms.Label();
            this.PanAllViews = new System.Windows.Forms.Panel();
            this.BtTnAllFeedback = new System.Windows.Forms.Button();
            this.BtTnAllCredentials = new System.Windows.Forms.Button();
            this.BtTnAllBookings = new System.Windows.Forms.Button();
            this.BtTnAllUsers = new System.Windows.Forms.Button();
            this.PanAllEdit = new System.Windows.Forms.Panel();
            this.BtTnRefresh = new System.Windows.Forms.Button();
            this.BtTnDeleteEntry = new System.Windows.Forms.Button();
            this.BtTnEditEntry = new System.Windows.Forms.Button();
            this.BtTnAddEntry = new System.Windows.Forms.Button();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.PbHome = new System.Windows.Forms.PictureBox();
            this.PbNettlyLogo = new System.Windows.Forms.PictureBox();
            this.PbSettings = new System.Windows.Forms.PictureBox();
            this.PbNavBar = new System.Windows.Forms.PictureBox();
            this.GvAdminPage = new System.Windows.Forms.DataGridView();
            this.PanAllViews.SuspendLayout();
            this.PanAllEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvAdminPage)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Verdana", 18.2F, System.Drawing.FontStyle.Bold);
            this.LbHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbHeading.Location = new System.Drawing.Point(398, 82);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(373, 38);
            this.LbHeading.TabIndex = 0;
            this.LbHeading.Text = "Administration View";
            // 
            // PanAllViews
            // 
            this.PanAllViews.BackColor = System.Drawing.Color.Transparent;
            this.PanAllViews.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanAllViews.BackgroundImage")));
            this.PanAllViews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanAllViews.Controls.Add(this.BtTnAllFeedback);
            this.PanAllViews.Controls.Add(this.BtTnAllCredentials);
            this.PanAllViews.Controls.Add(this.BtTnAllBookings);
            this.PanAllViews.Controls.Add(this.BtTnAllUsers);
            this.PanAllViews.Location = new System.Drawing.Point(12, 161);
            this.PanAllViews.Name = "PanAllViews";
            this.PanAllViews.Size = new System.Drawing.Size(203, 338);
            this.PanAllViews.TabIndex = 2;
            // 
            // BtTnAllFeedback
            // 
            this.BtTnAllFeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnAllFeedback.BackgroundImage")));
            this.BtTnAllFeedback.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnAllFeedback.Location = new System.Drawing.Point(24, 229);
            this.BtTnAllFeedback.Name = "BtTnAllFeedback";
            this.BtTnAllFeedback.Size = new System.Drawing.Size(161, 37);
            this.BtTnAllFeedback.TabIndex = 3;
            this.BtTnAllFeedback.Text = "All Feedback";
            this.BtTnAllFeedback.UseVisualStyleBackColor = true;
            // 
            // BtTnAllCredentials
            // 
            this.BtTnAllCredentials.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnAllCredentials.BackgroundImage")));
            this.BtTnAllCredentials.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnAllCredentials.Location = new System.Drawing.Point(24, 174);
            this.BtTnAllCredentials.Name = "BtTnAllCredentials";
            this.BtTnAllCredentials.Size = new System.Drawing.Size(161, 37);
            this.BtTnAllCredentials.TabIndex = 2;
            this.BtTnAllCredentials.Text = "All Credentials";
            this.BtTnAllCredentials.UseVisualStyleBackColor = true;
            this.BtTnAllCredentials.Click += new System.EventHandler(this.BtTnAllCredentials_Click);
            // 
            // BtTnAllBookings
            // 
            this.BtTnAllBookings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnAllBookings.BackgroundImage")));
            this.BtTnAllBookings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnAllBookings.Location = new System.Drawing.Point(24, 117);
            this.BtTnAllBookings.Name = "BtTnAllBookings";
            this.BtTnAllBookings.Size = new System.Drawing.Size(161, 37);
            this.BtTnAllBookings.TabIndex = 1;
            this.BtTnAllBookings.Text = "All Bookings";
            this.BtTnAllBookings.UseVisualStyleBackColor = true;
            this.BtTnAllBookings.Click += new System.EventHandler(this.BtTnAllBookings_Click_1);
            // 
            // BtTnAllUsers
            // 
            this.BtTnAllUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnAllUsers.BackgroundImage")));
            this.BtTnAllUsers.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTnAllUsers.Location = new System.Drawing.Point(24, 54);
            this.BtTnAllUsers.Name = "BtTnAllUsers";
            this.BtTnAllUsers.Size = new System.Drawing.Size(161, 37);
            this.BtTnAllUsers.TabIndex = 0;
            this.BtTnAllUsers.Text = "All Users";
            this.BtTnAllUsers.UseVisualStyleBackColor = true;
            this.BtTnAllUsers.Click += new System.EventHandler(this.BtTnAllUsers_Click);
            // 
            // PanAllEdit
            // 
            this.PanAllEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanAllEdit.BackgroundImage")));
            this.PanAllEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanAllEdit.Controls.Add(this.BtTnRefresh);
            this.PanAllEdit.Controls.Add(this.BtTnDeleteEntry);
            this.PanAllEdit.Controls.Add(this.BtTnEditEntry);
            this.PanAllEdit.Controls.Add(this.BtTnAddEntry);
            this.PanAllEdit.Location = new System.Drawing.Point(1007, 161);
            this.PanAllEdit.Name = "PanAllEdit";
            this.PanAllEdit.Size = new System.Drawing.Size(220, 338);
            this.PanAllEdit.TabIndex = 3;
            // 
            // BtTnRefresh
            // 
            this.BtTnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnRefresh.BackgroundImage")));
            this.BtTnRefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnRefresh.Location = new System.Drawing.Point(44, 229);
            this.BtTnRefresh.Name = "BtTnRefresh";
            this.BtTnRefresh.Size = new System.Drawing.Size(137, 37);
            this.BtTnRefresh.TabIndex = 4;
            this.BtTnRefresh.Text = "Refresh";
            this.BtTnRefresh.UseVisualStyleBackColor = true;
            this.BtTnRefresh.Click += new System.EventHandler(this.BtTnRefresh_Click);
            // 
            // BtTnDeleteEntry
            // 
            this.BtTnDeleteEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnDeleteEntry.BackgroundImage")));
            this.BtTnDeleteEntry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnDeleteEntry.Location = new System.Drawing.Point(44, 174);
            this.BtTnDeleteEntry.Name = "BtTnDeleteEntry";
            this.BtTnDeleteEntry.Size = new System.Drawing.Size(137, 37);
            this.BtTnDeleteEntry.TabIndex = 3;
            this.BtTnDeleteEntry.Text = "Delete Entry";
            this.BtTnDeleteEntry.UseVisualStyleBackColor = true;
            this.BtTnDeleteEntry.Click += new System.EventHandler(this.BtTnDeleteEntry_Click);
            // 
            // BtTnEditEntry
            // 
            this.BtTnEditEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnEditEntry.BackgroundImage")));
            this.BtTnEditEntry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnEditEntry.Location = new System.Drawing.Point(44, 117);
            this.BtTnEditEntry.Name = "BtTnEditEntry";
            this.BtTnEditEntry.Size = new System.Drawing.Size(137, 37);
            this.BtTnEditEntry.TabIndex = 2;
            this.BtTnEditEntry.Text = "Edit Entry";
            this.BtTnEditEntry.UseVisualStyleBackColor = true;
            this.BtTnEditEntry.Click += new System.EventHandler(this.BtTnEditEntry_Click);
            // 
            // BtTnAddEntry
            // 
            this.BtTnAddEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtTnAddEntry.BackgroundImage")));
            this.BtTnAddEntry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BtTnAddEntry.Location = new System.Drawing.Point(44, 54);
            this.BtTnAddEntry.Name = "BtTnAddEntry";
            this.BtTnAddEntry.Size = new System.Drawing.Size(137, 37);
            this.BtTnAddEntry.TabIndex = 1;
            this.BtTnAddEntry.Text = "Add Entry";
            this.BtTnAddEntry.UseVisualStyleBackColor = true;
            this.BtTnAddEntry.Click += new System.EventHandler(this.BtTnAddEntry_Click);
            // 
            // PbSearch
            // 
            this.PbSearch.BackColor = System.Drawing.Color.Transparent;
            this.PbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSearch.BackgroundImage")));
            this.PbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSearch.Location = new System.Drawing.Point(646, 12);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(19, 24);
            this.PbSearch.TabIndex = 47;
            this.PbSearch.TabStop = false;
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(381, 5);
            this.TbSearch.Multiline = true;
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(285, 37);
            this.TbSearch.TabIndex = 49;
            // 
            // PbHome
            // 
            this.PbHome.BackColor = System.Drawing.Color.Transparent;
            this.PbHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbHome.BackgroundImage")));
            this.PbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbHome.Location = new System.Drawing.Point(113, 13);
            this.PbHome.Name = "PbHome";
            this.PbHome.Size = new System.Drawing.Size(26, 27);
            this.PbHome.TabIndex = 48;
            this.PbHome.TabStop = false;
            this.PbHome.Click += new System.EventHandler(this.PbHome_Click);
            // 
            // PbNettlyLogo
            // 
            this.PbNettlyLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbNettlyLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbNettlyLogo.BackgroundImage")));
            this.PbNettlyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNettlyLogo.Location = new System.Drawing.Point(26, 5);
            this.PbNettlyLogo.Name = "PbNettlyLogo";
            this.PbNettlyLogo.Size = new System.Drawing.Size(39, 46);
            this.PbNettlyLogo.TabIndex = 46;
            this.PbNettlyLogo.TabStop = false;
            // 
            // PbSettings
            // 
            this.PbSettings.BackColor = System.Drawing.Color.Transparent;
            this.PbSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSettings.BackgroundImage")));
            this.PbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSettings.Location = new System.Drawing.Point(1190, 14);
            this.PbSettings.Name = "PbSettings";
            this.PbSettings.Size = new System.Drawing.Size(25, 28);
            this.PbSettings.TabIndex = 45;
            this.PbSettings.TabStop = false;
            // 
            // PbNavBar
            // 
            this.PbNavBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbNavBar.BackgroundImage")));
            this.PbNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNavBar.Location = new System.Drawing.Point(-6, 1);
            this.PbNavBar.Name = "PbNavBar";
            this.PbNavBar.Size = new System.Drawing.Size(1252, 50);
            this.PbNavBar.TabIndex = 44;
            this.PbNavBar.TabStop = false;
            // 
            // GvAdminPage
            // 
            this.GvAdminPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvAdminPage.Location = new System.Drawing.Point(243, 206);
            this.GvAdminPage.Name = "GvAdminPage";
            this.GvAdminPage.RowHeadersWidth = 51;
            this.GvAdminPage.RowTemplate.Height = 24;
            this.GvAdminPage.Size = new System.Drawing.Size(733, 326);
            this.GvAdminPage.TabIndex = 50;
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 649);
            this.Controls.Add(this.GvAdminPage);
            this.Controls.Add(this.PbSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.PbHome);
            this.Controls.Add(this.PbNettlyLogo);
            this.Controls.Add(this.PbSettings);
            this.Controls.Add(this.PbNavBar);
            this.Controls.Add(this.PanAllEdit);
            this.Controls.Add(this.PanAllViews);
            this.Controls.Add(this.LbHeading);
            this.DoubleBuffered = true;
            this.Name = "Admin_Page";
            this.Text = "Admin Main";
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            this.PanAllViews.ResumeLayout(false);
            this.PanAllEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvAdminPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Panel PanAllViews;
        private System.Windows.Forms.Panel PanAllEdit;
        private System.Windows.Forms.Button BtTnAllUsers;
        private System.Windows.Forms.Button BtTnAllFeedback;
        private System.Windows.Forms.Button BtTnAllCredentials;
        private System.Windows.Forms.Button BtTnAllBookings;
        private System.Windows.Forms.Button BtTnRefresh;
        private System.Windows.Forms.Button BtTnDeleteEntry;
        private System.Windows.Forms.Button BtTnEditEntry;
        private System.Windows.Forms.Button BtTnAddEntry;
        private System.Windows.Forms.PictureBox PbSearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.PictureBox PbHome;
        private System.Windows.Forms.PictureBox PbNettlyLogo;
        private System.Windows.Forms.PictureBox PbSettings;
        private System.Windows.Forms.PictureBox PbNavBar;
        private System.Windows.Forms.BindingSource nettlyBookingDbDataSetBindingSource;
        private System.Windows.Forms.DataGridView GvAdminPage;
    }
}