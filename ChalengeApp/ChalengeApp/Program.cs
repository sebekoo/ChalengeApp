using ChalengeApp;

#region Menu programu
Console.WriteLine("Witam w Programie do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Zakres wprowadzanych danych to: A - E lub 0 - 100");
Console.WriteLine("Wielkość liter nie ma znaczenia");
Console.WriteLine();
Console.WriteLine("Aby zakończyć wprowadzanie ocen pracownika, naciśnij \"q\"");
Console.WriteLine();
#endregion

var employee = new EmployeeInFile("Damian", "Miłek"); 
//var employee = new EmployeeInMemory("Adam", "Nowak");
//var supervisor = new Supervisor("Tomasz", "Kowalski");

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
    Console.WriteLine("");
}

employee.GradeAdded += EmployeeGradeAdded;
//employee.GradeAdded += EmployeeGradeAdded;
//supervisor.GradeAdded += EmployeeGradeAdded;

#region Ocena pracowników


while (true)
{
    Console.Write("Podaj ocenę pracownika: ");
    var inEmp = Console.ReadLine();

    if (inEmp == "q" || inEmp == "Q")
    {
        break;
    }
    else if (inEmp == "")
    {
        Console.WriteLine("Nie podano oceny");
        continue;

    }
    try
    {
        employee.AddGrade(inEmp);
        //employee.AddGrade(inEmp);
        //supervisor.AddGrade(inEmp);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception Catched: {e.Message}");
    }
}

//Console.Clear();
//Console.WriteLine("Aby zakończyć wprowadzanie ocen Kierownika, naciśnij \"q\"");

//while (true)
//{
//    Console.WriteLine("Zakres wprowadzanych danych to: 1 - 6");
//    Console.Write("Podaj ocenę kierownika: ");
//    var inSup = Console.ReadLine();

//    if (inSup == "q" || inSup == "Q")
//    {
//        break;
//    }
//    try
//    {
//        supervisor.AddGrade(inSup);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception Catched: {e.Message}");
//    }
//}
#endregion

#region Wyświetlanie statystyk
var statistics = employee.GetStatistics();

Console.Clear();
Console.WriteLine("Podsumowanie oceny");
Console.WriteLine("==--==--==--==--==");
Console.WriteLine("");
Console.WriteLine($"Ocena pracownika {employee.Name} {employee.Surname}");
Console.WriteLine($"Avg:            {statistics.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
Console.WriteLine($"Min:            {statistics.Min}");
Console.WriteLine($"Max:            {statistics.Max}");
Console.WriteLine($"Litera oceny:   {statistics.AverageLetter}");

//var statistics2 = supervisor.GetStatistics();

//Console.WriteLine("");
//Console.WriteLine($"Ocena kierownika {supervisor.Name} {supervisor.Surname}");
//Console.WriteLine($"Avg:            {statistics2.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
//Console.WriteLine($"Min:            {statistics2.Min}");
//Console.WriteLine($"Max:            {statistics2.Max}");
//Console.WriteLine($"Litera oceny:   {statistics2.AverageLetter}");

#endregion
