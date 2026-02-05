using Alura.Adopet.Console.Modelos;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class ClientesDoJson : LeitorDeArquivosJson<Cliente>
    {
        public ClientesDoJson(string caminhoArquivo) : base(caminhoArquivo)
        {
        }

        public override Cliente CriarDaLinhaJson(string caminhoArquivo)
        {
            using var stream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
            return (Cliente)(JsonSerializer.Deserialize<IEnumerable<Cliente>>(stream) ?? Enumerable.Empty<Cliente>());
        }
    }
}
