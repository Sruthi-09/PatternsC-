using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Facebook
    {
        public string ProfileName { get; set; }
        public string Status { get; set; }

        public Facebook(string ProfileName, string Status)
        {
           this.ProfileName = ProfileName;  
            this.Status = Status;   
        }
        public string GetDetails()
        {
            return "Facebook \n Profile Name :"+ProfileName+"\n Status : "+Status;
        }
    }
    public class Memento
    {
        public Facebook facebook { get; set; }
        public Memento(Facebook facebook)
        {
            this.facebook= facebook ;
        }

        public string GetDetails()
        {
            return  facebook.GetDetails();
        }
    }
    public class Caretaker
    {
        private List<Memento> list = new List<Memento>();
        public void AddMemento(Memento m)
        {
            list.Add(m);
            Console.WriteLine("details added\n" + m.GetDetails());
        }
        public Memento GetMemento(int index)
        {
            return list[index];
        }
    }
    public class Originator
    {
        public Facebook facebook;

        public Memento CreateMemento()
        {
            return new Memento(facebook);
        }
        public void SetMemento(Memento memento)
        {
            facebook = memento.facebook;
        }
        public string GetDetails()
        {
            return facebook.GetDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.facebook = new Facebook("ABC", "Student");

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            originator.facebook = new Facebook("abc", "Employee");

            Console.WriteLine("\nCurrent : " + originator.GetDetails());
            Console.WriteLine("\nRestore");
            originator.facebook = caretaker.GetMemento(0).facebook;
            Console.WriteLine("\ncurrent : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
