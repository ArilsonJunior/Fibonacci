using System.Runtime.Intrinsics.Arm;

namespace Fibonacci
{
    internal class Program
    {
        static void Main()
        {
            bool sair = false;

            do
            {

                Console.Write("Informe um número: ");
                int numeroInformado = int.Parse(Console.ReadLine());

                string resultado = VerificaFibonacci(numeroInformado);
                Console.WriteLine(resultado);


                static List<int> Fibonacci(int n)
                {
                    List<int> fibSequence = new List<int> { 0, 1 };
                    while (fibSequence[fibSequence.Count - 1] < n)
                    {
                        int nextFib = fibSequence[fibSequence.Count - 1] + fibSequence[fibSequence.Count - 2];
                        fibSequence.Add(nextFib);
                    }
                    return fibSequence;
                    
                }

                static string VerificaFibonacci(int num)
                {
                    List<int> fibSequence = Fibonacci(num);
                    if (fibSequence.Contains(num))
                    {
                        return $"\nO número {num} pertence à sequência de Fibonacci.\n";
                    }
                    else
                    {
                        return $"\nO número {num} não pertence à sequência de Fibonacci.\n";
                    }
                }
                int escolha;

                Console.WriteLine("Deseja sair do programa?\n" +
                    "[1]- Sim\n" +
                    "[2]- Não\n");

                escolha = Convert.ToInt32(Console.ReadLine());

                if(escolha == 1)
                {
                    sair = true;
                }

            } while (!sair);
        }
    }
}
