using Alura.Adopet.Console.Modelos;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class PetsDoJson : LeitorDeArquivosJson<Pet>
    {
        public PetsDoJson(string caminhoArquivo) : base(caminhoArquivo)
        {
        }

        public override Pet CriarDaLinhaJson(string caminhoArquivo)
        {
            using var stream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
            return (Pet)(JsonSerializer.Deserialize<IEnumerable<Pet>>(stream) ?? Enumerable.Empty<Pet>());
        }
    }
}
