namespace ChallengeApp.Tests
{
    public class Type_Tests
    {
        [Test]
        public void WhenComparedTwoInt_ShouldBeEqual()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;
            //act
            //assret
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoString_ShouldBeEqual()
        {
            //arrange
            string number1 = "Mariola";
            string number2 = "Mariola";
            //act
            //assret
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoFloat_ShouldBeNotEqual()
        {
            //arrange
            float number1 = 5.2f;
            float number2 = 5.5f;
            //act
            //assret
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoEmployee_ShouldBeNotEqual()
        {
            //arrange
            var Employee1 = GetEmployee("Adam", "Kowalski", 20);
            var Employee2 = GetEmployee("Tomasz", "Kowalski", 21);
            //act
            //assret
            Assert.AreNotEqual(Employee1, Employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}