using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public class dynamic1
    {
        public int add(int a,int b)
        {
            return a + b;
        }
    }
    public class var1
    {
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic1 dynamic = new dynamic1();
            {
                int result=dynamic.add(10, 5);
                Console.WriteLine(result);
            }
            var1 var = new var1();
            {
                int result1 = var.mul(10, 5);
                Console.WriteLine(result1);
            }
            dynamic ab = 1;
            Console.WriteLine("Value: {0}, Type: {1}", ab, ab.GetType());
            ab = "Hello All";
            Console.WriteLine("Value: {0}, Type: {1}", ab, ab.GetType());
            ab = "false";
            Console.WriteLine("Value: {0}, Type: {1}", ab, ab.GetType());
            dynamic bc = 20;
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            bc = "Good";
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            string Morning = bc;
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            bc = 23.45;
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            bc = (int)30.54;
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            bc = (float)70;
            Console.WriteLine("Value: {0}, Type: {1}", bc, bc.GetType());
            var ab1 = 10;
            Console.WriteLine("Value: {0}, Type: {1}", ab1, ab1.GetType());
            ab1 = 30;
            Console.WriteLine("Value: {0}, Type: {1}", ab1, ab1.GetType());
           var ab2 = "hello all";
            Console.WriteLine("Value: {0}, Type: {1}", ab2, ab2.GetType());
           var ab3 = 90.53;
            Console.WriteLine("Value: {0}, Type: {1}", ab3, ab3.GetType());


        }


        }
    }

