namespace Heranca
{

    internal class Program
    {

        static void Main(string[] args)
        {
            public virtual void Atacar(Personagem alvo)

        {

            alvo.PontosDeVida -= ForcaDeAtaque;


            if (alvo.PontosDeVida < 0)

            {

                alvo.PontosDeVida = 0;

            }


            Console.WriteLine($"{Nome} causou {ForcaDeAtaque} de dano em {alvo.Nome}.");

            Console.WriteLine($"{alvo.Nome} ficou com {alvo.PontosDeVida} PV.");

        }


        public bool EstaVivo()
        {

            return PontosDeVida > 0;

        }

    }


}
