using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
   
    public class CalculadoraEstatica 
    { 
        //Método de instância!!!
        public int Somar(int a, int b) {
            return  a + b;
        }
        //Método de Classe ou Método destático!!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);

            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica Calc = new CalculadoraEstatica();
            Console.WriteLine(Calc.Somar(2, 2));
        }
    }
}
