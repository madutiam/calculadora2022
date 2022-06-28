using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, soma, sub, div, mult, opera;

            Console.Write("Digite o primeiro número : ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação de acordo com o número " +
               "\n 1 . Soma + " +
               "\n 2 . Subtração - " +
               "\n 3 . Multiplicação X/. " +
               "\n 4 . Divisão /  ");
            opera = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número : ");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 + n2;
            sub = n1 - n2;
            div = n1 / n2;
            mult = n1 * n2;

            if(opera == 1)
            {
                Console.WriteLine(n1 + " + " + n2 + " = " + soma);
            }
            else if(opera == 2)
            {
                Console.WriteLine(n1 + " - " + n2 + " = " + sub);
            }
            else if(opera == 3)
            {
                Console.WriteLine(n1 + " X " + n2 + " = " + mult);
            }
            else if(opera == 4)
            {
                Console.WriteLine(n1 + " / " + n2 + " = " + div);
            }

            Console.ReadKey();

        }
    }
}
