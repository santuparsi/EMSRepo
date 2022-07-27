using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IMobiel
    {
        void Discount();
        void M1();
    }
    interface ILaptop
    {
        void Discount();
        void M2();
    }
    //Multiple Inheritance
    class ECommerce : IMobiel, ILaptop
    {
        //explicit implement
        void IMobiel.Discount()
        {
            Console.WriteLine("IMobiel.Discount()");
        }
         void ILaptop.Discount()
        {
            Console.WriteLine("ILaptop.Discount()");
        }
        public void M1() { }
        public void M2() { }
    }
    class Demo5
    {
        static void Main()
        {
            IMobiel mobile = new ECommerce();
            mobile.Discount();
            mobile.M1();
            ILaptop laptop = new ECommerce();
            laptop.Discount();
            laptop.M2();
        }
    }
}
