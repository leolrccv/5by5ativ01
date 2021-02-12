using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            string[,] matriz = new string[3, 3];
            int[,] mapa = new int[3, 3];

            string Jogador1 = "", Jogador2 = "";
            // nomeJogador(ref Jogador1, ref Jogador2);
            mapaMatriz(mapa);
            Console.WriteLine();
            posicao(matriz, "Leo", "Thiago");

            Console.ReadKey();
        }

        static void nomeJogador(ref string Jogador1, ref string Jogador2) {
            Console.Write("Digite o nome do primeiro Jogador: ");
            Jogador1 = Console.ReadLine();
            Console.Write("Digite o nome do segundo Jogador: ");
            Jogador2 = Console.ReadLine();
        } //Atualizar depois
        static void imprimeMatriz(string[,] matriz) {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int c = 0; c < matriz.GetLength(1); c++) {
                    Console.Write(matriz[i, c]);
                    if (c != matriz.GetLength(1) - 1) {
                        Console.Write(" " + "\t|" + " ");
                    }
                }
                if (i != matriz.GetLength(0) - 1) {
                    Console.WriteLine("\n  ------------------------");

                }
            }
        } //Estrutura visual
        static void mapaMatriz(int[,] mapa) {
            Console.WriteLine("-------ESCOLHA UM NÚMERO COM BASE NO MAPA A SEGUIR-------\n");
            int cont = 1;
            for (int i = 0; i < mapa.GetLength(0); i++) {
                for (int c = 0; c < mapa.GetLength(1); c++) {
                    mapa[i, c] = cont;
                    cont++;
                    Console.Write("[" + mapa[i, c] + "]");
                    if (c != mapa.GetLength(1) - 1) {
                        Console.Write(" " + "\t|" + " ");
                    }
                }
                if (i != mapa.GetLength(0) - 1) {
                    Console.WriteLine("\n  ------------------------");

                }
            }
        }
        static void posicao(string[,] matriz, string jogador1, string jogador2) {
            int pos = 0, cont = 0;
            string xo = "";
            for (int l = 0; l < 3; l++) {
                for (int c = 0; c < 3; c++) {
                    verificaCondicao();
                    while (cont<9) {
                        if (cont % 2 == 0) {
                            Console.Write($"=-=-=-=-Vez do {jogador1}-=-=-=-=-=");
                            xo = "X";
                            Console.Write($"\n\nDigite a posição desejada {jogador1}: ");
                        }
                        else {
                            Console.Write($"=-=-=-=-Vez do {jogador2}-=-=-=-=-=");
                            xo = "O";
                            Console.Write($"\n\nDigite a posição desejada {jogador2}: ");
                        }
                        pos = int.Parse(Console.ReadLine());
                        switch (pos) {
                            case 1:
                                if (matriz[0, 0] != "X" && matriz[0, 0] != "O") {
                                    matriz[0, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;

                            case 2:
                                if (matriz[0, 1] != "X" && matriz[0, 1] != "O") {
                                    matriz[0, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 3:
                                if (matriz[0, 2] != "X" && matriz[0, 2] != "O") {
                                    matriz[0, 2] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 4:
                                if (matriz[1, 0] != "X" && matriz[1, 0] != "O") {
                                    matriz[1, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 5:
                                if (matriz[1, 1] != "X" && matriz[1, 1] != "O") {
                                    matriz[1, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 6:
                                if (matriz[1, 2] != "X" && matriz[1, 2] != "O") {
                                    matriz[1, 2] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 7:
                                if (matriz[2, 0] != "X" && matriz[2, 0] != "O") {
                                    matriz[2, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 8:
                                if (matriz[2, 1] != "X" && matriz[2, 1] != "O") {
                                    matriz[2, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 9:
                                if (matriz[2, 2] != "X" && matriz[2, 2] != "O") {
                                    matriz[2, 2] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                        }
                        cont++;
                        Console.WriteLine();
                        imprimeMatriz(matriz);
                        Console.WriteLine();
                    }

                }

            }
            Console.WriteLine("\nDEU VELHA!!!");

        }

        static bool verificaCondicao() {
            bool resp = false;

            return resp;
        }

        /* static int estaPreenchido(string[,] matriz, int pos) {
             int contador = 0;
             for (int l = 0; l < 3; l++) {
                 for (int c = 0; c < 3; c++) {
                     switch (pos) {
                         case 1:
                             matriz[0, 0] = pos[0];
                             break;

                         case 2:
                             matriz[0, 1] = xo;
                             break;
                         case 3:
                             matriz[0, 2] = xo;
                             break;
                         case 4:
                             matriz[1, 0] = xo;
                             break;
                         case 5:
                             matriz[1, 1] = xo;
                             break;
                         case 6:
                             matriz[1, 2] = xo;

                             break;
                         case 7:
                             matriz[2, 0] = xo;
                             break;
                         case 8:
                             matriz[2, 1] = xo;

                             break;
                         case 9:
                             matriz[2, 2] = xo;
                             break;
                     }

                 }

             }
             return contador;

         }*/

    }
}

