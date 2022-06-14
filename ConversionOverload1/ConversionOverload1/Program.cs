using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOverload1
{

        internal class Program
    {
        class Dim
        {
            int x, y, z;
            public Dim()
            {
                x = y = z = 0;
            }
            public Dim(int i, int j, int k)
            {
                x = i;
                y = j;
                z = k;
            }
            public static Dim operator +(Dim op1, Dim op2)
            {
                Dim result = new Dim();
                result.x = op1.x + op2.x;
                result.y = op1.y + op2.y;
                result.z = op1.z + op2.z;
                return result;
            }
            public static implicit operator int(Dim op1)
            {
                return op1.x * op1.y * op1.z;
            }
            public void Show()
            {
                Console.WriteLine(x + ", " + y + ", " + z);
            }
            public static explicit operator double(Dim op1)
            {
                return op1.x * op1.y * op1.z;
            }

            // Show X, Y, Z coordinates.
            public void Display()
            {
                Console.WriteLine(x + ", " + y + ", " + z);
            }
        }

        static void Main(string[] args)
        {
            Dim a = new Dim(1, 2, 3);
            Dim b = new Dim(10, 10, 10);
            Dim c = new Dim();
            int i;
            a.Show();

            Console.WriteLine();
            a.Display();

            b.Show();
            Console.WriteLine();
            b.Display();
            c = a + b;
            Console.Write("Result of a + b: ");
            c.Show();
            c.Display();

            Console.WriteLine();

            i = a;

            Console.WriteLine("Result of i = a: " + i);
            Console.WriteLine();


            i = b - a * 2;
            Console.WriteLine("result of b - a * 2 : {0}\n", i);



        }
    }
}

