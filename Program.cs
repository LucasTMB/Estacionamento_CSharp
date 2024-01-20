using Estacionamento_C_.Models;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
string inputPI = Console.ReadLine();
decimal precoInicial = decimal.Parse(inputPI);

Console.Write("Digite o preço por hora: ");
string inputPH = Console.ReadLine();
decimal precoHora = decimal.Parse(inputPH);

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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();

            Veiculo veiculo = new Veiculo(placa, modelo);
            estacionamento.CadastrarVeiculo(veiculo);

            Console.WriteLine("\nDigite uma tecla para continuar");
            Console.ReadKey();

            break;
        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");

            // adicionar código

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