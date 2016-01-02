using System;

namespace Demo_CSharp6
{
    class Principal
    {
        static void Main()
        {            
            Punto p1 = new Punto();
            Punto p2 = new Punto(4,1);

            p1.X = 1;
            p1.Y = 1;

            var distance = StaticMethod.Distance(p1,p2);
            StaticMethod.ShowResult(p1, p2, distance);

            Console.ReadLine();
        }
    }
}
