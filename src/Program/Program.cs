using Library;

namespace Ucu.Poo.RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //En éste método deberas mostrar un ejemplo de funcionamiento de tu programa. A continuación te
            //planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar
            //en grande!

            Passenger pasajero1 = new Passenger("Rick","Grimes", 19202134,92);
            CommonDriver conductor1 = new CommonDriver("Bill","Jones", 12345678, 100, "Mustang", "Encantado de ser tu conductor");
            PoolDriver conductorPool1 = new PoolDriver("Dan","Ige",24232526, 85, "Polo","Exluchador dispuesto a llevarte a tu destino",4);
            DriverRepository rideShare = new DriverRepository();
            PassengerRepository passengerShare = new PassengerRepository();

            rideShare.AddDriver(conductor1, "src/Program/bill.jpg");
            //Se publica en Twitter un nuevo conductor!

            rideShare.AddDriver(conductorPool1,"src/Program/dan.jpg");
            //Se publica en Twitter un nuevo conductor!

            passengerShare.AddPassenger(pasajero1, "src/Program/rick.jpg");
            //Se publica en Twitter nuevo registro de pasajero!
            
        }
    }
}
