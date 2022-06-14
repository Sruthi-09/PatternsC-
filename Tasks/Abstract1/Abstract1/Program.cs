using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
        abstract class maths
        {
        public abstract void Info();
        public int Add(int a,int b)
        {
            return a + b;
        }

        }
    class Mul : maths
    {
        public int mul(int a, int b)
        {
            return a * b;
        }
        public override void Info()
        {
            Console.WriteLine("performing multiplication");
        }
        
    }
    class Sub : maths
    {
        public int sub(int a, int b)
        {
            return a - b;
        }
        public override void Info()
        {
            Console.WriteLine("performing subtraction");
        }

    }
    class test
        {
            static void Main(string[] args)
            {
                Mul ob = new Mul();
                int result = ob.Add(5, 10);
                int result1=ob.mul(5, 10);
                Sub obj = new Sub();
            int result2=obj.sub(5, 10);

                Console.WriteLine("the result is {0}", result);
            Console.WriteLine("the result is {0}", result1);
            Console.WriteLine("the result is {0}", result2);
        }
        }
    }
