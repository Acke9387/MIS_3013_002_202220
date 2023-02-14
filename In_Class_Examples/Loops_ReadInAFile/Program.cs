string entireBook = File.ReadAllText("The stainless steel rat by Harry Harrison.txt");

//Console.WriteLine(entireBook);

string[] linesOfBook = File.ReadAllLines("The stainless steel rat by Harry Harrison.txt");

Console.WriteLine(linesOfBook[0]);

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine(linesOfBook[1]);

for (int i = 0; i < linesOfBook.Length; i++)
{
    Console.WriteLine(linesOfBook[i]);
	if (i % 15 == 0)
	{
		Console.ReadKey();
	}
}