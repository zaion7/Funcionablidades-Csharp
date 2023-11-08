using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() {

            //Aredondando numero
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));

            // TRANSFORMAR UM VALOR MONETÁRIO (MOEDA DE ACORDO COM O IDIOMA DA MAQUINA)
            Console.WriteLine(valor.ToString("C"));

            //MULTIPLICA UM VALOR POR 100 ADICIONA PERCENTUAL 
            Console.WriteLine(valor.ToString("p"));

            //fORMATANDO O NÚMERO DO JEITO QUE VOCÊ QUISER
            Console.WriteLine(valor.ToString("#.##"));


        }
    }
}
