﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            //ATRIBUIÇAO
            var num = 3;

            //Substituindo numero por 7
            num = 7;

            //ATRIBUIÇÃO ADITIVS
            num += 10; //num = num + 10

            //ATRIBUIÇÃO SUBTRATIVA
            num -= 3; // num = num - 3

            //ATRIBUIÇÃO MULTIPLICATIVA 
            num *= 5;


            var a = 1;
            var b = 1;

            a++; // a = a +1
            b--; // b = b - 1

            Console.WriteLine(b);
           // Console.WriteLine(num);
        }
    }
}
