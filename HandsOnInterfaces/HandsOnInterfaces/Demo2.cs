﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IA
    {
        void M1();
    }
    interface IB:IA
    {
        void M2();
    }
    interface IC:IB
    {
        void M3();
    }
    class Demo2 : IC
    {
        public void M1()
        {
           
        }

        public void M2()
        {
           
        }

        public void M3()
        {
          
        }
    }
}
