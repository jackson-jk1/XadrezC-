using Tabuleiro;
namespace XadrezPecas
{
    public class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroJ tab) : base(cor, tab)
        {
            
        }

        private bool movimentosRei(Posicao pos){
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;

        }
        public override bool[,] movimentosPossiveis()
        {
           bool[,]mat = new bool[Tab.Linhas, Tab.Colunas];

           Posicao pos = new Posicao(0,0);

           pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }
           pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }
           pos.definirValores(Posicao.Linha, Posicao.Coluna + 1 );

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna +1 );

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }  
             pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }  
             pos.definirValores(Posicao.Linha + 1, Posicao.Coluna -1 );

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }  
             pos.definirValores(Posicao.Linha, Posicao.Coluna -1 );

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           } 
           pos.definirValores(Posicao.Linha -1, Posicao.Coluna -1 );

           if(Tab.posiVal(pos) && movimentosRei(pos)){
               mat[pos.Linha,pos.Coluna] = true;
           }   
           return mat;

        }

        public override string ToString()
        {
            if (Cor == Cor.Branca)
            return " ♔ ";
            else
            return " ♚ ";
        }
    }
}