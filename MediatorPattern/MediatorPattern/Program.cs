using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface Connect
    {
        void Message(string msg, User user);
        void IUser(User user);
    }
    public class Mediator : Connect
    {
        private List<User> usersList = new List<User>();
        public void IUser(User user)
        {
            usersList.Add(user);
        }
        public void Message(string message, User user)
        {
            foreach (var u in usersList)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }

    }
    public abstract class User
    {
        protected Mediator mediator;
        protected string name;
        public User(Mediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
    public class CUser : User
    {
        public CUser(Mediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.Message(message, this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator Mediator1 = new Mediator();
            User ABC = new CUser(Mediator1, "ABC");
            User BCD = new CUser(Mediator1, "BCD");
            User CDE = new CUser(Mediator1, "CDE");

        Mediator1.IUser(ABC);
            Mediator1.IUser(BCD);
            Mediator1.IUser(CDE);

            BCD.Send("Hello");
            Console.WriteLine();
            CDE.Send("Hi");
            Console.Read();
        }
    }
}
