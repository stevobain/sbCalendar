using sbCalendar.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sbCalendar.Forms
{
    public partial class ViewReportsForm : Form
    {
        public ViewReportsForm()
        {
            InitializeComponent();
        }

        ClientScheduleRepository clientScheduleRepository;

        private void ViewReportsForm_Load(object sender, EventArgs e)
        {
            clientScheduleRepository = new ClientScheduleRepository();

            // Report types are loaded into the reportTypeComboBox
            reportTypeComboBox.Items.Add("Number of appointment types by month");
            reportTypeComboBox.Items.Add("Schedule for each consultant");
            reportTypeComboBox.Items.Add("Number of customers added by month");

            reportDGV.DataSource = null;
            reportDGV.ClearSelection();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // If selectedIndex is 0, get the count of appointment types by month and display the output in the reportDGV
            if (reportTypeComboBox.SelectedIndex == 0)
            {
                reportDGV.DataSource = clientScheduleRepository.CountApptTypesByMonth();
            }
            // If selectedIndex is 1, load the selected consultants schedule
            else if (reportTypeComboBox.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(consultantComboBox.Text))
                {
                    var result = clientScheduleRepository.LoadConsultantSchedules(consultantComboBox.Text).Select(x => new { x.AppointmentID, x.CustomerID, x.Title, x.Description, x.Location, x.Contact, x.Type, x.Url, x.Start, x.End }).ToList();

                    reportDGV.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Please select a consultant before loading the report.", "sbCalendar - Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            // If selectedIndex is 2, get the count of customers created by month and display the output in the reportDGV
            else if (reportTypeComboBox.SelectedIndex == 2)
            {
                reportDGV.DataSource = clientScheduleRepository.CountCustomersCreatedByMonth();
            }
            else
            {
                MessageBox.Show("Please select a report to load.", "sbCalendar - Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void reportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If selectedIndex is 1, show the consultantNameComboBox, else, make it hidden
            if (reportTypeComboBox.SelectedIndex == 1)
            {
                consultantComboBox.Items.Clear();

                // Add all consultant names to the consultantNameComboBox
                foreach (User user in clientScheduleRepository.GetAllUsers())
                {
                    consultantComboBox.Items.Add(user.UserName);
                }

                consultantComboBox.Visible = true;
                consultantComboBoxLabel.Visible = true;
            }
            else
            {
                reportDGV.DataSource = null;
                consultantComboBox.Visible = false;
                consultantComboBoxLabel.Visible = false;
            }
        }
    }
}