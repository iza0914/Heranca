namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Luna";

            Gato gato = new Gato();
            gato.Nome = "Godofredo";


            Console.WriteLine($"Nome do cachorro: {cachorro.Nome}");

            cachorro.comer();

            cachorro.Latir();


            Console.WriteLine();


            Console.WriteLine($"Nome do gato: {gato.Nome}");

            gato.comer();

            gato.Miar();
        }
    }
}
