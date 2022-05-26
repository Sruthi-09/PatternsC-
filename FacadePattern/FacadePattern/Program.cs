using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Course
    {
        public void GetCourseDetails()
        {
            Console.WriteLine("Course Details");
        }
    }
    public class Register
    {
        public void EnrollCourse()
        {
            Console.WriteLine("Course Enrollment");
        }
    }
    public class Gather
    {
        public void CourseMaterial()
        {
            Console.WriteLine("Gathering Course Materials");
        }
    }
    public class Payment
    {
        public void CoursePayment()
        {
            Console.WriteLine("Course Payment");
        }
    }
    public class Process
    {
        public void StartProcess()
        {
           // Console.WriteLine("Place Order Started");
            Course course = new Course();
            course.GetCourseDetails();
            Register register = new Register();
            register.EnrollCourse();
            Gather gather = new Gather();
            gather.CourseMaterial();
            Payment payment = new Payment();
            payment.CoursePayment();

            Console.WriteLine("Process is done");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartProcess();
            Console.Read();
        }
    }
}
