string name = "Ewa";
string gender = "female";
int age = 33;

if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa,lat 33");
}
else if (gender != "female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (gender != "female" && age > 30)
{
    Console.WriteLine("Mężczyzna powyżej 30 lat");
}