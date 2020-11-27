using System;


namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }//A peça precisa de uma posição;
        public Cor cor { get; protected set; }// Ela pode ser alterada somente pela classe dela e pela SubClasses.
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }


    }
}
