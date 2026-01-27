namespace Alura.Adopet.Console.Servicos.Abstracoes
{
    public interface IApiServices<T>
    {
        Task CreateAsync(T obj);

        Task<IEnumerable<T>?> ListAsync();
    }
}
