namespace sbCalendar.Forms.Appointments
{
    partial class ViewAppointmentsForm
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
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.customersDGVLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.customerAppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.pastAppointmentsLabel = new System.Windows.Forms.LinkLabel();
            this.byWeekButton = new System.Windows.Forms.Button();
            this.byMonthButton = new System.Windows.Forms.Button();
            this.allAppointmentsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.byDayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAppointmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.AllowUserToResizeColumns = false;
            this.customersDGV.AllowUserToResizeRows = false;
            this.customersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDGV.Location = new System.Drawing.Point(10, 95);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(432, 241);
            this.customersDGV.TabIndex = 2;
            this.customersDGV.SelectionChanged += new System.EventHandler(this.customersDGV_SelectionChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(469, 115);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(148, 15);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Viewing appointments for:";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Enabled = false;
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(471, 132);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerTextBox.Multiline = true;
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(234, 25);
            this.customerTextBox.TabIndex = 4;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(352, 29);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersDGVLabel
            // 
            this.customersDGVLabel.AutoSize = true;
            this.customersDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersDGVLabel.Location = new System.Drawing.Point(10, 76);
            this.customersDGVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customersDGVLabel.Name = "customersDGVLabel";
            this.customersDGVLabel.Size = new System.Drawing.Size(69, 15);
            this.customersDGVLabel.TabIndex = 1;
            this.customersDGVLabel.Text = "Customers:";
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Location = new System.Drawing.Point(617, 353);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(65, 33);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Location = new System.Drawing.Point(696, 353);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // customerAppointmentsDGV
            // 
            this.customerAppointmentsDGV.AllowUserToAddRows = false;
            this.customerAppointmentsDGV.AllowUserToDeleteRows = false;
            this.customerAppointmentsDGV.AllowUserToResizeColumns = false;
            this.customerAppointmentsDGV.AllowUserToResizeRows = false;
            this.customerAppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerAppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerAppointmentsDGV.Location = new System.Drawing.Point(471, 162);
            this.customerAppointmentsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.customerAppointmentsDGV.Name = "customerAppointmentsDGV";
            this.customerAppointmentsDGV.ReadOnly = true;
            this.customerAppointmentsDGV.RowHeadersVisible = false;
            this.customerAppointmentsDGV.RowHeadersWidth = 51;
            this.customerAppointmentsDGV.RowTemplate.Height = 24;
            this.customerAppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerAppointmentsDGV.Size = new System.Drawing.Size(438, 175);
            this.customerAppointmentsDGV.TabIndex = 6;
            this.customerAppointmentsDGV.SelectionChanged += new System.EventHandler(this.customerAppointmentsDGV_SelectionChanged);
            // 
            // pastAppointmentsLabel
            // 
            this.pastAppointmentsLabel.AutoSize = true;
            this.pastAppointmentsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastAppointmentsLabel.Location = new System.Drawing.Point(728, 141);
            this.pastAppointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pastAppointmentsLabel.Name = "pastAppointmentsLabel";
            this.pastAppointmentsLabel.Size = new System.Drawing.Size(137, 15);
            this.pastAppointmentsLabel.TabIndex = 5;
            this.pastAppointmentsLabel.TabStop = true;
            this.pastAppointmentsLabel.Text = "View past appointments";
            this.pastAppointmentsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pastAppointmentsLabel_LinkClicked);
            // 
            // byWeekButton
            // 
            this.byWeekButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byWeekButton.Location = new System.Drawing.Point(250, 353);
            this.byWeekButton.Margin = new System.Windows.Forms.Padding(2);
            this.byWeekButton.Name = "byWeekButton";
            this.byWeekButton.Size = new System.Drawing.Size(85, 33);
            this.byWeekButton.TabIndex = 8;
            this.byWeekButton.Text = "By Week";
            this.byWeekButton.UseVisualStyleBackColor = true;
            this.byWeekButton.Click += new System.EventHandler(this.byWeekButton_Click);
            // 
            // byMonthButton
            // 
            this.byMonthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byMonthButton.Location = new System.Drawing.Point(147, 353);
            this.byMonthButton.Margin = new System.Windows.Forms.Padding(2);
            this.byMonthButton.Name = "byMonthButton";
            this.byMonthButton.Size = new System.Drawing.Size(85, 33);
            this.byMonthButton.TabIndex = 9;
            this.byMonthButton.Text = "By Month";
            this.byMonthButton.UseVisualStyleBackColor = true;
            this.byMonthButton.Click += new System.EventHandler(this.byMonthButton_Click);
            // 
            // allAppointmentsLabel
            // 
            this.allAppointmentsLabel.AutoSize = true;
            this.allAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allAppointmentsLabel.Location = new System.Drawing.Point(12, 361);
            this.allAppointmentsLabel.Name = "allAppointmentsLabel";
            this.allAppointmentsLabel.Size = new System.Drawing.Size(130, 15);
            this.allAppointmentsLabel.TabIndex = 7;
            this.allAppointmentsLabel.Text = "View all appointments:";
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(844, 353);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(65, 33);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // byDayButton
            // 
            this.byDayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byDayButton.Location = new System.Drawing.Point(357, 353);
            this.byDayButton.Margin = new System.Windows.Forms.Padding(2);
            this.byDayButton.Name = "byDayButton";
            this.byDayButton.Size = new System.Drawing.Size(85, 33);
            this.byDayButton.TabIndex = 13;
            this.byDayButton.Text = "By Day";
            this.byDayButton.UseVisualStyleBackColor = true;
            this.byDayButton.Click += new System.EventHandler(this.byDayButton_Click);
            // 
            // ViewAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 399);
            this.Controls.Add(this.byDayButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.allAppointmentsLabel);
            this.Controls.Add(this.byMonthButton);
            this.Controls.Add(this.byWeekButton);
            this.Controls.Add(this.pastAppointmentsLabel);
            this.Controls.Add(this.customerAppointmentsDGV);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.customersDGVLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customersDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAppointmentsForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.ViewAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAppointmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label customersDGVLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView customerAppointmentsDGV;
        private System.Windows.Forms.LinkLabel pastAppointmentsLabel;
        private System.Windows.Forms.Button byWeekButton;
        private System.Windows.Forms.Button byMonthButton;
        private System.Windows.Forms.Label allAppointmentsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button byDayButton;
    }
}