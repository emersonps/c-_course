using System;

namespace MeuPrograma11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores incrementais e decrementais
            Console.WriteLine("Pré-incremento: \n");
            int a = 0;
            Console.WriteLine("a= "+a);
            Console.WriteLine("\n ++a + 20 = \n");
            Console.WriteLine(++a + 20 +"\n");

            Console.WriteLine("Pós-incremento: \n");
            int b = 0;
            Console.WriteLine("\n b++ +20 = \n");
            Console.WriteLine(b++ + 20 +"\n"+" B: "+b);


            Console.WriteLine("\nPré-Decremento:\n");
            int d = 0;
            Console.WriteLine("d = " + d);
            Console.WriteLine("\n--d +20 = \n");
            Console.WriteLine(--d + 20 + "\n");


            Console.WriteLine("\nPós-Decremento:\n");
            int c = 0;
            Console.WriteLine("\nc-- +20 = \n");
            Console.WriteLine(c-- + 20 + "\n" + " C: "+c);
            Console.ReadKey();
        }
    }
}
