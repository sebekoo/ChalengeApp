int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Wynik dla liczby " + number);
Console.WriteLine("liczba 0 występuje " + counter0 + " razy");
Console.WriteLine("liczba 1 występuje " + counter1 + " razy");
Console.WriteLine("liczba 2 wystepuje " + counter2 + " razy");
Console.WriteLine("liczba 3 występuje " + counter3 + " razy");
Console.WriteLine("liczba 4 wystepuje " + counter4 + " razy");
Console.WriteLine("liczba 5 występuje " + counter5 + " razy");
Console.WriteLine("liczba 6 występuje " + counter6 + " razy");
Console.WriteLine("liczba 7 występuje " + counter7 + " razy");
Console.WriteLine("liczba 8 występuje " + counter8 + " razy");
Console.WriteLine("liczba 9 występuje " + counter9 + " razy");
