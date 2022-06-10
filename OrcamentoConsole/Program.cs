using OrcamentoConsumer;
using System.Net.Http.Headers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrcamentoConsumer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Seja Bem Vindo!!! Qual o seu nome?");
            var name = Console.ReadLine();
            
            var currentDate = DateTime.Now;

            Console.WriteLine($"{Environment.NewLine}Olá, {name}, em {currentDate:d} às {currentDate:t}!");

          
            Console.WriteLine($"Qual desses produtos você deseja?");
            
            RestClient client = new RestClient();

            client.GetProdutosAsync().Wait();
            
           var nomeProduto = Console.ReadLine();

            
            Console.WriteLine("Digite a quantidade");

            
            var quantidadeProduto = Int32.Parse(Console.ReadLine());

            OrcamentoRequest orcamentoRequest = new();

            orcamentoRequest.NomeProduto = nomeProduto;
            orcamentoRequest.QuantidadeProduto = quantidadeProduto;

            client.ExecutarOrcamentoAsync(orcamentoRequest).Wait();

                        
            Console.Write($"{Environment.NewLine}Pressione Enter para Sair...");
            Console.ReadKey(true);
            Console.ReadLine();



        }
        
        }
    }



