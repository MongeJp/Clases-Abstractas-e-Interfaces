using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClsJPR
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefante miElefante = new Elefante("Grande", "Gris", "Sabanas");
            Murcielago miMurcielago = new Murcielago("Pequeño", "Gris", "Zonas Tropicales");
            Gato miGato = new Gato();

            

            Console.Title = "Clases Abstractas e Interfaces";
            Console.WriteLine("CLASES ABSTRACTAS: \n Los datos de los mamiferos \n \n");
            Console.WriteLine(miElefante.imprimirDatos());
            Console.WriteLine(miMurcielago.imprimirDatos());

            Console.WriteLine("INTERFACES:\n Sonido de gato: \n");
            Console.WriteLine(miGato.imprimirSonido() + "\n");

            Console.WriteLine("presione <enter> para terminar.");
            Console.ReadLine();
        }
    }

    //Ejemplo de Interface
    public interface IAnimal
    {
        string imprimirSonido();
    }

    class Gato : IAnimal
    {
        public string imprimirSonido()
        {
            return "Gato: *Miau*";
        }
    }

}
