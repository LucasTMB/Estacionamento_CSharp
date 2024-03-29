﻿using System.Globalization;
using System.Text.RegularExpressions;
using Estacionamento_C_.Models;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
string inputPI = Console.ReadLine();
double precoInicial = double.Parse(inputPI, CultureInfo.InvariantCulture);

Console.Write("Digite o preço por hora: ");
string inputPH = Console.ReadLine();
double precoHora = double.Parse(inputPH, CultureInfo.InvariantCulture);

Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

bool encerrar = false;

while (encerrar != true) {
    Console.Clear();
    Console.WriteLine("Digite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar\n");

    string opcao = Console.ReadLine();
    
    switch (opcao) {
        case "1":
            Console.WriteLine("\nDigite a placa do veículo para estacionar (Ex: AAA-0000):");

            string placa = "";
            bool placaValida = false;

            while (placaValida != true) {
                placa = Console.ReadLine();
                
                placaValida = ValidarPlaca(placa);

                if (placaValida == false) {
                    Console.WriteLine("\nA placa não é válida. Por favor, digite novamente!\n");
                }
            }

            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();

            Veiculo veiculo = new Veiculo(placa, modelo);
            estacionamento.CadastrarVeiculo(veiculo);

            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            break;
        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaRemover = Console.ReadLine();

            bool removeu = estacionamento.RemoverVeiculo(placaRemover);

            if (removeu) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string inputHE = Console.ReadLine();
                int horasEstacionado = int.Parse(inputHE);

                Console.WriteLine($"\nO veículo {placaRemover} foi removido e o preço total foi de: R$ {estacionamento.CalcularPreco(horasEstacionado)}");
            } 

            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            break;
        case "3":
            estacionamento.ListarVeiculos();

            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            break;
        case "4":
            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\nO programa foi encerrado...");

            encerrar = true;

            break;
        default:
            Console.WriteLine("Insira uma opção válida!");

            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            break;
    }
}

static bool ValidarPlaca(string placa) {
    // Expressão regular para validar o formato da placa (3 letras - 4 dígitos)
    string padrao = @"^[A-Z]{3}-\d{4}$";


    // Verificação se a placa corresponde ao padrão
    return Regex.IsMatch(placa, padrao);
}