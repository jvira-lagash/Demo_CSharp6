using static System.Math;
using static System.Convert;

namespace Demo_CSharp6
{
    class Punto
    {
        #region Fields

        public int X { get; } = 1;
        public int Y { get; } = 1;

        #endregion
        
        #region Constructors

        public Punto() { }

        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion        
    }
}
