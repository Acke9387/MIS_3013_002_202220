Console.WriteLine("What # do you want to count down from? >>");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = number; i > -1; i = i - 1)
{
    Console.WriteLine(i.ToString("N0"));
}
