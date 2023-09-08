﻿using System;
using System.Collections.Generic;

using CursoCSharpUdemy.Fundamentos;
using CursoCSharpUdemy.EstruturasDeControle;
using CursoCSharpUdemy.ClassesEMetodos;
using CursoCSharpUdemy.OO;

namespace CursoCSharpUdemy {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atrubuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},


                // Estruturas de controle.
                {"Estrutura If - Estruturas de controles", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controles", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controles", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controles", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controles", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de controles", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controles", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controles", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controles", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controles", UsandoContinue.Executar},


                //Classes e Métodos.
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos estáticos - Classes e Métodos", MetodosComRetorno.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstáticos.Executar},


                //OO
                 {"Herança - OO", Heranca.Executar},
                 {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},





            });

            central.SelecionarEExecutar();
        }
    }
}