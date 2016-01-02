using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace Demo_CSharp6
{
    static class StaticMethod
    {
        public static double Distance(Punto p1, Punto p2)
        {
            int x_cuadrado = ((p2.X - p1.X) * (p2.X - p1.X));
            int y_cuadrado = ((p2.Y - p1.Y) * (p2.Y - p1.Y));

            double d = Sqrt( x_cuadrado + y_cuadrado );

            return d;
        }

        //Expression bodies on method-like members
        //String interpolation
        public static void ShowResult(Punto p1, Punto p2, double distance) => WriteLine($"La distancia entre el punto ({p1.X},{p1.Y}) y el punto ({p2.X}, {p2.Y}) es {distance}");

        public static List<Punto> FillList()
        {
            List<Punto> list = new List<Punto>();

            list.Add(new Punto(1, 3));
            list.Add(new Punto(2, 4));
            list.Add(new Punto(4, 6));

            return list;
        }
    }
}