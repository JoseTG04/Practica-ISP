using Practica_ISP.Interfaces;

namespace Practica_ISP.Class
{
    public class Pajaro : IAve, IVolador
    {
        public void Cantar()
        {
            Console.WriteLine("El pájaro canta.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pájaro pone huevos.");
        }

        public void Volar()
        {
            Console.WriteLine("El pájaro vuela.");
        }
    }
}
