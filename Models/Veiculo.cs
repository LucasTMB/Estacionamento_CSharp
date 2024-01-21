using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_C_.Models
{
    public class Veiculo
    {
        public Veiculo(string placa, string modelo) {
            Placa = placa;
            Modelo = modelo;
        }

        public String Placa { get; set; } // fazer lógica da placa

        public String Modelo { get; set; }
    }
}