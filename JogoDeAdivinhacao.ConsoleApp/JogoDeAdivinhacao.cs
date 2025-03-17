namespace JogoDeAdivinhacao.ConsoleApp;

public class JogoDeAdivinhacao
{
    static Random geradorNumeros = new Random();

    public static int numeroSecreto = geradorNumeros.Next(1, 21);

    public static int tentativa = 0;

    public static string JogarRodada(int tentativaMaxima, int numeroDigitado)
    {
        tentativa++;

        if (numeroDigitado == numeroSecreto)
        {
            Resetar();
            return "Acertou";
        }

        if (tentativa >= tentativaMaxima)
        {
            Resetar();
            return "Perdeu";
        }

        else if (numeroDigitado > numeroSecreto)
        {
            return "Maior";
        }

        else if (numeroDigitado < numeroSecreto)
        {
            return "Menor";
        }

        return "";
    }

    public static void Resetar()
    {
        numeroSecreto = geradorNumeros.Next(1, 21);
        tentativa = 0;
    }
}
