using static System.Console;
using static Demo_CSharp6.StaticMethod;

namespace Demo_CSharp6
{
    class Principal
    {
        static void Main()
        {
            Punto p1 = new Punto();
            Punto p2 = new Punto(4,1);

            //Using static
            var distance = Distance(p1,p2);
            ShowResult(p1, p2, distance);

            ReadLine();
        }
    }
}
