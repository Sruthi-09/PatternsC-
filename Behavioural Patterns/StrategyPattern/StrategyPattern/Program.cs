using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    public interface ISchool
    {
        void Details(String Info);
    }

    public class Resources
    {
        ISchool school;

        public void setSchool(ISchool school)
        {
            this.school = school;
        }

        public void connect(String name)
        {
            school.Details(name);
        }
    }

    public class Friends : ISchool
    {

        public void Details(string Info)
        {
            Console.WriteLine("knowing the school through a friend" + Info);
        }
    }
    public class Relatives : ISchool
    {

        public void Details(string Info)
        {
            Console.WriteLine("knowing the school through a relative" + Info);
        }
    }
    public class Search : ISchool
    {
        public void Details(string Info)
        {
            Console.WriteLine("knowing the school through a resource" + Info);
        }
    }

        public class Demo
        {
        static void Main(string[] args)
        {

        Resources resources = new Resources();
        resources.setSchool(new Friends());
        resources.connect("Ajay");
        resources.setSchool(new Relatives());
        resources.connect("Swathi");
        resources.setSchool(new Search());
        resources.connect("Web Browser");
        }
        }

}
