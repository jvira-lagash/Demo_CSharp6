using static System.Console;
using static Demo_CSharp6.StaticMethod;
using System.Collections.Generic;
using static System.Linq.Enumerable;


namespace Demo_CSharp6
{
    class Principal
    {
        static void Main()
        {
            #region Initializers for auto-properties & Static Class & String interpolation

            ////Punto p1 = new Punto();
            ////Punto p2 = new Punto(4, 1);

            //////Using static
            ////var distance = Distance(p1, p2);
            ////ShowResult(p1, p2, distance);

            #endregion

            #region Null-conditional operators & nameof expressions

            ////List<Punto> list = null;

            ////WriteLine($"La colección de puntos, de tipo {nameof(list)},tiene {list?.Count ?? -1}");

            ////list = FillList();
                        
            ////WriteLine($"La colección de puntos, de tipo {nameof(list)},tiene {list?.Count ?? -1}");

            #endregion
            
            ReadLine();
        }
    }
}
