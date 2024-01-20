using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_C_.Models
{
    public class Estacionamento
    {
        public Dictionary<string, string> VeiculosEstacionados { get; set; }
        public Estacionamento(decimal precoInicial, decimal precoHora) {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
            VeiculosEstacionados = new Dictionary<string, string>();
        }

        public decimal PrecoInicial { get; set; }

        public decimal PrecoHora { get; set; }

        public void CadastrarVeiculo(Veiculo veiculo) {
            VeiculosEstacionados.Add(veiculo.Placa, veiculo.Modelo);
        }

        public void RemoverVeiculo(Veiculo veiculo) {
            VeiculosEstacionados.Remove(veiculo.Placa);
        }

        public void ListarVeiculos() {
            Console.WriteLine("\nOs veículos estacionados são:\n");

            foreach(var veiculo in VeiculosEstacionados) {
                Console.WriteLine($"Placa: {veiculo.Key} - Modelo: {veiculo.Value}");
            }
        }
    }
}