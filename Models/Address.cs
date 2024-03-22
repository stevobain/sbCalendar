using System;

namespace sbCalendar.Models
{
    public class Address
    {
        public int AddressID { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public City City { get; set; } = new City();

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public Address()
        {
        }

        public Address(City city, int addressID, string address1, string address2, string postalCode, string phone, DateTime createDate, 
            string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            City.CityID = city.CityID;
            AddressID = addressID;
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}