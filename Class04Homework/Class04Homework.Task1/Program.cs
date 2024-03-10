Console.WriteLine("Whaddaya say?");
string userInput = Console.ReadLine();  

void GetCharacters(string say)
{
    if (say.Length < 5)
    {
        Console.WriteLine("Say somethin' more... :P");
    }
    else
    {
        Console.WriteLine(say.Substring(say.Length - 5, 5));
    }
}

GetCharacters(userInput);