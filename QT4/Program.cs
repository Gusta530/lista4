/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
•
Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da distância até o aliado e do nível de ameaça no caminho.
•
Comando: Crie um programa que receba a energia do jogador, a distância até o aliado (em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine se o resgate é possível com base nas seguintes condições:
•
Energia maior que 50: Resgate bem-sucedido.
•
Distância menor que 20 metros: +10 de energia.
•
Nível de ameaça:
o
Baixo: Sem penalidade.
o
Médio: -10 de energia.
o
Alto: -20 de energia.
•
Exiba se o resgate foi bem-sucedido ou falhou.
@Autor: Luís Gustavo Serafim de Souza
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Clear();
        string? amc;
        double ener, ald;

        Console.WriteLine("Qual a sua energia inicial? ");
        double.TryParse(Console.ReadLine(), out ener);

        Console.WriteLine("Qual sua distância até o aliado?");
        double.TryParse(Console.ReadLine(), out ald);

        Console.WriteLine("Qual o nível de ameaça ");
        amc = Console.ReadLine();


        double total = Some( ald, ener,amc);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double ald, double ener, string? amc)
    {

        double total = 0;
        if (amc == "baixo")
        {
            if(ald<20)
            {
                total=ener+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
             else 
            {
                   if(ener>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
           
        }

        else if (amc == "medio")
        {ener-=10;
             if(ald<20)
            {
                total=ener+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
             else 
            {
                   if(ener>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }

        else if (amc == "alto")
        {ener-=20;
             if(ald<20)
            {
                total=ener+10;
                if(total>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
            else 
            {
                   if(ener>50)
                {
                Console.WriteLine("Resgate bem sucedido");
                }
                else 
                {
                    Console.WriteLine("Resgate falhou");
                }
            }
        }
        return total;
    }
}