using Generic_types__Collections.Models;
using System;

namespace Generic_types__Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <Test> list = new MyList <Test>();
            list.Add(new Test { Age = 15, Name = "Ali" });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
        }
    }
}
