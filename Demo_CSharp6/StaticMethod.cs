using static System.Math;
using static System.Convert;

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
    }
}