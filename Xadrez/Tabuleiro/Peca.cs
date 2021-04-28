namespace Tabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao {get;set;}

        public Cor Cor {get; protected set;}
        
        public int QuantMovimento {get; protected set;}

        public TabuleiroJ Tab {get;protected set;}
   

   public Peca(Cor cor,TabuleiroJ tab){
       Posicao = null;
       Cor = cor;
       QuantMovimento = 0;
       Tab = tab;
   }

    public void contaMov(){
      QuantMovimento++;
    }

    public bool existeMovimentosPossiveis(){
        bool[,]mat = movimentosPossiveis();
        for (int i = 0; i < Tab.Linhas; i++)
            for (int j = 0; j < Tab.Colunas; j++)
            {
                if(mat[i,j] == true){
                    return true;
                }
            }

        {
            
        }
        return false;
    }

    public bool podeMover(Posicao pos){
        return movimentosPossiveis()[pos.Linha,pos.Coluna];

    }
    public abstract bool [,] movimentosPossiveis();
    }
}