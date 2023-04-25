/*
 * 
 *  
 *@Professor Ackerman
 */


using Classes_Cars;

string[] lines = File.ReadAllLines("Cars.csv");
List<Car> automobiles = new List<Car>();

for (int i = 1; i < lines.Length; i++)
{
    //  0    1     2    3    4    5
    //Make,Model,Year,Color,VIN,Price
    string[] pieces = lines[i].Split(",");
    Car c = new Car();
    c.Make = pieces[0];
    c.Model = pieces[1];
    c.Year = Convert.ToInt32(pieces[2]);
    c.Color = pieces[3];
    c.VIN = pieces[4];
    c.Price = Convert.ToDouble(pieces[5]);

    automobiles.Add(c);
}

foreach (Car item in automobiles)
{
    if (item.Year > 1999)
    {
        Console.WriteLine(item);
    }
}
