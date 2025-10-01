using System.Collections.Generic;

namespace Library
{
    public class DriverRepository : BaseRepository
    {
        public List<Driver> driverssList = new List<Driver>();
        public void AddDriver(Driver driver, string photoUrl)
        {
            this.driverssList.Add(driver);
            TweetPhoto(driver.Bio + "Bienvenido, " + driver.Name + " " + driver.LastName, @photoUrl);
        }
    }
}