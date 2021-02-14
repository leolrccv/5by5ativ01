using System;


namespace JogoDaVelha2 {
    class Program {
        static void Main(string[] args) {
            string[,] matriz = new string[3, 3];
            int[,] mapa = new int[3, 3];

            //string Jogador1 = "", Jogador2 = "";
            // nomeJogador(ref Jogador1, ref Jogador2);
            mapaMatriz(mapa);
            Console.WriteLine("\n");
            posicao(matriz, "Leo", "Thiago");

            Console.ReadKey();

        }

        static void nomeJogador(ref string Jogador1, ref string Jogador2) {
            Console.Write("Digite o nome do primeiro Jogador: ");
            Jogador1 = Console.ReadLine();
            Console.Write("Digite o nome do segundo Jogador: ");
            Jogador2 = Console.ReadLine();
        } //Atualizar depois
        static void Imprimir_Jogo(string[,] matriz) {
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
            bool cond;

            for (int l = 0; l < 3; l++) {
                for (int c = 0; c < 3; c++) {

                    while (cont < 9) {
                        if (cont % 2 == 0) {
                            Console.Write($"\n=-=-=-=-Vez do {jogador1}-=-=-=-=-=");
                            xo = "X";
                            Console.Write($"\n\nDigite a posição desejada {jogador1}: ");
                        }
                        else {
                            Console.Write($"\n=-=-=-=-Vez do {jogador2}-=-=-=-=-=");
                            xo = "O";
                            Console.Write($"\n\nDigite a posição desejada {jogador2}: ");
                        }
                        pos = int.Parse(Console.ReadLine());

                        if (pos < 1 || pos > 9) {
                            Console.WriteLine("\nO NÚMERO DEVE SER DE 1 A 9!!");
                            continue;
                        }
                        switch (pos) {
                            case 1:
                                if (matriz[0, 0] == null) {
                                    matriz[0, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;

                            case 2:
                                if (matriz[0, 1]== null) {
                                    matriz[0, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 3:
                                if (matriz[0, 2] == null) {
                                    matriz[0, 2] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 4:
                                if (matriz[1, 0] == null) {
                                    matriz[1, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 5:
                                if (matriz[1, 1] == null) {
                                    matriz[1, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 6:
                                if (matriz[1, 2] == null) {
                                    matriz[1, 2] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 7:
                                if (matriz[2, 0] == null) {
                                    matriz[2, 0] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 8:
                                if (matriz[2, 1] == null) {
                                    matriz[2, 1] = xo;
                                }
                                else {
                                    Console.WriteLine("POSIÇÃO JÁ PREENCHIDA!!\n");
                                    continue;
                                }
                                break;
                            case 9:
                                if (matriz[2, 2] == null) {
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
                        Imprimir_Jogo(matriz);
                        Console.WriteLine();
                    }
                    cond = verificaCondicao(matriz, jogador1, jogador2);
                    if (cond == true) {
                        Console.WriteLine("\nJOGO ENCERRADO!!!");
                        return;
                    }
                }

            }
            Console.WriteLine("\nDEU VELHA!!!");

        }

        static bool verificaCondicao(string[,] matriz, string jogador1, string jogador2) {
            bool resp = false;
            if (matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2]) {
                if (matriz[0, 0] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2]) {
                if (matriz[1, 0] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2]) {
                if (matriz[2, 0] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0]) {
                if (matriz[0, 0] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1]) {
                if (matriz[0, 1] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2]) {
                if (matriz[0, 2] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2]) {
                if (matriz[0, 0] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
            else if (matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0]) {
                if (matriz[0, 2] == "X")
                    Console.WriteLine("{jogador1} GANHOU!!");
                else Console.WriteLine("{jogador2} GANHOU!!");
                resp = true;
            }
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

