using ChalengeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(2); //odwołanie do metody w Employee > Ctrl + klik
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics(); //'GetStatistics' pobiera statystyki do obiektu 'statistics'
//Console.WriteLine("Average: " + statistics.Max); ten lub poniżej to to samo
Console.WriteLine($"Average: {statistics.Average:N2}");  // interpolacja - $ przed cudzysłowiem, w cudzysłowiu kod, N2 - dwa miejsca po przeinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

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