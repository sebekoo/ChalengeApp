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
            // 3.33
            // 3
            //int valueInInt = (int)grade;  // rzutowanie - tracimy to co po przecinku

            int valueInInt = (int)Math.Ceiling(grade);

            if (grade >= -50 && grade <= 100)  // walidacja - zabezpieczenie przed wpisaniem niepoprawnych danych 
            {
                this.grades.Add(grade);
                Console.WriteLine($"Dodaliśmy wartość {grade} - ");
            }
            else if (grade <= -50)
            {
                Console.WriteLine("Inwalid grade value is < -50");
            }
            else
            {
                Console.WriteLine("Inwalid grade value is > 100");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(byte grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(short grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        //public void AddGrade(int grade)
        //{
        //    float gradeAsFloat = (float)grade;
        //    this.AddGrade(gradeAsFloat);
        //}

        public void AddGrade(string grade) // przyjeliśmy 'string" "2"
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        // jak przerobić 'string' na 'float'
        //public void AddGrade(string grade)
        //{
        //    var value = float.Parse(grade);
        //    this.grades.Add(value);
        //}

        public Statistics GetStatistics() //metoda która zwróci wypełniony obiekt ze statystykami
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                //lub statistics.Average = statistics.Average + grade
            }

            statistics.Average /= this.grades.Count; // skrócony zapis tego co poniżej
            //statistics.Average = statistics.Average / this.grades.Count; // dzielenie przez sumę elementów

            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var i = 0;

            do // petla 'do while' - zawsze wykona sie jeden raz, 'do while' - to jest to samo co 'foreach'
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            } while (i < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var i = 0;
            
            while (i < this.grades.Count) // petla while - może nie wykonać sie ani razu
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        } 
    }
}
