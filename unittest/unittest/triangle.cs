using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittest
{
    public class triangle
    {
       

        public bool metodfalse(double x, double y, double z)
        {
            if (x > 0 || y > 0 || z > 0)
            {
                if (x + y >= z && y + z >= x && z + x >= y) return true;
                else return false;
            }
            else {Console.WriteLine("error"); return false;
        }

        }

    }
}
