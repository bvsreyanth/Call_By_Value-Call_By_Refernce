using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    internal class CallByvalueWithRefernce
    {
        public class Students
        {
            public int Id;
            public string? Name;

        }
        public void Callbyvalu()
        {
            Students obj = new Students();
            obj.Id = 1;
            Students obj1 = obj;
            obj1.Id = 2;
            Console.WriteLine(obj.Id);
            Console.WriteLine(obj1.Id);

        }
        
    }

}
