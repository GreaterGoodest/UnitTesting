using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
        }

        public static int call_adder(Class2 example_class)
        {
            return example_class.adder(5);
        }

        public static int call_param_out(Class2 example_class)
        {
            example_class.param_out(out int x);
            return x;
        }
         
    }
}
