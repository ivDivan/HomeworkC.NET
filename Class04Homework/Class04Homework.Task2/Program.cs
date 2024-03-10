Console.WriteLine("Gimme a sentence");
string sentenceInput  = Console.ReadLine();


void SplitSentence(string sentence)
{
    if(sentence.Contains(" "))
    {
        string[] words = sentence.Split(' ');
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }
    else
    {
        Console.WriteLine("Keep talkin'....");
    }
}

SplitSentence(sentenceInput);