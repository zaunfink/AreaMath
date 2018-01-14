using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Rectangle : Area
    {

        public Rectangle()
        {

            SetHeight();
            SetWidth();

            area = height * width;
        }
    }
}
