/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
•
Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar missões. A pontuação é calculada com base na dificuldade da missão, na quantidade de inimigos derrotados e no tempo gasto para completar.
•
Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil), o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para calcular a pontuação da missão usando os seguintes critérios:
•
Fácil: 5 pontos por inimigo, sem penalidade de tempo.
•
Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
•
Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
•
Exiba a pontuação final do jogador.
@Lista: 04 - Função
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

        string? nvl;
        int inmgs, tmp;

        Console.WriteLine("escreva o nível de dificuldade (facil, media ou dificil): ");
        nvl = Console.ReadLine();

        Console.WriteLine("Qual o número de inimigos derrotados? ");
        int.TryParse(Console.ReadLine(), out inmgs);

        Console.WriteLine("Qual foi o tempo gasto?");
        int.TryParse(Console.ReadLine(), out tmp);

        int total = Some(inmgs, tmp, nvl);

        Console.WriteLine("a sua pontuação de vida é: " + total);
    }
    static int Some(int inmgs, int tmp, string? nvl)
    {
        
        int total1 = 0;

        if (nvl == "facil")
        {
            total1 = (5 * inmgs);
            Console.WriteLine($"Você tem {total1} pontos");
        }

        if (nvl == "media")
        {
            int tmpT = (tmp - 10) * 2;

            total1= (10 * inmgs) - tmpT;
              Console.WriteLine($"Você tem {total1} pontos");
        }
        if (nvl == "dificil")
        {
            int tmpT = (tmp - 15) * 5;

            total1 = (15 * inmgs) - tmpT;
              Console.WriteLine($"Você tem {total1} pontos");
             
        }
        return total1;
    }
     

}    