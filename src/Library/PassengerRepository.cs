using System.Collections.Generic;

namespace Library
{
    public class PassengerRepository : BaseRepository
    {
        public List<Passenger> passengersList = new List<Passenger>();
        public void AddPassenger(Passenger passenger)
        {
            this.passengersList.Add(passenger);
        }
    }
}