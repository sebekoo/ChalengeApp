namespace ChalengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddDelegate(object sender, EventArgs args);

        public abstract event GradeAddDelegate GradeAdded;

        public EmployeeBase(string name, string surmane)
        {
            this.Name = name;
            this.Surname = surmane;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}