namespace sbCalendar.Forms
{
    partial class HomeForm
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
            this.appNameLabel = new System.Windows.Forms.Label();
            this.customersGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerLabel = new System.Windows.Forms.Label();
            this.viewCustomersButton = new System.Windows.Forms.Button();
            this.viewCustomersLabel = new System.Windows.Forms.Label();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.addAppointmentLabel = new System.Windows.Forms.Label();
            this.viewAppointmentsButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.viewAppointmentsLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.reportsGroupBox = new System.Windows.Forms.GroupBox();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.viewReportsLabel = new System.Windows.Forms.Label();
            this.customersGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.reportsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(240, 27);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGroupBox.Controls.Add(this.addCustomerButton);
            this.customersGroupBox.Controls.Add(this.addCustomerLabel);
            this.customersGroupBox.Controls.Add(this.viewCustomersButton);
            this.customersGroupBox.Controls.Add(this.viewCustomersLabel);
            this.customersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGroupBox.Location = new System.Drawing.Point(14, 85);
            this.customersGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Size = new System.Drawing.Size(299, 167);
            this.customersGroupBox.TabIndex = 1;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(12, 103);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(80, 32);
            this.addCustomerButton.TabIndex = 2;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addCustomerLabel
            // 
            this.addCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerLabel.Location = new System.Drawing.Point(96, 113);
            this.addCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCustomerLabel.Name = "addCustomerLabel";
            this.addCustomerLabel.Size = new System.Drawing.Size(178, 33);
            this.addCustomerLabel.TabIndex = 3;
            this.addCustomerLabel.Text = "Add a customer";
            // 
            // viewCustomersButton
            // 
            this.viewCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersButton.Location = new System.Drawing.Point(12, 41);
            this.viewCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomersButton.Name = "viewCustomersButton";
            this.viewCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.viewCustomersButton.TabIndex = 0;
            this.viewCustomersButton.Text = "View";
            this.viewCustomersButton.UseVisualStyleBackColor = true;
            this.viewCustomersButton.Click += new System.EventHandler(this.viewCustomersButton_Click);
            // 
            // viewCustomersLabel
            // 
            this.viewCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersLabel.Location = new System.Drawing.Point(96, 43);
            this.viewCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewCustomersLabel.Name = "viewCustomersLabel";
            this.viewCustomersLabel.Size = new System.Drawing.Size(178, 28);
            this.viewCustomersLabel.TabIndex = 1;
            this.viewCustomersLabel.Text = "View, update, or remove customers";
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentsGroupBox.Controls.Add(this.addAppointmentLabel);
            this.appointmentsGroupBox.Controls.Add(this.viewAppointmentsButton);
            this.appointmentsGroupBox.Controls.Add(this.addAppointmentButton);
            this.appointmentsGroupBox.Controls.Add(this.viewAppointmentsLabel);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(351, 85);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(299, 167);
            this.appointmentsGroupBox.TabIndex = 2;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // addAppointmentLabel
            // 
            this.addAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentLabel.Location = new System.Drawing.Point(96, 112);
            this.addAppointmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addAppointmentLabel.Name = "addAppointmentLabel";
            this.addAppointmentLabel.Size = new System.Drawing.Size(184, 33);
            this.addAppointmentLabel.TabIndex = 3;
            this.addAppointmentLabel.Text = "Add an appointment";
            // 
            // viewAppointmentsButton
            // 
            this.viewAppointmentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAppointmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsButton.Location = new System.Drawing.Point(11, 41);
            this.viewAppointmentsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(80, 32);
            this.viewAppointmentsButton.TabIndex = 0;
            this.viewAppointmentsButton.Text = "View";
            this.viewAppointmentsButton.UseVisualStyleBackColor = true;
            this.viewAppointmentsButton.Click += new System.EventHandler(this.viewApptsButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.Location = new System.Drawing.Point(11, 103);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(80, 32);
            this.addAppointmentButton.TabIndex = 2;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // viewAppointmentsLabel
            // 
            this.viewAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsLabel.Location = new System.Drawing.Point(96, 41);
            this.viewAppointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewAppointmentsLabel.Name = "viewAppointmentsLabel";
            this.viewAppointmentsLabel.Size = new System.Drawing.Size(184, 32);
            this.viewAppointmentsLabel.TabIndex = 1;
            this.viewAppointmentsLabel.Text = "View, update, or remove appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(574, 382);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(80, 32);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // reportsGroupBox
            // 
            this.reportsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsGroupBox.Controls.Add(this.viewReportsButton);
            this.reportsGroupBox.Controls.Add(this.viewReportsLabel);
            this.reportsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsGroupBox.Location = new System.Drawing.Point(183, 270);
            this.reportsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.reportsGroupBox.Name = "reportsGroupBox";
            this.reportsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.reportsGroupBox.Size = new System.Drawing.Size(299, 106);
            this.reportsGroupBox.TabIndex = 3;
            this.reportsGroupBox.TabStop = false;
            this.reportsGroupBox.Text = "Reports";
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsButton.Location = new System.Drawing.Point(12, 41);
            this.viewReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(80, 32);
            this.viewReportsButton.TabIndex = 0;
            this.viewReportsButton.Text = "View";
            this.viewReportsButton.UseVisualStyleBackColor = true;
            this.viewReportsButton.Click += new System.EventHandler(this.viewReportsButton_Click);
            // 
            // viewReportsLabel
            // 
            this.viewReportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsLabel.Location = new System.Drawing.Point(96, 43);
            this.viewReportsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewReportsLabel.Name = "viewReportsLabel";
            this.viewReportsLabel.Size = new System.Drawing.Size(178, 28);
            this.viewReportsLabel.TabIndex = 1;
            this.viewReportsLabel.Text = "View reports based on customer and appointment data";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 425);
            this.Controls.Add(this.reportsGroupBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Controls.Add(this.appNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.customersGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.ResumeLayout(false);
            this.reportsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.GroupBox customersGroupBox;
        private System.Windows.Forms.Label viewCustomersLabel;
        private System.Windows.Forms.GroupBox appointmentsGroupBox;
        private System.Windows.Forms.Label viewAppointmentsLabel;
        private System.Windows.Forms.Button viewCustomersButton;
        private System.Windows.Forms.Button viewAppointmentsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label addCustomerLabel;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Label addAppointmentLabel;
        private System.Windows.Forms.GroupBox reportsGroupBox;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Label viewReportsLabel;
    }
}