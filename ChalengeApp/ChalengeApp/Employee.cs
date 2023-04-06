namespace ChalengeApp
{
    public class Employee
    {
        private readonly char sex = 'M'; // tylko tutaj podczas definiowania i w konstruktorze mozna przypiać do 'readonly' wartość - patrz linia 17 i 28
        private const char sex1 = 'M'; // 'const' tylko raz można przypisać i zmienic w dowolnym miejscu w kodzie

        private List<float> grades = new List<float>();

        public Employee() // konstruktor
        {

        }
        public Employee(string name, string surname) // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.sex = 'K';
        }

        public string Name { get; private set; } //pola 

        public string Surname { get; private set; }

        public void AddGrade(float grade) // metoda
        {
            if (grade >= 0 && grade <= 100)  // walidacja - zabezpieczenie przed wpisaniem niepoprawnych danych 
            {
                //this.sex = 's'; - tu nie moża przypisać wartośći do 'readonly'
                this.grades.Add(grade);
            }
            else if (grade < 0)
            {
                throw new Exception("Podana wartość nie moze być mniejsza od \"0\". Podaj wartość od 0 - 100");
            }
            else
            {
                throw new Exception("Podana wartość przekracza zakres ocen. Podaj wartość od 0 - 100 lub literowo A-E");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float inputFloat))
            {
                this.AddGrade(inputFloat);
            }
            else if (char.TryParse(grade, out char inputChar))
            {
                switch (inputChar)
                {
                    case 'A':
                    case 'a':
                        this.grades.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        this.grades.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        this.grades.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        this.grades.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception($"Dodana ocena - \"{grade}\" jest spoza zakresu \n\nPrzypominam - zakres wprowadzanych ocen to: A - E lub 0 - 100, wybranie litery \"q\" zakończy wprowadzanie ocen\n");
                }
            }
            else
            {
                throw new Exception("String is not float");
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
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception($"Dodana ocena - \"{grade}\" jest spoza zakresu \n\nPrzypominam - zakres wprowadzanych ocen to: A - E, wybranie litery \"q\" zakończy wprowadzanie ocen\n");
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
