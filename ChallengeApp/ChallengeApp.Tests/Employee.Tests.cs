namespace ChallengeApp.Tests
{
    public class Employee_Tests
    {
        [Test]
        public void TestOfStatisticMaxValue()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(2);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(9, statistic.Max);
        }
        [Test]
        public void TestOfStatisticMinValue()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(2);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(-5, statistic.Min);
        }
        [Test]
        public void TestOfStatisticAverage()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(9);
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(2);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(3.5, statistic.Average);
        }
    }
}
