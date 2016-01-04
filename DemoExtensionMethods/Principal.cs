using static System.Console;
using static DemoExtensionMethods.Extensores;

namespace DemoExtensionMethods
{
    class Principal
    {
        static void Main()
        {
            Persona p1 = new Persona();

            WriteLine(EsNombreCorrecto(p1));

            ReadLine();
        }
    }
}
