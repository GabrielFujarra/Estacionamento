using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamentoRomano.Models
{
    public class Estacionamento
    {
        private int precoInicial;
        private int precoHora;
        private List<string> Lista = new List<string>();

        public Estacionamento(int precoInicial, int precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void CadastrarVeiculo()
        {

            Console.WriteLine("Digite a placa do veiculo que deseja cadastrar :");
            string placa = Console.ReadLine();
            Lista.Add(placa);
            Console.WriteLine("Veículo {0} cadastrado com sucesso!", placa);
            Console.WriteLine("Tota de carros cadastrasdos: {0}", Lista.Count);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
                
            
        }   
        public int CalcularPreco(int horas)
        {
            return precoInicial + precoHora * horas;
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo que deseja remover :");
            string placaRemover = Console.ReadLine();

            if (Lista.Contains(placaRemover))
            {
                Console.Write("Quantas horas o veiculo ficou estacionado : ");
                int horas = int.Parse(Console.ReadLine());

                Lista.Remove(placaRemover);

                Console.WriteLine("O preco total a pagar é {0} reais", CalcularPreco(horas));
                Console.WriteLine("Veículo {0} removido com sucesso!", placaRemover);
            }
           Console.WriteLine("Pressione qualquer tecla para continuar...");
           Console.ReadKey();

        }

        public void ListarVeiculos()
        {
            if (Lista.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");

            }
            else
            {
                Console.WriteLine("Veiculos cadastrados");

                foreach (var n in Lista)
                {
                    Console.WriteLine(n);
                }
            }
           Console.WriteLine("Pressione qualquer tecla para continuar...");
           Console.ReadKey();
        }
        
        

        
    }
}