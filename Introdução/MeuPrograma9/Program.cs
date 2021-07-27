using System;

//Nullable Types
namespace MeuPrograma9
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 10;

            if(x != null){
                Console.WriteLine("Valor da variável é: "+x);
            }else{
                Console.WriteLine("Variável é Null!");
            }

            //Operador ternário
            Console.WriteLine("O valor do X é: "+((x != null ) ? "um inteiro" : "nulo"));
            
        }
    }
}
