int[] sumArray = new int[6];
int sum = 0;

for (int i = 0; i < sumArray.Length; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1}");
    if (int.TryParse(Console.ReadLine(), out sumArray[i]))
    {
        if (sumArray[i] % 2 == 0)
        {
            sum += sumArray[i];
        }
    }
    else
    {
        Console.WriteLine("You got yourself an oooopsiiieee!!! Mebbe try again?");
        i--;
    }
}

Console.WriteLine($"The result is: {sum}");
