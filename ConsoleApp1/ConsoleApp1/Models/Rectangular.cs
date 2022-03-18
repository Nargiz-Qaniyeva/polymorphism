using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Rectangular : Figure
    {
        public int Length
        {
            get
            {
                return Length;
            }
            set
            {
                if (value > 0)
                    Length = value;
                else
                    Console.WriteLine("Error");
            }
        }
        public int Width
        {
            get
            {
                return Width;
            }
            set
            {
                if (value > 0)
                    Width = value;
                else
                    Console.WriteLine("Error!!!");
            }
        }
        public Rectangular()
        {
            this.Width = Width;
            this.Length = Length;
        }

        public override int CalcArea()
        {
            Length = 3;
            Width = 4;
            int area = Width * Length;
            return area;
        }
    }
}
