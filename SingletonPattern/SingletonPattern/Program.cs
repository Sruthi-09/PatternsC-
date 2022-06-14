using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Classroom
    {
        private static Classroom instance = null;
        private int StudentsCount{ get; set; }
        private Classroom()
        {
            StudentsCount = 40;
        }     
        public void Display()
        {
            Console.WriteLine("Classroom contains Students with count of " + StudentsCount);
        }
        public static Classroom getInstance()
        {
            if (instance == null)
            {
                instance = new Classroom();
            }
            return instance;

        }

    }   
    class Program
    {
        static void Main(string[] args)
        {
            Classroom.getInstance().Display();

            Console.ReadKey();
        }
    }
}
