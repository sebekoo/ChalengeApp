namespace ChalengeApp
{
    public abstract class Person
    {
        public Person(string name) 
        {
            this.Name = name;
        }

        //public Person(string name, string surname)
        //    : this(name, surname, "Not stated")
        //{ }

        //public Person(string name, string surname, string position)
        //{
        //    this.Name = name;
        //    this.Surname = surname;
        //    this.Position = position;
        //}
        public string Name { get; private set; }
        //public string Surname { get; private set; }
        //public string Position { get; private set; }
    }
}
// Składowe interfejsu nie mogą być oznaczone atrybutem dostępu (domyślnie ustawiony jest public)
// Interfejs umożliwia jedynie deklarację skłądowych, bez implementacji
// Interfejs może dziedziczyć jedynie po innych interfejsach
// Klasa abstrakcyjna może dziedziczyć po klasach abstrakcyjnych, interfejsach a nawet zwykłych klasach
// Jeśli do interfejsu zostanie dodana nowa metoda trzeba prześledzić wszystkie klasy implementujące dany interfejs i dodać implementację nowej metody
// Interfejs nie może mieć kostruuktora
// Jeśli w klasie nie ma logiki zróbmy interface a nie klasę abstrakcyjną
