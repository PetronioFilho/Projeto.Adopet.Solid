using Alura.Adopet.Console.Servicos.Arquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.IsType<LeitorDeArquivosCsv>(leitor);
        }

        [Fact]
        public void QuandoExtensaoForJsonDeveRetornarTipoLeitorDeArquivoJson()
        {
            // Arrange
            string caminhoArquivo = "pets.json";

            // Act
            var leitor = LeitorDeArquivosFactory.CreatePetFrom(caminhoArquivo);

            // Assert
            Assert.IsType<LeitorDeArquivosJson>(leitor);
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
