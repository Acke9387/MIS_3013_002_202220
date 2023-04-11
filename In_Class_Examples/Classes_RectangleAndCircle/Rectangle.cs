using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_RectangleAndCircle
{
    public class Rectangle
    {
        //private double Length;
        public double Length { get; set; }

        public double Width { get; set; }

        public string ThisIsNotNeeded { get; set; }

        //public void SetLength(double length)
        //{
        //    Length = length;
        //}

        //public double GetLength()
        //{
        //    return Length;
        //}

        /// <summary>
        /// This is the empty/default constructor
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            ThisIsNotNeeded = string.Empty;
        }

        /// <summary>
        /// This is the overloaded constructor accepting the width and the length
        /// </summary>
        /// <param name="width">The width of the rectangle</param>
        /// <param name="length">The length of the rectangle</param>
        public Rectangle(double width, double length) : this()
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        /// <returns>The area of the rectangle</returns>
        public double CalculateArea()
        {
            double area = Length * Width;

            return area;
        }


        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Width:{Width} \tLength:{Length} \tArea:{CalculateArea()} \tPerimeter:{CalculatePerimeter()}";
        }

    }
}
