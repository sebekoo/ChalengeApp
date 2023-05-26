namespace ChalengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestWartosciowy()
        {
            // arrange - przygotowanie
            int number1 = 2;
            int number2 = 2;

            float number3 = 2;
            float number4 = 2;

            double number5 = 2;
            double number6 = 3;

            string number7 = "Adam";
            string number8 = "Adam";

            string number9 = "Adam";
            string number10 = "ADAM";

            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione warunki
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number3, number4);
            Assert.AreNotEqual(number5, number6); // "AreNotEqual"
            Assert.AreEqual(number7, number8);
            Assert.AreNotEqual(number9, number10); // "AreNotEqual"
        }

        [Test]
        public void TestReferencyjny()
        {
            // arrange - przygotowanie
            var user1 = GetUser("Adam", "Nowak");
            var user2 = GetUser("Adam", "Nowak");


            // act - uruchamiamy

            // assert - sprawdzamy czy zostały spełnione warunki
            //Assert.AreEqual(user1, user2); //false
            Assert.AreEqual(user1.Surname, user2.Surname);

            //Assert.AreNotEqual(user1, user2);
            //Assert.AreNotEqual(user1.Login, user2.Login); // false
        }

        // metoda
        private EmployeeInMemory GetUser(string name, string surname) //przy wywołaniu metody 'GetUser' otrzymamy imie 'Adam'
        {
            return new EmployeeInMemory(name, surname);
        }
    }
}
