string[] studentsG1 = new string[] { "Mile", "Kemal", "Semsa", "Dzej", "Ipce" };
string[] studentsG2 = new string[] { "The", "Artist", "Formerly", "Known as", "Prince" };


Console.WriteLine("Gimme a 1 or a 2");
if (int.TryParse(Console.ReadLine(), out int result))
{
    switch (result)
    {
        case 1:
            Console.WriteLine("The students in G1 are: ");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }
            break;
        case 2:
            Console.WriteLine("The students in G2 are: ");
            foreach(string student in studentsG2)
            {
                Console.WriteLine(student);
            }
            break;
        default:
            Console.WriteLine("Ooopsiiieee!!! Gimme a 1 or a 2");
            break;
    }
}
else
{
    Console.WriteLine("Ooooopsiiiieee!! Gimme a number!!!");
}
