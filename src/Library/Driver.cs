namespace Library
{
    public abstract class Driver : User
    {
        public Driver(string name, string lastName, int Id,int qualification,string vehicle, string bio) : base(name, lastName, Id)
        {
            this.Qualification = qualification;
            this.Bio = bio;
            this.Vehicle = vehicle;
        }
        public int Qualification { get; set; }
        public string Vehicle { get; set; }
        public string Bio { get; set; }
    }
}