using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Servicos
{
    public class PetService : IApiServices<Pet>
    {
        private HttpClient client;

        public PetService(HttpClient client)
        {
            this.client = client;
        }

        public Task CreateAsync(Pet pet)
        {
            return client.PostAsJsonAsync("pet/add", pet);
        }

        public Task<IEnumerable<Pet>?> ListAsync()
        {
            HttpResponseMessage response =  client.GetAsync("pet/list").Result;
            return response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
        }
    }
}
