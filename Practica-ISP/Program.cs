using Practica_ISP.Class;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demostración del Principio de Segregación de Interfaces (ISP)");

        Pajaro pajaro = new Pajaro();
        Console.WriteLine("\nComportamiento del Pájaro:");
        pajaro.Cantar();
        pajaro.PonerHuevos();
        pajaro.Volar();

        Pinguino pinguino = new Pinguino();
        Console.WriteLine("\nComportamiento del Pingüino:");
        pinguino.Cantar();
        pinguino.PonerHuevos();
        pinguino.Nadar();

        Aguila aguila = new Aguila();
        Console.WriteLine("\nComportamiento del Águila:");
        aguila.Cantar();
        aguila.PonerHuevos();
        aguila.Volar();
        aguila.Cazar();

        Console.ReadLine();
    }
}