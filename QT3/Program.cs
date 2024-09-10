﻿/*-------------------------------------------------------------------
@Lista: 04 - Funções
Questão 3: Cálculo de Dano Crítico
* Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
* Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
* Espada: +10 pontos ao dano total.
* Arco: +5 pontos ao dano total.
* Cajado: +15 pontos ao dano total.
* Exiba o dano total causado pelo ataque crítico.
@Autor: Luís Gustavo Serafim de Souza
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? tp;
        double atqe, crit;

        Console.WriteLine("Quanto foi o ataque base? ");
        double.TryParse(Console.ReadLine(), out atqe);

        Console.WriteLine("Qual o multiplicador crítico?");
        double.TryParse(Console.ReadLine(), out crit);

        Console.WriteLine("Qual o tipo de arma (espada, arco ou cajado)? ");
        tp = Console.ReadLine();


        double total = Some( atqe, crit, tp);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double atqe, double crit, string? tp)
    {

        double total = 0;
        if (tp == "espada")
        {
            total = (crit * atqe) + 10;
            Console.WriteLine($"O dano critico foi de {total}");
        }

        else if (tp == "arco")
        {
            total = (crit * atqe) + 5;
            Console.WriteLine($"O dano critico foi de {total}");
        }

        else if (tp == "cajado")
        {
            total = (crit * atqe) + 15;
            Console.WriteLine($"O dano critico foi de {total}");
        }
        return total;
    }
}
    