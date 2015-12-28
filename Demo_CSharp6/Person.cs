namespace Demo_CSharp6
{
    class Person
   {
        //Before C# 6
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Person() { }
        

        //After C# 6

        ////public string FirstName { get; } = "Juan";
        ////public string LastName { get; } = "Vira";

        ////public string FullName { get; }



        ////public Person()
        ////{
        ////    //FullName = _firstName + " " + _lastName;
        ////    FullName = this.FirstName + " " + this.LastName;
        ////}
    }
}
