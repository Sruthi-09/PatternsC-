using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface ITypeFood
    {
        void DisplayOrder();
    }
    public class Low : ITypeFood
    {
        public string Name { get; set; }
        public Low(string name)
        {
            this.Name = name;
        }

        public void DisplayOrder()
        {
            Console.WriteLine(Name);
        }
    }
    public class High : ITypeFood
    {
        public string Name { get; set; }
        List<ITypeFood> Foods = new List<ITypeFood>();
        public High(string name)
        {
            this.Name = name;
        }
        public void AddItem(ITypeFood item)
        {
            Foods.Add(item);
        }

        public void DisplayOrder()
        {
            Console.WriteLine(Name);
            foreach (var a in Foods)
            {
                a.DisplayOrder();
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ITypeFood sugar = new Low("Sugar");
            ITypeFood fruits = new Low("Fruits");
            ITypeFood spicies = new Low("Spicies");
            ITypeFood vegetables = new Low("Vegetables");
            High sweet = new High("Sweet Food");
            High spicy = new High("Spicy Food");
            High snacks = new High("snacks");
            High food = new High("Food");
            sweet.AddItem(sugar);
            sweet.AddItem(fruits);
            snacks.AddItem(sweet);
            snacks.AddItem(spicy);
            spicy.AddItem(spicies);
            spicy.AddItem(vegetables);
            food.AddItem(snacks);
            food.DisplayOrder();
            Console.WriteLine();
            snacks.DisplayOrder();
            Console.WriteLine();
        }
    }
}
