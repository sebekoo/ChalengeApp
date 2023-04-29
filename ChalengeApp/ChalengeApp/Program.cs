using ChalengeApp;

Console.WriteLine("Witam w Programie do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();

Console.WriteLine("Zakres wprowadzanych danych to: A - E lub 0 - 100");
Console.WriteLine("Aby zakończyć wprowadzanie ocen, naciśnij \"q\"");
Console.WriteLine("Wielkość liter nie ma znaczenia");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Nowak");
//var employee = new EmployeeInFile("Adam", "Nowak");
//employee.AddGrade(0.5f);
//employee.AddGrade(10F);
////employee.AddGrade("e");
////employee.AddGrade('D');
//employee.AddGrade(20f);

//var employee = new EmployeeInMemory("Adam", "Nowak");
//var supervisor = new Supervisor("Tomasz", "Kowalski");

//while (true)
//{
//    Console.Write("Podaj ocenę pracownika: ");
//    var inEmp = Console.ReadLine();

//    if (inEmp == "q" || inEmp == "Q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(inEmp);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception Catched: {e.Message}");
//    }
//}

//while(true)
//{
//    Console.Write("Podaj ocenę kierownika: ");
//    var inSup = Console.ReadLine();

//    if(inSup == "q" || inSup == "Q")
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

var statistics = employee.GetStatistics();

Console.Clear();
Console.WriteLine("Podsumowanie oceny: ");
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


//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Wystąpił błąd. Administrator został powiadomiony. Kontynuujemy");
//}
