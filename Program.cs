using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //Method overloading is an example of Static Polymorphism

            TestData test = new TestData();

            int add1 = test.Add(30, 40, 50);
            int add2 = test.Add(20, 10);

        }

        public class TestData
        {
         
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}
