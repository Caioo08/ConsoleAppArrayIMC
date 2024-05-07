using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] alt = new double[5];
            double[] imc = new double[5];
            int cont = 0;

            for (int i = 0;i<= 4;i++)
            {
                Console.WriteLine("Digite o nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a altura da pessoa: ");
                alt[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso da pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                imc[i] = peso[i] / (alt[i] * alt[i]);
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Nome: " + nome[j]);
                Console.WriteLine("Peso: " + peso[j]);
                Console.WriteLine("Altura: " + alt[j]);
                if (imc[j] <= 16.9)
                {
                    Console.WriteLine("Você está muito abaixo do peso " + imc[j]);
                }
                else if (imc[j] <= 18.4)
                {
                    Console.WriteLine("Você está abaixo do peso: " + imc[j]);
                }
                else if (imc[j] <= 24.9)
                {
                    Console.WriteLine("Você está no peso normal: " + imc[j]);
                }
                else if (imc[j] <= 29.9)
                {
                    Console.WriteLine("Você está acima do peso: " + imc[j]);
                    cont++;
                }
                else if (imc[j] <= 34.9)
                {
                    Console.WriteLine("Você está com Obesidade Grau I: " + imc[j]);
                    cont++;
                }
                else if (imc[j] < 40)
                {
                    Console.WriteLine("Você está com Obesidade Grau II: " + imc[j]);
                    cont++;
                }
                else if (imc[j] >= 40)
                {
                    Console.WriteLine("Você está com obesidade Grau III: " + imc[j]);
                    cont++;
                }
            }
            Console.WriteLine("" + cont*20 + "% pessoas estão acima do peso ideal");
            Console.ReadKey();
        }
    }
}
