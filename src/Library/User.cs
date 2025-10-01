namespace Library
{
    public abstract class User
    {
        public User(string name, string lastName, int ID)
        {
            this.Name = name;
            this.LastName = lastName;
            this.ID = ID;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }
}
