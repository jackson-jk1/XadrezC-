namespace Tabuleiro
{
    public class TabuleiroJ
    {
       public int Linhas {get;set;}
       public int Colunas {get;set;} 

       private Peca[,] pecas;

    public Tabuleiro(int linhas, int colunas){
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.pecas = new Peca[linhas,colunas];
    }
    public Peca peca(int linha, int coluna){
      return pecas[linha,coluna];
   }
    }
}