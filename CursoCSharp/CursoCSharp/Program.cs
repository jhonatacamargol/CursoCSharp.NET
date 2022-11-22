using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura Do For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Do For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando BREACK - Estruturas de Controle", UsandoBreack.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},

            }) ;

            central.SelecionarEExecutar();
        }
    }
}