using sbCalendar.Forms.Appointments;
using sbCalendar.Forms.Customers;
using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sbCalendar.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private ClientScheduleRepository clientScheduleRepository;

        private void viewCustomersButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewCustomersForm customersForm = new ViewCustomersForm();
            customersForm.ShowDialog();
            Show();
        }

        private void viewApptsButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewAppointmentsForm appointmentsForm = new ViewAppointmentsForm();
            appointmentsForm.ShowDialog();
            Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            clientScheduleRepository = new ClientScheduleRepository();

            DateTime currentTime = DateTime.Now;

            List<Customer> customerList = clientScheduleRepository.GetAllCustomers();
            List<Appointment> appointments = clientScheduleRepository.GetAllCustomerAppointments();

            // Check if any appointment in the appointment table has a start time within 15 minutes of the current time; if so, a message box is shown to remind about the meeting
            foreach (Appointment appt in appointments)
            {
                DateTime startTime = appt.Start;

                if (currentTime.Date == appt.Start.Date)
                {
                    if ((startTime.Hour == currentTime.Hour) && (startTime.Minute - currentTime.Minute <= 15))
                    {
                        if ((startTime.Minute - currentTime.Minute >= 1))
                        {
                            int minutesUntilAppt = startTime.Minute - currentTime.Minute;
                            var notifyCustNameForAppt = customerList.Where(x => x.CustomerID == appt.CustomerID).Select(x => x.CustomerName).First();
                            MessageBox.Show($"Upcoming Appointment for {notifyCustNameForAppt}\nin {minutesUntilAppt} minutes", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if ((startTime.Hour - currentTime.Hour == 1) && ((startTime.Minute - currentTime.Minute <= 15) && (startTime.Minute - currentTime.Minute >= 0)))
                    {
                        if (startTime.Date.Minute == 0)
                        {
                            if ((60 - currentTime.Minute >= 1))
                            {
                                int minutesUntilAppt = 60 - currentTime.Minute;
                                var notifyCustNameForAppt = customerList.Where(x => x.CustomerID == appt.CustomerID).Select(x => x.CustomerName).First();
                                MessageBox.Show($"Upcoming Appointment for {notifyCustNameForAppt}\nin {minutesUntilAppt} minutes", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        double minutesBetweenTimes = (currentTime - startTime).TotalMinutes;

                        if (minutesBetweenTimes <= 15 && !(minutesBetweenTimes < 0))
                        {
                            int minutesUntilAppt = 60 - currentTime.Minute;
                            var notifyCustNameForAppt = customerList.Where(x => x.CustomerID == appt.CustomerID).Select(x => x.CustomerName).First();
                            MessageBox.Show($"Upcoming Appointment for {notifyCustNameForAppt}\nin {minutesUntilAppt} minutes", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            Show();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm();
            updateCustomerForm.ShowDialog();
            Show();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.ShowDialog();
            Show();
        }

        private void updateAppointmentButton_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateAppointmentForm updateAppointmentForm = new UpdateAppointmentForm();
            updateAppointmentForm.ShowDialog();
            Show();
        }

        private void viewReportsButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewReportsForm viewReports = new ViewReportsForm();
            viewReports.ShowDialog();
            Show();
        }
    }
}