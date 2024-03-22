using sbCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sbCalendar.Forms
{
    public partial class ViewCalendarsForm : Form
    {
        public ViewCalendarsForm()
        {
            InitializeComponent();
        }
        public ViewCalendarsForm(string viewType)
        {
            InitializeComponent();

            if (viewType == "day")
            {
                Text = "sbCalendar - Calendar by Day";
                dayWeekMonthLabel.Text = "Today";
            }
            else if (viewType == "week")
            {
                Text = "sbCalendar - Calendar by Week";
                dayWeekMonthLabel.Text = "Current Week";
            }
            else if (viewType == "month")
            {
                Text = "sbCalendar - Calendar by Month";
                dayWeekMonthLabel.Text = "Month of ";
            }
        }


        ClientScheduleRepository clientScheduleRepository;
        private List<Appointment> appointments;
        private string currentMonth;

        private void CalendarByWeekOrMonthForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            clientScheduleRepository = new ClientScheduleRepository();
            appointments = new List<Appointment>();

            // Get the current month name
            currentMonth = DateTime.UtcNow.ToString("MMMM");

            appointments = clientScheduleRepository.GetAllCustomerAppointments();

            // Check if form loaded with either Month or Week inside the dayWeekMonthLabel
            if (dayWeekMonthLabel.Text.Contains("Month"))
            {
                // Lambda is used to query the appointments list to find all appointments that have a start month name that matches the currentMonth name
                calendarDGV.DataSource = appointments.Where(x => x.Start.ToString("MMMM") == currentMonth).ToList();
                dayWeekMonthLabel.Text = "Month of " + currentMonth;
            }
            else if (dayWeekMonthLabel.Text.Contains("Week"))
            {
                // Lambda is used to query the appointments list to find all appointments that have a start date/time greater than the current time, but the start date/time is less than 7 days from now (week ahead)
                DateTime thisWeek = DateTime.UtcNow.AddDays(7);
                calendarDGV.DataSource = appointments.Where(x => (x.Start > DateTime.Now) && (x.Start < thisWeek.ToLocalTime())).Select(x => x).ToList();
                dayWeekMonthLabel.Text = "Current Week";
            }
            else if (dayWeekMonthLabel.Text.Contains("Today"))
            {
                // Lambda is used to query the appointments list to find all appointments that have a start date/time greater than the current time, but the end date/time is today
                calendarDGV.DataSource = appointments.Where(x => (x.Start > DateTime.Now) && (x.End.Date == DateTime.Today.Date)).Select(x => x).ToList();
                dayWeekMonthLabel.Text = "Today";
            }
        }
    }
}