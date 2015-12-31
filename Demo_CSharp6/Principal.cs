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
            
            var distance = Distance(p1,p2);

            string str = $"La distancia entre el punto ({p1.X},{p1.Y}) y el punto ({p2.X}, {p2.Y}) es {distance}";

            WriteLine(str);

            ReadLine();
        }
    }
}
