using SEDC.Homework_6.Driver.Classes;

Driver[] drivers = new Driver[4]
{
    new Driver {Name = "Bob", Level = 5},
    new Driver {Name = "Greg", Level= 3},
    new Driver {Name = "Jill", Level = 2},
    new Driver {Name = "Anne", Level = 4}
};

Car[] cars = new Car[4]
{
    new Car {Model = "Hyndai", Speed = 150},
    new Car {Model = "Mazda", Speed = 120},
    new Car {Model = "Ferrari", Speed = 250},
    new Car {Model = "Porche" , Speed = 230}
};

while (true)
{
    Console.WriteLine("Select a car no.1");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1} {cars[i].Model}");
    };
    int carNoOne = int.Parse(Console.ReadLine()) - 1;


    Console.WriteLine("Select driver no.1");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1} {drivers[i].Name}");

    };
    int driverNoOne = int.Parse(Console.ReadLine()) - 1;


    Console.WriteLine("Select car no.2");
    for (int i = 0; i < cars.Length; i++)
    {
        if (i != carNoOne)
        {
            Console.WriteLine($"{i + 1} {cars[i].Model}");
        }
    };
    int carNoTwo = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Select driver no.2");
    for (int i = 0; i < drivers.Length; i++)
    {
        if (i != driverNoOne)
        {
            Console.WriteLine($"{i + 1} {drivers[i].Name}");
        }
    };
    int driverNoTwo = int.Parse(Console.ReadLine()) - 1;


    cars[carNoOne].Driver = drivers[driverNoOne];
    cars[carNoTwo].Driver = drivers[driverNoTwo];

    RaceCar(cars[carNoOne], cars[carNoTwo]);
    Console.WriteLine("Do you whant to race again? Y or N");
    string input = Console.ReadLine();  
    if (input == "Y" || input == "y")
    {
        RaceCar(cars[carNoOne], cars[carNoTwo]);
    }
    else if (input == "N" || input == "n")
    {
        Console.WriteLine("See you next time");
        break;
    }
    else
    {
        Console.WriteLine("You input somethig wrong.Plase check!");
        break;
    }
}
void RaceCar(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();  

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"Car {car1.Model} was won. The speed of this car is {car1.Speed} and was driven by {car1.Driver.Name}");
    } else if (car1Speed < car2Speed)
    {
        Console.WriteLine($"Car {car2.Model} was won. The speed of this car is {car2.Speed} and was driven by {car2.Driver.Name}");
    }
    else
    {
        Console.WriteLine("Nobody win!");
    }
};
