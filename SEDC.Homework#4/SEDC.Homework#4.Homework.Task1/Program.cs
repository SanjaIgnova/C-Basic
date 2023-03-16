using SEDC.Homework_4.Homework.Task1.Classes;

Human human = new Human();

Console.WriteLine("Plase enter a first name?");
string firstName = Console.ReadLine();

Console.WriteLine("Plase enter a last name?");
string lastName = Console.ReadLine();

Console.WriteLine("Plase enter a age?");
bool age = int.TryParse(Console.ReadLine(), out int ageHuman);

while (true)
{
    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Plase enter a valid imput!");
    }
    else
    {
        human.FirstName = firstName; human.LastName = lastName;
        break;
    }
}
while (true) { 

    if (age)
    {
        human.Age = ageHuman;
        break;
    }else
    {
        Console.WriteLine("Plase enter a valid input!");
        break;
    }
}

human.GetPersonStats();