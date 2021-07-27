using PooCsharpIntroducao;
using System;

namespace PooCsharpIntroducao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Nome = "Emerson Pinheiro de Souza";
            p.Bracos = 2;
            p.Pernas = 2;
            p.Olhos = 2;
            p.CorCabelo = "Preto";
            Console.WriteLine(p.Nome +" possui "+p.Bracos+" braços, \n"+p.Pernas+" pernas, \n"+p.Olhos+" olhos e cabelo "+p.CorCabelo+"\n");

            Pessoa p1 = new Pessoa("Loiro");
            //UTILIZANDO O CONSTRUTOR PERSONALIZADO
            p1.Nome = "Welleson Gama de Souza";

            Console.WriteLine(p1.Nome + " possui " + p1.Bracos + " braços, \n" + p1.Pernas + " pernas, \n" + p1.Olhos + " olhos e cabelo " + p1.CorCabelo + "\n");

            Console.ReadKey();

            
            /*   p.setNome("Emerson Pinheiro de Souza"); 
            Console.WriteLine("A pessoa: "+p.getNome()+" foi criada com sucesso!");
            Console.ReadKey();*/

        }
    }
}
