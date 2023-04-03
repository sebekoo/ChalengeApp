namespace ChalengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee() // konstruktor
        {

        }
        public Employee(string name, string surname) // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }
        
        public string Name { get; private set; } //pola 

        public string Surname { get; private set; }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float inputFloat)) //char.TryParse(input, out grade);
            {
                this.AddGrade(inputFloat);
            }
            else
            {
                Console.WriteLine("String is not float");
                char.TryParse(grade, out char inputChar);
                this.AddGrade(inputChar);
            }
        }

        public void AddGrade(float grade) // metoda
        {
            if (grade > 0 && grade <= 100)  // walidacja - zabezpieczenie przed wpisaniem niepoprawnych danych 
            {
                this.grades.Add(grade);
                Console.WriteLine($"Dodana ocena \"float\"- {grade}");
            }
            else if (grade <= 0)
            {
                Console.WriteLine("Podana wartość nie moze być mniejsza od \"0\". Podaj wartość od 0 - 100");
            }
            else
            {
                Console.WriteLine("Podana wartość przekracza zakres ocen. Podaj wartość od 0 - 100");
            }
        }

        //public void AddGrade(double grade)
        //{
        //    float gradeAsFloat = (float)grade;
        //    this.AddGrade(gradeAsFloat);
        //}

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    Console.WriteLine($"Dodana ocena \"char\" - {grade}");
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    Console.WriteLine($"Dodana ocena \"char\" - {grade}");
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    Console.WriteLine($"Dodana ocena \"char\" - {grade}");
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    Console.WriteLine($"Dodana ocena \"char\" - {grade}");
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    Console.WriteLine($"Dodana ocena \"char\" - {grade}");
                    break;
                default:
                    Console.WriteLine($"Dodana ocena - \"{grade}\" jest spoza zakresu");
                    Console.WriteLine("Przypominam - zakres wprowadzanych ocen to: A - E, wybranie litery \"q\" zakończy wprowadzanie ocen");
                    break;
            }
        }
        public Statistics GetStatistics() //metoda która zwróci wypełniony obiekt ze statystykami
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
