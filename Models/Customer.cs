using System;
using System.ComponentModel;

namespace sbCalendar.Models
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        // Address object property added to mirror database implementation
        public int AddressID { get; set; }

        public Address Address { get; set; } = new Address();

        //Database value is likely either 0 or 1, aka False or True
        public bool Active { get; set; }
        
        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }

        public static BindingList<Customer> AllCustomers = new BindingList<Customer>();

        public Customer()
        {
            CustomerName = string.Empty;
            Address = new Address();
            Active = true;
            CreateDate = DateTime.UtcNow;
            CreatedBy = ClientScheduleRepository.loggedInUser.UserName;
            LastUpdate = DateTime.UtcNow;
            LastUpdatedBy = ClientScheduleRepository.loggedInUser.UserName;
        }

        public Customer(Address address, int customerID, string customerName, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            AddressID = address.AddressID;
            CustomerID = customerID;
            CustomerName = customerName;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }

        public void NotifyPropertyChanged(string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}