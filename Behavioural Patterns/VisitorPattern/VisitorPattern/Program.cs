using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
    public class Customer : IElement
    {
        public string CustomerName { get; set; }

        public Customer(string name)
        {
            CustomerName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public interface IVisitor
    {
        void Visit(IElement element);
    }
    public class Markerter : IVisitor
    {
        public string Name { get; set; }
        public Markerter(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Customer customer = (Customer)element;
            Console.WriteLine("Marketer" + this.Name + " markets and sells the product to " + customer.CustomerName);
        }
    }
    class ProductOwner : IVisitor
    {
        public string Name { get; set; }
        public ProductOwner(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Customer customer = (Customer)element;
            Console.WriteLine("ProductOwner " + this.Name + " sells the product "
                            + customer.CustomerName);
        }
    }
    public class Business
    {
        private static List<IElement> elements;
        static Business()
        {
            elements = new List<IElement>
            {
                new Customer("ABC"),
                new Customer("BCD"),
            new Customer("CDE"),

            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var customer in elements)
            {
                customer.Accept(visitor);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business(); 
            var visitor1 = new Markerter("aaa");
            business.PerformOperation(visitor1);
            Console.WriteLine();
            Console.Read();
        }
    }
}
