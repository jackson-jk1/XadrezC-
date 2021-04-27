using System;

namespace Tabuleiro
{
    public class TabuleiroJ
    {
       public int Linhas {get;set;}
       public int Colunas {get;set;} 

       private Peca[,] pecas = new Peca[8,8];

    public TabuleiroJ(int linhas, int colunas){
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.pecas = new Peca[linhas,colunas];
    }
    public Peca peca(int linha, int coluna){
      return pecas[linha,coluna];
   }

    public Peca peca(Posicao pos){
      return pecas[pos.Linha,pos.Coluna];
   }
   
   public void colocarPeca(Peca p, Posicao pos){
       if (existePeca(pos)){
           throw new TabuleiroExcepition("Ja existe uma peça nessa posição");
       }
    pecas[pos.Linha,pos.Coluna] = p;
    p.Posicao = pos;
   }

    public Peca retirarPeca(Posicao pos){
        if(peca(pos) == null){
           return null;
        }

        Peca aux = peca(pos);
        aux.Posicao = null;
        pecas[pos.Linha,pos.Coluna] = null;
        return aux;

    }
    public bool existePeca(Posicao pos){
        validaPosicao(pos);
        return peca(pos) !=null;

    }
   public bool posiVal(Posicao pos){
     if(pos.Linha <0 ||pos.Linha > 7|| pos.Coluna < 0|| pos.Coluna > 7){
         return false;
     }
     return true;
   }
   public void validaPosicao (Posicao pos){
       if(!posiVal(pos)){
           throw new TabuleiroExcepition("Posicao inválida");
       }
   }
    }
}