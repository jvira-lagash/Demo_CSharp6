using System;

namespace Demo_CSharp6
{
    static class StaticMethod
    {
        public static double Distance(Punto p1, Punto p2)
        {
            int x_cuadrado = ((p2.X - p1.X) * (p2.X - p1.X));
            int y_cuadrado = ((p2.Y - p1.Y) * (p2.Y - p1.Y));

            double d = Math.Sqrt( x_cuadrado + y_cuadrado );

            return d;
        }
                
        public static void ShowResult(Punto p1, Punto p2, double distance)
        {            
            Console.WriteLine(String.Format("La distancia entre el punto ({0},{1}) y el punto ({2}, {3}) es {4}", p1.X, p1.Y, p2.X, p2.Y, distance));
        }
    }
}