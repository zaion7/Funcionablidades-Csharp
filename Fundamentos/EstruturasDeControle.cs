using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturasDeControle {
        public static void Executar() {

            /* 
             double dinheiro = 8.000;

             if(dinheiro > 5.000) {
                 Console.WriteLine("Posso Viajar!");
             } else {
                 Console.WriteLine("Não posso viajar");
             }
            */

            Console.WriteLine("Digite sua primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double resultado = n1 * n2 * n3 / 3;

            if (resultado >= 7.0) {
                Console.WriteLine("Passou de ano fiot");
            } else {
                Console.WriteLine("Fica mais 1 ano ai");
            }
        }
    
    }
}
