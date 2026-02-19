using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.TestesIntegracao.Builder;

public static class LeitorDeArquivosMockBuilder<T>
{
    public static Mock<LeitorDeArquivoCsv<T>> GetMock(List<T> lista)
    {
        var leitorDeArquivo = new Mock<LeitorDeArquivoCsv<T>>(MockBehavior.Default,
            It.IsAny<string>());

        leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(lista);

        return leitorDeArquivo;
    }
}