using Class05Homework.CreateDog;

Console.WriteLine("What's the dog's name?");
string dogName = Console.ReadLine();

Console.WriteLine("What's the dog's breed?");
string dogBreed = Console.ReadLine();

Console.WriteLine("What's the dog's colour?");
string dogColor = Console.ReadLine();


int dogDoing;
while (true)
{
    Console.WriteLine("What's the dog doing? Gimme a 1 - 3.");
    string dogInput = Console.ReadLine();
    bool dogParsed = int.TryParse(dogInput, out dogDoing);

    if (dogParsed)
    {
       if(dogDoing == 1 ||  dogDoing == 2 || dogDoing == 3)
        {
            break;
        }
        else
        {
            Console.Write("Gimme a 1 - 3!!");
        }
    }
    else
    {
        Console.WriteLine("Gimme a number!!");
    }
}


Dog dog = new Dog();
dog.Name = dogName;
dog.Breed = dogBreed;
dog.Color = dogColor;

switch (dogDoing)
{
    case 1:
        string dogAct1 = dog.Eat();
        Console.Write(dogAct1);
        break;
    case 2:
        string dogAct2 = dog.Play();
        Console.WriteLine(dogAct2);
        break;
    case 3:
        string dogAct3 = dog.ChaseTail();
        Console.WriteLine(dogAct3);
        break;
}
