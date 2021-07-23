using System;

namespace MeuPrograma12
{
    class Program
    {
        static void Main(string[] args)
        {

            //Operadores Relacionais
            int a = 10, b = 25, c = 50, d = 100; // declaramos quatro variáveis de tipo int

            Console.WriteLine(a == d); // avaliamos a igualdade entre a e d
            Console.WriteLine(b != c);  // avaliamos a desigualdade entre b e c
            Console.WriteLine(a > b); // avaliamos se a é maior que b
            Console.WriteLine(c < d);  // avaliamos se c é menor que d
            Console.WriteLine(c >= a); // avaliamos se c é maior ou igual que a
            Console.WriteLine(d <= b); // avaliamos se d é menor ou igual que b

            Console.ReadKey();


            //Operadores Lógicos
            int _a = 5, _b = 10, _c = 15, _d = 20; // declaramos quatro variáveis do tipo int

            Console.WriteLine(_a == 5 && _d == 10); // avaliamos se a é igual a 5 e se d é igual a 10
            Console.WriteLine(_c < _b || _d == 20); // avaliamos se c é menor que b ou se d é igual a 20
            Console.WriteLine(! (_b > _a)); // negamos que b é maior que a

            Console.ReadKey();

            //Operadores Ternários
            int x = 5, y = 10; // declaradas duas variáveis de tipo int

            Console.WriteLine(x < y ? "sim" : "não"); // expressão x < y é avaliada
            // se for verdadeira exibe "sim"
            // se não for verdadeira exibe "não"
            Console.ReadKey();
        }
    }
}
