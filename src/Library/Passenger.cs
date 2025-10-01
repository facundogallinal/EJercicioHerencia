namespace Library
{
    public class Passenger : User
    {
        public Passenger(string name, string lastName, int Id, int qualification) : base(name, lastName, Id)
        {
            this.Qualification = qualification;
        }
        public int Qualification { get; set; }
    }
}