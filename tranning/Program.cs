using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tranning
{
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.brand();

            c.p();
            c.bikes(111);
            c.bikes("hero");
            c.name();
            Console.ReadKey();
        }
    }
    abstract class price
    {
        public abstract void p();
    }
    class Vhicle : price
    {
        public  Vhicle()
        {
            Console.WriteLine("CAR");
        }
       
        public override void p()
        {
            Console.WriteLine("1200000");
        }
    }
    class bike : Vhicle
    {
        public void bikes(Int32 a)
        {
            Console.WriteLine("ptice  "+a);
        }
        public void bikes(string b)
        {
            Console.WriteLine(b);
        }
    }
    class car : bike,Rc
    {
        public void brand()
        {
            Console.WriteLine("AUDI");
        }
        public void name()
        {
            Console.WriteLine("DIPU");
        }
    }
    interface Rc
    {
        void name();
    }

}
