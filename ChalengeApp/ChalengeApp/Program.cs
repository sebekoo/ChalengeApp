using ChalengeApp;

Console.WriteLine("Witam w Programie do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Zakres wprowadzanych danych to: A - E lub 0 - 100");
Console.WriteLine("Aby zakończyć wprowadzanie ocen, naciśnij \"q\"");
Console.WriteLine("Wielkość liter nie ma znaczenia");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.Write("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception Catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Avg:            {statistics.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
Console.WriteLine($"Min:            {statistics.Min}");
Console.WriteLine($"Max:            {statistics.Max}");
Console.WriteLine($"Litera oceny:   {statistics.AverageLetter}");


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
