using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsExample
{
   public  class ConTest
    {
        //Constructor
        public ConTest()
        {
            Console.WriteLine("Object Created");
        }


        ~ ConTest()
        {
            Console.WriteLine("Object Destroyed");
        }

    }
}
