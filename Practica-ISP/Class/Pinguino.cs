using Practica_ISP.Interfaces;

namespace Practica_ISP.Class
{
    public class Pinguino : IAve, INadador
    {
        public void Cantar()
        {
            Console.WriteLine("El pingüino hace sonidos.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pingüino pone huevos.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pingüino nada.");
        }
    }
}
