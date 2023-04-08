namespace ChalengeApp
{
    public abstract class Person
    {
        public Person(string name) 
            :this(name, "Not stated", "Not stated")
        { }

        public Person(string name, string surname)
            : this(name, surname, "Not stated")
        { }

        public Person(string name, string surname, string position)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Position { get; private set; }
        
    }
}
