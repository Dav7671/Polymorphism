using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(12);
            Console.WriteLine($"Area of the square = {square.GetArea()}");

            Console.Read();
        }

        abstract class Shape
        {
            public abstract int GetArea();
        }

        class Square : Shape
        {
            private int _side;

            public Square(int n)
            {
                _side = n;
            }
            public override int GetArea()
            {
                return _side * _side;
            }
        }
    }
}
