using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sbCalendar.Forms.Appointments
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            selectedCustomer = new Customer();
            directedFromLandingForm = true;
        }

        public AddAppointmentForm(Customer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
            directedFromLandingForm = false;
        }

        private ClientScheduleRepository clientScheduleRepository;
        private Customer selectedCustomer;
        private List<Customer> customers;
        private List<Appointment> appointments;
        private bool directedFromLandingForm;

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            addAppointmentStartTimePicker.Checked = true;
            addAppointmentEndTimePicker.Checked = true;

            // Initialize variables
            clientScheduleRepository = new ClientScheduleRepository();
            customers = new List<Customer>();
            appointments = new List<Appointment>();
            customers = clientScheduleRepository.GetAllCustomers();
            appointments = clientScheduleRepository.GetAllCustomerAppointments();

            // Fill the customerNameComboBox with the customer names found in the customers list
            customerNameComboBox.DataSource = customers.Select(x => x.CustomerName).ToList();

            // Handling for when the form is launched from the landing form (no selected customer as on the ViewCustomers form)
            if (!directedFromLandingForm)
            {
                customerNameComboBox.SelectedItem = customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).Select(x => (x.CustomerName)).FirstOrDefault();
            }
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            // Check if the selected date and time is correct
            addAppointmentStartTimePicker.Checked = true;
            DateTime selectedDate = DateTime.Parse(addAppointmentDatePicker.Text);
            DateTime selectedStartTime = DateTime.Parse(addAppointmentDatePicker.Text + " " + addAppointmentStartTimePicker.Text);
            DateTime selectedEndTime = DateTime.Parse(addAppointmentDatePicker.Text + " " + addAppointmentEndTimePicker.Text);
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToShortTimeString());

            // Check to see if the selected date is in the past, or if the time is earlier in the day; else, verify appointment information and schedule the appointment
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("The selected date is invalid.\nPlease select a future date.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (selectedStartTime < currentTime || selectedEndTime < currentTime)
            {
                MessageBox.Show("The selected start and/or end time is invalid.\nPlease select a future timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (addAppointmentStartTimePicker.Value > addAppointmentEndTimePicker.Value)
                {
                    MessageBox.Show("The appointment start time must be before the end time.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    VerifyAppointmentInfo();
                }
            }
        }

        // Verifies all controls are filled, checks if times are available for sheduling, and schedules the appointment
        private void VerifyAppointmentInfo()
        {
            addAppointmentStartTimePicker.Checked = true;
            //this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text))
            if (string.IsNullOrEmpty(titleTextBox.Text.Trim())
                    || string.IsNullOrEmpty(appointmentDescriptionTextBox.Text.Trim())
                    || string.IsNullOrEmpty(contactTextBox.Text.Trim())
                    || string.IsNullOrEmpty(typeTextBox.Text.Trim())
                    || string.IsNullOrEmpty(locationTextBox.Text.Trim())
                    || string.IsNullOrEmpty(urlTextBox.Text.Trim()))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    Appointment newAppointment = new Appointment();

                    string startDateTimeString = addAppointmentDatePicker.Text + " " + addAppointmentStartTimePicker.Text;
                    string endDateTimeString = addAppointmentDatePicker.Text + " " + addAppointmentEndTimePicker.Text;

                    if (!DateTime.TryParse(startDateTimeString, out DateTime startTime) || !DateTime.TryParse(endDateTimeString, out DateTime endTime))
                    {
                        MessageBox.Show("The date and/or time you entered was invalid. Please try again.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        newAppointment.Start = DateTime.Parse(startDateTimeString);
                        newAppointment.End = DateTime.Parse(endDateTimeString);

                        if (newAppointment.Start.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppointment.Start.Hour >= 17 && newAppointment.Start.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppointment.End.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppointment.End.Hour >= 17 && newAppointment.End.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppointment.Start.DayOfWeek == DayOfWeek.Sunday || newAppointment.Start.DayOfWeek == DayOfWeek.Saturday)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppointment.Start == newAppointment.End)
                        {
                            MessageBox.Show("The appointment start and end times cannot be the same.\nPlease select a different timeframe.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            var overlappingAppointments = clientScheduleRepository.GetAllCustomerAppointments().Where(x => (newAppointment.Start >= x.Start) && (newAppointment.Start <= x.End)).ToList();

                            if (overlappingAppointments.Count > 0)
                            {
                                MessageBox.Show("The chosen time has already been taken.\nPlease select a different time.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                newAppointment.AppointmentID = clientScheduleRepository.GetAppointmentCount();

                                // Lambda expression is used to retrieve the customer ID of the object in the customers list that has a name matching that of the Customer Name Combo Box; the first element is returned if found, if not, a default value is found
                                newAppointment.CustomerID = customers.Where(x => x.CustomerName == customerNameComboBox.Text).Select(x => x.CustomerID).FirstOrDefault();

                                newAppointment.Description = appointmentDescriptionTextBox.Text;
                                newAppointment.Title = titleTextBox.Text;
                                newAppointment.Contact = contactTextBox.Text;
                                newAppointment.Location = locationTextBox.Text;
                                newAppointment.Type = typeTextBox.Text;
                                newAppointment.Url = urlTextBox.Text;

                                clientScheduleRepository.AddAppointment(newAppointment, customerNameComboBox.Text);

                                MessageBox.Show($"The appointment for {customerNameComboBox.Text} was scheduled successfully.", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred when scheduling the appointment.\n{ex}", "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Builds an error message based on which controls have no text
        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to schedule an appointment:\n\n");

            if (string.IsNullOrWhiteSpace(customerNameComboBox.Text))
            {
                errorBlankInfo.AppendLine("Customer Name");
            }
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                errorBlankInfo.AppendLine("Title");
            }
            if (string.IsNullOrWhiteSpace(appointmentDescriptionTextBox.Text))
            {
                errorBlankInfo.AppendLine("Description");
            }
            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                errorBlankInfo.AppendLine("Contact");
            }
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                errorBlankInfo.AppendLine("Location");
            }
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                errorBlankInfo.AppendLine("Type");
            }
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                errorBlankInfo.AppendLine("URL");
            }
            if (string.IsNullOrWhiteSpace(addAppointmentStartTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appointment Start Time");
            }
            if (string.IsNullOrWhiteSpace(addAppointmentEndTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appointment End Time");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "sbCalendar - Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void schedApptStartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            addAppointmentStartTimePicker.Checked = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}