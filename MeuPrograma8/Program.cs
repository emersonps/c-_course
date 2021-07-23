using System;

namespace MeuPrograma8
{
    class Program
    {
        class Humano
        {
            //Propriedades e Métodos
        }
        class Feminino : Humano
        {
            //Propriedades e Métodos
        }
        class Masculino : Humano
        {
            //Propriedades e Métodos
        }
        static void Main(string[] args)
        {
            Feminino Mulher = new Feminino();
            Humano SerHumano = null;
            Feminino OutraMulher = SerHumano as Feminino;

            Console.WriteLine("Objeto: "+OutraMulher);
        }
    }
}
