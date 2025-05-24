using System;

namespace Singleton
{
    // Garante que apenas uma instância desta classe seja criada
    public sealed class AppSingleton
    {
        // Instância única criada de forma thread-safe sob demanda
        private static readonly Lazy<AppSingleton> _instance = new Lazy<AppSingleton>(() => new AppSingleton());

        // Valor configurável apenas na inicialização
        public string ConfigurationValue { get; private set; }

        // Flag para garantir inicialização única
        private bool _isInitialized = false;

        // Construtor privado impede instanciação externa
        private AppSingleton() { }

        // Acesso global à instância
        public static AppSingleton Instance => _instance.Value;

        // Inicializa o singleton uma única vez com um valor
        public void Initialize(string value)
        {
            if (!_isInitialized)
            {
                ConfigurationValue = value;
                _isInitialized = true;
            }
        }
    }

    // Classe separada para execução da aplicação
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton executando com sucesso!");

            var singleton = AppSingleton.Instance;
            singleton.Initialize("Configuração Inicial");

            Console.WriteLine("Valor configurado no Singleton: " + singleton.ConfigurationValue);
        }
    }
}
