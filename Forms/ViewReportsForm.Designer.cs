namespace sbCalendar.Forms
{
    partial class ViewReportsForm
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
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.reportTypeComboBoxLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.consultantComboBoxLabel = new System.Windows.Forms.Label();
            this.consultantComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDGV
            // 
            this.reportDGV.AllowUserToAddRows = false;
            this.reportDGV.AllowUserToDeleteRows = false;
            this.reportDGV.AllowUserToResizeColumns = false;
            this.reportDGV.AllowUserToResizeRows = false;
            this.reportDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Location = new System.Drawing.Point(12, 175);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.RowHeadersVisible = false;
            this.reportDGV.Size = new System.Drawing.Size(446, 263);
            this.reportDGV.TabIndex = 6;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(159, 26);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(147, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "sbCalendar";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Location = new System.Drawing.Point(12, 100);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(274, 21);
            this.reportTypeComboBox.TabIndex = 2;
            this.reportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.reportTypeComboBox_SelectedIndexChanged);
            // 
            // reportTypeComboBoxLabel
            // 
            this.reportTypeComboBoxLabel.AutoSize = true;
            this.reportTypeComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeComboBoxLabel.Location = new System.Drawing.Point(9, 84);
            this.reportTypeComboBoxLabel.Name = "reportTypeComboBoxLabel";
            this.reportTypeComboBoxLabel.Size = new System.Drawing.Size(81, 15);
            this.reportTypeComboBoxLabel.TabIndex = 1;
            this.reportTypeComboBoxLabel.Text = "Report to run:";
            // 
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(350, 95);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 29);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // consultantComboBoxLabel
            // 
            this.consultantComboBoxLabel.AutoSize = true;
            this.consultantComboBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantComboBoxLabel.Location = new System.Drawing.Point(13, 128);
            this.consultantComboBoxLabel.Name = "consultantComboBoxLabel";
            this.consultantComboBoxLabel.Size = new System.Drawing.Size(113, 15);
            this.consultantComboBoxLabel.TabIndex = 3;
            this.consultantComboBoxLabel.Text = "Select a consultant:";
            this.consultantComboBoxLabel.Visible = false;
            // 
            // consultantComboBox
            // 
            this.consultantComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultantComboBox.FormattingEnabled = true;
            this.consultantComboBox.Location = new System.Drawing.Point(12, 144);
            this.consultantComboBox.Name = "consultantComboBox";
            this.consultantComboBox.Size = new System.Drawing.Size(274, 21);
            this.consultantComboBox.TabIndex = 4;
            this.consultantComboBox.Visible = false;
            // 
            // ViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.consultantComboBox);
            this.Controls.Add(this.consultantComboBoxLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.reportTypeComboBoxLabel);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.reportDGV);
            this.Name = "ViewReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ViewReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label reportTypeComboBoxLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label consultantComboBoxLabel;
        private System.Windows.Forms.ComboBox consultantComboBox;
    }
}