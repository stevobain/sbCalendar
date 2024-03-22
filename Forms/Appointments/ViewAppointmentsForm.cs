using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sbCalendar.Forms.Appointments
{
    public partial class ViewAppointmentsForm : Form
    {
        public ViewAppointmentsForm()
        {
            InitializeComponent();
        }

        private ClientScheduleRepository clientScheduleRepository;
        private bool initialLoad;
        private bool initialSelectedCustomerAppointmentsLoad;
        private List<Appointment> appointments;
        private List<Customer> customerList;
        private List<Appointment> selectedCustomerScheduledAppointments;
        private List<Appointment> selectedCustomerPastAppointments;
        private Customer selectedCustomer;
        private Appointment selectedCustomerAppointment;

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            initialLoad = true;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            selectedCustomer = new Customer();
            appointments = new List<Appointment>();
            selectedCustomerScheduledAppointments = new List<Appointment>();
            selectedCustomerPastAppointments = new List<Appointment>();
            customerList = new List<Customer>();
            clientScheduleRepository = new ClientScheduleRepository();
            customersDGV.DataSource = clientScheduleRepository.GetAllCustomers();

            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hide the column for the Address object
                if (col.Name == "Address")
                    customersDGV.Columns[col.Name].Visible = false;
            }

            customersDGV.ClearSelection();
            initialLoad = false;
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (!initialLoad)
            {
                Customer customer = GetSelectedCustomer();

                if (customer != null)
                {
                    customerTextBox.Text = customer.CustomerName;

                    initialSelectedCustomerAppointmentsLoad = true;

                    selectedCustomerScheduledAppointments = GetSelectedCustomerAppointments(customer);

                    // Swap between past and current appointment views
                    if (selectedCustomerScheduledAppointments.Count != 0 || selectedCustomerPastAppointments.Count != 0)
                    {
                        if (pastAppointmentsLabel.Text == "View past appointments")
                        {
                            customerAppointmentsDGV.DataSource = selectedCustomerScheduledAppointments;
                            customerAppointmentsDGV.ClearSelection();

                            foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                            {
                                // Show only AppointmentID, Type, Start, and End in the customerAppointmentsDGV
                                if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                                    customerAppointmentsDGV.Columns[col.Name].Visible = false;
                            }
                        }
                        else
                        {
                            customerAppointmentsDGV.DataSource = selectedCustomerPastAppointments;
                            customerAppointmentsDGV.ClearSelection();

                            foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                            {
                                // Show only AppointmentID, Type, Start, and End in the customerAppointmentsDGV
                                if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                                    customerAppointmentsDGV.Columns[col.Name].Visible = false;
                            }
                        }
                    }
                    else
                    {
                        customerAppointmentsDGV.DataSource = null;
                        updateButton.Enabled = false;
                        deleteButton.Enabled = false;
                    }

                    initialSelectedCustomerAppointmentsLoad = false;
                }
            }
        }

        private List<Appointment> GetSelectedCustomerAppointments(Customer customer)
        {

            appointments = clientScheduleRepository.GetAllCustomerAppointments();

            // Lambda is used to query the list and return appointments that are in the future, and also another lambda is used to get past appointments
            var upcomingCustAppts = appointments.Where(x => ((x.Start >= DateTime.Now) || (x.Start < DateTime.Now && x.End > DateTime.Now)) && (x.CustomerID == customer.CustomerID)).ToList();
            selectedCustomerPastAppointments = appointments.Where(x => (x.End < DateTime.Now) && (x.CustomerID == customer.CustomerID)).ToList();
            return upcomingCustAppts;
        }

        // Get the selected customer from the data grid view
        public Customer GetSelectedCustomer()
        {
            customerList = new List<Customer>();
            customerList = clientScheduleRepository.GetAllCustomers();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if (col.Name == "CustomerID")
                    {
                        selectedCustomer = customerList.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                    }
                }
            }

            return selectedCustomer;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Hide();
            // Send the selected customer to the UpdateAppointmentForm
            UpdateAppointmentForm updateAppointmentForm = new UpdateAppointmentForm(selectedCustomerAppointment);
            updateAppointmentForm.ShowDialog();
            Show();

            customersDGV_SelectionChanged(sender, e);
        }

        // Get the selected customer from the data grid view on the selection changed event
        private void customerAppointmentsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (!initialSelectedCustomerAppointmentsLoad)
            {
                if (customerAppointmentsDGV.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in customerAppointmentsDGV.SelectedRows)
                    {
                        foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                        {
                            if (col.Name == "AppointmentID")
                            {
                                selectedCustomerAppointment = appointments.Where(x => x.AppointmentID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                            }
                        }
                    }

                    if (customerAppointmentsDGV.Rows.Count > 0 && pastAppointmentsLabel.Text == "View past appointments")
                    {
                        updateButton.Enabled = true;
                        deleteButton.Enabled = true;
                    }
                    else
                    {
                        updateButton.Enabled = false;
                        deleteButton.Enabled = false;
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?", "sbCalendar - Appointments", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (customerAppointmentsDGV.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in customerAppointmentsDGV.SelectedRows)
                    {
                        foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                        {
                            if (col.Name == "AppointmentID")
                            {
                                selectedCustomerAppointment = appointments.Where(x => x.AppointmentID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                            }
                        }
                    }

                    clientScheduleRepository.DeleteSpecificCustomerAppt(selectedCustomerAppointment);

                    GetSelectedCustomerAppointments(selectedCustomer);


                    initialSelectedCustomerAppointmentsLoad = true;
                    deleteButton.Enabled = false;
                    updateButton.Enabled = false;
                    customersDGV_SelectionChanged(sender, e);
                }
            }
            else
            {
                return;
            }
        }

        // Swap between upcoming appointment and past appointment views
        private void pastAppointmentsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Unsubscribe from the customerAppointmentsDGV_SelectionChanged event
            customerAppointmentsDGV.SelectionChanged -= customerAppointmentsDGV_SelectionChanged;

            List<Appointment> pastCustAppts = new List<Appointment>();
            if (pastAppointmentsLabel.Text == "View past appointments")
            {
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
                pastAppointmentsLabel.Text = "View scheduled appointments";

                if (selectedCustomerScheduledAppointments.Count != 0 || selectedCustomerPastAppointments.Count != 0)
                {
                    customerAppointmentsDGV.DataSource = null;
                    customerAppointmentsDGV.DataSource = selectedCustomerPastAppointments;
                    customerAppointmentsDGV.ClearSelection();

                    foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                    {
                        // Show only AppointmentID, Type, Start, and End in the customerAppointmentsDGV
                        if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                            customerAppointmentsDGV.Columns[col.Name].Visible = false;
                    }
                }
            }
            else if (pastAppointmentsLabel.Text == "View scheduled appointments")
            {
                pastAppointmentsLabel.Text = "View past appointments";

                if (selectedCustomerScheduledAppointments.Count != 0 || selectedCustomerPastAppointments.Count != 0)
                {
                    customerAppointmentsDGV.DataSource = null;
                    customerAppointmentsDGV.DataSource = selectedCustomerScheduledAppointments;
                    customerAppointmentsDGV.ClearSelection();

                    foreach (DataGridViewColumn col in customerAppointmentsDGV.Columns)
                    {
                        // Show only AppointmentID, Type, Start, and End in the customerAppointmentsDGV
                        if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                            customerAppointmentsDGV.Columns[col.Name].Visible = false;
                    }
                }
            }

            // Subscribe to the customerAppointmentsDGV_SelectionChanged event
            customerAppointmentsDGV.SelectionChanged += customerAppointmentsDGV_SelectionChanged;
        }

        private void byDayButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewCalendarsForm viewCalendarsForm = new ViewCalendarsForm("day");
            viewCalendarsForm.ShowDialog();
            Show();
        }

        private void byWeekButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewCalendarsForm viewCalendarsForm = new ViewCalendarsForm("week");
            viewCalendarsForm.ShowDialog();
            Show();
        }

        private void byMonthButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewCalendarsForm viewCalendarsForm = new ViewCalendarsForm("month");
            viewCalendarsForm.ShowDialog();
            Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}