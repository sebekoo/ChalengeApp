namespace ChalengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScore_ShouldCorrectResult()
        {
            // arrange - przygotowanie
            var employee = new EmployeeInMemory("Adam", "Nowak");
            employee.AddGrade(4);
            employee.AddGrade(4);
            //employee.AddGrade(-1); //punkty karne
            employee.AddGrade(3);
            //employee.AddGrade(-10); // punkty ujemne

            // act - uruchamiamy
            var result = employee.GetStatistics();

            // assert - sprawdzamy czy zosta�y spe�nione warunki
            Assert.AreEqual(11, result.Sum);
        }
    }
}