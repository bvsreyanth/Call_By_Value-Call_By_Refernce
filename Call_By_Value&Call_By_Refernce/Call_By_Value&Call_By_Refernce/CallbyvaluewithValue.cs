using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    internal class CallbyvaluewithValue
    {
        public void Callbyvalu()
        {
            int a = 15;
            int b = a;
            b = 30;
            Console.WriteLine(b);
        }
        public void Callbyvalu2()
        {
            int a = 15;
            Callbyvalu3(a);
            Console.WriteLine("This is outside the scope " + a);
        }

        public static void Callbyvalu3(int b)
        {
            b = 30;
            Console.WriteLine("This is inside the scope " + b);
        }
       
    }

}

