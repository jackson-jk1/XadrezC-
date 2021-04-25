namespace Tabuleiro
{
    public class TabuleiroJ
    {
       public int Linhas {get;set;}
       public int Colunas {get;set;} 

       private Peca[,] pecas;

    public TabuleiroJ(int linhas, int colunas){
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.pecas = new Peca[linhas,colunas];
    }
    public Peca peca(int linha, int coluna){
      return pecas[linha,coluna];
   }

   public void colocarPeca(Peca p, Posicao pos){
    pecas[pos.Linha,pos.Coluna] = p;
    p.Posicao = pos;
   }
    }
}