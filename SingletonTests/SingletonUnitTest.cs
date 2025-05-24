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
            // Obtém a instância do Singleton e inicializa com "Valor Inicial"
            var instancia1 = AppSingleton.Instance;
            instancia1.Initialize("Valor Inicial");

            // Obtém novamente a instância e tenta inicializar com outro valor (deve ser ignorado)
            var instancia2 = AppSingleton.Instance;
            instancia2.Initialize("Outro Valor");

            // Verifica se ambas as instâncias são exatamente o mesmo objeto na memória
            Assert.AreSame(instancia1, instancia2, "As instâncias devem ser a mesma (singleton).");

            // Verifica se o valor inicial foi mantido
            Assert.AreEqual("Valor Inicial", instancia1.ConfigurationValue, "O valor deve permanecer como o inicial.");
            Assert.AreEqual("Valor Inicial", instancia2.ConfigurationValue, "O valor deve ser o mesmo para todas as instâncias.");
        }
    }
}
