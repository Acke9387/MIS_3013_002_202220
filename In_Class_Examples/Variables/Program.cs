const string message = "Welcome, to my application";
Console.WriteLine(message);
Console.WriteLine("What is your name? >>\n");

string name = Console.ReadLine();

Console.WriteLine(name + ", what is your monthly income? >>");
string answer = Console.ReadLine();
double income = Convert.ToDouble(answer);

Console.WriteLine($"{name}, what is your monthly expenses? >>");
answer = Console.ReadLine();
double expenses = Convert.ToDouble(answer);

double total = income - expenses;

Console.WriteLine($"Your total is {total.ToString("C3")}");