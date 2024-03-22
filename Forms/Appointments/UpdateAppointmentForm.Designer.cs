namespace sbCalendar.Forms.Appointments
{
    partial class UpdateAppointmentForm
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
            this.updateAppointmentButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newAppointmentLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.currentAppointmentLabel = new System.Windows.Forms.Label();
            this.currentAppointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.currentAppointmentEndTimeLabel = new System.Windows.Forms.Label();
            this.currentAppointmentStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.currentAppointmentEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.newAppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.currentAppointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.currentAppointmentDateLabel = new System.Windows.Forms.Label();
            this.newAppointmentEndTimelabel = new System.Windows.Forms.Label();
            this.newAppointmentStartTimeLabel = new System.Windows.Forms.Label();
            this.newAppointmentEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newAppointmentStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(151, 17);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateAppointmentButton
            // 
            this.updateAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateAppointmentButton.Location = new System.Drawing.Point(108, 540);
            this.updateAppointmentButton.Name = "updateAppointmentButton";
            this.updateAppointmentButton.Size = new System.Drawing.Size(101, 41);
            this.updateAppointmentButton.TabIndex = 28;
            this.updateAppointmentButton.Text = "Update";
            this.updateAppointmentButton.UseVisualStyleBackColor = true;
            this.updateAppointmentButton.Click += new System.EventHandler(this.updateAppointmentButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // newAppointmentLabel
            // 
            this.newAppointmentLabel.AutoSize = true;
            this.newAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointmentLabel.Location = new System.Drawing.Point(22, 407);
            this.newAppointmentLabel.Name = "newAppointmentLabel";
            this.newAppointmentLabel.Size = new System.Drawing.Size(113, 15);
            this.newAppointmentLabel.TabIndex = 22;
            this.newAppointmentLabel.Text = "Select new date:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(234, 249);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(192, 20);
            this.typeTextBox.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(22, 124);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(232, 232);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(36, 15);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(234, 92);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(192, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(24, 143);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(196, 160);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(232, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 15);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(24, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(234, 194);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(192, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(234, 303);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(192, 20);
            this.urlTextBox.TabIndex = 14;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(232, 176);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(57, 15);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(232, 284);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(35, 15);
            this.urlLabel.TabIndex = 13;
            this.urlLabel.Text = "URL:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(234, 143);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(192, 20);
            this.contactTextBox.TabIndex = 8;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(232, 125);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(51, 15);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact:";
            // 
            // currentAppointmentLabel
            // 
            this.currentAppointmentLabel.AutoSize = true;
            this.currentAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentLabel.Location = new System.Drawing.Point(22, 330);
            this.currentAppointmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAppointmentLabel.Name = "currentAppointmentLabel";
            this.currentAppointmentLabel.Size = new System.Drawing.Size(138, 15);
            this.currentAppointmentLabel.TabIndex = 15;
            this.currentAppointmentLabel.Text = "Current Appointment";
            // 
            // currentAppointmentStartTimeLabel
            // 
            this.currentAppointmentStartTimeLabel.AutoSize = true;
            this.currentAppointmentStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentStartTimeLabel.Location = new System.Drawing.Point(164, 351);
            this.currentAppointmentStartTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAppointmentStartTimeLabel.Name = "currentAppointmentStartTimeLabel";
            this.currentAppointmentStartTimeLabel.Size = new System.Drawing.Size(66, 15);
            this.currentAppointmentStartTimeLabel.TabIndex = 18;
            this.currentAppointmentStartTimeLabel.Text = "Start Time:";
            // 
            // currentAppointmentEndTimeLabel
            // 
            this.currentAppointmentEndTimeLabel.AutoSize = true;
            this.currentAppointmentEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentEndTimeLabel.Location = new System.Drawing.Point(291, 350);
            this.currentAppointmentEndTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAppointmentEndTimeLabel.Name = "currentAppointmentEndTimeLabel";
            this.currentAppointmentEndTimeLabel.Size = new System.Drawing.Size(63, 15);
            this.currentAppointmentEndTimeLabel.TabIndex = 20;
            this.currentAppointmentEndTimeLabel.Text = "End Time:";
            // 
            // currentAppointmentStartTimeTextBox
            // 
            this.currentAppointmentStartTimeTextBox.Location = new System.Drawing.Point(164, 367);
            this.currentAppointmentStartTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentAppointmentStartTimeTextBox.Name = "currentAppointmentStartTimeTextBox";
            this.currentAppointmentStartTimeTextBox.Size = new System.Drawing.Size(99, 20);
            this.currentAppointmentStartTimeTextBox.TabIndex = 19;
            // 
            // currentAppointmentEndTimeTextBox
            // 
            this.currentAppointmentEndTimeTextBox.Location = new System.Drawing.Point(293, 367);
            this.currentAppointmentEndTimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentAppointmentEndTimeTextBox.Name = "currentAppointmentEndTimeTextBox";
            this.currentAppointmentEndTimeTextBox.Size = new System.Drawing.Size(99, 20);
            this.currentAppointmentEndTimeTextBox.TabIndex = 21;
            // 
            // newAppointmentDatePicker
            // 
            this.newAppointmentDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAppointmentDatePicker.Location = new System.Drawing.Point(24, 425);
            this.newAppointmentDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentDatePicker.Name = "newAppointmentDatePicker";
            this.newAppointmentDatePicker.Size = new System.Drawing.Size(187, 20);
            this.newAppointmentDatePicker.TabIndex = 23;
            this.newAppointmentDatePicker.ValueChanged += new System.EventHandler(this.newAppointmentDatePicker_ValueChanged);
            // 
            // currentAppointmentDateTextBox
            // 
            this.currentAppointmentDateTextBox.Location = new System.Drawing.Point(24, 367);
            this.currentAppointmentDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentAppointmentDateTextBox.Name = "currentAppointmentDateTextBox";
            this.currentAppointmentDateTextBox.Size = new System.Drawing.Size(114, 20);
            this.currentAppointmentDateTextBox.TabIndex = 17;
            // 
            // currentAppointmentDateLabel
            // 
            this.currentAppointmentDateLabel.AutoSize = true;
            this.currentAppointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentDateLabel.Location = new System.Drawing.Point(22, 351);
            this.currentAppointmentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAppointmentDateLabel.Name = "currentAppointmentDateLabel";
            this.currentAppointmentDateLabel.Size = new System.Drawing.Size(36, 15);
            this.currentAppointmentDateLabel.TabIndex = 16;
            this.currentAppointmentDateLabel.Text = "Date:";
            // 
            // newAppointmentEndTimelabel
            // 
            this.newAppointmentEndTimelabel.AutoSize = true;
            this.newAppointmentEndTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointmentEndTimelabel.Location = new System.Drawing.Point(240, 468);
            this.newAppointmentEndTimelabel.Name = "newAppointmentEndTimelabel";
            this.newAppointmentEndTimelabel.Size = new System.Drawing.Size(68, 15);
            this.newAppointmentEndTimelabel.TabIndex = 26;
            this.newAppointmentEndTimelabel.Text = "End Time";
            // 
            // newAppointmentStartTimeLabel
            // 
            this.newAppointmentStartTimeLabel.AutoSize = true;
            this.newAppointmentStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointmentStartTimeLabel.Location = new System.Drawing.Point(22, 468);
            this.newAppointmentStartTimeLabel.Name = "newAppointmentStartTimeLabel";
            this.newAppointmentStartTimeLabel.Size = new System.Drawing.Size(73, 15);
            this.newAppointmentStartTimeLabel.TabIndex = 24;
            this.newAppointmentStartTimeLabel.Text = "Start Time";
            // 
            // newAppointmentEndTimePicker
            // 
            this.newAppointmentEndTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAppointmentEndTimePicker.CustomFormat = "hh:mm tt";
            this.newAppointmentEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newAppointmentEndTimePicker.Location = new System.Drawing.Point(243, 485);
            this.newAppointmentEndTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentEndTimePicker.Name = "newAppointmentEndTimePicker";
            this.newAppointmentEndTimePicker.ShowUpDown = true;
            this.newAppointmentEndTimePicker.Size = new System.Drawing.Size(150, 20);
            this.newAppointmentEndTimePicker.TabIndex = 27;
            // 
            // newAppointmentStartTimePicker
            // 
            this.newAppointmentStartTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAppointmentStartTimePicker.CustomFormat = "hh:mm tt";
            this.newAppointmentStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newAppointmentStartTimePicker.Location = new System.Drawing.Point(24, 485);
            this.newAppointmentStartTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentStartTimePicker.Name = "newAppointmentStartTimePicker";
            this.newAppointmentStartTimePicker.ShowUpDown = true;
            this.newAppointmentStartTimePicker.Size = new System.Drawing.Size(150, 20);
            this.newAppointmentStartTimePicker.TabIndex = 25;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(238, 540);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 41);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 606);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newAppointmentEndTimelabel);
            this.Controls.Add(this.newAppointmentStartTimeLabel);
            this.Controls.Add(this.newAppointmentEndTimePicker);
            this.Controls.Add(this.newAppointmentStartTimePicker);
            this.Controls.Add(this.currentAppointmentDateTextBox);
            this.Controls.Add(this.currentAppointmentDateLabel);
            this.Controls.Add(this.newAppointmentDatePicker);
            this.Controls.Add(this.currentAppointmentEndTimeTextBox);
            this.Controls.Add(this.currentAppointmentStartTimeTextBox);
            this.Controls.Add(this.currentAppointmentEndTimeLabel);
            this.Controls.Add(this.currentAppointmentStartTimeLabel);
            this.Controls.Add(this.currentAppointmentLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.updateAppointmentButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.newAppointmentLabel);
            this.Name = "UpdateAppointmentForm";
            this.Text = "Update Appointment";
            this.Load += new System.EventHandler(this.UpdateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button updateAppointmentButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label newAppointmentLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label currentAppointmentLabel;
        private System.Windows.Forms.Label currentAppointmentStartTimeLabel;
        private System.Windows.Forms.Label currentAppointmentEndTimeLabel;
        private System.Windows.Forms.TextBox currentAppointmentStartTimeTextBox;
        private System.Windows.Forms.TextBox currentAppointmentEndTimeTextBox;
        private System.Windows.Forms.DateTimePicker newAppointmentDatePicker;
        private System.Windows.Forms.TextBox currentAppointmentDateTextBox;
        private System.Windows.Forms.Label currentAppointmentDateLabel;
        private System.Windows.Forms.Label newAppointmentEndTimelabel;
        private System.Windows.Forms.Label newAppointmentStartTimeLabel;
        private System.Windows.Forms.DateTimePicker newAppointmentEndTimePicker;
        private System.Windows.Forms.DateTimePicker newAppointmentStartTimePicker;
        private System.Windows.Forms.Button cancelButton;
    }
}