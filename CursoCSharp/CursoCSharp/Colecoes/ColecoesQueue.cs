using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var Fila = new Queue<String>();

            Fila.Enqueue("Fulano");
            Fila.Enqueue("Ciclano");
            Fila.Enqueue("Beltrano");

            Console.WriteLine(Fila.Peek());
            Console.WriteLine(Fila.Count());
            Console.WriteLine(Fila.Peek());
        }
    }
}
