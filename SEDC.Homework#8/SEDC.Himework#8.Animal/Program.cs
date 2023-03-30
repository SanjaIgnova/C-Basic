using SEDC.Himework_8.Animal.Class;
using SEDC.Himework_8.Animal.Enum;

Console.WriteLine("Animals: ");

List<Animal> animals = new List<Animal>()
{
    new Animal("Bear", "Brown", 5,Gender.Male),
    new Animal("Dog", "White", 6, Gender.Female),
    new Animal("Cat", "Yellow", 2, Gender.Female),
    new Animal("Lion", "Brown", 3, Gender.Male),
    new Animal("Tiger", "Brown", 4, Gender.Female),
    new Animal("Carot", "Blue", 2, Gender.Male),
    new Animal("Aligator", "Green", 8, Gender.Male),
    new Animal("Hippopotamus", "Grey", 7, Gender.Female),
};

List<Animal> ageOfAnimal = animals.Where(animal => animal.Age >= 5).ToList();
Console.WriteLine("There is animal who is 5 or more years old:");
foreach (Animal animal in ageOfAnimal)
{
    Console.WriteLine("-" + animal.Name + " " + animal.Age + "years old");
}

List<Animal> animalNameWithA = animals.Where(animal => animal.Name.StartsWith("A")).ToList();
Console.WriteLine("There is animals witch name starts with A: ");
foreach (Animal animal in animalNameWithA)
{
    Console.WriteLine("-" + animal.Name);
}

List<Animal> maleBrownAnimal = animals.Where(animal => animal.Color == "Brown").Where(animal => animal.Gender == Gender.Male).ToList();
Console.WriteLine("There is animal witch has brown color and is male:");
foreach (Animal animal in maleBrownAnimal)
{
    Console.WriteLine("-" + animal.Name + " "+ "color:" + animal.Color + " gender:" + animal.Gender);
}

Animal nameLengthMoreThanTen = animals.First(animal => animal.Name.Length > 10);
Console.WriteLine("There is the first animal witch name is longer than 10 characters:");
Console.WriteLine("-" + nameLengthMoreThanTen.Name);