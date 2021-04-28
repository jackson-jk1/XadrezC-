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
                try{ 
                Console.Clear();
                Tela.imprimirPartida(partida);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                partida.validarPosicaoOrigem(origem);
                Console.Clear();
                bool[,] posicaoPosivel = partida.tab.peca(origem).movimentosPossiveis();
                Tela.ImprimirTabulheiro(partida.tab, posicaoPosivel);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
                partida.validarPosicaoDestino(origem,destino);
                partida.realizaJogada(origem,destino);
                }catch (TabuleiroExcepition e){
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
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
