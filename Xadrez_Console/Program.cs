using System;
using tabuleiro;
using Xadrez;
using System.Collections.Generic;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();

                        Tela.ImprimirPartida(partida);
                        
                        Console.Write("\n\nDigite a posição de origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                        partida.ValidarPosicaoDeOrigem(origem);
                        bool[,] PosicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, PosicoesPossiveis);

                        Console.Write("\n\nDigite a posição de Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message+" Refaça o movimento...");
                        Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalido! Refaça o movimento...");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message+ " Refaça o movimento...");
            }

            Console.ReadLine();

        }
    }
}
