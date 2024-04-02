namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraEscolhida = 'E';

            FazerDiamante(letraEscolhida);

            Console.ReadLine();
        }

        private static void FazerDiamante(char letraEscolhida)
        {
            int tamanho = letraEscolhida - 'A' + 1;

            for (int i = 0; i < tamanho; i++)
            {
                char letra = (char)('A' + i);
                int espacos = tamanho - i - 1;
                FazerLinha(letra, espacos);
            }

            for (int i = tamanho - 2; i >= 0; i--)
            {
                char letra = (char)('A' + i);
                int espacos = tamanho - i - 1;
                FazerLinha(letra, espacos);
            }
        }

        private static void FazerLinha(char letra, int espacos)
        {
            // Espaços à esquerda
            for (int i = 0; i < espacos; i++)
            {
                Console.Write(" ");
            }

            // Letra e os espaços entre letras
            for (char c = 'A'; c <= letra; c++)
            {
                Console.Write(c);
                if (c != letra)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
