namespace DemoExtensionMethods
{
    static class Extensores
    {   
        public static bool EsNombreCorrecto(Persona persona) => string.IsNullOrEmpty(persona.Nombre) == false
                       && string.IsNullOrWhiteSpace(persona.Nombre);
    }
}
