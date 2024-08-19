using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string input = Console.ReadLine();
            veiculos.Add(input.ToUpper());
            Console.WriteLine($"Veículo de placa {input} cadastrado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string input = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Contains(input.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal qtdHorasEstacionado = Convert.ToDecimal(Console.ReadLine());
                decimal precoTotal = precoInicial + (qtdHorasEstacionado * precoPorHora);
                veiculos.Remove(input);
                Console.WriteLine($"O veículo {input} foi removido e o preço total foi de: R$ {precoTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculoItem in veiculos)
                {
                    Console.WriteLine($"Placa - {veiculoItem}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}