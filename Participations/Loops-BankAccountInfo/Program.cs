Console.WriteLine("How many bank accounts do you have? >>");
string answer = Console.ReadLine();
int numberOfAccounts;

while (int.TryParse(answer, out numberOfAccounts) == false)
{
    Console.WriteLine("Incorrect input, please try again >>");
    answer = Console.ReadLine();
}

double total = 0;

for (int i = 1; i <= numberOfAccounts; i++)
{

    Console.WriteLine($"What is your balance for bank account {i.ToString("N3")}");
    double balance;// = Convert.ToDouble(Console.ReadLine());
    answer = Console.ReadLine();
    while (double.TryParse(answer, out balance) == false)
    {
        Console.WriteLine("Incorrect input, please try again >>");
        answer = Console.ReadLine();
    }


    //total = total + balance;
    total += balance;
}

Console.WriteLine($"Your total amount for all bank accounts is {total.ToString("C")}");

double averageBalance = total / numberOfAccounts;

if (averageBalance > 5000)
{
    Console.ForegroundColor = ConsoleColor.Green;// (ConsoleColor)10;
}

Console.WriteLine($"Your average amount for your bank accounts is {averageBalance.ToString("C")}");

Console.ForegroundColor = ConsoleColor.White;