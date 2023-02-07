Random random = new Random();
int randomNumber = random.Next(1, 3);

//Console.WriteLine(randomNumber.ToString("N0"));

Console.WriteLine("Guess, Heads or Tails? >>");
string answer = Console.ReadLine();


string randomNumberConvertToWord;

if (randomNumber == 1)
{
    //Console.WriteLine("It was Heads.");
    randomNumberConvertToWord = "Heads";
}
else// if (randomNumber == 2)
{
    //Console.WriteLine("It was Tails.");
    randomNumberConvertToWord = "Tails";
}

Console.WriteLine($"It was {randomNumberConvertToWord}.");

if (randomNumberConvertToWord == answer)
{
    Console.WriteLine("Congratulations, you guessed correctly!");
}
else
{
    Console.WriteLine("Sorry, better luck next time.");
}