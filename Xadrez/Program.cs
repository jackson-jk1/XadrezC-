using System;
using System.Text;
using Tabuleiro;
using XadrezPecas;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
             try{
           PatidaDeXadrez partida = new PatidaDeXadrez();
            Console.OutputEncoding = Encoding.UTF8;
            while(!partida.Terminada){
                Console.Clear();
                Tela.ImprimirTabulheiro(partida.tab);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                Console.Clear();
                bool[,] posicaoPosivel = partida.tab.peca(origem).movimentosPossiveis();
                Tela.ImprimirTabulheiro(partida.tab, posicaoPosivel);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                partida.movimenta(origem,destino);
            }
          
             Console.ReadLine();
            }
            catch(TabuleiroExcepition e){
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
