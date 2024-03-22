using System;

namespace sbCalendar.Models
{
    public class City
    {
        public int CityID { get; set; }

        public string CityName { get; set; }

        public Country Country { get; set; } = new Country();

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; } = ClientScheduleRepository.loggedInUser.UserName;

        public City()
        {
        }

        public City(Country country, int cityID, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            Country.CountryID = country.CountryID;
            CityID = cityID;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}