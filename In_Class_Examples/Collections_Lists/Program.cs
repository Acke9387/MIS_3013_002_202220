List<string> favoriteThings = new List<string>();

do
{
    Console.WriteLine("Please tell me on of your favorite things >>");
    string thing = Console.ReadLine();

    favoriteThings.Add(thing);

    Console.WriteLine("Do you have another favorite thing to tell me about? yes or no >>");

} while (Console.ReadLine().ToLower()[0] == 'y');

foreach (var thing in favoriteThings)
{
    Console.WriteLine(thing);
}

Random random = new Random();
int randomIndex = random.Next(0, favoriteThings.Count);

Console.WriteLine($"A random thing from your list is ");
Console.WriteLine(favoriteThings[randomIndex]);