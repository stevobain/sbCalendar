using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sbCalendar.Forms.Appointments
{
    public partial class UpdateAppointmentForm : Form
    {
        public UpdateAppointmentForm()
        {
            InitializeComponent();
        }

        public UpdateAppointmentForm(Appointment selectedCustAppt)
        {
            InitializeComponent();
            selectedAppointment = selectedCustAppt;
        }

        private ClientScheduleRepository clientScheduleRepository;
        private Appointment selectedAppointment;
        private List<Customer> customers;
        private List<Appointment> appointments;
        DateTime selectedAppointmentTime;

        private void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            clientScheduleRepository = new ClientScheduleRepository();
            customers = new List<Customer>();
            appointments = new List<Appointment>();
            currentAppointmentDateTextBox.Enabled = false;
            currentAppointmentStartTimeTextBox.Enabled = false;
            currentAppointmentEndTimeTextBox.Enabled = false;
            Customer customer = new Customer();
            customers = clientScheduleRepository.GetAllCustomers();
            appointments = clientScheduleRepository.GetAllCustomerAppointments();

            // Load controls on form using the selected appointment from the previous form
            // A lambda is used to load the correct customer name by searching querying the customers list and comparing the customerIDs of each item and the selected appointment
            nameTextBox.Text = customers.Where(x => x.CustomerID == selectedAppointment.CustomerID).Select(x => x.CustomerName).FirstOrDefault().ToString();
            titleTextBox.Text = selectedAppointment.Title;
            contactTextBox.Text = selectedAppointment.Contact;
            typeTextBox.Text = selectedAppointment.Type;
            locationTextBox.Text = selectedAppointment.Location;
            urlTextBox.Text = selectedAppointment.Url;
            descriptionTextBox.Text = selectedAppointment.Description;
            currentAppointmentDateTextBox.Text = selectedAppointment.Start.ToShortDateString();
            currentAppointmentStartTimeTextBox.Text = selectedAppointment.Start.ToLocalTime().ToShortTimeString();
            currentAppointmentEndTimeTextBox.Text = selectedAppointment.End.ToLocalTime().ToShortTimeString();
        }

        private void newAppointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Assign the selected date to the selectedAppointmentTime variable
            selectedAppointmentTime = newAppointmentDatePicker.Value;
            if (newAppointmentDatePicker.Value != null)
            {
                selectedAppointmentTime = newAppointmentDatePicker.Value;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateAppointmentButton_Click(object sender, EventArgs e)
        {
            // Check if the selected date and time is correct
            newAppointmentStartTimePicker.Checked = true;
            DateTime selectedDate = DateTime.Parse(newAppointmentDatePicker.Text);
            DateTime selectedStartTime = DateTime.Parse(newAppointmentDatePicker.Text + " " + newAppointmentStartTimePicker.Text);
            DateTime selectedEndTime = DateTime.Parse(newAppointmentDatePicker.Text + " " + newAppointmentEndTimePicker.Text);
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToShortTimeString());


            // Check to see if the selected date is in the past, or if the time is earlier in the day; else, verify appointment information and schedule the appointment
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("The selected date is invalid.\nPlease select a future date.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (selectedStartTime < currentTime || selectedEndTime < currentTime)
            {
                MessageBox.Show("The selected start and/or end time is invalid.\nPlease select a future timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (newAppointmentStartTimePicker.Value > newAppointmentEndTimePicker.Value)
                {
                    MessageBox.Show("The appointment start time must be before the end time.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    VerifyAppointmentInfo();
                }
            }
        }

        // Verifies all controls are filled, checks if times are available for sheduling, and adds the appointment
        private void VerifyAppointmentInfo()
        {
            newAppointmentStartTimePicker.Checked = true;

            if (string.IsNullOrEmpty(titleTextBox.Text)
                    || string.IsNullOrEmpty(descriptionTextBox.Text)
                    || string.IsNullOrEmpty(contactTextBox.Text)
                    || string.IsNullOrEmpty(typeTextBox.Text)
                    || string.IsNullOrEmpty(locationTextBox.Text)
                    || string.IsNullOrEmpty(urlTextBox.Text))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    Appointment updatedAppointment = new Appointment();

                    string startDateTimeString = newAppointmentDatePicker.Text + " " + newAppointmentStartTimePicker.Text;
                    string endDateTimeString = newAppointmentDatePicker.Text + " " + newAppointmentEndTimePicker.Text;

                    if (!DateTime.TryParse(startDateTimeString, out DateTime startTime) || !DateTime.TryParse(endDateTimeString, out DateTime endTime))
                    {
                        MessageBox.Show("The date and/or time you entered was invalid. Please try again.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        updatedAppointment.Start = DateTime.Parse(startDateTimeString);
                        updatedAppointment.End = DateTime.Parse(endDateTimeString);

                        if (updatedAppointment.Start.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (updatedAppointment.Start.Hour >= 17 && updatedAppointment.Start.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (updatedAppointment.End.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (updatedAppointment.End.Hour >= 17 && updatedAppointment.End.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (updatedAppointment.Start.DayOfWeek == DayOfWeek.Sunday || updatedAppointment.Start.DayOfWeek == DayOfWeek.Saturday)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            var overlappingAppts = clientScheduleRepository.GetAllCustomerAppointments().Where(x => (updatedAppointment.Start >= x.Start) && (updatedAppointment.Start <= x.End)).ToList();

                            if (overlappingAppts.Count > 0)
                            {
                                MessageBox.Show("The chosen time has already been taken.\nPlease select a different time.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                updatedAppointment.AppointmentID = selectedAppointment.AppointmentID;

                                // Lambda expression is used to retrieve the customer ID of the object in the customers list that has a name matching that of the Customer Name Combo Box; the first element is returned if found, if not, a default value is found
                                updatedAppointment.CustomerID = customers.Where(x => x.CustomerName == nameTextBox.Text).Select(x => x.CustomerID).FirstOrDefault();

                                updatedAppointment.Description = descriptionTextBox.Text;
                                updatedAppointment.Title = titleTextBox.Text;
                                updatedAppointment.Contact = contactTextBox.Text;
                                updatedAppointment.Location = locationTextBox.Text;
                                updatedAppointment.Type = typeTextBox.Text;
                                updatedAppointment.Url = urlTextBox.Text;

                                clientScheduleRepository.UpdateUser(ClientScheduleRepository.loggedInUser);
                                clientScheduleRepository.UpdateCustomer(updatedAppointment.CustomerID, customers);
                                clientScheduleRepository.UpdateAppointment(updatedAppointment, nameTextBox.Text);

                                MessageBox.Show($"The appointment information for {nameTextBox.Text} was updated successfully.", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred when updating the appointment information.\n{ex}", "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Builds an error message based on which controls have no text
        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to update an appointment:\n\n");

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorBlankInfo.AppendLine("Customer Name");
            }
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                errorBlankInfo.AppendLine("Title");
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
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
            if (string.IsNullOrWhiteSpace(newAppointmentDatePicker.Text))
            {
                errorBlankInfo.AppendLine("Appointment Date");
            }
            if (string.IsNullOrWhiteSpace(newAppointmentStartTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appointment Start Time");
            }
            if (string.IsNullOrWhiteSpace(newAppointmentEndTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appointment End Time");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "sbCalendar - Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}