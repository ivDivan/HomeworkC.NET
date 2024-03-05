Console.WriteLine("Input First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Second Number");
int num2 = Convert.ToInt32(Console.ReadLine());

int tempNum = num1;
num1 = num2;
num2 = tempNum;

Console.WriteLine("After Swapping: ");
Console.WriteLine($"First Number: {num1}");
Console.WriteLine($"Second Number: {num2}");
