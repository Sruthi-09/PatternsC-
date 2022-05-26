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
    public class Teacher: b
    {
        public string Work()
        {
            return "Teaching";
        }
    }
    public class Principal : b
    {
        public string Work()
        {
            return "Organizing";
        }
    }
    public class Employee : b
    {
        public string Work()
        {
            return "Working on Project";
        }
    }
    public class TeamLead : b
    {
        public string Work()
        {
            return "Monitoring";
        }
    }
    public class Manager : b
    {
        public string Work()
        {
            return "Managing";
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
            else if (OrgType.Equals("TeamLead"))
            {
                return new TeamLead();
            }
            else if (OrgType.Equals("Manager"))
            {
                return new Manager();
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
            else if (OrgType.Equals("Teacher"))
            {
                return new Teacher();
            }
            else if(OrgType.Equals("Principal"))
            {
                return new Principal();
            }  
            else
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
            a = c.GetIOrganization("Teacher");
            Console.WriteLine("Person:" + a.GetType().Name);
            working = a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
            Console.WriteLine();
            a = c.GetIOrganization("Principal");
            Console.WriteLine("Person:" + a.GetType().Name);
            working = a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
            Console.WriteLine();
            c = Organizer.CreateOrganizer("Job");
            Console.WriteLine("Organization type : " + c.GetType().Name);
            Console.WriteLine();
            a = c.GetIOrganization("Manager");
            Console.WriteLine("Person:" + a.GetType().Name);
            working = a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
            Console.WriteLine();
           
            a = c.GetIOrganization("TeamLead");
            Console.WriteLine("Person:" + a.GetType().Name);
            working = a.Work();
            Console.WriteLine(a.GetType().Name + " Work: " + working);
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
