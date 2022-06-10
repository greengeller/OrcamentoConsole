using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoConsumer
{
    public class RestClient : IRestClient
    {
               
        HttpClient client = new HttpClient();
       

        public async Task ExecutarOrcamentoAsync(OrcamentoRequest orcamentoRequest)
        {
            var nomeProduto = orcamentoRequest.NomeProduto;
            var quantidadeProduto = orcamentoRequest.QuantidadeProduto;

            
            HttpResponseMessage response = await client.GetAsync($"/Orcamento?NomeProduto={nomeProduto}&Quantidade={quantidadeProduto}");
                if (response.IsSuccessStatusCode)
                {
                    OrcamentoResponse orcamento = await response.Content.ReadAsAsync<OrcamentoResponse>();

                    Console.WriteLine($"Segue seu Orcamento: " +
                        $"ID do Orcamento: {orcamento.Id} {Environment.NewLine}" +
                        $"Nome do Produto: {orcamento.Produtos.Nome} {Environment.NewLine}" +
                        $"Valor do Produto: R${orcamento.Produtos.Valor} {Environment.NewLine}" +
                        $"Quantidade: {orcamento.Quantidade} {Environment.NewLine}" +
                        $"Valor Total: R${orcamento.ValorTotal}{Environment.NewLine}" +
                        $"Nome do Vendedor: {orcamento.Vendedor.Nome}");
                }
        }
        public async Task<Produtos> GetProdutosAsync()
        {
            client.BaseAddress = new Uri("https://localhost:7020");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("/Produto");
                if (response.IsSuccessStatusCode)
                {
                    List<Produtos> listaProduto = await response.Content.ReadAsAsync<List<Produtos>>();

                foreach (var elemento in listaProduto)
                {
                    Console.WriteLine(elemento.Nome);
                }
        }
   
            return null;
    }
}
}

                

