using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual1
{
    public class Virtual
        {
            public string name;
            public int age;
            private string v;

        public Virtual(string name, int age )
            {
            this.name = name;
            this.age = age;
            }
            public Virtual(string name)
            {
            this.name = name;
            this.age = 20;
        }

        public Virtual(string name, string v) : this(name)
        {
            this.v = v;
        }

        public virtual void Info()
            {
                Console.WriteLine("the person with name "+this.name+" is having "+age);
            }
        }

        public class Names : Virtual
        {
            public Names(string name,int age) : base(name,age)
            {

            }

        public Names(string name, string v) : base(name, v)
        {
        }

        public override void Info()
            {
                Console.WriteLine("the person with name " + this.name + " is having " + this.age);
            }

        }
        public class Another : Virtual
        {
        public Another(string name) : base(name) { }
        }
    public class Another1 : Virtual
    {
        public Another1(string name) : base(name) { }
    }
    class Program
        {
            static void Main(string[] args)
            {
            Names names = new Names("Sruthi", "21");
            names.Info();
                Another another1 = new Another("Abhi");
                another1.Info();
            Console.ReadKey();
            }
        }
    }