double num1;
double num2;
string op;

while (true)
{
    Console.WriteLine("Gimme a number, any number");
    string numInput1 = Console.ReadLine();
    bool numParsed1 = double.TryParse(numInput1, out num1);

    if(numParsed1)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ooooopsiiieeee!! Gimme a number!!!");
    }
}

while (true)
{
    Console.WriteLine("Gimme another number, any number");
    string numInput2 = Console.ReadLine();
    bool numParsed2 = double.TryParse(numInput2, out num2);

    if(numParsed2)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ooooopsiiieeee!! Gimme a number!!!");
    }
}



while (true)
{
    Console.WriteLine("Gimme a \"+\" or a \"-\"");
    op = Console.ReadLine();

    if (op == "+" || op == "-")
    {
        break;
    }
    else
    {
        Console.WriteLine("Woooow camel!!!Gimme a \"+\" or a \"-\"");
    }
}

switch (op)
{
    case "+":
        double sum = num1 + num2;
        Console.WriteLine($"The result is: {sum}");
        break;
    case "-":
        double subtr = num1 - num2;
        Console.WriteLine($"The result is: {subtr}");
        break;
}