using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface b
    {
        string Work();
    }
    public class Student : b
    {
        public string Work()
        {
            return "Studying";
        }
    }
    public class Employee : b
    {
        public string Work()
        {
            return "Working on Project";
        }
    }

    public abstract class Organizer
    {
        public abstract b GetIOrganization(string OrgType);
        public static Organizer CreateOrganizer(string OrggType)
        {
            if (OrggType.Equals("Job"))
                return new JobOrgType();
            else
                return new SchoolOrgType();
        }
    }
    public class JobOrgType : Organizer
    {
        public override b GetIOrganization(string OrgType)
        {
            if (OrgType.Equals("Employee"))
            {
                return new Employee();
            }
            else
                return null;
        }
    }
    public class SchoolOrgType : Organizer
    {
        public override b GetIOrganization(string OrgType)
        {
            if (OrgType.Equals("Student"))
            {
                return new Student();
            }
                return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            b a = null;
            Organizer c = null;
            string working = null;
            c= Organizer.CreateOrganizer("School");
            Console.WriteLine("Organization type : " + c.GetType().Name);
            Console.WriteLine();
            a = c.GetIOrganization("Student");
            Console.WriteLine("Person:"   + a.GetType().Name);
            working= a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
            Console.WriteLine();
            c = Organizer.CreateOrganizer("Job");
            Console.WriteLine("Organization type : " + c.GetType().Name);
            Console.WriteLine();
            a = c.GetIOrganization("Employee");
            Console.WriteLine("Person:" + a.GetType().Name);
            working = a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
            Console.WriteLine();
            Console.Read();
        }
    }
}
