using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Mago : Personagem

    {

        public int PontosDeMagia { get; set; }


        public Mago(string nome, int pontosDeVida, int forcaDeAtaque, int pontosDeMagia)

            : base(nome, pontosDeVida, forcaDeAtaque)

        {

            PontosDeMagia = pontosDeMagia;

        }


    }
