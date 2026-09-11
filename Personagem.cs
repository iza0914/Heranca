using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Personagem

    {

        public string Nome { get; set; }

        public int PontosDeVida { get; set; }

        public int ForcaDeAtaque { get; set; }


        public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)

        {

            Nome = nome;

            PontosDeVida = pontosDeVida;

            ForcaDeAtaque = forcaDeAtaque;

        }

    }
}