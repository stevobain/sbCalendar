using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sbCalendar.Forms.Customers
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        ClientScheduleRepository clientScheduleRepository;

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            clientScheduleRepository = new ClientScheduleRepository();
            ActiveControl = customerNameTextBox;
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            // Checks if phone number has characters that are not -'s and #'s
            string pattern = @"^[0-9\-]+$";
            if (!Regex.IsMatch(phoneTextBox.Text, pattern))
            {
                MessageBox.Show("Phone number can only contain numbers and dashes(-).", "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            // Checks to see if any textbox on the form is null or whitespace
            else if (Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox"))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    List<Customer> customers = new List<Customer>();
                    customers = clientScheduleRepository.GetAllCustomers();

                    int countryId = clientScheduleRepository.GetAllCountries().Count + 1;

                    // Adds customer information to the customer address object using form control values
                    Address customerAddress = new Address();
                    customerAddress.AddressID = clientScheduleRepository.GetAddressCount();
                    customerAddress.Address1 = addressTextBox.Text;
                    customerAddress.Address2 = address2TextBox.Text;
                    customerAddress.City.CityID = clientScheduleRepository.GetAllCities().Count + 1;
                    customerAddress.LastUpdate = DateTime.Now;
                    customerAddress.PostalCode = postalCodeTextBox.Text;
                    customerAddress.Phone = phoneTextBox.Text;
                    customerAddress.CreateDate = DateTime.Now;
                    customerAddress.CreatedBy = ClientScheduleRepository.loggedInUser.UserName;
                    customerAddress.LastUpdatedBy = ClientScheduleRepository.loggedInUser.UserName;

                    // Methods for adding country, city, and address are called to satisfy foreign key constraints
                    clientScheduleRepository.AddCountry(countryId, countryTextBox.Text);
                    clientScheduleRepository.AddCity(customerAddress.City.CityID, countryId, cityTextBox.Text);
                    clientScheduleRepository.AddCustomerAddress(customerAddress, customers);

                    // A new customer is created using remaining control values and the custAddress object
                    Customer customer = new Customer()
                    {
                        CustomerID = Customer.AllCustomers.Count + 1,
                        CustomerName = customerNameTextBox.Text,
                        Active = true,
                        Address = customerAddress,
                        CreateDate = DateTime.Now.ToUniversalTime(),
                        CreatedBy = ClientScheduleRepository.loggedInUser.UserName,
                        LastUpdate = DateTime.Now.ToUniversalTime(),
                        LastUpdatedBy = ClientScheduleRepository.loggedInUser.UserName
                    };

                    // The customer is added to the database
                    clientScheduleRepository.AddCustomer(customer);

                    MessageBox.Show("Customer has been added successfully.", "sbCalendar - Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to add customer:\n\n");

            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text))
            {
                errorBlankInfo.AppendLine("Customer Name");
            }
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                errorBlankInfo.AppendLine("Street Address");
            }
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                errorBlankInfo.AppendLine("City");
            }
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                errorBlankInfo.AppendLine("Country");
            }
            if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text))
            {
                errorBlankInfo.AppendLine("Postal Code");
            }
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                errorBlankInfo.AppendLine("Phone");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}