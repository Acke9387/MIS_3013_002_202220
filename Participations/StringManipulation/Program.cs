const string SENTENCE = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
Console.WriteLine(SENTENCE);

Console.WriteLine("What word would you like to replace? >>");
string searchWord = Console.ReadLine();

Console.WriteLine($"What would you like to replace '{searchWord}' with? >>");
string replaceWord = Console.ReadLine();

bool sentenceContainsSearchWord = SENTENCE.Contains(replaceWord);

if (sentenceContainsSearchWord == true)
{
    string newSentence = SENTENCE.Replace(searchWord, replaceWord);
    Console.WriteLine(newSentence);
}
else
{
    Console.WriteLine($"Sorry, I could not find your word {searchWord}.");

    for (int i = searchWord.Length - 1; i >= 0; i = i -1)
    {
        Console.Write(searchWord[i]);
    }
}


