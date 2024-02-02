using ChallengeApp;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Witamy w programie do oceny pracownikow i kierownikow");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Aby zakończyć i wyświetlić końcowa ocene wciśnij: q ");
Console.WriteLine();

var employee = new Employee("Mariola", "Furdak");
var supervisor = new Supervisor("Kamil", "Kowalski");


while (true)
{
    Console.WriteLine("Podaj kolejna ocene PRACOWNIKA:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e) 
    {
        Console.WriteLine($"Exception catched:{e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Podaj kolejna ocene KIEROWNIKA:");
    Console.WriteLine("Kierownika oceniamy liczbami używając skali: 1-6");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched:{e.Message}");
    }
}

var statistics = employee.GetStatistics();
var statistics1 = supervisor.GetStatistics();

Console.WriteLine("Dane pracownika");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");

Console.WriteLine("Dane kierownika");
Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"AverageLetter: {statistics1.AverageLetter}");
