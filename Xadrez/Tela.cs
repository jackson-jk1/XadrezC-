using System;
using Tabuleiro;
using XadrezPecas;

namespace Xadrez
{
    public class Tela
    {
        public static void ImprimirTabulheiro(TabuleiroJ tab){
            int k = 0;
             for (int i = 0; i< tab.Linhas; i++,k++){
                    
              Console.BackgroundColor = ConsoleColor.Red;
              Console.Write( 8 - i + " ");
             for (int j = 0; j< tab.Colunas; j++,k++){
                 imprimirPeca(tab.peca(i,j),k);
            }
              Console.WriteLine();
           }
            k=0;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   A  B  C  D  E  F  G  H ");
        }
        public static void ImprimirTabulheiro(TabuleiroJ tab, bool[,] casas){
            int k = 0;
             for (int i = 0; i< tab.Linhas; i++,k++){
                    
              Console.BackgroundColor = ConsoleColor.Red;
              Console.Write(8 - i + " "); 
             for (int j = 0; j< tab.Colunas; j++,k++){
                    imprimirPeca(tab.peca(i,j),k,casas[i,j]);
            }
              
              Console.BackgroundColor = ConsoleColor.Black; 
              Console.WriteLine();
           }
            k=0;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("   A  B  C  D  E  F  G  H ");
        }
 
          public static void imprimirPeca(Peca peca , int k){
            if(peca == null){
                   if (k % 2 == 0)
                     { 
                         Console.BackgroundColor = ConsoleColor.DarkYellow;
                     }
                     else{
                        Console.BackgroundColor = ConsoleColor.Yellow;
                         }
                   Console.Write("   ");
                 }
                 else
                  { 
                    if (k % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    } 
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    if(peca.Cor == Cor.Branca)
                    {
                         Console.Write(peca);
                    }
                    else
                    {
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(peca);
                        Console.ForegroundColor = aux;
                    }
              
                 }   
        }

              public static void imprimirPeca(Peca peca , int k,bool casa){
            if(peca == null){
                   if (k % 2 == 0)
                     { 

                         Console.BackgroundColor = ConsoleColor.DarkYellow;
                     }
                     else{
                        Console.BackgroundColor = ConsoleColor.Yellow;
                         }
                         if(casa == true){
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write("   ");
                         }
                         else{
                              Console.Write("   ");
                         }
                  
                 }
                 else
                  { 
                    if (k % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    } 
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    if(peca.Cor == Cor.Branca)
                    {
                         Console.Write(peca);
                    }
                    else
                    {
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(peca);
                        Console.ForegroundColor = aux;
                    }
              
                 }   
        }
        public static PosicaoXadrez lerPosicaoXadrez(){
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1]+"");
            return new PosicaoXadrez(coluna, linha);

        }
    }
}