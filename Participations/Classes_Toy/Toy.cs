using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Toy
{
    public class Toy
    {

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public List<string> MyProperty { get; set; }

        public void SetNote(string note)
        {
            Notes = note;
        }

        public string GetNote()
        {
            return Notes;
        }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = string.Empty;
            MyProperty = new List<string>();
        }

        public Toy(string note) : this()
        {
            //Manufacturer = string.Empty;
            //Name = "";
            //Price = 0;
            //Notes = string.Empty;
            //MyProperty = new List<string>();
            Notes = note;
        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} costs {Price.ToString("C")} located on aisle {GetAisle()}\tNotes: {Notes}";
        }

        public string GetAisle()
        {
            string aisleLetter = Manufacturer.ToUpper()[0].ToString();
            Random r = new Random();
            aisleLetter += r.Next(1, 25);

            return aisleLetter;
        }
    }
}
