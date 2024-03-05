Console.WriteLine("Enter First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Third Number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Fourth Number: ");
int num4 = Convert.ToInt32(Console.ReadLine());

int avg = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {avg}");