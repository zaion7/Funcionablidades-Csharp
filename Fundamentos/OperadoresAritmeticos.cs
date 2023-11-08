using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            /*
                    Console.WriteLine("Digite um Número ?");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro Número ?");
                    int n2 = int.Parse(Console.ReadLine());

                    int resultado = n1 + n2;

                    Console.WriteLine($" A soma de {n1} + {n2} é = {resultado}");

                    */

            Console.WriteLine("Digite a base: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Altura: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = (num1 * num2) / 2;

            Console.WriteLine($"A Área do trangulo é de : {resultado}");

        }
    }
}
