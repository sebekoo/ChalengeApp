string myName = "Ewa";
char mySex = 'k';
int myAge = 37;

if(myName == "Ewa" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if(myAge < 30 && mySex == 'k')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(myAge < 18 && mySex != 'k')
{
    Console.WriteLine("Niepełnoletni Mężczyzna"); 
}
else
{
    Console.WriteLine(myName + ", mam " + myAge + " lat");
}