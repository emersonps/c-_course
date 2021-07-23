using System;

//Convertion Explicit TypeValue 
namespace MeuPrograma7
{
    class Humano
    {
        //Propriedades e Métodos
        public int olhos = 2;
        public int ouvido = 2;
        public int boca = 1;
    }
    class Feminino : Humano
    {
        //Propriedades e Métodos
        public string sexo = "F";
    }
    class Masculino : Humano
    {
        //Propriedades e Métodos
        public string sexo = "M";
    }

    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            short b = (short)a;
            int c = (int)b;
            long d = (long)c;
            float e = (long)d;
            double f = (float)e;
            Console.Write(f);
            Console.Read();

            Feminino Mulher = new Feminino();
            Humano SerHumano = Mulher;
            Feminino OutraMulher = (Feminino)SerHumano;
            
            Console.WriteLine("Mulher: "+OutraMulher.boca);
        }
    }
}