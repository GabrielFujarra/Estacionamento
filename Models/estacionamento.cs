using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamentoRomano.Models
{
    public class Carro
    {
        public string placa;
        public DateTime entrada;
        public DateTime saida;

        public Carro(string placa)
        {
            this.placa = placa;
            this.entrada = DateTime.Now;
        }
    }


    public class Estacionamento
    {
        public const int precoInicial = 10;
        public const int qtdVagas = 10;
        public const int minutosPermanencia = 1;
        public const double precoMinuto = 12;
        private List<Carro> carros;

        public Estacionamento()
        {
            this.carros = new List<Carro>();
        }

        public void EntrarVeiculo()
        {
            if (carros.Count >= qtdVagas)
            {
                Console.WriteLine("Sem vagas no momento");
            }
            else
            {
                Console.Write("Digite a placa do carro : ");
                var placa = Console.ReadLine();

                carros.Add(new Carro(placa));           

            }
            
         }

        public double CalcularPagamento(DateTime entrada)
        {
            Double tempoPermanencia = (DateTime.Now - entrada).TotalMinutes;
            
            if (tempoPermanencia<=minutosPermanencia)
            {
                return 0;
            }

            Console.WriteLine(string.Format("Tempo:{0}",tempoPermanencia));
            Console.WriteLine(string.Format("ValorMinuto:{0}",(precoMinuto/60)));
            Console.ReadKey();

            return Math.Round(precoInicial + (tempoPermanencia * (precoMinuto / 60)),2);
            

         }

        public void SaidaVeiculo()
        {

            Console.Write("Digite a placa do carro : ");
            var placa = Console.ReadLine();

            if (carros.Count == 0)
            {
                Console.WriteLine("Nao tem carros cadastrados !!");
                return;
            }

            for (int i = 0; i < carros.Count; i++)
            {
                var c = carros[i];
                if (c.placa == placa)
                {

                    var valor = CalcularPagamento(c.entrada);

                    if (valor == 0)
                    {
                        Console.WriteLine("liberado sem pagamento ");
                        
                    }
                    else
                    {
                        Console.WriteLine(string.Format("valor a pagar : {0} ", valor));
                    }
                    Console.ReadKey();
                    carros.RemoveAt(i);
                    return;

                   
                }
            }
        }
        

        public void ListarVeiculos()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");

            }
            else
            {
                Console.WriteLine("Veiculos cadastrados");

                foreach (var n in carros)
                {
                    Console.WriteLine(String.Format("Placa:{0} - Entrada:{1}", n.placa, n.entrada));
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}
