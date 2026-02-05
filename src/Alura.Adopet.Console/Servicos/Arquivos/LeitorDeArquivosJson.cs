using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public abstract class LeitorDeArquivosJson<T>: ILeitorDeArquivos<T>
    {
        private string caminhoArquivo;

        public LeitorDeArquivosJson(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        public virtual IEnumerable<T> RealizaLeitura()
        {
            if(string.IsNullOrEmpty(caminhoArquivo))
            {
                return null;
            }
            List<T> lista = new List<T>();
            using var stream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

            while(!stream.CanRead)
            {
                var objeto = CriarDaLinhaJson(caminhoArquivo);
                lista.Add(objeto);
            }

            return lista;
        }

        public abstract T CriarDaLinhaJson(string caminhoArquivo);

    }
}