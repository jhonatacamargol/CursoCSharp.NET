using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar() {

            double somatorio = 0;
            string entrada;
            int NotaBimestre;

            Console.WriteLine("Quantos bimestres já foram concluídos ?");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out NotaBimestre);
           

            if (NotaBimestre >= 5 ){
                Console.WriteLine("Número de bimestres inválido!");
            }
                for (int i = 1; i <= NotaBimestre; i++)
            {
                Console.WriteLine("Informe a nota alcançada no bimestre {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double NotaAtual);

                somatorio += NotaAtual;
            }

            double MediaFinal = NotaBimestre > 0 ? somatorio / NotaBimestre : 0;
            Console.WriteLine("Média Final : {0}", MediaFinal);

           
        }
    }
}