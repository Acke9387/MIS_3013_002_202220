string[] names = { "Matt", "Talia", "Micah", "Tim", "Luke" };
int[] ids = new int[5];
List<List<double>> grades = new List<List<double>>();

ids[0] = 1;
ids[1] = 2;
ids[2] = 3;
ids[3] = 4;
ids[4] = 5;

//grades.Add(new List<double>());
//grades.Add(new List<double>());
//grades.Add(new List<double>());
//grades.Add(new List<double>());
//grades.Add(new List<double>());

//grades[0].Add(64);
//grades[0].Add(6.24);
//grades[0].Add(26.24);
//grades[0].Add(26.24);
//grades[0].Add(96.24);


for (int i = 0; i < names.Length; i++)
{
    grades.Add(CreateRandomSizedListWithRandomValues()); 
}

//StudentInformation(names[0], ids[0], grades[0]);
//StudentInformation(names[1], ids[1], grades[1]);
//StudentInformation(names[2], ids[2], grades[2]);

for (int i = 0; i < names.Length; i++)
{
    StudentInformation(names[i], ids[i], grades[i]);
}


void StudentInformation(string name, int id, List<double> grds) 
{
    double sum = 0;

    foreach (var grade in grds)
    {
        sum += grade;
    }

    double average = sum / grds.Count;
    average = grds.Average();

    Console.WriteLine($"{name}-{id} has {grds.Count.ToString("N0")} grades and an average of {average.ToString("N2")}");
}

static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 8);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble() * 100;
        randoGrades.Add(grade);
    }

    return randoGrades;
}