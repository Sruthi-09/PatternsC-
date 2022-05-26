using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Identity { get; set; }
        public Person(string name, string id, string identity)
        {
            Name = name;
            Id = id;
            Identity = identity;
        }
    }
    public interface INotice
    {
        void Inform();
    }
    public class Message : INotice
    {
        public void Inform()
        {
          //  Console.WriteLine("Inform Notice");
        } 
    }
    class Information : Message
    {
        private Message msg;
        private Person per;
        public Information(Person person)
        {
            per = person;
        }
        public void INotice()
        {
            if (per.Identity == "teacher" || per.Identity == "principal")
            {
                msg= new Message();
                Console.WriteLine("can access the notice");
                msg.Inform();
            }
            else
            {
                Console.WriteLine("can not access the notice");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("");
            Person s = new Person("Abhi", "ABC1", "student");
            Information info1 = new Information(s);
            info1.INotice();
            Console.WriteLine();
            Person ss = new Person("Harika", "451", "teacher");
            Information info2 = new Information(ss);
            info2.INotice();
            Console.WriteLine();
            Person sss = new Person("Ajay", "100", "principal");
            Information info3 = new Information(sss);
            info3.INotice();
            Console.WriteLine();
            Person ssss = new Person("Jake", "ABC15", "STUDENT");
            Information info4= new Information(ssss);
            info4.INotice();
            Console.WriteLine();
            Console.Read();
        }
    }
}
