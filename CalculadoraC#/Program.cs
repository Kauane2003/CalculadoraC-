
namespace CalculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração ");

            int operacao = int.Parse(Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero: ");
            int Numero1 = int.Parse(Console.ReadLine();

            Console.WriteLine("Digite o Segundo numero: ");
            int Numero2 = int.Parse(Console.ReadLine();

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(Numero1 + Numero2);
                        break;
                    }
                case 2:                           
                    {
                        resultado = Subtracao(Numero1 - Numero2);
                        break;
                    }


            }
        }
    }
}

