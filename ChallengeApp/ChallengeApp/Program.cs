using ChallengeApp;

Employee employee1 = new("Daniel", "Kowalski", 28);
Employee employee2 = new("Mariola", "Nowak", 22);
Employee employee3 = new("Kamil", "Furdak", 30);

employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
//24
employee2.AddScore(9);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(2);
employee2.AddScore(6);
//30
employee3.AddScore(8);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(9);
//41

List<Employee> employees = new()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwyższą liczbe punktów: "
    + maxResult
    + " Uzyskał pracownik: "
    + employeeWithMaxResult.Name
    + " "
    + employeeWithMaxResult.Surname
    +" w wieku "
    + employeeWithMaxResult.Age
    +" lat.");


