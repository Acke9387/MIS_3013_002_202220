string[] names = new string[5];
int[] ids = new int[5];
List<List<double>> grades = new List<List<double>>();
grades.Add(CreateRandomSizedListWithRandomValues());


static List<double> CreateRandomSizedListWithRandomValues()
{
    List<double> randoGrades = new List<double>();
    Random rand = new Random();
    int numberOfGrades = rand.Next(3, 10);

    for (int i = 0; i < numberOfGrades; i++)
    {
        double grade = rand.NextDouble() * 100;
        randoGrades.Add(grade);
    }

    return randoGrades;
}