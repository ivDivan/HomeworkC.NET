List<int> numberList = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
Console.WriteLine("The numbers in numberList are:");
foreach (int num in numberList)
{
    Console.WriteLine(num);
}

List<int> squaresList = numberList.Select(n => n * n).ToList();
Console.WriteLine("The squares of the numbers in the numberList are:");
foreach (int square in squaresList)
{
    Console.WriteLine(square);
}