using ChalengeApp;

Employee employee1 = new Employee("Adam", "Nowak", 34);
Employee employee2 = new Employee("Monika", "Kowalska", 45);
Employee employee3 = new Employee("Zuzia", "Adamczewska", 63);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee2.AddScore(6);
employee2.AddScore(9);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(4);

employee3.AddScore(11);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(8);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
        
}
Console.WriteLine("Najwyższą liczbę ocen ma: " + employeeWithMaxResult.Name);
Console.WriteLine("Imie:                     " + employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko:                 " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek:                     " + employeeWithMaxResult.Age);
Console.WriteLine("Suma punktów:             " + employeeWithMaxResult.Result);
