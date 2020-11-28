﻿using System;


namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao Posicao { get; set; }//A peça precisa de uma posição;
        public Cor Cor { get; protected set; }// Ela pode ser alterada somente pela classe dela e pela SubClasses.
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
