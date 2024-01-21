using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_C_.Models
{
    public class Estacionamento
    {
        public Dictionary<string, string> VeiculosEstacionados { get; set; }
        
        public Estacionamento(double precoInicial, double precoHora) {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
            VeiculosEstacionados = new Dictionary<string, string>();
        }

        public double PrecoInicial { get; set; }

        public double PrecoHora { get; set; }

        public void CadastrarVeiculo(Veiculo veiculo) {
            if (VeiculosEstacionados.ContainsKey(veiculo.Placa)) {
                Console.WriteLine("Já existe um veículo estacionado com a placa informada.");
            } else {
                VeiculosEstacionados.Add(veiculo.Placa, veiculo.Modelo);
            }
        }

        public bool RemoverVeiculo(string placa) {
            if (VeiculosEstacionados.ContainsKey(placa)) {
                VeiculosEstacionados.Remove(placa);

                return true;
            } else {
                Console.WriteLine("\nNão existe nenhum veículo estacionado com a placa informada.");

                return false;
            }
        }

        public void ListarVeiculos() {
            Console.WriteLine("\nOs veículos estacionados são:\n");

            foreach(var veiculo in VeiculosEstacionados) {
                Console.WriteLine($"Placa: {veiculo.Key} - Modelo: {veiculo.Value}");
            }
        }

        public string CalcularPreco(int horasEstacionado) {
            double horas = Convert.ToDouble(horasEstacionado);
            double precoTotal = PrecoInicial + (PrecoHora * horas);
            string precoFormatado = precoTotal.ToString("F2");

            return precoFormatado;
        }
    }
}