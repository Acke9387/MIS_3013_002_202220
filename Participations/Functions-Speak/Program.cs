Console.WriteLine("Please name an animal >>");
string animal = Console.ReadLine();

string noise = Speak(animal);
Console.WriteLine(noise);
Console.WriteLine("Enter another animal >>");
animal = Console.ReadLine();
Console.WriteLine(Speak(animal));
 string Speak(string x)
{
    string output = "";
    string sound;
    if (x == "dog")
    {
        sound = "arf arf";
    }
    else if (x == "monkey")
    {
        sound = "oooo ahhhh ahhh";
    }
    else if (x == "goat")
    {
        sound = "Human scream";
    }
    else
    {
        sound = "GRRR";
    }

    output = $"{x} makes the sound '{sound}'";

    return output;
}

//double Speak(double y, double x)
//{
//    return 0;
//}