namespace Library
{
    public class PoolDriver : Driver
    {
        public PoolDriver(string name, string lastName, int Id, int qualification, string vehicle, string bio, int capacity) : base(name, lastName, Id, qualification, vehicle, bio)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }
    }
}