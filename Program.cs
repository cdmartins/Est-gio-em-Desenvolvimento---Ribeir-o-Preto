
class Program
{
    static void Main(string[] args)
    {
        static void TesteSoftware()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.Write($"O valor da variável SOMA é: {SOMA}\n\n");

        }
        bool Fibonacci()
        {
            Console.WriteLine("Digite um número: ");
            int entrada_usuario = int.Parse(Console.ReadLine()!);
            if (entrada_usuario == 0)
            {
                Console.WriteLine($"Este número faz parte da sequencia de Fibonacci");
                return true;
            }

            int primeiro_numero = 0; int segundo_numero = 1;
            while (segundo_numero <= entrada_usuario)
            {
                if (entrada_usuario == segundo_numero)
                {
                    Console.WriteLine($"Este número faz parte da sequencia de Fibonacci");
                    return true;
                }

                int sequencia = segundo_numero + primeiro_numero;
                primeiro_numero = segundo_numero;
                segundo_numero = sequencia;
            }

            Console.WriteLine("Este numero não faz parte da sequencia de Fibonacci");
            return false;
        }

        void InverterString()
        {
            Console.WriteLine("\nEntre com uma palavra: ");
            string entrada_usuario = Console.ReadLine()!;
            char[] letras = new char[entrada_usuario.Length];

            for (int i = 0; i < entrada_usuario.Length; i++)
            {
                int quantidade = entrada_usuario.Length - 1 - i;
                letras[i] = entrada_usuario[quantidade];
                quantidade--;
            }

            Console.WriteLine("Palavra invertida: ");
            foreach (char letra in letras)
            {
                Console.Write(letra);
            }



        }

        TesteSoftware();
        Fibonacci();
        InverterString();
        


    }
}

