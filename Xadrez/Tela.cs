using System;
using Tabuleiro;


namespace Xadrez
{
    public class Tela
    {
        public static void ImprimirTabulheiro(TabuleiroJ tab){
           for (int i = 0; i< tab.Linhas; i++){
             for (int j = 0; j< tab.Colunas; j++){
                 if(tab.peca(i,j) == null){
                     Console.Write("- ");
           
                 }
                 else 
                Console.Write(tab.peca(i,j) + " ");
           }
           Console.WriteLine();
           }
        }
    }
}