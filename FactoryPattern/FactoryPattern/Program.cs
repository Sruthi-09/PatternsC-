using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
        interface IFood
        {
            void FavOne();
        }
        class Biryani : IFood
        {
            public void FavOne()
            {
                Console.WriteLine("1st favourite food");
            }
        }
        class Pizza : IFood
        {
            public void FavOne()
            {
                Console.WriteLine("2nd favourite food");
            }
        }
        class IceCream : IFood
        {
            public void FavOne()
            {
                Console.WriteLine("3rd favourite food");
            }
        }
        class Factory
        {
            public IFood GetFavourite(string str)
            {
                if (str.Equals("First"))
                {
                    return new Biryani();
                }
                else if (str.Equals("Second"))
                {
                    return new Pizza();
                }
                else
                {
                    return new IceCream();
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Factory a = new Factory();
                IFood b = a.GetFavourite("First");
                b.FavOne();


            }
        }
    }
