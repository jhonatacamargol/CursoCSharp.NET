using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreack
    {
        public static void Executar() {
            Random randon = new Random();
            int numero = randon.Next(1, 26);

            Console.WriteLine("O número que queromos é {0}.",numero);

            for (int i = 1; i <= 25; i++) {
                Console.Write("{0} é o número que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;
                } else {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
