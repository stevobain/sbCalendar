using sbCalendar.Models;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sbCalendar.Forms.Customers
{
    public partial class UpdateCustomerForm : Form
    {
        public Customer selectedCustomer;
        private ClientScheduleRepository clientScheduleRepository;

        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        public UpdateCustomerForm(Customer selectedCustomer)
        {
            this.selectedCustomer = selectedCustomer;
            InitializeComponent();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            // Checks to see if any textbox on the form is null or whitespace
            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox"))
            {
                BuildErrorMessage();
            }
            else
            {
                // The selected customer's information is overwritten with data from the textboxes on the form
                selectedCustomer.CustomerName = customerNameTextBox.Text.Trim();
                selectedCustomer.Address.Address1 = addressTextBox.Text.Trim();
                selectedCustomer.Address.Address2 = address2TextBox.Text.Trim();
                selectedCustomer.Address.PostalCode = postalCodeTextBox.Text.Trim();
                selectedCustomer.Address.Phone = phoneTextBox.Text.Trim();
                selectedCustomer.LastUpdate = DateTime.Now.ToUniversalTime();
                selectedCustomer.LastUpdatedBy = ClientScheduleRepository.loggedInUser.UserName;
                selectedCustomer.Active = activeCheckBox.Checked;

                selectedCustomer.Address.City.Country.CountryID = clientScheduleRepository.GetAllCountries().Where(x => x.CountryName == countryTextBox.Text).Select(x => x.CountryID).FirstOrDefault();
                selectedCustomer.Address.City.CityID = clientScheduleRepository.GetAllCities().Where(x => x.CityName == cityTextBox.Text).Select(x => x.CityID).FirstOrDefault();

                // Call the update methods for country, city, address, and customer to satisfy foreign key contraints
                clientScheduleRepository.UpdateCustomerCountry(selectedCustomer.Address.City.Country.CountryID, countryTextBox.Text);
                clientScheduleRepository.UpdateCustomerCity(selectedCustomer.Address.City.CityID, selectedCustomer.Address.City.Country.CountryID, cityTextBox.Text);
                clientScheduleRepository.UpdateAddress(selectedCustomer);

                clientScheduleRepository.UpdateCustomer(selectedCustomer);

                MessageBox.Show("Customer information has been updated successfully.", "sbCalendar - Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            clientScheduleRepository = new ClientScheduleRepository();

            // Fill countryTextBox and cityTextBoxes
            // Lamda is used to query the list returned from GetAllCountries and find where the countryID is equal to the selectedCustomer's countryID, the country name is selected based of the country ID value.
            countryTextBox.Text = clientScheduleRepository.GetAllCountries().Where(x => x.CountryID == selectedCustomer.Address.City.Country.CountryID).Select(x => x.CountryName).FirstOrDefault();

            // Lamda is used to query the list returned from GetAllCities and find where the cityID is equal to the selectedCustomer's cityID, the city name is selected based of the city ID value.
            cityTextBox.Text = clientScheduleRepository.GetAllCities().Where(x => x.CityID == selectedCustomer.Address.City.CityID).Select(x => x.CityName).FirstOrDefault();

            // The selected customer's information is loaded into the textboxes on the form
            customerNameTextBox.Text = selectedCustomer.CustomerName;
            addressTextBox.Text = selectedCustomer.Address.Address1;
            address2TextBox.Text = selectedCustomer.Address.Address2;
            postalCodeTextBox.Text = selectedCustomer.Address.PostalCode;
            phoneTextBox.Text = selectedCustomer.Address.Phone;
            activeCheckBox.Checked = selectedCustomer.Active;

            ActiveControl = customerNameTextBox;
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
    }
}