using sbCalendar.Forms.Appointments;
using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sbCalendar.Forms.Customers
{
    public partial class ViewCustomersForm : Form
    {
        public ViewCustomersForm()
        {
            InitializeComponent();
        }

        Customer customer;
        List<Customer> customers;

        ClientScheduleRepository clientScheduleRepository;

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            clientScheduleRepository = new ClientScheduleRepository();
            customer = new Customer();
            customers = clientScheduleRepository.GetAllCustomers();
            customersDGV.DataSource = customers;
            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hides column for Address object column from view
                if (col.Name == "Address")
                    customersDGV.Columns[col.Name].Visible = false;
            }

            // Disable Update Customer, Add Appointment, and Delete Customer buttons on intial load
            customersDGV.ClearSelection();
            updateCustomerButton.Enabled = false;
            addAppointmentButton.Enabled = false;
            deleteCustomerButton.Enabled = false;

            // If more than one row is selected, Update Customer, Add Appointment, and Delete Customer buttons are enabled
            if (customersDGV.SelectedRows.Count > 0)
            {
                updateCustomerButton.Enabled = true;
                addAppointmentButton.Enabled = true;
                deleteCustomerButton.Enabled = true;
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            // Get the selected customer from the data grid view
            Customer selectedCustomer = new Customer();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if (col.Name == "CustomerID")
                    {
                        selectedCustomer = customers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                    }
                }

                // Send the selected customer to the UpdateCustomerForm
                UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(selectedCustomer);
                Hide();
                updateCustomerForm.ShowDialog();

                // Clears/refreshes the data grid view to show new customers
                customersDGV.DataSource = null;
                customersDGV.Rows.Clear();
                customers = clientScheduleRepository.GetAllCustomers();
                customersDGV.Update();
                customersDGV.DataSource = customers;

                customersDGV.ClearSelection();
                Show();
            }
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            // Get the selected customer from the data grid view
            Customer selectedCustomer = new Customer();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if (col.Name == "CustomerID")
                    {
                        selectedCustomer = customers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                    }
                }

                // Send the selected customer to the AddAppointmentForm
                Hide();
                AddAppointmentForm addAppointmentForm = new AddAppointmentForm(selectedCustomer);
                addAppointmentForm.ShowDialog();
                Show();
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to delete this customer?", "sbCalendar - Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // delete selected row (cast as Customer object)
                    Customer selectedCustomer = new Customer();

                    foreach (DataGridViewRow row in customersDGV.SelectedRows)
                    {
                        foreach (DataGridViewColumn col in customersDGV.Columns)
                        {
                            if (col.Name == "CustomerID")
                            {
                                selectedCustomer = customers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                            }
                        }

                        // Call the DeleteCustomer method to delete the selected customer and all related data from the database
                        clientScheduleRepository.DeleteCustomer(selectedCustomer);

                        MessageBox.Show("The customer has been deleted successfully.", "sbCalendar - Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Clears/refreshes the data grid view to show new customers
                    customersDGV.DataSource = null;
                    customersDGV.Rows.Clear();
                    customers = clientScheduleRepository.GetAllCustomers();
                    customersDGV.Update();
                    customersDGV.DataSource = customers;

                    foreach (DataGridViewColumn col in customersDGV.Columns)
                    {
                        // Hides column for Address object column from view
                        if (col.Name == "Address")
                            customersDGV.Columns[col.Name].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customersDGV.SelectedRows.Count > 0)
            {
                updateCustomerButton.Enabled = true;
                addAppointmentButton.Enabled = true;
                deleteCustomerButton.Enabled = true;
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();

            customer.NotifyPropertyChanged();

            // Clears/refreshes the data grid view to show new customers
            customersDGV.DataSource = null;
            customersDGV.Rows.Clear();
            customers = clientScheduleRepository.GetAllCustomers();
            customersDGV.Update();
            customersDGV.DataSource = customers;

            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hides column for Address object from view
                if (col.Name == "Address")
                    customersDGV.Columns[col.Name].Visible = false;
            }

            Show();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}