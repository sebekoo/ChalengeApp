namespace ChalengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surmane) 
            : base(name, surmane)
        {
        }

        //public override void SayHello()
        //{
        //    Console.WriteLine("Witam z klasy EmployeeInMemory");
        //    base.SayHello();
        //}

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
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

        public override void AddGrade(string grade)
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
                        throw new Exception($"Dodana ocena - \"{grade}\" jest spoza zakresu \n\nPrzypominam - zakres wprowadzanych ocen to: A - E lub 0 - 100, \n\nWybranie litery \"q\" zakończy wprowadzanie ocen\n");
                }
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade > 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            statistics.AverageLetter = statistics.Average
                switch
            {
                var average when average >= 80 => 'A',
                var average when average >= 60 => 'B',
                var average when average >= 40 => 'C',
                var average when average >= 20 => 'D',
                _ => 'E'
            };
            return statistics;
        }
    }
}
