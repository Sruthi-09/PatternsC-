using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IPhone
    {
        IPhone DecPhone();
    }
    public class Samsung : IPhone
    {
        private string PhoneName = "Samsung";
        public string PhoneModel { get; set; }
        public string PhoneCase { get; set; }
        public string PhoneScreen { get; set; }
        public string PhoneApps { get; set; }
        public string PhoneColor { get; set; }
        public string Feature { get; internal set; }

        public override string ToString()
        {
            return "Samsung \n\n PhoneName=" + PhoneName + "\n PhoneModel=" + PhoneModel + "\n PhoneCase=" + PhoneCase + "\n PhoneScreen="
                            + PhoneScreen + "\n PhoneApps=" + PhoneApps + "\n PhoneColor=" + PhoneColor ;
        }
        public IPhone DecPhone()
        {
            PhoneModel = "Z-Fold";
            PhoneCase = "Transparent";
            PhoneScreen = "Gorilla Glass";
            PhoneApps = "Health Apps";
            PhoneColor = "Rose Gold";
            return this;
        }
    }
    public abstract class PhoneSamsung : IPhone
    {
        protected IPhone phone;
        public PhoneSamsung(IPhone phone)
        {
            this.phone = phone;
        }
        public virtual IPhone DecPhone()
        {
            return phone.DecPhone();
        }
    }
    public class SPen : PhoneSamsung
    {
        public SPen(IPhone phone) : base(phone)
        {
        }
        public override IPhone DecPhone()
        {
            phone.DecPhone();
            AddFeature(phone);
            return phone;
        }
        public void AddFeature(IPhone phone)
        {
            if (phone is Samsung)
            {
                Samsung Samsung = (Samsung)phone;
                Samsung.Feature = "SPen";
                Console.WriteLine("SPen feature added");
            }
        }
    }
    public class QuadLens : PhoneSamsung
    {
        public QuadLens(IPhone phone) : base(phone)
        {
        }
        public override IPhone DecPhone()
        {
            phone.DecPhone();
            AddFeature(phone);
            return phone;
        }
        public void AddFeature(IPhone phone)
        {
            if (phone is Samsung)
            {
                Samsung Samsung = (Samsung)phone;
                Samsung.Feature = "Quad Lens";
                Console.WriteLine("QuadLens feature added " );
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPhone a = new Samsung();
            a.DecPhone();
            Console.WriteLine(a+ "\n");
            SPen b = new SPen(a);
            b.DecPhone();
            Console.WriteLine();
            IPhone c = new Samsung();
            QuadLens d = new QuadLens(c);
            d.DecPhone();
            Console.ReadKey();
        }
    }
}
