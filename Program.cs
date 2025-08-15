using estacionamentoRomano.Models;

Estacionamento es = new Estacionamento();

Console.Clear();
Console.WriteLine("Bem-vindo ao estacionamento do Mr.Romano!");

while (true)
{

    Console.WriteLine("1 - Entrada de Veículo");
    Console.WriteLine("2 - Saida Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            es.EntrarVeiculo();
            break;
        case 2:
            es.SaidaVeiculo();
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

    Console.Clear();
}
