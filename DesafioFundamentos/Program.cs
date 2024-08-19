using DesafioFundamentos.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = "";
bool exibirMenu = true;

//veiculos.CadastrarVeiculo("");

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Programa encerrado!");
            exibirMenu = false;
            break;
        default:
             Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}
Console.WriteLine("O programa se encerrou");