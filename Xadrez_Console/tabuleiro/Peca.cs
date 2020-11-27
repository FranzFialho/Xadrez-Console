using System;


namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }//A peça presica de uma posição;
        public Cor cor { get; protected set; }// Ela pode ser alterada somente pela classe dela e pela SubClasses.
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

       
    }
}
