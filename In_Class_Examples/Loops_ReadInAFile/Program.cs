string entireBook = File.ReadAllText("The stainless steel rat by Harry Harrison.txt");

//Console.WriteLine(entireBook);

string[] linesOfBook = File.ReadAllLines("The stainless steel rat by Harry Harrison.txt");

Console.WriteLine(linesOfBook[0]);

Console.ForegroundColor = ConsoleColor.Red;

//Console.WriteLine(linesOfBook[1]);


bool foundStartOfBook = false;

for (int i = 0; i < linesOfBook.Length; i++)
{
	string line = linesOfBook[i];

	if (line.Contains("THE END") == true)
	{
		Console.WriteLine(line);
		break;
	}

	if (foundStartOfBook == false && line.Contains("Title") == false)
	{
		continue;
	}
	else
	{
		foundStartOfBook = true;
	}


    Console.WriteLine(linesOfBook[i]);
	//if (i % 15 == 0)
	//{
	//	Console.ReadKey();
	//}
}