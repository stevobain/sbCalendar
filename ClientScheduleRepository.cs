using System;
using System.Collections.Generic;
using System.Linq;
using sbCalendar.Models;
using System.Data;
using MySql.Data.MySqlClient;

namespace sbCalendar
{
    public class ClientScheduleRepository
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public static User loggedInUser;

        private string _connectionStr = @"server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule";

        public ClientScheduleRepository()
        {
            connection = new MySqlConnection(_connectionStr);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        // Verifies that the credentials used are found in the database, granting access to the application
        public bool AuthenticateUser(string username, string password)
        {
            connection.Open();

            string sql = $"SELECT * FROM user WHERE username = '{username}' AND BINARY password = '{password}'";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                loggedInUser = new User();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        switch (reader.GetName(i).ToLower())
                        {
                            case "userid":
                                loggedInUser.UserID = (int)reader.GetValue(i);
                                break;
                            case "username":
                                loggedInUser.UserName = (string)reader.GetValue(i);
                                break;
                            case "password":
                                loggedInUser.Password = (string)reader.GetValue(i);
                                break;
                            case "active":
                                if ((sbyte)reader.GetValue(i) != 0)
                                {
                                    loggedInUser.Active = true;
                                }
                                else
                                    loggedInUser.Active = false;
                                break;
                            case "createdate":
                                loggedInUser.CreateDate = (DateTime)reader.GetValue(i);
                                break;
                            case "createdby":
                                loggedInUser.CreatedBy = (string)reader.GetValue(i);
                                break;
                            case "lastupdate":
                                loggedInUser.LastUpdate = (DateTime)reader.GetValue(i);
                                break;
                            case "lastupdateby":
                                loggedInUser.LastUpdatedBy = (string)reader.GetValue(i);
                                break;
                            default:
                                return false;
                        }
                    }
                }
                connection.Close();
                reader.Close();
                return true;

            }
            else
            {
                reader.Close();
                connection.Close();
                return false;
            }
        }

        // Gets all data from the user table, adds it to a list, and the list is returned
        public List<User> GetAllUsers()
        {
            connection.Open();

            List<User> users = new List<User>();

            string sql = "SELECT * FROM user";

            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User newUser = new User();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "userid":
                            newUser.UserID = (int)reader.GetValue(i);
                            break;
                        case "username":
                            newUser.UserName = (string)reader.GetValue(i);
                            break;
                        case "password":
                            newUser.Password = (string)reader.GetValue(i);
                            break;
                        case "active":
                            if ((sbyte)reader.GetValue(i) != 0)
                            {
                                newUser.Active = true;
                            }
                            else
                                newUser.Active = false;
                            break;
                        case "createdate":
                            DateTime createDate = (DateTime)reader.GetValue(i);
                            newUser.CreateDate = createDate.ToLocalTime();
                            break;
                        case "createdby":
                            newUser.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            DateTime lastUpdate = (DateTime)reader.GetValue(i);
                            newUser.LastUpdate = lastUpdate.ToLocalTime();
                            break;
                        case "lastupdateby":
                            newUser.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            break;
                    }
                }

                users.Add(newUser);

            }
            reader.Close();

            connection.Close();

            return users;
        }

        // Gets all data from the customer table, adds it to a list, and the list is returned
        public List<Customer> GetAllCustomers()
        {
            connection.Open();

            List<Customer> customerList = new List<Customer>();

            string sql = "SELECT * FROM customer c INNER JOIN address a " +
                                    "ON c.addressid = a.addressid " +
                                    "INNER JOIN city t " +
                                    "ON a.cityid = t.cityid " +
                                    "INNER JOIN country y " +
                                    "ON t.countryid = y.countryid";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer newCust = new Customer();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "customerid":
                            newCust.CustomerID = (int)reader.GetValue(i);
                            break;
                        case "customername":
                            newCust.CustomerName = (string)reader.GetValue(i);
                            break;
                        case "addressid":
                            newCust.Address.AddressID = (int)reader.GetValue(i);
                            newCust.AddressID = (int)reader.GetValue(i);
                            break;
                        case "address":
                            newCust.Address.Address1 = (string)reader.GetValue(i);
                            break;
                        case "address2":
                            newCust.Address.Address2 = (string)reader.GetValue(i);
                            break;
                        case "active":
                            newCust.Active = (bool)reader.GetValue(i);
                            break;
                        case "cityid":
                            newCust.Address.City.CityID = (int)reader.GetValue(i);
                            break;
                        case "city":
                            newCust.Address.City.CityName = (string)reader.GetValue(i);
                            break;
                        case "postalcode":
                            newCust.Address.PostalCode = (string)reader.GetValue(i);
                            break;
                        case "phone":
                            newCust.Address.Phone = (string)reader.GetValue(i);
                            break;
                        case "countryid":
                            newCust.Address.City.Country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "country":
                            newCust.Address.City.Country.CountryName = (string)reader.GetValue(i);
                            break;
                        case "createdate":
                            DateTime createDate = (DateTime)reader.GetValue(i);
                            newCust.CreateDate = createDate.ToLocalTime();
                            break;
                        case "createdby":
                            newCust.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            DateTime lastUpdate = (DateTime)reader.GetValue(i);
                            newCust.LastUpdate = lastUpdate.ToLocalTime();
                            break;
                        case "lastupdateby":
                            newCust.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            break;
                    }
                }

                customerList.Add(newCust);

            }
            reader.Close();

            connection.Close();

            return customerList;

        }

        // Gets all data from the country table, adds it to a list, and the list is returned
        public List<Country> GetAllCountries()
        {
            connection.Open();

            List<Country> countryList = new List<Country>();
            string sql = "SELECT * FROM country";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Country country = new Country();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "countryid":
                            country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "country":
                            country.CountryName = (string)reader.GetValue(i);
                            break;
                        case "createdate":
                            DateTime createDate = (DateTime)reader.GetValue(i);
                            country.CreateDate = createDate.ToLocalTime();
                            break;
                        case "createdby":
                            country.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            DateTime lastUpdate = (DateTime)reader.GetValue(i);
                            country.LastUpdate = lastUpdate.ToLocalTime();
                            break;
                        case "lastupdateby":
                            country.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            return null;
                    }
                }
                countryList.Add(country);
            }
            reader.Close();

            connection.Close();
            return countryList;
        }

        // Gets the current count of addresses in the address table
        public int GetAddressCount()
        {
            connection.Open();

            string sql = "SELECT COUNT(*) FROM address";
            cmd = new MySqlCommand(sql, connection);

            int addressCount = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return addressCount + 1;
        }

        // Adds a new customer to the customer table using values supplied by a customer object
        public void AddCustomer(Customer cust)
        {
            connection.Open();

            string sql = "INSERT INTO customer( customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES( @customername, @addressid, @active, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customername", cust.CustomerName);
            cmd.Parameters.AddWithValue("@addressid", cust.Address.AddressID);
            cmd.Parameters.AddWithValue("@active", cust.Active);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        // Adds a new customer address to the address table using values supplied by an address object
        public int AddCustomerAddress(Address customerAddr, List<Customer> customers)
        {
            connection.Open();

            string sql = "INSERT INTO address( addressid, address, address2, cityid, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES( @addressid, @address1, @address2, @cityid, @postalcode, @phone, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@addressid", customerAddr.AddressID);
            cmd.Parameters.AddWithValue("@address1", customerAddr.Address1);
            cmd.Parameters.AddWithValue("@address2", customerAddr.Address2);
            cmd.Parameters.AddWithValue("@cityid", customerAddr.City.CityID);
            cmd.Parameters.AddWithValue("@postalcode", customerAddr.PostalCode);
            cmd.Parameters.AddWithValue("@phone", customerAddr.Phone);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        // Adds a new city to the city table using values supplied by the cityId, countryId, and cityName values
        public int AddCity(int cityId, int countryId, string cityName)
        {
            connection.Open();

            string sql = "INSERT INTO city( cityid, city, countryid, createdate, createdby, lastupdate, lastupdateby) VALUES( @cityid, @cityname, @countryid, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@cityid", cityId);
            cmd.Parameters.AddWithValue("@cityname", cityName);
            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        // Adds a new country to the country table using values supplied by the countryId and countryName values
        public int AddCountry(int countryId, string countryName)
        {
            connection.Open();

            string sql = "INSERT INTO country( countryId, country, createdate, createdby, lastupdate, lastupdateby) VALUES( @countryId, @country, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        // Adds a new customer appointment to the appointment table using values supplied by an appointment object
        public void AddAppointment(Appointment newAppt, string text)
        {
            connection.Open();

            string sql = "INSERT INTO appointment( appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createdate, createdby, lastupdate, lastupdateby) VALUES( @appointmentId, @customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@appointmentid", newAppt.AppointmentID);
            cmd.Parameters.AddWithValue("@customerid", newAppt.CustomerID);
            cmd.Parameters.AddWithValue("@userid", loggedInUser.UserID);
            cmd.Parameters.AddWithValue("@title", newAppt.Title);
            cmd.Parameters.AddWithValue("@description", newAppt.Description);
            cmd.Parameters.AddWithValue("@location", newAppt.Location);
            cmd.Parameters.AddWithValue("@contact", newAppt.Contact);
            cmd.Parameters.AddWithValue("@type", newAppt.Type);
            cmd.Parameters.AddWithValue("@url", newAppt.Url);
            cmd.Parameters.AddWithValue("@start", newAppt.Start.ToUniversalTime());
            cmd.Parameters.AddWithValue("@end", newAppt.End.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        // Gets all data from the city table, adds it to a list, and the list is returned
        public List<City> GetAllCities()
        {
            connection.Open();

            List<City> cityList = new List<City>();
            string sql = "SELECT * FROM city";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                City city = new City();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "cityid":
                            city.CityID = (int)reader.GetValue(i);
                            break;
                        case "city":
                            city.CityName = (string)reader.GetValue(i);
                            break;
                        case "countryid":
                            city.Country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "createdate":
                            DateTime createDate = (DateTime)reader.GetValue(i);
                            city.CreateDate = createDate.ToLocalTime();
                            break;
                        case "createdby":
                            city.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            DateTime lastUpdate = (DateTime)reader.GetValue(i);
                            city.LastUpdate = lastUpdate.ToLocalTime();
                            break;
                        case "lastupdateby":
                            city.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            return null;
                    }
                }
                cityList.Add(city);
            }
            reader.Close();

            connection.Close();
            return cityList;
        }

        // Updates the customer information for the specified customer
        public void UpdateCustomer(Customer selectedCustomer)
        {
            connection.Open();

            string sql = "UPDATE customer SET customerName = @customername, active = @active, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE customerId = @customerid";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);
            cmd.Parameters.AddWithValue("@customername", selectedCustomer.CustomerName);
            cmd.Parameters.AddWithValue("@active", selectedCustomer.Active);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            connection.Close();

        }

        // Updates the address information for the specified customer
        public void UpdateAddress(Customer selectedCustomer)
        {
            connection.Open();
            string sql = "UPDATE address a SET a.address = @address, a.address2 = @address2, a.cityId = @cityid, a.postalCode = @postalcode, a.phone = @phone, a.lastUpdate = @lastupdate, a.lastUpdateBy = @lastupdateby WHERE a.addressId = @addressid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@addressid", selectedCustomer.Address.AddressID);
            cmd.Parameters.AddWithValue("@address", selectedCustomer.Address.Address1);
            cmd.Parameters.AddWithValue("@address2", selectedCustomer.Address.Address2);
            cmd.Parameters.AddWithValue("@cityid", selectedCustomer.Address.City.CityID);
            cmd.Parameters.AddWithValue("@postalcode", selectedCustomer.Address.PostalCode);
            cmd.Parameters.AddWithValue("@phone", selectedCustomer.Address.Phone);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        // Updates the country table using supplied countryId, and countryName values
        public void UpdateCustomerCountry(int countryId, string countryName)
        {
            connection.Open();
            string sql = "UPDATE country SET country = @country, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE countryId = @countryid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        // Updates the city table using supplied cityId, countryId, and cityName values
        public void UpdateCustomerCity(int cityId, int countryId, string cityName)
        {
            connection.Open();
            string sql = "UPDATE city SET city = @city, countryId = @countryId, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE cityId = @cityid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@cityid", cityId);
            cmd.Parameters.AddWithValue("@city", cityName);
            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        // Calls methods that fully remove all data associated with the specified customer
        public void DeleteCustomer(Customer selectedCustomer)
        {
            connection.Open();

            // Delete any customer appointments
            DeleteCustomerAppointments(selectedCustomer);

            DeleteCustomerInfo(selectedCustomer);

            DeleteCustomerAddress(selectedCustomer);

            connection.Close();
        }

        // Deletes the specified customer from the customer table
        private void DeleteCustomerInfo(Customer selectedCustomer)
        {
            string sql = "DELETE FROM customer WHERE customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        }

        // Deletes the appointments belonging to a specific customer
        private void DeleteCustomerAppointments(Customer selectedCustomer)
        {
            string sql = "DELETE FROM appointment WHERE customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void DeleteSpecificCustomerAppt(Appointment selectedCustAppt)
        {
            connection.Open();

            string sql = "DELETE FROM appointment WHERE appointmentId = @appointmentid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@appointmentid", selectedCustAppt.AppointmentID);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            connection.Close();
        }

        // Deletes the specified customer's address from the address table
        private void DeleteCustomerAddress(Customer selectedCustomer)
        {
            string sql = "DELETE a FROM address a INNER JOIN customer c ON c.addressId = a.addressId WHERE c.customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        // Gets all data from the appointment table, adds it to a list, and the list is returned
        public List<Appointment> GetAllCustomerAppointments()
        {
            connection.Open();

            List<Appointment> appointments = new List<Appointment>();

            string sql = "SELECT * FROM appointment";

            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Appointment custAppt = new Appointment();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "appointmentid":
                            custAppt.AppointmentID = (int)reader.GetValue(i);
                            break;
                        case "customerid":
                            custAppt.CustomerID = (int)reader.GetValue(i);
                            break;
                        case "userid":
                            custAppt.UserID = (int)reader.GetValue(i);
                            break;
                        case "title":
                            custAppt.Title = (string)reader.GetValue(i);
                            break;
                        case "description":
                            custAppt.Description = (string)reader.GetValue(i);
                            break;
                        case "location":
                            custAppt.Location = (string)reader.GetValue(i);
                            break;
                        case "contact":
                            custAppt.Contact = (string)reader.GetValue(i);
                            break;
                        case "type":
                            custAppt.Type = (string)reader.GetValue(i);
                            break;
                        case "url":
                            custAppt.Url = (string)reader.GetValue(i);
                            break;
                        case "start":
                            DateTime startTime = (DateTime)reader.GetValue(i);
                            custAppt.Start = startTime.ToLocalTime();
                            break;
                        case "end":
                            DateTime endTime = (DateTime)reader.GetValue(i);
                            custAppt.End = endTime.ToLocalTime();
                            break;
                        case "createdate":
                            DateTime createDate = (DateTime)reader.GetValue(i);
                            custAppt.CreateDate = createDate.ToLocalTime();
                            break;
                        case "createdby":
                            custAppt.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            DateTime lastUpdate = (DateTime)reader.GetValue(i);
                            custAppt.LastUpdate = lastUpdate.ToLocalTime();
                            break;
                        case "lastupdateby":
                            custAppt.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            break;
                    }
                }

                appointments.Add(custAppt);

            }
            reader.Close();

            connection.Close();

            return appointments;
        }

        // Gets the count of appointment currently in the appointment table
        public int GetAppointmentCount()
        {
            connection.Open();

            string sql = "SELECT MAX(appointmentId) FROM appointment";
            cmd = new MySqlCommand(sql, connection);

            int appointmentCount = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return appointmentCount + 1;
        }

        // Gets the count of appointment types by month
        public DataTable CountApptTypesByMonth()
        {
            connection.Open();

            DataTable dt = new DataTable();

            string sql = "SELECT type, COUNT(type) as Number_of_appt_type, MONTH(start) as Month FROM appointment GROUP BY type, MONTH(start) ORDER BY Number_of_appt_type";

            cmd = new MySqlCommand(sql, connection);
            dt.Load(cmd.ExecuteReader());

            connection.Close();

            return dt;
        }

        // Gets the schedule for the specified consultant
        public List<Appointment> LoadConsultantSchedules(string userName)
        {
            //string sql = "SELECT u.userName, a.appointmentId, c.customerName, a.title, a.description, a.location, a.contact, a.type, a.url, a.start, a.end FROM  user u INNER JOIN appointment a ON u.userId = a.userID INNER JOIN customer c on c.customerId = a.customerID";
            var consultant = GetAllUsers().Where(x => x.UserName == userName).FirstOrDefault();

            var result = GetAllCustomerAppointments().Where(x => x.UserID == consultant.UserID).Select(x => x).ToList();

            return result;
        }

        // Gets the count of customers created by month
        public DataTable CountCustomersCreatedByMonth()
        {
            // Complete final report
            connection.Open();

            DataTable dt = new DataTable();

            string sql = "SELECT MONTHNAME(createDate) as Month, COUNT(MONTH(createDate)) as Customers_Created FROM customer GROUP BY MONTHNAME(createDate)";

            cmd = new MySqlCommand(sql, connection);
            dt.Load(cmd.ExecuteReader());

            connection.Close();

            return dt;
        }

        // Updates the appointment table using values provided by an appointment object
        public void UpdateAppointment(Appointment modifiedAppt, string text)
        {
            connection.Open();

            string sql = "UPDATE appointment SET title = @title, description = @description, location = @location, contact = @contact, type = @type, url = @url, start = @start, end = @end, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE appointmentId = @appointmentid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@appointmentid", modifiedAppt.AppointmentID);
            cmd.Parameters.AddWithValue("@customerid", modifiedAppt.CustomerID);
            cmd.Parameters.AddWithValue("@userid", modifiedAppt.UserID);
            cmd.Parameters.AddWithValue("@title", modifiedAppt.Title);
            cmd.Parameters.AddWithValue("@description", modifiedAppt.Description);
            cmd.Parameters.AddWithValue("@location", modifiedAppt.Location);
            cmd.Parameters.AddWithValue("@contact", modifiedAppt.Contact);
            cmd.Parameters.AddWithValue("@type", modifiedAppt.Type);
            cmd.Parameters.AddWithValue("@url", modifiedAppt.Url);
            cmd.Parameters.AddWithValue("@start", modifiedAppt.Start.ToUniversalTime());
            cmd.Parameters.AddWithValue("@end", modifiedAppt.End.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        // Updates the user table using values provided by a user object
        public void UpdateUser(User loggedInUser)
        {
            connection.Open();

            string sql = "UPDATE user SET userName = @username, password = @password, active = @active, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE userId = @userid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@userid", loggedInUser.UserID);
            cmd.Parameters.AddWithValue("@username", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@password", loggedInUser.Password);
            cmd.Parameters.AddWithValue("@active", loggedInUser.Active);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        // Updates the customer table using values provided by a customer object
        public void UpdateCustomer(int customerId, List<Customer> customers)
        {
            Customer selectedCustomer = customers.Where(x => x.CustomerID == customerId).Select(x => x).FirstOrDefault();

            connection.Open();

            string sql = "UPDATE customer SET customerName = @customername, active = @active, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", customerId);
            cmd.Parameters.AddWithValue("@customername", selectedCustomer.CustomerName);
            cmd.Parameters.AddWithValue("@active", selectedCustomer.Active);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            connection.Close();
        }
    }
}