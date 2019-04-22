using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 9;
            int num1 = 5;
            int num2 = 3;

            if (num1 > 5)
            {
                Console.WriteLine(num1 + " es mayor que: " + num2);
            }
            
            if(num1 < num2)
            {
                num1+=num2;
            }
        }
    }
}
