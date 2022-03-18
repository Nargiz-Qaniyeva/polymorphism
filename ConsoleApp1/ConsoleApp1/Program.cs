using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Square square = new Square();
                    Console.WriteLine(square.CalcArea());
                    break;
                case "2":
                    Rectangular rectangular = new Rectangular();
                    Console.WriteLine((rectangular.CalcArea()));
                    break;

                case "0":
                    return;
                default:
                    Console.WriteLine("error");
                    break;



            }
        }
    }
  }

