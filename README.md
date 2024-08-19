# Projeto do desafio - CÁLCULO DO CDB

Este repositório contém a solução completa para o projeto do desafio Calculo do CDB. A solução consiste em uma API desenvolvida em .NET Framework, Testes em MSUnit e uma aplicação web desenvolvida em Angular.

## Pré-requisitos
Certifique-se de que você possui as seguintes ferramentas instaladas em seu ambiente:

- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [Angular 16 CLI](https://angular.io/cli)

## Instruções para a API

### Configuração do Ambiente

1. **Clone o Repositório**
    ```bash
    git clone https://github.com/DavidUdala/B3.Investimento.git
    cd seu-repositorio/B3.Investimento/B3.Investimento.API
    ```

2. **Abrir a Solução no Visual Studio**
    - Abra o Visual Studio 2022.
    - Clique em `Open a project or solution` e selecione o arquivo `B3.Investimento.sln`.

### Execução da API
1. **Restaurar Pacotes**
    - No Visual Studio, clique com o botão direito na solução e selecione `Restore NuGet Packages`.

2. **Compilar a Solução**
    - Pressione `Ctrl+Shift+B` para compilar a solução.

3. **Executar a API**
    - Defina `B3.Investimento.API` como o projeto de inicialização.
    - Pressione `F5` para executar a API.

### Executar Testes da API

1. **Executar Testes**
    - No Visual Studio, abra o menu `Test` e selecione `Run All Tests`.

## Instruções para a Aplicação Web

### Configuração do Ambiente

1. **Navegar até o Diretório Web**
    ```bash
    cd ../B3.Investimento/B3.Investimento.WebApp
    ```

2. **Instalar Dependências**
    ```bash
    npm install
    ```

### Execução da Aplicação Web

1. **Iniciar o Servidor de Desenvolvimento**
    ```bash
    ng serve
    ```
2. **Acessar a Aplicação**
    - Abra o navegador e acesse `http://localhost:4200`.