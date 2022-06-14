using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Op1
    {

        public int a,b;
        public int c,d,e,f;
        public int num3,num4;

        public Op1(int num1, int num2)
        {
            a = num1;
            b= num2;
            c = num1;
            d = num2;
            e = num1;
            f = num2;
        }

        public Op1(int num3)
        {
            this.num3=num3;
            num4 = num3;
        }

        public Op1()
        {
        }

        public static Op1 operator -(Op1 op)
        {
            op.a = -op.a; ;
            op.b= -op.b;
            return op;
        }
        public static Op1 operator ++(Op1 op)
        {
            op.c = ++ op.c; ;
            op.d =++ op.d;
            return op;
        }
        public static Op1 operator +(Op1 op1,Op1 op2)
        {
            Op1 op3 = new Op1(0);
            op3.num4 = op1.num4+ op2.num4;
            return op3;
        }
        public static Op1 operator %(Op1 op1, Op1 op2)
        {
            Op1 op3 = new Op1(0);
            op3.num3 = op1.num3 % op2.num3;
            return op3;
        }
       
        public void Print()
        {
            Console.WriteLine("Unary Operator");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
        public void Display()
        {
            Console.WriteLine("Binary Operator");
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Op1 ab = new Op1(10,-40);
           // Op1 fg = new Op1(20, 30);
           // Op1 gh = new Op1(20, 30);
            ab = -ab;
            ab.Print();
            Op1 bc = new Op1(10);
            Op1 cd = new Op1(30);
            Op1 de = new Op1();
            Op1 ef=new Op1();
            de = bc +cd;
            ef = bc % cd;
            de.Display();
            ef.Display();

           

        }
    }
}
