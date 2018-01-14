using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program : IOAC
    {
        static void Main(string[] args)
        {
            char shape;
            Header("Willkommen zur Flächenberechnung. Bitte geben Sie die entsprechenden Werte ein, wenn Sie dazu aufgeordert werden.");
            Console.WriteLine("Von welchem Objekt soll die Fläche berechnet werden?\n\"c\" für Kreis\n\"r\" für Rechteck\n\"t\" für Dreieck");
            do
            {
                shape = Convert.ToChar(Console.ReadLine());
            } while (shape != 'c' && shape != 'r' && shape != 't');

            switch (shape)
            {
                case 'c':
                    Circle circle = new Circle();
                    circle.PrintArea("Kreises");
                    break;
                case 'r':
                    Rectangle rectangle = new Rectangle();
                    rectangle.PrintArea("Rechtecks");
                    break;
                case 't':
                    Triangle triangle = new Triangle();
                    triangle.PrintArea("Dreiecks");
                    break;
                default:
                    break;
            }
        }
    }
}
