using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Music
    {
        private static Music instance = null;
        private string Instrument { get; set; }
        private string Type { get; set; }
        private Music()
        {

            Instrument = "Guitar";
            Type = "Acoustic";
        }
        private static object syncLock = new object();

        public static Music Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (Music.instance == null)
                        Music.instance = new Music();

                    return Music.instance;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine(Instrument);
            Console.WriteLine(Type);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Music.Instance.Display();

            Console.ReadKey();
        }
    }
}
