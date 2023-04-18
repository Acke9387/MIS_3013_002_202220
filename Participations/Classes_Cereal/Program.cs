
using Classes_Cereal;

string entireContentsOfFile = File.ReadAllText("Cereal_Data.txt");

//Console.WriteLine(entireContentsOfFile);

string[] eachLineOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < eachLineOfFile.Length; i++)
{
    Cereal c = new Cereal();
    //  0       1          2      3
    //name|manufacturer|calories|cups
    string[] partsOfLine = eachLineOfFile[i].Split('|');
    // partsOfLine[0] = "name"
    // partsOfLine[1] = "manufacturer"
    // partsOfLine[2] = "calories"
    // partsOfLine[3] = "cups"

    string manufacturer = partsOfLine[1];
    double cups = Convert.ToDouble(partsOfLine[3]);
    c.Manufacturer = manufacturer;
    c.Cups = cups;

    cereals.Add(c);
    //Console.WriteLine($"{manufacturer} {cups.ToString()}");
}

//cereals that have serving size of 1 cup or more
foreach (Cereal cereal in cereals)
{

}

//cereals that have 100 calories or less
foreach (Cereal cereal in cereals)
{

}