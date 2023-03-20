using System.Reflection.Metadata;

namespace ChalengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScore_ShouldReturnSumOfResult()
        {
            // arrange - przygotowanie
            var user = new User("Adam", "sgfdsg");
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