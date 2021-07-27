using System;

namespace MeuPrograma10
{
    //Operador de Atribuição
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 21;
            bool maiorIdade = (idade > 18) ? true : false;

            Console.WriteLine("\n"+ idade +"\n");
            Console.WriteLine(maiorIdade);

            Console.ReadKey();

            int _a = 10;
            int _b = _a;

            Console.WriteLine("Valor A: "+ _a + " Valor B: " + _b);

            //Operadores Aritméticos 
            int a = 5, b = 10, c = 15, d = 20; // declaramos quatro variáveis do tipo int
            Console.WriteLine(a + d); // operação de soma
            Console.WriteLine(c - a); // operação de subtração
            Console.WriteLine(b * c); // operação de multiplicação
            Console.WriteLine(d / b); // operação de divisão
            Console.WriteLine(c % b); // operação de módulo (resto de divisão)
            Console.ReadKey();

            //Ordem de operações matemáticas
            int __a = 5, __b = 10, __c = 15;
            Console.WriteLine(__a + __b * __c); // a operação de multiplicação será executada primeiro
            Console.WriteLine((__a + __b) * __c); // a operação de soma será executada primeiro porque está entre parênteses
            Console.ReadKey();

            //Operadores Aritméticos de Atribuição Reduzida
            int x = 5;            
            x += 5; // é a mesma coisa que x = x + 5
            Console.WriteLine("Valor do x = " + x);
            Console.ReadKey();
        }
    }
}
