﻿/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
•
Contextualização: No jogo, o jogador pode usar habilidades especiais durante a batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de inimigo e da distância do alvo.
•
Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo (Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira qual habilidade usar com base nos seguintes critérios:
•
Mana maior que 50: Use Habilidade Poderosa.
•
Inimigo Forte ou Boss: +10 mana necessária.
•
Distância menor que 10 metros: Reduz a mana necessária em 5.
•
Exiba a habilidade sugerida.
@Lista: 04 - Função
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
        string? tp;
        double mn, alv;

        Console.WriteLine("Qual a sua quantidade de mana? ");
        double.TryParse(Console.ReadLine(), out mn);

        Console.WriteLine("Qual sua distância até ao alvo?");
        double.TryParse(Console.ReadLine(), out alv);

        Console.WriteLine("Qual o tipo de inimigo ");
        tp = Console.ReadLine();


        double total = Some( mn, alv,tp);
        Console.ReadLine();

        Console.WriteLine("o seu ataque foi de: " + total);
    }
    static double Some(double mn, double alv, string? tp)
    {

        double total = 0;
        
        if (tp== "forte" || tp=="boss")
        {
            if(alv<10)
            {
                if(mn>55)
                {
                Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            }

        
        else if(mn>60)
        {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                    Console.WriteLine("Use Habilidade Básica");
                }
            
        }
    
        else if(mn>0)
        {
            if(alv<10)
            {
                if(mn >45)
                {
                    Console.WriteLine("Use Habilidade Poderosa");
                }
                else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
        }
            else 
            {
            if(mn>50)
                {
                     Console.WriteLine("Use Habilidade Poderosa");
                }
                 else
                {
                      Console.WriteLine("Use Habilidade Básica");
                }
            }
            return total;
        }
    }