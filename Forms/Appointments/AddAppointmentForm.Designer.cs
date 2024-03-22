namespace sbCalendar.Forms.Appointments
{
    partial class AddAppointmentForm
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
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.addAppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentStartTimePickerLabel = new System.Windows.Forms.Label();
            this.addAppointmentEndTimePickerLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(244, 140);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(176, 20);
            this.contactTextBox.TabIndex = 8;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(242, 122);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(51, 15);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(244, 190);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(176, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(244, 292);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(176, 20);
            this.urlTextBox.TabIndex = 14;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(242, 172);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(57, 15);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(242, 273);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(35, 15);
            this.urlLabel.TabIndex = 13;
            this.urlLabel.Text = "URL:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(152, 19);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.Location = new System.Drawing.Point(136, 460);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(86, 41);
            this.addAppointmentButton.TabIndex = 21;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(244, 239);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(176, 20);
            this.typeTextBox.TabIndex = 12;
            // 
            // appointmentDescriptionTextBox
            // 
            this.appointmentDescriptionTextBox.Location = new System.Drawing.Point(26, 140);
            this.appointmentDescriptionTextBox.Multiline = true;
            this.appointmentDescriptionTextBox.Name = "appointmentDescriptionTextBox";
            this.appointmentDescriptionTextBox.Size = new System.Drawing.Size(190, 160);
            this.appointmentDescriptionTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(244, 89);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(176, 20);
            this.titleTextBox.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(242, 221);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(36, 15);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type:";
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(24, 121);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.appointmentDescriptionLabel.TabIndex = 3;
            this.appointmentDescriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(242, 71);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 15);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(26, 327);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(65, 15);
            this.calendarLabel.TabIndex = 15;
            this.calendarLabel.Text = "Calendar";
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(26, 86);
            this.customerNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(175, 21);
            this.customerNameComboBox.TabIndex = 2;
            // 
            // addAppointmentDatePicker
            // 
            this.addAppointmentDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentDatePicker.Location = new System.Drawing.Point(26, 344);
            this.addAppointmentDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.addAppointmentDatePicker.Name = "addAppointmentDatePicker";
            this.addAppointmentDatePicker.Size = new System.Drawing.Size(190, 20);
            this.addAppointmentDatePicker.TabIndex = 16;
            // 
            // addAppointmentStartTimePicker
            // 
            this.addAppointmentStartTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentStartTimePicker.CustomFormat = "hh:mm tt";
            this.addAppointmentStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addAppointmentStartTimePicker.Location = new System.Drawing.Point(26, 401);
            this.addAppointmentStartTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.addAppointmentStartTimePicker.Name = "addAppointmentStartTimePicker";
            this.addAppointmentStartTimePicker.ShowUpDown = true;
            this.addAppointmentStartTimePicker.Size = new System.Drawing.Size(190, 20);
            this.addAppointmentStartTimePicker.TabIndex = 18;
            this.addAppointmentStartTimePicker.ValueChanged += new System.EventHandler(this.schedApptStartTimePicker_ValueChanged);
            // 
            // addAppointmentEndTimePicker
            // 
            this.addAppointmentEndTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentEndTimePicker.CustomFormat = "hh:mm tt";
            this.addAppointmentEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addAppointmentEndTimePicker.Location = new System.Drawing.Point(245, 401);
            this.addAppointmentEndTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.addAppointmentEndTimePicker.Name = "addAppointmentEndTimePicker";
            this.addAppointmentEndTimePicker.ShowUpDown = true;
            this.addAppointmentEndTimePicker.Size = new System.Drawing.Size(190, 20);
            this.addAppointmentEndTimePicker.TabIndex = 20;
            // 
            // addAppointmentStartTimePickerLabel
            // 
            this.addAppointmentStartTimePickerLabel.AutoSize = true;
            this.addAppointmentStartTimePickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentStartTimePickerLabel.Location = new System.Drawing.Point(24, 384);
            this.addAppointmentStartTimePickerLabel.Name = "addAppointmentStartTimePickerLabel";
            this.addAppointmentStartTimePickerLabel.Size = new System.Drawing.Size(73, 15);
            this.addAppointmentStartTimePickerLabel.TabIndex = 17;
            this.addAppointmentStartTimePickerLabel.Text = "Start Time";
            // 
            // addAppointmentEndTimePickerLabel
            // 
            this.addAppointmentEndTimePickerLabel.AutoSize = true;
            this.addAppointmentEndTimePickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentEndTimePickerLabel.Location = new System.Drawing.Point(242, 384);
            this.addAppointmentEndTimePickerLabel.Name = "addAppointmentEndTimePickerLabel";
            this.addAppointmentEndTimePickerLabel.Size = new System.Drawing.Size(68, 15);
            this.addAppointmentEndTimePickerLabel.TabIndex = 19;
            this.addAppointmentEndTimePickerLabel.Text = "End Time";
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(234, 460);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 41);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 520);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAppointmentEndTimePickerLabel);
            this.Controls.Add(this.addAppointmentStartTimePickerLabel);
            this.Controls.Add(this.addAppointmentEndTimePicker);
            this.Controls.Add(this.addAppointmentStartTimePicker);
            this.Controls.Add(this.addAppointmentDatePicker);
            this.Controls.Add(this.customerNameComboBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.appointmentDescriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calendarLabel);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox appointmentDescriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.DateTimePicker addAppointmentDatePicker;
        private System.Windows.Forms.DateTimePicker addAppointmentStartTimePicker;
        private System.Windows.Forms.DateTimePicker addAppointmentEndTimePicker;
        private System.Windows.Forms.Label addAppointmentStartTimePickerLabel;
        private System.Windows.Forms.Label addAppointmentEndTimePickerLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}