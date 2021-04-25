namespace Tabuleiro
{
    public class Peca
    {
        public Posicao Posicao {get;set;}

        public Cor Cor {get; protected set;}
        
        public int QuantMovimento {get; protected set;}

        public TabuleiroJ Tab {get;protected set;}
   

   public Peca(Posicao posicao, Cor cor, int quantMovimento, TabuleiroJ tab){
       Posicao = posicao;
       Cor = cor;
       QuantMovimento = quantMovimento;
       Tab = tab;
   }

   
   
   }
}