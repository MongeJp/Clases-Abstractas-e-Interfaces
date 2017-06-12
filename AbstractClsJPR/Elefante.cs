namespace AbstractClsJPR
{
    public class Elefante : Mamifero
    {
        public Elefante(string tamaño, string color, string habitat)
            : base(tamaño, color, habitat)
        {

        }

        public override string imprimirDatos()
        {
            return "Elefante: \n" +
                "Tamaño: "+ tamañoMam + "\n" + "Color: " + colorMam + "\n" + "Habitat: " + habitatMam + "\n";
        }
    }
}
