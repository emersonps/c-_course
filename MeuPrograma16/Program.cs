using System;

namespace MeuPrograma16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seu código

            int cartas = 40;
            int jogadores = 3; //Aqui passou duas vezes ;; correto é apenas ;

            int cartas_por_pessoa = cartas/jogadores;
            int cartas_restantes = cartas % jogadores;

            Console.WriteLine("Foi distribuído " + cartas_por_pessoa + " cartas para cada jogador.");
            Console.WriteLine("Restaram " + cartas_restantes + " cartas no baralho.");
           
        }
    }
}
