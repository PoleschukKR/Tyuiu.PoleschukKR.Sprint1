using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PoleschukKR.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
           double xx = x1 - x2;
           double yy = y1 - y2;
           double x = Math.Pow(xx, 2);
           double y = Math.Pow(yy, 2);
           double sqr = Math.Sqrt(x + y);
           int res = Convert.ToInt32(sqr);
           
            return res;
        }
    }
}
