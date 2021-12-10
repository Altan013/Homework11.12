using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading.Tasks;

namespace homework1
{
    public class Quvvet
    {
        public void ikininquvveti(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("0");
            }
            while (num % 2 == 0)
            {
                num = num / 2;
            }
            if (num == 1)
            {
                Console.WriteLine("2nin quvvetidir");
            }
            else
            {
                Console.WriteLine("2nin quvveti deyil");
            }

        }
    }

}
