using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public static class LeitorDeArquivosFactory
    {
        public static ILeitorDeArquivos<Pet>? CreatePetFrom(string caminhoArquivo)
        {
            var extensao = Path.GetExtension(caminhoArquivo);
            return extensao.ToLower() switch
            {
                ".json" => new LeitorDeArquivoJson<Pet>(caminhoArquivo),
                ".csv" => new PetsDoCsv(caminhoArquivo),
                _ => throw new NotSupportedException(null),
            };
        }

        public static ILeitorDeArquivos<Cliente>? CreateClienteFrom(string caminhoArquivo)
        {
            var extensao = Path.GetExtension(caminhoArquivo);
            return extensao.ToLower() switch
            {
                ".json" => new LeitorDeArquivoJson<Cliente>(caminhoArquivo),
                ".csv" => new ClientesDoCsv(caminhoArquivo),
                _ => throw new NotSupportedException(null),
            };
        }
    }
}
