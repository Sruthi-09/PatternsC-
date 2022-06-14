using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public interface Stamp
    {
        void Write();
    }
    public class Word : Stamp
    {
        public string Color { get; set; }
        private string Straight = "Line";

        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Write()
        {
            Console.WriteLine("Signature : Sai Sruthi");
        }
    }
    public class Shape
    {
        private static Dictionary<string, Stamp> stampMap = new Dictionary<string, Stamp>();
        public static Stamp GetStamp(string stampType)
        {
            Stamp stamp = null;
            if (stampType.Equals("Straight", StringComparison.InvariantCultureIgnoreCase))
            {
                if (stampMap.TryGetValue("Straight", out stamp))
                {
                }
                else
                {
                    stamp = new Word();
                    stampMap.Add("Straight", stamp);
                }
            }
            return stamp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Creating different color stamp with straight alignment \n");
            Console.WriteLine("\n Black Stamp");
            for (int i = 0; i < 3; i++)
            {
                Word straight = (Word)Shape.GetStamp("straight");
                straight.SetColor("Black");
                straight.Write();
            }
            Console.WriteLine("\n Purple Stamp ");
            for (int i = 0; i < 2; i++)
            {
                Word straight = (Word)Shape.GetStamp("straight");
                straight.SetColor("Purple");
                straight.Write();
            }
            Console.WriteLine("\n Blue Stamp");
            Word a= (Word)Shape.GetStamp("straight");
            a.SetColor("Blue");
            a.Write();
            Console.ReadKey();
        }
    }
}
