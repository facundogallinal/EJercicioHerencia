using System.Collections.Generic;

namespace Library
{
    public class DriverRepository : BaseRepository
    {
        public List<Driver> driverssList = new List<Driver>();
        public void AddDriver(Driver driver)
        {
            this.driverssList.Add(driver);
        }
    }
}