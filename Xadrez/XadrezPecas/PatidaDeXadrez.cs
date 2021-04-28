using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez;

namespace XadrezPecas
{ 
    public class PatidaDeXadrez
    {
        public TabuleiroJ tab {get; private set;}
        public int Turno {get; private set;}
        public Cor JogadorAtual {get; private set;}

        public bool Terminada {get; private set;}
        private HashSet<Peca>pecas;
         private HashSet<Peca>capturadas;

      public PatidaDeXadrez(){
          tab = new TabuleiroJ(8,8);
          this.Turno = 1;
          this.JogadorAtual = Cor.Branca;
          pecas = new HashSet<Peca>();
          capturadas = new HashSet<Peca>();
          colocarPeca(); 
          Terminada = false;
    }
    public void movimenta(Posicao origem, Posicao destino){
          Peca p = tab.retirarPeca(origem);
          p.contaMov();
          Peca pecaCapturada =  tab.retirarPeca(destino);
          if(pecaCapturada != null){
            capturadas.Add(pecaCapturada);
             tab.retirarPeca(destino);
         }
        
          tab.colocarPeca(p, destino);

    }
    public void realizaJogada(Posicao origem, Posicao destino){
        movimenta(origem,destino);
        Turno++;
        mudaJogador();

    }
    private void mudaJogador(){
        if(JogadorAtual == Cor.Branca){
            this.JogadorAtual = Cor.Preta;
        }
        else
        {
            this.JogadorAtual = Cor.Branca;
        }
    }
    public void validarPosicaoOrigem(Posicao pos){
        if(tab.peca(pos) == null){
            throw new TabuleiroExcepition ("nao existe uma peça nessa posição");
        }
         if(JogadorAtual != tab.peca(pos).Cor){
             throw new TabuleiroExcepition ("Mova uma peça " + JogadorAtual); 
        }
        if(!tab.peca(pos).existeMovimentosPossiveis()){
             throw new TabuleiroExcepition ("Peça bloqueada"); 
        }
        
    }
     public void validarPosicaoDestino(Posicao origem, Posicao destino){
        if(!tab.peca(origem).podeMover(destino)){
            throw new TabuleiroExcepition ("Posição de destino invalida");
        }
     }

     public void colocarNovaPeca( Peca peca,int coluna, int linha){
         tab.colocarPeca(peca,new Posicao(coluna, linha));
         pecas.Add(peca);
     }
    private void colocarPeca(){
            for(int i = 0; i < 8; i++ ){
               colocarNovaPeca(new Peao(Cor.Preta, tab), 1,i);
               colocarNovaPeca(new Peao(Cor.Branca, tab),6,i);
              
            }


            colocarNovaPeca(new Rei(Cor.Branca, tab), 7,3);
            colocarNovaPeca(new Rei(Cor.Preta, tab),0,4);
            colocarNovaPeca(new Rainha(Cor.Branca, tab),7,4);
            colocarNovaPeca(new Rainha(Cor.Preta, tab),0,3);
            colocarNovaPeca(new Torre(Cor.Branca, tab), 7,0);
            colocarNovaPeca(new Torre(Cor.Branca, tab),7,7);
            colocarNovaPeca(new Torre(Cor.Preta, tab),0,0);
            colocarNovaPeca(new Torre(Cor.Preta, tab), 0,7);
            colocarNovaPeca(new Cavalo(Cor.Branca, tab), 7,1);
            colocarNovaPeca(new Cavalo(Cor.Branca, tab),7,6);
            colocarNovaPeca(new Cavalo(Cor.Preta, tab), 0,1);
            colocarNovaPeca(new Cavalo(Cor.Preta, tab), 0,6);
            colocarNovaPeca(new Bispo(Cor.Branca, tab), 7,2);
            colocarNovaPeca(new Bispo(Cor.Branca, tab),7,5);
            colocarNovaPeca(new Bispo(Cor.Preta, tab), 0,2);
            colocarNovaPeca(new Bispo(Cor.Preta, tab),0,5);
            
          
            
    }
     public HashSet<Peca> pecasCapturadas(Cor cor){
        HashSet<Peca> aux = new HashSet<Peca>();
        foreach (var peca in capturadas)
        {
            if(peca.Cor == cor)
            aux.Add(peca);
        }
        return aux;
     }
      public HashSet<Peca> pecasEmJogo(Cor cor){
        HashSet<Peca> aux = new HashSet<Peca>();
        foreach (var peca in capturadas)
        {
            if(peca.Cor == cor)
            aux.Add(peca);
        }
        return aux;
     }
    }
  
}