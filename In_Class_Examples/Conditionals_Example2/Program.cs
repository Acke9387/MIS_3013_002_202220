const string DEVELOPER_INFO = "Professor Ackerman";
Random rand = new Random();

int randomNumber = rand.Next(1, 100 + 1);

randomNumber = 1;
if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if(randomNumber % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (randomNumber % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(randomNumber.ToString("N0"));
}


Console.WriteLine(DEVELOPER_INFO);