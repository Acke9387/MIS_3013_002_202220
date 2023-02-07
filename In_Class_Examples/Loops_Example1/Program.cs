
using System;

int countBy;
Console.WriteLine("What # do you want to count by? >>");
string answer = Console.ReadLine();

bool isUserInputReallyANumber;

isUserInputReallyANumber = int.TryParse(answer, out  countBy);

if (isUserInputReallyANumber == false)
{
    Console.WriteLine("Sorry, you failed to input a number.  Goodbye");
    Environment.Exit(1);
    return;
}

Console.WriteLine("What # do you want to count to? >>");
int countTo = Convert.ToInt32(Console.ReadLine());

int total = countBy;
Console.WriteLine("While Loop");
while (total <= countTo)
{
    Console.WriteLine(total.ToString("N"));
    total = total + countBy;
}

Console.WriteLine("\nFor Loop");
for (int i = countBy; i <= countTo; i += countBy)
{
    Console.WriteLine(i.ToString("N0"));
}