using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Engine
    {
        public string Type;
        public string Cost;
        public Engine(string Type, string Cost)
        {
            this.Type = Type;
            this.Cost = Cost;
        }
    }
    class Car
    {
        public List<Engine> engines;
        public Car(List<Engine> engines)
        {
            this.engines = engines;
        }
        public List<Engine> getEngines()
        {

            return engines;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Engine a = new Engine("Straight or Inline Engine Layout", "1 lakh");
            Engine b = new Engine("Flat Engine Layout", "1.5lakh");
            List<Engine> engines = new List<Engine>();
            engines.Add(a);
            engines.Add(b);

            Car car = new Car(engines);
            List<Engine> eng = car.getEngines();
            for(int i = 0; i < eng.Count; i++)
            {
                Console.WriteLine("Type: " + eng.Type + " and " + " Cost : " + eng.Cost);
            }
          
        }
    }
}