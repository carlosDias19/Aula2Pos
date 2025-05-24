using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace SingletonTests
{
    [TestClass]
    public class AppSingletonTests
    {
        [TestMethod]
        public void Singleton_DeveManterMesmaInstanciaEValorInicial()
        {
            // Obt�m a inst�ncia do Singleton e inicializa com "Valor Inicial"
            var instancia1 = AppSingleton.Instance;
            instancia1.Initialize("Valor Inicial");

            // Obt�m novamente a inst�ncia e tenta inicializar com outro valor (deve ser ignorado)
            var instancia2 = AppSingleton.Instance;
            instancia2.Initialize("Outro Valor");

            // Verifica se ambas as inst�ncias s�o exatamente o mesmo objeto na mem�ria
            Assert.AreSame(instancia1, instancia2, "As inst�ncias devem ser a mesma (singleton).");

            // Verifica se o valor inicial foi mantido
            Assert.AreEqual("Valor Inicial", instancia1.ConfigurationValue, "O valor deve permanecer como o inicial.");
            Assert.AreEqual("Valor Inicial", instancia2.ConfigurationValue, "O valor deve ser o mesmo para todas as inst�ncias.");
        }
    }
}
