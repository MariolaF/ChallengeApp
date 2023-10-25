namespace ChallengeApp.Tests
{
    public class Tests1
    {
        [Test]
        public void WhenEmployeeCollectPositivePoints_ShouldCorrectResults()
        {
            //arrange
            var employee = new Employee("Kamil", "Furdak", 30);
            employee.AddScore(8);
            employee.AddScore(7);
            employee.AddScore(8);
            employee.AddScore(9);
            employee.AddScore(9);

            //act
            var result = employee.Result;

            //assret
            Assert.AreEqual(41, result);
        }
    }
    public class Tests2
    { 
        [Test]
        public void WhenEmployeeCollectNegativeAndPositivePoints_ShouldCorrectResults()
        {
            //arrange
            var employee = new Employee("Daniel", "Kowalski", 28);
            employee.AddScore(9);
            employee.AddScore(-5);
            employee.AddScore(10);
            employee.AddScore(-6);
            employee.AddScore(-8);

            //act
            var result = employee.Result;

            //assret
            Assert.AreEqual(0, result);
        }
    }
}