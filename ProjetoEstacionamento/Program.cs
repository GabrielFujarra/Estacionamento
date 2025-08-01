using estacionamentoRomano.Models;

Console.WriteLine("Bem-vindo ao estacionamento do Romano!");

Console.Write("Digite o preço inicial: ");
int precoInicial = int.Parse(Console.ReadLine());

Console.Write("Digite o preco por hora :");
int precoHora = int.Parse(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoHora);



while (true)
{
    Console.Clear();
    
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            es.CadastrarVeiculo();
            break;
        case 2:
            es.RemoverVeiculo();   
            break;
        case 3:
            es.ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Saindo do sistema...");
            return;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}
