using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    public class College
    {
        public string name;
        public College(string name)
        {
            this.name = name;
        }
        public string getClgName()
        {
            return this.name;
        }
    }
    public class Student
    {
        public string name;
        public Student(String name)
        {
            this.name = name;
        }
        public String getStuName()
        {
            return this.name;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

            College clg = new College("Vignan University");
            Student stu = new Student("Sruthi");
            Console.WriteLine(stu.getStuName() + " is student of "+ clg.getClgName());
        }
    }
}