using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Servicos
{
    public class LeitorDeArquivoFactoryTest
    {
        [Fact]  
        public void QuandoExtensaoForCsvDeveRetornarTipoLeitorDeArquivoCsv()
        {
            //Arrange
            string caminhoArquivo = "pets.csv";

            //Act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            //Assert
            Assert.IsType<PetsDoCsv>(leitor);
        }

        [Fact]
        public void QuandoExtensaoForJsonDeveRetornarTipoLeitorDeArquivoJson()
        {
            // Arrange
            string caminhoArquivo = "pets.json";

            // Act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            // Assert
            Assert.IsType<LeitorDeArquivoJson<Pet>>(leitor);
        }

        [Fact]
        public void QuandoExetnsaoNaoSuportadaDeveRetornarNulo()
        {
            // Arrange
            string caminhoArquivo = "pets.xml";
            // Act & Assert
            Assert.Throws<NotSupportedException>(() => LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo));
        }
    }
}
