using System;
using System.Text;
using Tabuleiro;
using Xadrez;

namespace XadrezPecas
{ 
    public class PatidaDeXadrez
    {
        public TabuleiroJ tab {get;set;}
        private int Turno;
        private Cor JogadorAtual;

        public bool Terminada {get;set;}

      public PatidaDeXadrez(){
          tab = new TabuleiroJ(8,8);
          this.Turno = 1;
          this.JogadorAtual = Cor.Branca;
          colocarPeca(); 
          Terminada = false;
    }
    public void movimenta(Posicao origem, Posicao destino){
          Peca p = tab.retirarPeca(origem);
          p.contaMov();
         Peca pecaCapturada =  tab.retirarPeca(destino);
         tab.colocarPeca(p, destino);

    }

    private void colocarPeca(){
            for(int i = 0; i < 8; i++ ){
               tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1,i));
               tab.colocarPeca(new Peao(Cor.Branca, tab),new Posicao(6,i));
            }
            tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(7,3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0,4));
            tab.colocarPeca(new Rainha(Cor.Branca, tab), new Posicao(7,4));
            tab.colocarPeca(new Rainha(Cor.Preta, tab), new Posicao(0,3));
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(7,0));
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(7,7));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0,0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0,7));
            tab.colocarPeca(new Cavalo(Cor.Branca, tab), new Posicao(7,1));
            tab.colocarPeca(new Cavalo(Cor.Branca, tab), new Posicao(7,6));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0,1));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0,6));
            tab.colocarPeca(new Bispo(Cor.Branca, tab), new Posicao(7,2));
            tab.colocarPeca(new Bispo(Cor.Branca, tab), new Posicao(7,5));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0,2));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0,5));
            
          
            
    }
    }
   

}