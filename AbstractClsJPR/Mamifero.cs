namespace AbstractClsJPR
{
    public abstract class Mamifero
    {
        protected string tamañoMam;
        protected string colorMam;
        protected string habitatMam;

        public Mamifero(string tamaño, string color, string habitat)
        {
            tamañoMam = tamaño;
            colorMam = color;
            habitatMam = habitat;
        }

        public abstract string imprimirDatos();
    }
}
