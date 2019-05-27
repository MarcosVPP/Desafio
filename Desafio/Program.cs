using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string mensagem;

            Console.WriteLine("Digite o valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";

            Console.WriteLine(mensagem);
            Console.WriteLine("------------------------------");
            int total = 0;
            for (int i = 0; i <= valor; i ++)
            {
                total = valor * 2;
            }
            Console.WriteLine("O total é: " + total);

            Console.ReadKey();
        }
    }
}
