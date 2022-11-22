using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subitrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado () {
            return memoria;
        }
    }

    internal class MetodosComRetorno
    {
        public static void Executar() {
            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);
           
            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraComum.Subitrair(14, 5));
            Console.WriteLine(CalculadoraComum.Multiplicar(18, 36));
            Console.WriteLine(CalculadoraComum.Dividir(526, 8));

            var CalculadoraCadeia = new CalculadoraCadeia();
            CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
        }
    }
}
