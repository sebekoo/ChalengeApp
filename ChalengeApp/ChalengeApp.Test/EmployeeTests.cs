﻿namespace ChalengeApp.Test
{
    public class EmployeeTests
    {
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new EmployeeInMemory("Adam", "Kamizelich");
            employee.AddGrade('D');
            employee.AddGrade("C");
            employee.AddGrade(10);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(60, statistics.Max);
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new EmployeeInMemory("Adam", "Kamizelich");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new EmployeeInMemory("Adam", "Kamizelich");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}
