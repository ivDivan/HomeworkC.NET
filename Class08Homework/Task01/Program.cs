Queue<int> numQueue = new Queue<int> ();
string anotherNum;

do
{
    while (true)
    {
        Console.WriteLine("Gimme a number, any number");
        string numberInput = Console.ReadLine();
        int number;

        if (int.TryParse(numberInput, out number))
        {
            numQueue.Enqueue(number);
            break;
        }
        else
        {
            Console.WriteLine("You need to gimme a number!!!");
        }
    }

    do
    {
        Console.WriteLine("You need another number?? Gimme a Y/N.");
        anotherNum = Console.ReadLine().ToUpper();

        if (anotherNum != "Y" && anotherNum != "N")
        {
            Console.WriteLine("You need to gimme a Y or a N on that...");
        }
    }
    while (anotherNum != "Y" && anotherNum != "N");
}
while (anotherNum == "Y");

Console.WriteLine("The numbers you entered in the order you entered them are:");
foreach (int i in numQueue)
{
    Console.WriteLine(i);
}




