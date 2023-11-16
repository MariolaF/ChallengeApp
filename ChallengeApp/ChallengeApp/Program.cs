using ChallengeApp;
using System;

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

var statistic1 = employee.GetStatisticsWithForEach();
Console.WriteLine("Wyniki dla pętli Foreach");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");

var statistic2 = employee.GetStatisticWithFor();
Console.WriteLine("Wyniki dla pętli For");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");

var statistic3 = employee.GetStatisticWithDoWhile();
Console.WriteLine("Wyniki dla pętli Do While");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");

var statistic4 = employee.GetStatisticWithWhile();
Console.WriteLine("Wyniki dla pętli While");
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Max: {statistic.Max}");


