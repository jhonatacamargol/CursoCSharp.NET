﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            bool comprouTv50 =executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saldável? {0}", !comprouSorvete);
        }
    }
}
