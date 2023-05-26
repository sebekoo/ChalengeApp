namespace ChalengeApp
{
    internal class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddDelegate GradeAdded;

        #region Konstruktor
        public Supervisor(string name, string surname)
            : base(name, surname)
        {
        }
        #endregion

        #region Metody AddGrade
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else if (grade < 0)
            {
                throw new Exception("Podana wartość jest mniejsza od 0. \n\nPodaj wartość od 1 - 6");
            }
            else
            {
                throw new Exception("Podana wartość jest większa od 6. \n\nPodaj wartość od 1 - 6");
            }
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    AddGrade(5);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong value");
            }
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Metody Statistics
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
        #endregion
    }
}