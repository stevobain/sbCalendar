using System;

namespace sbCalendar.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //Database value is likely either 0 or 1, aka False or True
        public bool Active { get; set; } 

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }

        public User()
        {
        }

        public User(int userID, string userName, string password, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}
