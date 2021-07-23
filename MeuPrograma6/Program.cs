using System;

//ConversionImplicitaReferenceType
namespace MeuPrograma6
{        class Humano{
            public string braco = "2";
            public string perna = "2";
        }

        class Feminino : Humano{
            public string sexo = "F"; 
        }

        class Masculino : Humano{
            public string sexo = "M"; 
        }

    class Program
    {
        static void Main(string[] args)
        {
            //ConversionTypeSafe - Explícita
            sbyte a = 10;
            short b = a;
            int c = b;
            long d = c;
            float e = d;
            double f = e;


            Masculino Robson = new Masculino();
            Humano humano = Robson;

            Console.Write("Valor: "+f+" ");

            Console.WriteLine("Sexo: "+Robson.sexo);
            
            //Converção implícita do valor do tipo char 'X'
            int codigo = 'X'; //Exibe o código ASCII do caractere X
            //int codigo = "X"; //Exibe erro

            Console.WriteLine("Código: "+codigo);

            var _div = 15/2;
            Console.WriteLine("Resultado: "+ _div);

            var __div = 15.5/2.5;
            Console.WriteLine("Resultado: "+ __div);

            var _x = 5;
            var _y = 5.5;

            Console.WriteLine("Resultado _x: "+_x);
            Console.WriteLine("Resultado _y: "+_y);
        }
    }
}
