using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Triangle : Area
    {

        public Triangle()
        {
            SetHeight();
            SetWidth();
            area = height * width / 2;
        }
    }
}
