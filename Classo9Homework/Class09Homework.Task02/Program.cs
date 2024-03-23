using Classo9Homework.Task02.Domain.Enums;
using Classo9Homework.Task02.Domain.Models;

Animal dog = new Animal("Mile", "Green", 7, AnimalGender.He);
Animal cat = new Animal("Fifi", "Purple", 2, AnimalGender.She);
Animal meercat = new Animal("Frufru", "Yellow", 99, AnimalGender.Ze);
Animal hippogriff = new Animal("Buckbeak", "Brown", 33, AnimalGender.He);
Animal springbok = new Animal("Bambi", "Pink", 2, AnimalGender.She);
Animal wildebeast = new Animal("Stole", "Sepia", 77, AnimalGender.Ze);
Animal stegosaurus = new Animal("Tirilimbambam", "Cyan", 223, AnimalGender.He);

List<Animal> animalsList = new List<Animal>() { cat, dog, meercat, hippogriff, springbok, wildebeast, stegosaurus };

//Ages >5
List<Animal> animalsAgedFive = animalsList.Where(animal => animal.Age > 5).ToList();
Console.WriteLine("Animals older than five are:");
PrintNames(animalsAgedFive);

//Brown males
List<Animal> animalsBrownMale = animalsList.Where(a => a.Color == "Brown" && a.Gender == AnimalGender.He).ToList();

Console.WriteLine("Male, brown animals are:");
PrintNames(animalsBrownMale);

//First animal with long name
Animal parentsHatedIt = animalsList.FirstOrDefault(n => n.Name.Length > 10);
if (parentsHatedIt != null)
{
    Console.WriteLine($"First animal with a name longer than 10 characters is: {parentsHatedIt.Name}");
}
else
{
    Console.WriteLine("No such animals mate...");
}


void PrintNames(List<Animal> animals)
{
    if (animals.Count == 0)
    {
        Console.WriteLine("No such animals mate...");
    }
    else
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}