using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            string nome = "Malcon";
            var sobreNome = "Batman";
            int idade = 38;
            double altura = 1.60;
            bool casado = false;

            const double pi = 3.14;// constante

                //concatenando
            Console.WriteLine("Olá meu nome é " + nome + " Tenho " + idade + " anos de idade, tenho " + altura + " de altura e " + casado + " não sou");
            Console.WriteLine($"Olá meu nome é {nome} Tenho {idade} anos e tenho {altura} de altura, e é {casado} a historia de que sou casado");
        }
    }
}
