using Classes_Toy;

List<Toy> toybox = new List<Toy>();
Toy toy= new Toy();
toy.Name = "Buzz";
toy.Manufacturer = "Hasbro";
toy.SetNote("Fun");
toy.Price = 50;

toybox.Add(toy);

Toy toy2 = new Toy("More fun than Buzz");
toy2.Name = "Slinky dog";
toy2.Manufacturer = "Hasbro";
toy2.Price = 24.99;

toybox.Add(toy2);


foreach (Toy t in toybox)
{
    Console.WriteLine(t.ToString());
}