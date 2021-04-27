using Tabuleiro;
namespace XadrezPecas
{
    public class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroJ tab) : base(cor,tab)
        {
        }

         private bool movimentosTorre(Posicao pos){
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;

        }
        public override bool[,] movimentosPossiveis()
        {
           bool[,]mat = new bool[Tab.Linhas, Tab.Colunas];

           Posicao pos = new Posicao(0,0);

           pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);

           while(Tab.posiVal(pos) && movimentosTorre(pos)){
               mat[pos.Linha,pos.Coluna] = true;
               if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor){
                  break;
               }
               pos.Linha = pos.Linha - 1;
           }

            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);

           while(Tab.posiVal(pos) && movimentosTorre(pos)){
               mat[pos.Linha,pos.Coluna] = true;
               if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor){
                  break;
               }
               pos.Linha = pos.Linha + 1;
           }
            pos.definirValores(Posicao.Linha , Posicao.Coluna + 1);

           while(Tab.posiVal(pos) && movimentosTorre(pos)){
               mat[pos.Linha,pos.Coluna] = true;
               if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor){
                  break;
               }
               pos.Coluna = pos.Coluna + 1;
           }
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);

           while(Tab.posiVal(pos) && movimentosTorre(pos)){
               mat[pos.Linha,pos.Coluna] = true;
               if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor){
                  break;
               }
               pos.Coluna = pos.Coluna - 1;
           }
          
           return mat;
        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♖ ";
            else
            return " ♜ ";
        }
    }
}