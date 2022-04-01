using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Class2
    {
        public virtual int adder(int a)
        {
            return a + 1;
        }

        public virtual void param_out(out int x) { 
            x = 5; 
        }
    }
}
