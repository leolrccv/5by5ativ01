using System;
namespace Exercicio01 {
    class Pessoa {
        public Veiculo veiculo;
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string DataDeNascimento { get; set; }
        public string DataCompra { get; set; }
        public override string ToString() {
            return ($"Nome: {Nome} Cpf: {Cpf} Endereço: {Endereco} Data de Nascimento: {DataDeNascimento}" +
                    $"\nData de compra: {DataCompra} Marca: {veiculo.Marca} Modelo: {veiculo.Modelo} Cor: {veiculo.Cor}" +
                    $"\nAno: {veiculo.Ano} Placa: {veiculo.Placa} Renavam: {veiculo.Renavam} Chassi: {veiculo.Chassi}");
        }
    }
}
