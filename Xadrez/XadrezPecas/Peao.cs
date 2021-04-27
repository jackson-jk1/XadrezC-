using Tabuleiro;

namespace XadrezPecas
{
    public class Peao : Peca

    {
         public Peao(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
        }

          private bool movimentosPeao(Posicao pos){
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;

        }

        public override bool[,] movimentosPossiveis()
        {
           bool[,]mat = new bool[Tab.Linhas, Tab.Colunas];

           Posicao pos = new Posicao(0,0);

           pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);

           if(Tab.posiVal(pos) && movimentosPeao(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }
           return mat;
           
           }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♟";
            else
            return " ♙ ";
        }
    }
}