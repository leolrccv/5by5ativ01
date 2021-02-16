using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            int op = 0;
            Pessoa pessoa = new Pessoa();
            pessoa.veiculo = new Veiculo();

            while (op != 3) {
                Console.Write("\n[1]Informar todos os dados\n[2]Imprimir os dados\n[3]Finalizar\n\nESCOLHA UMA OPÇÃO: ");
                try {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception) {
                    Console.WriteLine("O NÚMERO DEVE SER DE INTEIRO!!");
                    continue;
                }
                if (op < 1 && op > 3) {
                    Console.WriteLine("O NÚMERO DEVE SER DE 1 A 9");
                    continue;
                }
                Console.WriteLine();
                switch (op) {
                    case 1:
                        Console.Write("Nome: ");
                        pessoa.Nome = Console.ReadLine();

                        Console.Write("CPF: ");
                        pessoa.Cpf = Console.ReadLine();

                        Console.Write("Endereço: ");
                        pessoa.Endereco = Console.ReadLine();

                        Console.Write("Data de Nascimento: ");
                        pessoa.DataDeNascimento = Console.ReadLine();

                        Console.Write("Data de Compra: ");
                        pessoa.DataCompra = Console.ReadLine();

                        Console.Write("Marca: ");
                        pessoa.veiculo.Marca = Console.ReadLine();

                        Console.Write("Modelo: ");
                        pessoa.veiculo.Modelo = Console.ReadLine();

                        Console.Write("Cor: ");
                        pessoa.veiculo.Cor = Console.ReadLine();

                        while (true) {
                            try {
                                Console.Write("Ano: ");
                                pessoa.veiculo.Ano = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception) {
                                Console.WriteLine("VOCÊ DEVE DIGITAR UM NÚMERO INTEIRO!!\n");
                            }
                        }

                        Console.Write("Placa: ");
                        pessoa.veiculo.Placa = Console.ReadLine();

                        Console.Write("Chassi: ");
                        pessoa.veiculo.Chassi = Console.ReadLine();

                        while (true) {
                            try {
                                Console.Write("Renavam: ");
                                pessoa.veiculo.Renavam = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception) {
                                Console.WriteLine("VOCÊ DEVE DIGITAR UM NÚMERO INTEIRO!!\n");
                            }
                        }
                        break;

                    case 2:
                        if (pessoa.Nome == null) {
                            Console.WriteLine("Nenhum dado inserido!!");
                            break;
                        }
                        Console.WriteLine(pessoa);
                        break;

                    case 3:
                        Console.WriteLine("\nFinalizando");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
