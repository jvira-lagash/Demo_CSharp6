namespace Demo_CSharp6
{
    class Punto
    {
        #region Initializers for auto-properties & Getter-only auto-properties

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
