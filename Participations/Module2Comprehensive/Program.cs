List<string> states = new List<string>();

do
{
    Console.WriteLine("Please enter a state you have lived in >>");
    states.Add(Console.ReadLine());

    Console.WriteLine("Do you have another state to add? yes or no >>");

} while (Console.ReadLine().ToLower() == "yes");

int max = 0;

foreach (string state in states)
{
    if (state.Length > max)
    {
        max = state.Length;
    }
}


foreach (string state in states)
{
    if (state.Length == max)
    {
        Console.WriteLine($"{state.ToUpper()} : {state[0]}{state[1]}");

        // OR

        Console.WriteLine($"{state.ToUpper()} : {state.Substring(0, 2)}");
    }
}