using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar() {
            var saldacao = "olá".ToUpper().Insert(3, " World!").Replace( "World!", "Mundo!");
            Console.WriteLine(saldacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
