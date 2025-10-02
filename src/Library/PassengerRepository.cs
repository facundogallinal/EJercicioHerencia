using System.Collections.Generic;

namespace Library
{
    public class PassengerRepository : BaseRepository
    {
        public List<Passenger> passengersList = new List<Passenger>();
        public void AddPassenger(Passenger passenger, string photoUrl)
        {
            this.passengersList.Add(passenger);
            TweetPhoto( "Bienvenido, " + passenger.Name + " " + passenger.LastName, @photoUrl);

        }
    }
}