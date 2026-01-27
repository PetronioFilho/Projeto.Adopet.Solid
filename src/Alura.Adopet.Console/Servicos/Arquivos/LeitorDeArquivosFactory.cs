using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public static class LeitorDeArquivosFactory
    {
        public static ILeitorDeArquivos CreatePetFrom(string caminhoArquivo)
        {
            var extensao = Path.GetExtension(caminhoArquivo);
            return extensao.ToLower() switch
            {
                ".json" => new LeitorDeArquivosJson(caminhoArquivo),
                ".csv" => new LeitorDeArquivosCsv(caminhoArquivo),
                _ => throw new NotSupportedException(null),
            };
        }
    }
}
