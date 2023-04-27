
using Classes_Pharmaceutical_Drugs;

string[] fileContents = File.ReadAllLines("Pharmaceutical Drugs.csv");

List<Drug> drugList = new List<Drug>();

for (int i = 1; i < fileContents.Length; i++)
{
    //  0     1      2     3      4
    //Name,Company,Brand,Code,StreetName
    string[] piecesOfLine = fileContents[i].Split(',');

    Drug d = new Drug();
    d.Name = piecesOfLine[0];
    d.Company = piecesOfLine[1];
    d.Brand = piecesOfLine[2];
    d.Code = Convert.ToInt32(piecesOfLine[3]);
    d.StreetName = piecesOfLine[4];

    drugList.Add(d);
}

foreach (Drug drugItem in drugList)
{
    Console.WriteLine(drugItem.Name);
}

Console.WriteLine("\n\n----------------------------");
Console.WriteLine("Which drug would you like more information about? >>");
string answer = Console.ReadLine();

foreach (Drug drugItem in drugList)
{
    if (drugItem.Name == answer)
    {
        Console.WriteLine(drugItem);
    }
}
