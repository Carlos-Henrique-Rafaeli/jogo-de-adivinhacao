namespace JogoDeAdivinhacao.ConsoleApp;

internal class Program
{
    static string[] opcoesValidas = { "1", "2", "3", "S" };
    
    static void Main(string[] args)
    {
        while (true)
        {
            string opcao = ExibirMenu();

            if (!opcoesValidas.Contains(opcao))
            {
                Console.WriteLine("Opcão Inválida!\nPressione ENTER para voltar!");
                Console.ReadLine();
                continue;
            }

            else if (opcao == "1")
                IniciarJogo(10);
            else if (opcao == "2")
                IniciarJogo(5);
            else if (opcao == "3")
                IniciarJogo(3);
            else if (opcao == "S")
                return;
        }

    }

    static void IniciarJogo(int tentativas)
    {
        Console.Clear();

        while (true)
        {
            int numeroDigitado = ExibirTentativas(tentativas);

            string verificacao = JogoDeAdivinhacao.JogarRodada(tentativas, numeroDigitado);

            if (verificacao == "Acertou")
            {
                Console.WriteLine("\nVocê acertou o número secreto!");
                break;
            }
            else if (verificacao == "Perdeu")
            {
                Console.WriteLine($"\nVocê não acertou o número secreto. Ele era {JogoDeAdivinhacao.numeroSecreto}!");
                break;
            }
            else if (verificacao == "Maior")
            {
                Console.WriteLine("\nO número informado é maior que o número secreto!\n");
                continue;
            }
            else if (verificacao == "Menor")
            {
                Console.WriteLine("\nO número informado é menor que o número secreto!\n");
                continue;
            }
        }

        Console.WriteLine("\nPressione ENTER para jogar novamente!");
        Console.ReadLine();
    }

    static string ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine("\nEscolha o nível de dificuldade:\n");
        Console.WriteLine("1 - Fácil (10 tentativas)");
        Console.WriteLine("2 - Médio (5 tentativas)");
        Console.WriteLine("3 - Difícil (3 tentativas)");
        Console.WriteLine("S - Sair");

        Console.Write("\nEscolha a opção: ");
        string opcaoDificuldade = Console.ReadLine()!.ToUpper();

        return opcaoDificuldade;
    }

    static int ExibirTentativas(int tentativaMaxima)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Tentativa {(JogoDeAdivinhacao.tentativa + 1)} de {tentativaMaxima}");
        Console.WriteLine("----------------------------------------------------");

        while (true)
        {
            Console.Write("\nDigite um número: ");
            string numeroDigitado = Console.ReadLine()!;

            if (VerificarStringNumero(numeroDigitado))
            {
                Console.WriteLine("\nNúmero inválido digite novamente!");
                continue;
            }
            
            int numeroDigitadoInt = Convert.ToInt32(numeroDigitado);

            return numeroDigitadoInt;
        }
        
    }

    static bool VerificarStringNumero(string x)
    {
        bool verificacao = String.IsNullOrEmpty(x) || !decimal.TryParse(x, out _);

        return verificacao;
    }
}
