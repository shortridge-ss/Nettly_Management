namespace NettlyManagement
{
    partial class Add_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Booking));
            this.PbHome = new System.Windows.Forms.PictureBox();
            this.PbSearch = new System.Windows.Forms.PictureBox();
            this.PbNettlyLogo = new System.Windows.Forms.PictureBox();
            this.PbSettings = new System.Windows.Forms.PictureBox();
            this.PbNavBar = new System.Windows.Forms.PictureBox();
            this.McDatePicker = new System.Windows.Forms.MonthCalendar();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbBookingSteps = new System.Windows.Forms.Label();
            this.LbSubHeading = new System.Windows.Forms.Label();
            this.LbBookingName = new System.Windows.Forms.Label();
            this.LbStartTime = new System.Windows.Forms.Label();
            this.LbEndTime = new System.Windows.Forms.Label();
            this.LbAppointmentDetails = new System.Windows.Forms.Label();
            this.DtP_StartTime = new System.Windows.Forms.DateTimePicker();
            this.DtP_EndTime = new System.Windows.Forms.DateTimePicker();
            this.TbBookingName = new System.Windows.Forms.TextBox();
            this.TbAppDetails = new System.Windows.Forms.TextBox();
            this.BtTnSave = new System.Windows.Forms.Button();
            this.BtTnCancel = new System.Windows.Forms.Button();
            this.BtTnBookNow = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNavBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PbHome
            // 
            this.PbHome.BackColor = System.Drawing.Color.Transparent;
            this.PbHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbHome.BackgroundImage")));
            this.PbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbHome.Location = new System.Drawing.Point(115, 24);
            this.PbHome.Name = "PbHome";
            this.PbHome.Size = new System.Drawing.Size(26, 27);
            this.PbHome.TabIndex = 27;
            this.PbHome.TabStop = false;
            this.PbHome.Click += new System.EventHandler(this.PbHome_Click);
            // 
            // PbSearch
            // 
            this.PbSearch.BackColor = System.Drawing.Color.Transparent;
            this.PbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSearch.BackgroundImage")));
            this.PbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSearch.Location = new System.Drawing.Point(648, 23);
            this.PbSearch.Name = "PbSearch";
            this.PbSearch.Size = new System.Drawing.Size(19, 24);
            this.PbSearch.TabIndex = 26;
            this.PbSearch.TabStop = false;
            // 
            // PbNettlyLogo
            // 
            this.PbNettlyLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbNettlyLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbNettlyLogo.BackgroundImage")));
            this.PbNettlyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNettlyLogo.Location = new System.Drawing.Point(28, 16);
            this.PbNettlyLogo.Name = "PbNettlyLogo";
            this.PbNettlyLogo.Size = new System.Drawing.Size(39, 46);
            this.PbNettlyLogo.TabIndex = 25;
            this.PbNettlyLogo.TabStop = false;
            // 
            // PbSettings
            // 
            this.PbSettings.BackColor = System.Drawing.Color.Transparent;
            this.PbSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSettings.BackgroundImage")));
            this.PbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSettings.Location = new System.Drawing.Point(1118, 23);
            this.PbSettings.Name = "PbSettings";
            this.PbSettings.Size = new System.Drawing.Size(25, 28);
            this.PbSettings.TabIndex = 24;
            this.PbSettings.TabStop = false;
            // 
            // PbNavBar
            // 
            this.PbNavBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbNavBar.BackgroundImage")));
            this.PbNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNavBar.Location = new System.Drawing.Point(-4, 12);
            this.PbNavBar.Name = "PbNavBar";
            this.PbNavBar.Size = new System.Drawing.Size(1188, 50);
            this.PbNavBar.TabIndex = 22;
            this.PbNavBar.TabStop = false;
            // 
            // McDatePicker
            // 
            this.McDatePicker.Location = new System.Drawing.Point(60, 253);
            this.McDatePicker.Name = "McDatePicker";
            this.McDatePicker.TabIndex = 28;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbHeading.Location = new System.Drawing.Point(139, 82);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(358, 34);
            this.LbHeading.TabIndex = 29;
            this.LbHeading.Text = "Book an Appointment";
            // 
            // LbBookingSteps
            // 
            this.LbBookingSteps.AutoSize = true;
            this.LbBookingSteps.BackColor = System.Drawing.Color.Transparent;
            this.LbBookingSteps.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.LbBookingSteps.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbBookingSteps.Location = new System.Drawing.Point(34, 141);
            this.LbBookingSteps.MaximumSize = new System.Drawing.Size(300, 0);
            this.LbBookingSteps.Name = "LbBookingSteps";
            this.LbBookingSteps.Size = new System.Drawing.Size(288, 85);
            this.LbBookingSteps.TabIndex = 30;
            this.LbBookingSteps.Text = "Select a date slot below and the an avaible period, than lastly enter the appoint" +
    "ment deatials such as reson for appointment and other supporting details.";
            // 
            // LbSubHeading
            // 
            this.LbSubHeading.AutoSize = true;
            this.LbSubHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbSubHeading.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubHeading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbSubHeading.Location = new System.Drawing.Point(692, 86);
            this.LbSubHeading.Name = "LbSubHeading";
            this.LbSubHeading.Size = new System.Drawing.Size(225, 28);
            this.LbSubHeading.TabIndex = 31;
            this.LbSubHeading.Text = "Today\'s Booking";
            // 
            // LbBookingName
            // 
            this.LbBookingName.AutoSize = true;
            this.LbBookingName.BackColor = System.Drawing.Color.Transparent;
            this.LbBookingName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBookingName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LbBookingName.Location = new System.Drawing.Point(433, 157);
            this.LbBookingName.Name = "LbBookingName";
            this.LbBookingName.Size = new System.Drawing.Size(250, 20);
            this.LbBookingName.TabIndex = 32;
            this.LbBookingName.Text = "Booking/Reminder Name";
            // 
            // LbStartTime
            // 
            this.LbStartTime.AutoSize = true;
            this.LbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.LbStartTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStartTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LbStartTime.Location = new System.Drawing.Point(434, 217);
            this.LbStartTime.Name = "LbStartTime";
            this.LbStartTime.Size = new System.Drawing.Size(194, 18);
            this.LbStartTime.TabIndex = 33;
            this.LbStartTime.Text = "Select Available Period";
            // 
            // LbEndTime
            // 
            this.LbEndTime.AutoSize = true;
            this.LbEndTime.BackColor = System.Drawing.Color.Transparent;
            this.LbEndTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEndTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LbEndTime.Location = new System.Drawing.Point(434, 299);
            this.LbEndTime.Name = "LbEndTime";
            this.LbEndTime.Size = new System.Drawing.Size(138, 18);
            this.LbEndTime.TabIndex = 34;
            this.LbEndTime.Text = "Select End Time";
            // 
            // LbAppointmentDetails
            // 
            this.LbAppointmentDetails.AutoSize = true;
            this.LbAppointmentDetails.BackColor = System.Drawing.Color.Transparent;
            this.LbAppointmentDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppointmentDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LbAppointmentDetails.Location = new System.Drawing.Point(434, 362);
            this.LbAppointmentDetails.Name = "LbAppointmentDetails";
            this.LbAppointmentDetails.Size = new System.Drawing.Size(224, 18);
            this.LbAppointmentDetails.TabIndex = 35;
            this.LbAppointmentDetails.Text = "Enter Appointment Details";
            // 
            // DtP_StartTime
            // 
            this.DtP_StartTime.CalendarFont = new System.Drawing.Font("Verdana", 9.2F, System.Drawing.FontStyle.Bold);
            this.DtP_StartTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtP_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtP_StartTime.Location = new System.Drawing.Point(437, 253);
            this.DtP_StartTime.Name = "DtP_StartTime";
            this.DtP_StartTime.ShowUpDown = true;
            this.DtP_StartTime.Size = new System.Drawing.Size(300, 28);
            this.DtP_StartTime.TabIndex = 36;
            // 
            // DtP_EndTime
            // 
            this.DtP_EndTime.CalendarFont = new System.Drawing.Font("Verdana", 9.2F, System.Drawing.FontStyle.Bold);
            this.DtP_EndTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtP_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtP_EndTime.Location = new System.Drawing.Point(437, 320);
            this.DtP_EndTime.Name = "DtP_EndTime";
            this.DtP_EndTime.ShowUpDown = true;
            this.DtP_EndTime.Size = new System.Drawing.Size(300, 28);
            this.DtP_EndTime.TabIndex = 37;
            // 
            // TbBookingName
            // 
            this.TbBookingName.Location = new System.Drawing.Point(437, 184);
            this.TbBookingName.Multiline = true;
            this.TbBookingName.Name = "TbBookingName";
            this.TbBookingName.Size = new System.Drawing.Size(284, 24);
            this.TbBookingName.TabIndex = 38;
            // 
            // TbAppDetails
            // 
            this.TbAppDetails.Location = new System.Drawing.Point(437, 383);
            this.TbAppDetails.Multiline = true;
            this.TbAppDetails.Name = "TbAppDetails";
            this.TbAppDetails.Size = new System.Drawing.Size(579, 179);
            this.TbAppDetails.TabIndex = 39;
            // 
            // BtTnSave
            // 
            this.BtTnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.BtTnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtTnSave.Location = new System.Drawing.Point(1021, 272);
            this.BtTnSave.Name = "BtTnSave";
            this.BtTnSave.Size = new System.Drawing.Size(150, 45);
            this.BtTnSave.TabIndex = 40;
            this.BtTnSave.Text = "Save";
            this.BtTnSave.UseVisualStyleBackColor = true;
            this.BtTnSave.Click += new System.EventHandler(this.BtTnSave_Click_1);
            // 
            // BtTnCancel
            // 
            this.BtTnCancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtTnCancel.Location = new System.Drawing.Point(1021, 195);
            this.BtTnCancel.Name = "BtTnCancel";
            this.BtTnCancel.Size = new System.Drawing.Size(140, 40);
            this.BtTnCancel.TabIndex = 41;
            this.BtTnCancel.Text = "Cancel";
            this.BtTnCancel.UseVisualStyleBackColor = true;
            this.BtTnCancel.Click += new System.EventHandler(this.BtTnCancel_Click);
            // 
            // BtTnBookNow
            // 
            this.BtTnBookNow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTnBookNow.ForeColor = System.Drawing.Color.Green;
            this.BtTnBookNow.Location = new System.Drawing.Point(94, 497);
            this.BtTnBookNow.Name = "BtTnBookNow";
            this.BtTnBookNow.Size = new System.Drawing.Size(228, 46);
            this.BtTnBookNow.TabIndex = 42;
            this.BtTnBookNow.Text = "Book Appointment";
            this.BtTnBookNow.UseVisualStyleBackColor = true;
            this.BtTnBookNow.Click += new System.EventHandler(this.BtTnBookNow_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(383, 16);
            this.TbSearch.Multiline = true;
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(285, 37);
            this.TbSearch.TabIndex = 43;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.BackColor = System.Drawing.Color.Transparent;
            this.LbId.Location = new System.Drawing.Point(835, 237);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(10, 16);
            this.LbId.TabIndex = 44;
            this.LbId.Text = "l";
            this.LbId.Visible = false;
            // 
            // Add_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 616);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.PbSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.BtTnBookNow);
            this.Controls.Add(this.BtTnCancel);
            this.Controls.Add(this.BtTnSave);
            this.Controls.Add(this.TbAppDetails);
            this.Controls.Add(this.TbBookingName);
            this.Controls.Add(this.DtP_EndTime);
            this.Controls.Add(this.DtP_StartTime);
            this.Controls.Add(this.LbAppointmentDetails);
            this.Controls.Add(this.LbEndTime);
            this.Controls.Add(this.LbStartTime);
            this.Controls.Add(this.LbBookingName);
            this.Controls.Add(this.LbSubHeading);
            this.Controls.Add(this.LbBookingSteps);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.McDatePicker);
            this.Controls.Add(this.PbHome);
            this.Controls.Add(this.PbNettlyLogo);
            this.Controls.Add(this.PbSettings);
            this.Controls.Add(this.PbNavBar);
            this.DoubleBuffered = true;
            this.Name = "Add_Booking";
            this.Text = "Add Booking";
            ((System.ComponentModel.ISupportInitialize)(this.PbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNettlyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNavBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbHome;
        private System.Windows.Forms.PictureBox PbSearch;
        private System.Windows.Forms.PictureBox PbNettlyLogo;
        private System.Windows.Forms.PictureBox PbSettings;
        private System.Windows.Forms.PictureBox PbNavBar;
        private System.Windows.Forms.MonthCalendar McDatePicker;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbBookingSteps;
        private System.Windows.Forms.Label LbSubHeading;
        private System.Windows.Forms.Label LbBookingName;
        private System.Windows.Forms.Label LbStartTime;
        private System.Windows.Forms.Label LbEndTime;
        private System.Windows.Forms.Label LbAppointmentDetails;
        private System.Windows.Forms.DateTimePicker DtP_StartTime;
        private System.Windows.Forms.DateTimePicker DtP_EndTime;
        private System.Windows.Forms.TextBox TbBookingName;
        private System.Windows.Forms.TextBox TbAppDetails;
        private System.Windows.Forms.Button BtTnSave;
        private System.Windows.Forms.Button BtTnCancel;
        private System.Windows.Forms.Button BtTnBookNow;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Label LbId;
    }
}