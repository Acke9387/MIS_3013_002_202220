int[] ids = new int[3];
//double[] gpas = new double[3];
//                0    1    2
double[] gpas = { 3, 3.25, 2.75 };

ids[0] = 33;
ids[1] = 76;
ids[2] = 5;

Console.WriteLine("From the below list, whose GPA do you want to see? >>");

//Console.WriteLine(ids[0]);
//Console.WriteLine(ids[1]);
//Console.WriteLine(ids[2]);

//for (int i = 0; i < ids.Length; i++)
//{
//    int currentId = ids[i];
//    Console.WriteLine(currentId);
//}

foreach (int currentId in ids)
{
    Console.WriteLine(currentId);
}
Console.WriteLine(">>");
int selectedId = Convert.ToInt32(Console.ReadLine());

bool foundId = false;

for (int i = 0; i < ids.Length; i++)
{
	if (selectedId == ids[i])
	{
		Console.WriteLine(gpas[i]);
		foundId = true;
		break;
	} 
}

if (foundId == false)
{
	Console.WriteLine($"Sorry, there's no student with id {selectedId.ToString("N0")}");
}