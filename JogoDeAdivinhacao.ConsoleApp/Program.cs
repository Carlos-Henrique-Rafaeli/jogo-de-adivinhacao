namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deveRodar = true;

            while (deveRodar)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("\nEscolha o nível de dificuldade:\n");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Médio (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");

                Console.Write("\nDigite sua escolha de dificuldade: ");
                string opcaoDificuldade = Console.ReadLine();

                int totalDeTentativas = 5;

                if (opcaoDificuldade == "1")
                    totalDeTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalDeTentativas = 5;
                else
                    totalDeTentativas = 3;

                Random geradorNumeros = new Random();

                int numeroSecreto = geradorNumeros.Next(1, 21);

                Console.Clear();

                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                { 
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("----------------------------------------------------");

                    Console.Write("\nDigite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("\nVocê acertou o número secreto!");
                        break;
                    }
                        
                    if (tentativa >= totalDeTentativas)
                    {
                        Console.WriteLine($"\nVocê não acertou o número secreto. Ele era {numeroSecreto}!");
                        break;
                    }
                    
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("\nO número informado é maior que o número secreto!\n");
                    }
                    
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("\nO número informado é menor que o número secreto!\n");
                    }

                }
                Console.Write("\nDeseja Continuar? (S/N): ");
                
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    deveRodar = false;
                    break;
                }

            }
            
            Console.WriteLine("\nAplicativo encerrado.\nPressione ENTER para sair!");
            Console.ReadLine();
        }
    }
}
