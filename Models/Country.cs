using System;
using System.Collections.Generic;

namespace sbCalendar.Models
{
    public class Country
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public List<Country> Countries { get; set; }

        public Country()
        {
        }

        public Country(int countryID, string countryName, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            CountryID = countryID;
            CountryName = countryName;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}