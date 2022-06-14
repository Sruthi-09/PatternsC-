using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class Facebook
    {
        public void FacebookAcc()
        {
            GoToApp();
            GivePersonalDetails();
            CreateProfile();
            UpdateProfile();
            Console.WriteLine("Facebook profile is created");
        }
        protected abstract void GoToApp();
        protected abstract void GivePersonalDetails();
        protected abstract void CreateProfile();
        protected abstract void UpdateProfile();
    }
    public class PrivateAcc: Facebook
    {
        protected override void GoToApp()
        {
            Console.WriteLine("Step1:Go to App");
        }
        protected override void GivePersonalDetails()
        {
            Console.WriteLine("Step2:Add the personal details");
        }
        protected override void CreateProfile()
        {
            Console.WriteLine("Step3:Create Facebook profile");
        }
        protected override void UpdateProfile()
        {
            Console.WriteLine("Step4:Update Profile and set account as private");
        }
    }
    public class PublicAcc : Facebook
    {
        protected override void GoToApp()
        {
            Console.WriteLine("Step1:Go to App");
        }
        protected override void GivePersonalDetails()
        {
            Console.WriteLine("Step2:Add the personal details");
        }
        protected override void CreateProfile()
        {
            Console.WriteLine("Step3:Create Facebook profile");
        }
        protected override void UpdateProfile()
        {
            Console.WriteLine("Step4:Update Profile and set account as public");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("private account\n");
            Facebook fb= new PrivateAcc();
            // call the template method
            fb.FacebookAcc();
            Console.WriteLine();
            Console.WriteLine("public account\n");
            fb = new PublicAcc();
            // call the template method
            fb.FacebookAcc();
            Console.Read();
        }
    }
}
