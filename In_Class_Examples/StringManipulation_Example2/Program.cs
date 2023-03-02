string answer;
do
{
	Console.WriteLine("Please give me a word >>");
	string word = Console.ReadLine();

	word = word.Replace("e", "EE");

	Console.WriteLine(word);
	Console.WriteLine("Do you want to go again? yes or no >>");
	answer = Console.ReadLine().ToLower();
	answer = answer.ToLower();

} while (answer.ToLower()[0]== 'y');
