using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface Laptop
    {
        void PlugInPenDrive();
        void PlugOutPenDrive();
        void EjectPenDrive();
        void NoEjectPendDrive();
        void OpenFolder();
        void NoFolder();
        void SelectFolder();
            void NoSelectFolder();
    }
    public class States : Laptop
    {
        public void PlugInPenDrive()
        {
            Console.WriteLine("PenDrive Inserted");
        }
        public void OpenFolder()
        {
            Console.WriteLine("Opened Folders that are available");
        }
        public void SelectFolder()
        {
            Console.WriteLine("Selecting the required folders from pendrive");
        }
        public void EjectPenDrive()
        { 
            Console.WriteLine("Afer work ejecting pendrive");
        }

        public void PlugOutPenDrive()
        {
            throw new NotImplementedException();
        }

        public void NoEjectPendDrive()
        {
            throw new NotImplementedException();
        }

        public void NoFolder()
        {
            throw new NotImplementedException();
        }

        public void NoSelectFolder()
        {
            throw new NotImplementedException();
        }
    }
    public class NoStates : Laptop
    {
        public void PlugNotPenDrive()
        {
            Console.WriteLine("PenDrive not Inserted");
        }
        public void NoOpenFolder()
        {
            Console.WriteLine("Cannot Open Folders as pendrive is ejected");
        }
        public void NoSelectFolder()
        {
            Console.WriteLine("No folders available");
        }
        public void NoEjectPenDrive()
        {
            Console.WriteLine("No penrive to eject");
        }

        public void PlugInPenDrive()
        {
            throw new NotImplementedException();
        }

        public void PlugOutPenDrive()
        {
            throw new NotImplementedException();
        }

        public void EjectPenDrive()
        {
            
        }

        public void NoEjectPendDrive()
        {
           
        }

        public void OpenFolder()
        {
            
        }

        public void NoFolder()
        {
        }

        public void SelectFolder()
        {
            
        }
    }
    public class Pendrive : Laptop
    {
        public Laptop laptop { get; set; }
        public Pendrive()
        {
            
            laptop = new NoStates();
            laptop = new States();

        }
        public void PlugInPenDrive()
        {
            laptop.PlugInPenDrive();

            if (laptop is NoStates)
            {
                laptop = new States();
                //Console.WriteLine(laptop.GetType().Name);
            }
        }
        public void EjectPenDrive()
        {
            laptop.EjectPenDrive();
            if (laptop is States)
            {
               laptop = new NoStates();
                //Console.WriteLine(laptop.GetType().Name);
            }
        }
        public void OpenFolder()
        {
            laptop.OpenFolder();    
        }
        public void SelectFolder()
        {
            laptop.SelectFolder(); 
        }

        public void PlugOutPenDrive()
        {
        }

        public void NoEjectPendDrive()
        {
         
        }

        public void NoFolder()
        {
            
        }

        public void NoSelectFolder()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pendrive pen= new Pendrive();
            Console.WriteLine("Laptop now is: "
                            + pen.laptop.GetType().Name);
            Console.WriteLine();
            pen.PlugInPenDrive();
            pen.SelectFolder();
            pen.OpenFolder();
            pen.EjectPenDrive();
            Console.WriteLine();
            Console.WriteLine("laptop now is: "
                            + pen.laptop.GetType().Name);
            Console.WriteLine();
            pen.PlugOutPenDrive();
            pen.NoSelectFolder();
            pen.NoFolder();
            pen.NoEjectPendDrive();

            //Console.WriteLine("");
            Console.Read();
        }
    }
}
