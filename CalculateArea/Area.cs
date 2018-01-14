using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Area : IOAC
    {
        #region Attributes
        protected double height, width, area;
        #endregion

        public Area()
        {
        }

        public void SetHeight()
        {
            do
            {
                height = GetDbl("Bitte geben Sie die Höhe ein: "); ;
            } while (height <= 0);

        }

        public void SetWidth()
        {
            do
            {
                width = GetDbl("Bitte geben Sie die Breite ein: ");
            } while (width <= 0);
        }

        public void PrintArea(string type)
        {
            Console.WriteLine("Die Fläche des {0} beträgt {1}", type, area);
        }
    }
}
