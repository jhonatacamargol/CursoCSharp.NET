using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamililia = new Filme();
            filmeParaFamililia.Titulo = "Sharknardo 17";
            filmeParaFamililia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamililia.Titulo, filmeParaFamililia.GeneroDoFilme);
        }
    }
}
