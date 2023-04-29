namespace ChalengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surmane)
        {
            this.Name = name;
            this.Surname = surmane;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        //public virtual void SayHello()
        //{
        //    Console.WriteLine($"Hello! I am {Name} {Surname}. Jestem w klasie EmployeeBase");
        //}
        
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);   

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();

    }
}
