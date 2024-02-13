using ChallengeApp;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Witamy w programie do oceny pracownikow");
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine("Aby zakończyć i wyświetlić końcowa ocene wciśnij: q ");
Console.WriteLine();

var employee = new EmployeeInFile("Mariola", "Furdak");



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

var statistics = employee.GetStatistics();
Console.WriteLine("Dane pracownika");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");