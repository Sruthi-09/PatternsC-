using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface ICake
    {
        void VanillaCake();
    }
    public class Stove : ICake
    {
        public void VanillaCake()
        {
            Console.WriteLine("Cake is baked using Stove");
        }
    }

    public class Oven : ICake
    {
        public void VanillaCake()
        {
            Console.WriteLine("Cake is baked using Oven");
        }
    }
    public abstract class Baking
    {
        protected ICake cake;
        protected Baking(ICake cake)
        {
            this.cake = cake;
        }
        public abstract void VanillaCake();
    }
    public class StoveBaking : Baking
    {
        public StoveBaking(ICake cake) : base(cake)
        {
        }

        public override void VanillaCake()
        {
            cake.VanillaCake();
        }
    }
    public class OvenBaking : Baking
    {
        public OvenBaking(ICake cake) : base(cake)
        {
        }
        public override void VanillaCake()
        {
            cake.VanillaCake();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StoveBaking b = new StoveBaking(new Stove()) ; 
            b.VanillaCake();
            Console.WriteLine();
            OvenBaking c = new OvenBaking(new Oven());
            c.VanillaCake();
            Console.ReadKey();
        }
    }
 }
