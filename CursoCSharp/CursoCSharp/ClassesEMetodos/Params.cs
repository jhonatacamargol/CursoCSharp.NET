using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessaos)
        {
            foreach (var pessoa in pessaos)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "João");
        }
    }
}
