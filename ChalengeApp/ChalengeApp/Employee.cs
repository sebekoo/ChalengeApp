namespace ChalengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname) // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; } //pola 

        public string Surname { get; private set; }

        public void AddGrade(float grade) // metoda
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics() //metoda która zwróci wypełniony obiekt ze statystykami
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade; 
                // lub statistics.Average = statistics.Average + grade
            }

            statistics.Average = statistics.Average / this.grades.Count; // dzielenie przez sumę elementów
            // statistics.Average /= this.grades.Count; // skrócony zapis tego co powyżej

            return statistics;
        }
    }

}
