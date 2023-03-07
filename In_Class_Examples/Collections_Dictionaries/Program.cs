Dictionary<string, double> students = new Dictionary<string, double>();

do
{
    Console.WriteLine("What is the student's id? >>");
    string id = Console.ReadLine();

    Console.WriteLine($"What is {id}'s GPA? >>");
    double gpa = Convert.ToDouble(Console.ReadLine());

    if (students.ContainsKey(id) == false)
    {
        students.Add(id, gpa);
    }
    else
    {
        Console.WriteLine($"{id} has already been entered.  We will update their gpa");
        students[id] = gpa;
    }

    Console.WriteLine("Do you want to add another student? yes or no >>");
} while (Console.ReadLine().ToLower() == "yes");


Console.WriteLine("Which student's GPA do you want to see? >>");

foreach (string id in students.Keys)
{
    Console.WriteLine(id);
}

string answer = Console.ReadLine();

if (students.ContainsKey(answer) == true)
{
    double studentGpa = students[answer];

    Console.WriteLine($"{answer} has a {studentGpa.ToString("n2")}"); 
}
else
{
    Console.WriteLine($"{answer} does not exist.");
}