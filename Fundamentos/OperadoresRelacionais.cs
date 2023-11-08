using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            int a = 12;
            int b = 7;
            int c = 24;
            int d = 18;

            Console.WriteLine(a >= b);
            Console.WriteLine(c != d);
            //F OU F = F
            Console.WriteLine(a == b || c <= d);
            //F e V = F
            Console.WriteLine(d <= a && c != d);
        }
    }

}
