namespace sbCalendar.Forms.Customers
{
    partial class ViewCustomersForm
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
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.appNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.AllowUserToResizeRows = false;
            this.customersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDGV.Location = new System.Drawing.Point(12, 45);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(711, 357);
            this.customersDGV.TabIndex = 0;
            this.customersDGV.SelectionChanged += new System.EventHandler(this.customersDGV_SelectionChanged);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerButton.Location = new System.Drawing.Point(34, 432);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(98, 45);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentButton.Location = new System.Drawing.Point(319, 432);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(98, 45);
            this.addAppointmentButton.TabIndex = 3;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCustomerButton.Location = new System.Drawing.Point(461, 432);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(98, 45);
            this.deleteCustomerButton.TabIndex = 4;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCustomerButton.Location = new System.Drawing.Point(176, 432);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(98, 45);
            this.updateCustomerButton.TabIndex = 2;
            this.updateCustomerButton.Text = "Update Customer";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(603, 432);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 45);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(291, 9);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 6;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 489);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customersDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.ViewCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label appNameLabel;
    }
}