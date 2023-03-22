namespace ChalengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScore_ShouldCorrectResult()
        {
            // arrange - przygotowanie
            var user = new User("Adam");
            user.AddScore(4);
            user.AddScore(4);
            user.AddScore(-1); //punkty karne
            user.AddScore(3);
            user.AddScore(-10); // punkty ujemne

            // act - uruchamiamy
            var result = user.Result;

            // assert - sprawdzamy czy zosta³y spe³nione warunki
            Assert.AreEqual(0, result);
        }
    }
}