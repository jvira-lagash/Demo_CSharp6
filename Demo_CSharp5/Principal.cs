using System;
using System.Collections.Generic;

namespace Demo_CSharp6
{
    class Principal
    {
        static void Main()
        {
            #region Initializers for auto-properties & Static Class & String interpolation

            Punto p1 = new Punto();
            Punto p2 = new Punto(4, 1);

            p1.X = 1;
            p1.Y = 1;

            var distance = StaticMethod.Distance(p1, p2);
            StaticMethod.ShowResult(p1, p2, distance);

            #endregion

            #region Null-conditional operators & nameof expressions

            List<Punto> list = null;

            if (list != null)
                Console.WriteLine("La colección de puntos, tiene {0}", list.Count);
            else
                Console.WriteLine("La colección de puntos, tiene 0"); //Console.WriteLine("La colección de puntos, tiene {0}", list.Count); Arroja NULL

            list = StaticMethod.FillList();

            if (list != null)
                Console.WriteLine("La colección de puntos, tiene {0}", list.Count);
            else
                Console.WriteLine("La colección de puntos, tiene 0"); //Console.WriteLine("La colección de puntos, tiene {0}", list.Count); Arroja NULL

            #endregion

            Console.ReadLine();
        }
    }
}
