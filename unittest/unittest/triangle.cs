using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittest
{
    public class triangle
    {
        double x;
        double y;
        double z;
    
        public bool metodfalse(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0) { x=Math.Abs(x); y = Math.Abs(y); z= Math.Abs(z); };
            if (x + y >= z && y + z >= x && z + x >= y) return true;
            else return false;

        }

    }
}
