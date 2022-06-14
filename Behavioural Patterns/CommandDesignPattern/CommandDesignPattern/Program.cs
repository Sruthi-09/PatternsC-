using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public interface IRemote
    {
        void execute();
    }
    public class Car
       {
        public void Move()
        {
            Console.WriteLine("Car is Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Car is Stopped");
        }
    }
    public class MoveCar : IRemote
    {
        Car car;    

  public MoveCar(Car car) : base()
    {
        this.car = car;
    }

        public void execute()
        {
            car.Move();
            Console.WriteLine("Car moves with remote controls");
        }
    }
    public class StopCar : IRemote
    {

        Car car;


        public StopCar(Car car) : base()
        {
            this.car = car;

        }

        public void execute()
        {
            car.Stop();
            Console.WriteLine("Car stops with remote controls");
        }
    }
public class Process
{

    IRemote remote;

    public void setAction(IRemote remote)
    {
        this.remote = remote;
    }
    public void Controls()
    {
            remote.execute();
            Console.WriteLine("remote is operating the car");
    }
}
internal class Program
{
     static void Main(string[] args)
    {
        Car c = new Car();  
       Car a =new Car();

        Process p = new Process();

        p.setAction(new MoveCar(c));
        p.Controls();
            p.setAction(new StopCar(c));
            p.Controls();
        }
}
}
