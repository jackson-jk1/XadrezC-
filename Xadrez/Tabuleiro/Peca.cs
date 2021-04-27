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

    public abstract bool [,] movimentosPossiveis();
    }
}