using ChalengeApp;

Console.WriteLine("Witam w Programie do oceny Pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Aby zakończyć wprowadzanie ocen, naciśnij \"q\"");
Console.WriteLine("Wielkość liter nie ma znaczenia");
Console.WriteLine();
var employee = new Employee();
string input;
char grade;

do
{
    Console.Write("Podaj ocenę: ");
    input = Console.ReadLine();

    if (char.TryParse(input, out grade))
    {
        employee.AddGrade(grade);
    }
    else
    {
        employee.AddGrade(input);
    }
}
while (input != "q" && input != "Q");

var statistics = employee.GetStatistics();

Console.WriteLine($"Avg: {statistics.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Litera oceny: {statistics.AverageLetter}");




//int emp = 1;

//while (true)
//{
//    Console.Write($"Podaj {emp} ocenę pracownika : ");
//    var input = Console.ReadLine();
//    emp++;
//    if (input == "q" || input == "Q")
//    {
//        break;
//    }

//    employee.AddGrade(input);
//}