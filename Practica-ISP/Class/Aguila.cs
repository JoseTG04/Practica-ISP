using Practica_ISP.Interfaces;

namespace Practica_ISP.Class
{
    public class Aguila : IAve, IVolador, ICazador
    {
        public void Cantar()
        {
            Console.WriteLine("El águila emite un chillido.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El águila pone huevos.");
        }

        public void Volar()
        {
            Console.WriteLine("El águila vuela.");
        }

        public void Cazar()
        {
            Console.WriteLine("El águila caza.");
        }
    }
}
