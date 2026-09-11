using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Guerreiro
    {
        class Guerreiro : Personagem

        {

            public int Defesa { get; set; }


            public Guerreiro(string nome, int pontosDeVida, int forcaDeAtaque, int defesa)

                : base(nome, pontosDeVida, forcaDeAtaque)

            {

                Defesa = defesa;

            }

        }
    }
}