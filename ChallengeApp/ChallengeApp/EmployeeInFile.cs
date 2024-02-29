namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;    

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var write = File.AppendText(fileName))
                {
                    write.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
            
        }
        public override void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public override void AddGrade(char grade)
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
        public override void AddGrade(int grade)
        {
            float gradeToInt = (int)grade;
            this.AddGrade(gradeToInt);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("String in not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
        
    }   
}
