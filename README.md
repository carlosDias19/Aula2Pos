# Singleton Pattern em C#

Este projeto demonstra a implementação do **padrão Singleton** em C# utilizando a inicialização preguiçosa (`Lazy<T>`) para garantir que a instância seja criada de forma **thread-safe** e que a inicialização ocorra apenas uma vez.

---

## Descrição

O padrão Singleton assegura que uma classe tenha apenas uma única instância durante o tempo de execução da aplicação, oferecendo um ponto global de acesso a essa instância.

Este exemplo inclui um método `Initialize` que permite configurar a instância **uma única vez**, ignorando chamadas subsequentes para evitar alteração do estado após a inicialização.

---

## Como funciona

- A instância do Singleton é criada somente quando acessada pela primeira vez, graças ao uso de `Lazy<T>`.
- A propriedade `ConfigurationValue` armazena um valor configurado apenas uma vez por meio do método `Initialize`.
- O construtor da classe é privado para impedir que outras partes da aplicação criem instâncias adicionais.

---

## Como usar

```csharp
var singleton = AppSingleton.Instance;
singleton.Initialize("Valor Inicial");

Console.WriteLine(singleton.ConfigurationValue);
