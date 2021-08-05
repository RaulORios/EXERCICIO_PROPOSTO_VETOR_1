using System;
using System.Globalization;

namespace EXERCICIO_PROPOSTO_VETOR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            double[] valores = new double[n];

            string[] vet = Console.ReadLine().Split(' ');
            double maior = 0; 
            int posicao = 0;
            for (int i = 0; i < n; i++)
            {                
                valores[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                if (valores[i] > maior)
                {
                    maior = valores[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

            Console.ReadKey();

        }
    }
}
