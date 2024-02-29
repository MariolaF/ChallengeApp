namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)

        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(decimal grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(int grade)
        {
            float gradeToInt = grade;
            this.AddGrade(gradeToInt);
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong Grade");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}