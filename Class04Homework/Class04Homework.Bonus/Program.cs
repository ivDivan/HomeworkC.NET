Console.WriteLine("Gimme a sentence");
string sentenceInput = Console.ReadLine();


void SplitSentence(string sentence)
{
    if (sentence.Contains(" "))
    {
        string[] words = sentence.Split(' ');
        string largestWord = "";

        foreach (string word in words)
        {
            if(word.Length > largestWord.Length)
            {
                largestWord = word;
            }
        }

        Console.WriteLine($"The largest word in the sentence is {largestWord}");
    }
    else
    {
        Console.WriteLine("Keep talkin'....");
    }
}

SplitSentence(sentenceInput);