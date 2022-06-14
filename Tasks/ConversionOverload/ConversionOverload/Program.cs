using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOverload
{
    public class Dimtwo
    {
        public int a, b;
        public Dimtwo()
        { }
        public Dimtwo(int x, int y)
        {
            a = x;
            b = y;
        }
        public static implicit operator Dimtwo(Dimthree v)
        {
            Dimtwo d1=new Dimtwo(v.a, v.b);
            return d1;
        }
        public void Show()
        {
            Console.WriteLine("2-D x="+a+"y"+b);
        }


    }
    public class Dimthree
    {
        public int a, b, c;
        public Dimthree()
        {

        }
        public Dimthree(int x,int y,int z)
        {
            a = x;
            b = y;
            c = z;
        }

        public Dimthree(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static explicit operator Dimthree(Dimtwo v)
        {
            Dimthree d2 = new Dimthree(v.a, v.b);
            return d2;
        }
        public void Show()
        {
            Console.WriteLine("3-D x=" + a + "y=" + b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dimtwo dimtwo = new Dimtwo();   
            //dimtwo.a = 1;   
            //dimtwo.b = 2;   
            Dimthree dimthree = new Dimthree();
           // dimthree.a = 3; 
            //dimthree.b = 4; 
           // dimthree.c = 5;
            dimthree = (Dimthree)dimtwo;
            dimthree.Show();

        }
    }
}
