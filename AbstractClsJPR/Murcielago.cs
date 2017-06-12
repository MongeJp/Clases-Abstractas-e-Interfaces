namespace AbstractClsJPR
{
    public class Murcielago : Mamifero
    {
        public Murcielago(string tamaño, string color, string habitat)
            : base(tamaño, color, habitat)
        {

        }
        public override string imprimirDatos()
        {
            return "Murcielago: \n" +
                "Tamaño: " + tamañoMam + "\n" + "Color: " + colorMam + "\n" + "Habitat: " + habitatMam + "\n";
        }

    }
}
