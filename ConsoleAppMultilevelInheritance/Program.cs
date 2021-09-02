using System;

namespace MultilevelInheritance
{
    class Shape
    {
        public void Display()
        {
            Console.WriteLine("Shape is:");
        }
    }
    class Rectangle : Shape
    {
        public void PrintRectangle()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Square : Rectangle
    {
        public void PrintSquare()
        {
            base.Display();
            Console.WriteLine("Square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.PrintSquare();
            square.Display();
            square.PrintRectangle();
            Console.ReadKey();
        }
    }
}