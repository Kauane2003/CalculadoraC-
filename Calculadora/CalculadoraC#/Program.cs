namespace CalculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração ");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo numero: ");
            int Numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(Numero1, Numero2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(Numero1, Numero2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(Numero1, Numero2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(Numero1, Numero2);
                        break;
                    }
            }
            Console.WriteLine("O resultado da operacao com os numeros {0} e {1} é: {2}", Numero1, Numero2, resultado);

        }

        public static int Adicao(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        public static int Subtracao(int numero1, int numero2)
        {  
            int resultado = numero1 - numero2;
            return resultado;
        }
        public static int Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        public static int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }

    }
}
