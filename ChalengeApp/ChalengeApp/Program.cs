using ChalengeApp;

var employee = new Employee("Adam", "Kamizelich"); // tworzymy obiekt 'employee'
employee.AddGrade("Adam"); // string //odwołanie do metody w Employee > Ctrl + klik
employee.AddGrade(2.3);    // double //wykonujemy operacje na obiekcie 'employee'
employee.AddGrade(7f);     // float
employee.AddGrade(-85);    // short
employee.AddGrade(85);     // byte
employee.AddGrade(1.7);    // byte
employee.AddGrade(9);
employee.AddGrade(2);
employee.AddGrade(11);

var statistics = employee.GetStatistics(); //'GetStatistics' pobiera statystyki do obiektu 'statistics'
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine();
Console.WriteLine("---Pętla ForEach---");
Console.WriteLine($"Average: {statistics.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();
Console.WriteLine("---Pętla ForEach---");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();
Console.WriteLine("--- Pętla For---");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();
Console.WriteLine("---Pętla DoWhile---");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();
Console.WriteLine("---Pętla While---");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

//Console.WriteLine("Average: " + statistics.Max); //ten lub powyżej to to samo

//SetSth(ref statistics); //wywołanie metody
//void SetSth(ref Statistics statistics)  //SetSth metoda. 'ref' - Przekazany parametr ma przypisaną wartość.
//{
//    //statistics = new Statistics(); // - tego nie trzeba przy 'ref'
//}

//SetSth2(out statistics);
//void SetSth2(out Statistics statistics)  //SetSth metoda. 'out' - Przekazany parametr nie ma przypisanej wartości.
//{
//    statistics = new Statistics();
//}