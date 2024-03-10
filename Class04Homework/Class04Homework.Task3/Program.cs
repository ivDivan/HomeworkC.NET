//prv instinkt mi bese so delenje so 10 i ostatokot da si igram (mislam u JS deka istoto go pravevme) 
//ama sakav da probam nesto drugo i nekako mi se svigja kako mi iskoci...

int DigitSum(int num)
{
    string numString = num.ToString();
    char[] numArray = numString.ToCharArray();
    int sum = 0;
    foreach (char chr in numArray)
    {
        sum += int.Parse(chr.ToString());
    }
    Console.WriteLine($"The sum of digits in {num} is {sum}");
    return sum;
}


while (true)
{
    Console.WriteLine("Gimme a number");
    string numberInput = Console.ReadLine();
    int number;
    bool numberParsed = int.TryParse(numberInput, out number);

    if (numberParsed)
    {
        DigitSum(number);
        break;
    }
    else
    {
        Console.WriteLine("You need to gimme a number!!!");
    }
}

