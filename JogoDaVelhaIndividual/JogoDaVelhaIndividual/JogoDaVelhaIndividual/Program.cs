using System;

namespace JogoDaVelha {
    class Program {
        static void Main(string[] args) {
            string[,] matriz = new string[3, 3];
            int[,] mapa = new int[3, 3];
            string daltonico, resposta;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t++++++++++++++++ JOGO DA VELHA ++++++++++++++++\n\n");
            Console.ResetColor();

            daltonico = Acessibilidade();

            do {
                string jogador1 = "", jogador2 = "";
                Console.WriteLine();
                NomeJogador(ref jogador1, ref jogador2);
                Console.WriteLine();

                MapaMatriz(mapa);
                Posicao(matriz, jogador1, jogador2, daltonico, mapa);

                Console.Write("\nDESEJA JOGAR NOVAMENTE??[S/N]: ");
                while (true) {
                    try {
                        resposta = Console.ReadLine();
                        resposta = resposta.ToUpper();
                        if (resposta == "S" || resposta == "N") break;
                        Console.WriteLine("POR FAVOR DIGITE [S] PARA SIM OU [N] PARA NÃO!!");
                        Console.Write("Digite novamente: ");
                    }
                    catch (FormatException) {
                        Console.WriteLine("POR FAVOR DIGITE [S] PARA SIM OU [N] PARA NÃO!!");
                        Console.Write("Digite novamente: ");
                    }
                }
                Console.Clear();
                Array.Clear(matriz, 0, matriz.Length);
            } while (resposta == "S");
        }
        static void NomeJogador(ref string jogador1, ref string jogador2) {
            while (jogador1 == "") {
                Console.Write("Digite o nome do primeiro Jogador: ");
                jogador1 = Console.ReadLine();
                if (jogador1 == "") {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O NOME NÃO PODE SER VAZIO!!\n");
                    Console.ResetColor();
                }
            }

            while (jogador2 == "") {
                Console.Write("Digite o nome do segundo Jogador: ");
                jogador2 = Console.ReadLine();
                if (jogador2 == "") {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O NOME NÃO PODE SER VAZIO!!\n");
                    Console.ResetColor();
                }
            }
            Console.Clear();
        }
        static void ImprimirJogo(string[,] matriz, string dalt) {
            if (dalt == "N") {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int c = 0; c < matriz.GetLength(1); c++) {
                        Pad(4);
                        if (matriz[i, c] == "X") {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(matriz[i, c]);
                            Console.ResetColor();
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(matriz[i, c]);
                            Console.ResetColor();
                        }
                        if (c != matriz.GetLength(1) - 1) {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\t|");
                            Console.ResetColor();
                        }
                    }
                    if (i != matriz.GetLength(0) - 1) {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Trace(26);
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
            }
            else {
                for (int i = 0; i < matriz.GetLength(0); i++) {
                    for (int c = 0; c < matriz.GetLength(1); c++) {
                        Pad(4);
                        if (matriz[i, c] == "X") {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(matriz[i, c]);
                            Console.ResetColor();
                        }
                        else {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(matriz[i, c]);
                            Console.ResetColor();
                        }
                        if (c != matriz.GetLength(1) - 1) {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("\t|");
                            Console.ResetColor();
                        }
                    }
                    if (i != matriz.GetLength(0) - 1) {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Trace(26);
                        Console.ResetColor();
                        Console.WriteLine();

                    }
                }
            }
            Console.WriteLine();
        }
        static void MapaMatriz(int[,] mapa) {
            Console.WriteLine("\n ESCOLHA UM NÚMERO COM BASE NO MAPA A SEGUIR\n");
            int cont = 1;
            for (int i = 0; i < mapa.GetLength(0); i++) {
                Pad(8);
                for (int c = 0; c < mapa.GetLength(1); c++) {
                    mapa[i, c] = cont;
                    cont++;
                    Pad(1);
                    Console.Write("[" + mapa[i, c] + "]");
                    if (c != mapa.GetLength(1) - 1) {
                        Pad(1);
                        Console.Write("|");
                    }
                }
                if (i != mapa.GetLength(0) - 1) {
                    Console.WriteLine();
                    Pad(8);
                    Trace(17);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static void Posicao(string[,] matriz, string jogador1, string jogador2, string daltonico, int[,] mapa) {
            int pos, cont = 0, linha, situacao;
            string xo;

            while (cont < matriz.Length) {
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

                try {
                    pos = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException) {
                    Console.Clear();
                    ImprimirJogo(matriz, daltonico);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVOCÊ DEVE DIGITAR UM NÚMERO INTEIRO!!");
                    Console.ResetColor();
                    MapaMatriz(mapa);
                    continue;
                }
                catch (OverflowException) {
                    Console.Clear();
                    ImprimirJogo(matriz, daltonico);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVOCÊ DEVE DIGITAR UM NÚMERO ENTRE 1 E 9!!");
                    Console.ResetColor();
                    MapaMatriz(mapa);
                    continue;
                }

                if (pos < 1 || pos > 9) {
                    ImprimirJogo(matriz, daltonico);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO NÚMERO DEVE SER DE 1 A 9!!");
                    Console.ResetColor();
                    MapaMatriz(mapa);
                    continue;
                }

                linha = 0;
                if (pos >= 4 && pos < 7) {
                    pos -= 3;
                    linha = 1;
                }

                else if (pos >= 7) {
                    pos -= 6;
                    linha = 2;
                }

                if (matriz[linha, pos - 1] == null) {
                    matriz[linha, pos - 1] = xo;
                }
                else {
                    ImprimirJogo(matriz, daltonico);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPOSIÇÃO JÁ PREENCHIDA!!!");
                    Console.ResetColor();
                    MapaMatriz(mapa);
                    continue;
                }

                cont++;
                Console.WriteLine();
                ImprimirJogo(matriz, daltonico);
                Console.WriteLine();
                if (cont >= 5) {
                    situacao = VerificarSituacao(matriz);

                    if (situacao == 1) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\n{jogador1.ToUpper()} GANHOU!!");
                        Console.ResetColor();
                        return;
                    }
                    else if (situacao == 2) {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n{jogador2.ToUpper()} GANHOU!!");
                        Console.ResetColor();
                        return;
                    }
                    else if (cont == 9) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nDEU VELHA!!!");
                        Console.ResetColor();
                        return;
                    }
                }
                MapaMatriz(mapa);
            }
        }
        static int VerificarSituacao(string[,] matriz) {
            int cont;
            //linha
            for (int linha = 0; linha < 3; linha++) {
                cont = 0;
                for (int coluna = 0; coluna < 2; coluna++)
                    if (matriz[linha, coluna] == matriz[linha, coluna + 1] && matriz[linha, coluna] != null) {
                        cont++;
                        if (cont == 2)
                            if (matriz[linha, coluna] == "X") return 1;
                            else return 2;
                    }
            }
            //coluna
            for (int coluna = 0; coluna < 3; coluna++) {
                cont = 0;
                for (int linha = 0; linha < 2; linha++)
                    if (matriz[linha, coluna] == matriz[linha + 1, coluna] && matriz[linha, coluna] != null) {
                        cont++;
                        if (cont == 2)
                            if (matriz[linha, coluna] == "X") return 1;
                            else return 2;
                    }
            }
            //diagonal 1
            cont = 0;
            for (int coluna = 0, linha = 0; coluna < 2; coluna++, linha++)
                if (matriz[linha, coluna] == matriz[linha + 1, coluna + 1] && matriz[linha, coluna] != null) {
                    cont++;
                    if (cont == 2)
                        if (matriz[linha, coluna] == "X") return 1;
                        else return 2;
                }
            //diagonal 2
            cont = 0;
            for (int linha = 2, coluna = 0; coluna < 2; linha--, coluna++)
                if (matriz[linha, coluna] == matriz[linha - 1, coluna + 1] && matriz[linha, coluna] != null) {
                    cont++;
                    if (cont == 2)
                        if (matriz[linha, coluna] == "X") return 1;
                        else return 2;
                }
            return 0;
        }
        static string Acessibilidade() {
            string daltonico;
            Console.Write("Olá jogadores, desejam ligar o recurso de acessibilidade para daltônicos?[S/N]: ");
            while (true) {
                daltonico = Console.ReadLine();
                daltonico = daltonico.ToUpper();
                if (daltonico == "S" || daltonico == "N") break;
                Console.Write("POR FAVOR DIGITE [S] PARA SIM OU [N] PARA NÃO!!: ");
            }
            return daltonico;
        }
        static void Pad(int tam) {
            for (int i = 0; i < tam; i++) {
                Console.Write(" ");
            }
        }
        static void Trace(int qtd) {
            for (int i = 0; i < qtd; i++) {
                Console.Write("-");
            }
        }
    }
}