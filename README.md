# Jogo De Adivinha��o

![](https://i.imgur.com/BBEzTmd.gif)

## Introdu��os

Um jogo onde voc� tenta adivinhar um n�mero secreto de 1 - 20.

## Funcionalidades

- **Gerador de n�mero aleat�rio**: O jogo automaticamente gera um n�mero de 1 at� 20.
- **Multiplas tentativas**: Voc� pode escolher a dificuldade do jogo e mudar quantas chances voc� tem para acertar.
- **Feedback**: Caso o jogador erre o n�mero, o jogo vai indicar se o n�mero � maior ou menor do que o n�mero secreto.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project JogoDeAdivinhacao.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./JogoDeAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
JogoDeAdivinhacao.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.