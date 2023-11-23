namespace ChallengeApp.Tests
{
    public class Employee_Tests
    {
        [Test]
        public void TestOfStatisticMaxValue()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(20);
            employee.AddGrade(25);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(25, statistic.Max);
        }
        [Test]
        public void TestOfStatisticMinValue()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(5, statistic.Min);
        }
        [Test]
        public void TestOfStatisticAverage()
        {
            var employee = new Employee("Mariola", "Furdak");
            //arrange
            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(15, statistic.Average);
        }
        [Test]
        public void TestForALetter()
        {
            var employee = new Employee("Mariola", "Furdak");
            float grade1 = 83;
            float grade2 = 81;
            float grade3 = 83;
            //arrange
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('A'));
        }
        [Test]
        public void TestForBLetter()
        {
            var employee = new Employee("Mariola", "Furdak");
            float grade1 = 63;
            float grade2 = 61;
            float grade3 = 63;
            //arrange
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('B'));
        }
        [Test]
        public void TestForCLetter()
        {
            var employee = new Employee("Mariola", "Furdak");
            float grade1 = 43;
            float grade2 = 41;
            float grade3 = 43;
            //arrange
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('C'));
        }
        [Test]
        public void TestForDLetter()
        {
            var employee = new Employee("Mariola", "Furdak");
            float grade1 = 23;
            float grade2 = 21;
            float grade3 = 23;
            //arrange
            employee.AddGrade(grade1);
            employee.AddGrade(grade2);
            employee.AddGrade(grade3);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('D'));
        }
    }

}
