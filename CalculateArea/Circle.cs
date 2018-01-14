using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Circle : Area
    {

        public Circle()
        {

            SetHeight();

            area = 3.14*Math.Pow(height/2, 2);
        }
    }
}
