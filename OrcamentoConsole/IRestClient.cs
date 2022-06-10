namespace OrcamentoConsumer
{
    public interface IRestClient
    {
        Task<Produtos> GetProdutosAsync();
    }
}
