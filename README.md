# Jogo De Adivinhação

## Demonstração

![](https://i.imgur.com/BBEzTmd.gif)

## Introdução

Um jogo onde você tenta adivinhar um número secreto de 1 - 20.

## Funcionalidades

- **Gerador de número aleatório**: O jogo gera automaticamente um número de 1 até 20.
- **Múltiplas tentativas**: Você pode escolher a dificuldade do jogo e definir quantas chances terá para acertar.
- **Feedback**: Caso o jogador erre o número, o jogo indicará se o número é maior ou menor que o número secreto.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDeAdivinhacao.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./JogoDeAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDeAdivinhacao.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.