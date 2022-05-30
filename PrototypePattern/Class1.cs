using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrototypePattern
{
    public class Flower
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Flower flo = new Flower();
            flo.Name = "Rose";
            flo.Color = "Pink";
            Flower flo1 = flo;
            flo1.Name = "Tulip";
            //flo1.Color = "Red";
            Console.WriteLine("Flower 1 \n Name: " + flo.Name + "\n Color: " + flo.Color + "\n");
            Console.WriteLine("Flower 2 \n Name: " + flo1.Name + "\n Color: " + flo1.Color);
            Console.Read();
        }
    }
}
