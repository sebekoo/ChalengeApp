namespace ChalengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddDelegate GradeAdded;

        #region Konstruktor
        public EmployeeInMemory(string name, string surmane)
            : base(name, surmane)
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
            else
            {
                throw new Exception("Wrong Value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float inputFloat))
            {
                AddGrade(inputFloat);
            }
            else if (grade.Length > 1)
            {
                throw new Exception("String is not float");
            }
            else
            {
                AddGrade(grade[0]);
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            grade = char.ToUpper(grade);
            switch (grade)
            {
                case 'A':
                    AddGrade(100);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(40);
                    break;
                case 'E':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        #endregion

        #region Metody Statistics
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
        #endregion
    }
}