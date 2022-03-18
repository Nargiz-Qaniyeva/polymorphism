using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Square : Figure
    {
        public int Side
        {
            get
            {
                return Side;
            }
            set
            {
                if (value > 0)
                    Side = value;
                else
                    Console.WriteLine(Side);
            }
        }

        public Square()
        {
            this.Side = Side;
        }
        public override int CalcArea()
        {
            int side = 3;
            int area = side * side;
            return area;
        }
    }
}
