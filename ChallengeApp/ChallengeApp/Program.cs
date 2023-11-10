using ChallengeApp;

var employee = new Employee("Mariola","Furdak");

employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade("300");
employee.AddGrade(5f);
var statistic = employee.GetStatistics();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");

