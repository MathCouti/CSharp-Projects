using System;
using System.Collections.Generic;
using JogoDaForca.Entities;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=-=-=-=-=-=-= | Jogo da forca | -=-=-=-=-=");
        Console.WriteLine("MENU");
        Console.WriteLine("1 - Iniciar jogo | 2 - Sair");
        int res = int.Parse(Console.ReadLine());
        while (res == 1)
        {
            Console.WriteLine("Novo jogo");
            PalavraDica game = new PalavraDica();

            while (game.espaco.Contains("_") == true)
            {
                Console.WriteLine(game.Tela());
                Console.Write("\nInsira a letra desejada: ");
                char pala = char.Parse(Console.ReadLine().ToLower());
                game.CheckLetra(pala);
            }
            res = 2;
            Console.WriteLine("Fim de jogo");
            
        }
    }
}
