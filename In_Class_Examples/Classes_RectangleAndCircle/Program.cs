
using Classes_RectangleAndCircle;

Rectangle r = new Rectangle();
r.Width = 5;
r.Length = 10;
//r.SetLength(10);

//Console.WriteLine($"Width:{r.Width} Length:{r.Length} Area:{r.CalculateArea()} Perimeter:{r.CalculatePerimeter()}");

Rectangle r1 = new Rectangle();
r1.Width = 7.5;
r1.Length = 10;

//Console.WriteLine($"Width:{r1.Width} Length:{r1.Length} Area:{r1.CalculateArea()} Perimeter:{r1.CalculatePerimeter()}");

Console.WriteLine("What is the rectangles width? >>");
double w = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the rectangles length? >>");
double l = Convert.ToDouble(Console.ReadLine());

Rectangle r2 = new Rectangle(w, l);

List<Rectangle> rectangles = new List<Rectangle>();
rectangles.Add(r);
rectangles.Add(r1);
rectangles.Add(r2);

foreach (Rectangle rect in rectangles)
{
    Console.WriteLine(rect);
}