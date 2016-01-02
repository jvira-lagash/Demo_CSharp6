namespace Demo_CSharp6
{
    class Punto
    {
        #region Fields
                
        public int X { get; set; }
        public int Y { get; set; }

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
