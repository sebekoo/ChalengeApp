namespace ChalengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        // konstruktor
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        // pola
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        // metoda AddScore
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
