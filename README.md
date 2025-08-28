# Sistema de Estacionamento

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white )
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white )

## 📖 Sobre o Projeto

Este projeto é a solução para um desafio técnico proposto no bootcamp da Avanade, de desenvolvimento C#/.NET. O objetivo foi criar um sistema de console para gerenciar o fluxo de entrada e saída de veículos em um estacionamento. A aplicação calcula o valor a ser pago pelo cliente com base em um preço inicial e um preço por hora.

Este projeto foi desenvolvido para demonstrar e aplicar conceitos fundamentais de C#, como:
- Manipulação de listas (`List<T>`)
- Estruturas de repetição (`while`, `foreach`)
- Estruturas condicionais (`if/else`, `switch`)
- Interação com o console (`Console.WriteLine`, `Console.ReadLine`)
- Conversão de tipos e validação de dados (`int.TryParse`)

---

## 💻 Funcionalidades

- **Cadastrar Veículo:** Adiciona uma nova placa de veículo à lista de veículos estacionados.
- **Remover Veículo:** Remove um veículo da lista, calcula e exibe o valor total a ser pago com base nas horas estacionadas.
- **Listar Veículos:** Exibe todas as placas dos veículos que estão atualmente no estacionamento.
- **Encerrar:** Finaliza a execução do programa.

---

## ✨ Features e Melhorias Implementadas

Além dos requisitos básicos, foram implementadas as seguintes melhorias para garantir a robustez e a qualidade do software:

- **Tratamento de Erros na Entrada de Dados:** O sistema utiliza `int.TryParse` para validar a entrada de horas, prevenindo que a aplicação quebre (`crash`) caso o usuário digite um texto em vez de um número.
- **Lógica Case-Insensitive para Placas:** As placas são convertidas para maiúsculas no momento do cadastro e da remoção. Isso garante que `abc-1234` e `ABC-1234` sejam tratados como o mesmo veículo, melhorando a experiência do usuário.

---

## 🚀 Como Executar

Para executar este projeto, você precisará ter o SDK do .NET instalado em sua máquina.

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/vitorcomv/sistema-estacionamento
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd sistema-estacionamento
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

Após a execução, o menu interativo será exibido no seu terminal.

---

## 👨‍💻 Autor

**Vitor Hugo Dias da Silva**

- LinkedIn: [`Vitor Hugo (Clique aqui!)`](https://www.linkedin.com/in/vitor-hugo-258130258/)
- Github: [`vitorcomv`](https://github.com/vitorcomv)