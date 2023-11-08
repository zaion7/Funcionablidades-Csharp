using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosOperadores
    {
        public static void Executar() {

            /*
            Console.WriteLine("qual é a 1 nota do aluno ?");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual é a 2 nota do aluno ?");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual a 3 nota ?");
            double n3 = double.Parse(Console.ReadLine());

            double resultado = Math.Round((n1 + n2 + n3) / 3,2);

            Console.WriteLine($"A média do aluno é : {resultado}");
            */

            /*
             double n1 = double.Parse(Console.ReadLine());
            double resul1 = n1 * 3.5;
 
            Console.WriteLine("Digite a 2° Nota: ");
            double n2 = double.Parse(Console.ReadLine());
            double resul2 = n2 * 7.5;
 
            double resultado = Math.Round((resul1 + resul2) / 11,1);
            Console.WriteLine($"O resultado:{resultado}");
             */


            Console.WriteLine("qual o número do funcionario ?");
            var numero = double.Parse(Console.ReadLine());

            Console.WriteLine("quantas horas foram trabalhadas ?");
            var horas = double.Parse(Console.ReadLine());

            Console.WriteLine("qual o Salario por hora dele ? ?");
            var salario = double.Parse(Console.ReadLine());

            double resultado = (horas * salario);

            Console.WriteLine($" Número de Funcionario: {numero}\n Salário {resultado}");


        }
    }
}
