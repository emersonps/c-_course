using System;

namespace MeuPrograma5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Emerson ";
            char lastName = "Souza"[3];

            string completName = nome+lastName;
            Console.WriteLine("Nome: "+completName.Length);

            string[] array = {"Quadrado", "Círculo", "Triângulo", "Retângulo"};
            string forma = array[0];

            Console.WriteLine("Array: "+forma);

            string[] frutas = {"Laranja", "Pera", "Banana"};
            Console.WriteLine("Quantidade de Frutas: "+frutas.Length);

            const double medida = 10.5;
            Console.WriteLine("Média: "+medida);

            int numero_1 = 10;
            numero_1 *= ++numero_1;

            Console.WriteLine(numero_1);

            int a = 5;
            int b = 20;
            b /= a++; //4

            Console.WriteLine(a + b); //5+5

            string aa = "ASP.NET MVC";

            char bb = aa[10];
            
            Console.WriteLine(bb); //5+5

            
            double variavel_1 = 10.0;
            string variavel_2 = "10";
            int variavel_4 = 10;
            char variavel_5 = variavel_2[0];
            double variavel_6 = variavel_1 + variavel_4;

            int aaa = 30;
            int bbb = 4;
            int x = aaa / bbb;

            Console.WriteLine(x);

            string name = "Federal Bureau of Investigation";

            char primeiro_caractere = name[0];
            char segundo_caractere = name[8];
            char terceiro_caractere = name[18];

            Console.WriteLine(primeiro_caractere.ToString() + segundo_caractere.ToString() + terceiro_caractere.ToString());
        
            int biscoito = 18;
            int pessoas = 5;
            double resultado = (double) biscoito / pessoas;

            Console.WriteLine(resultado);

            int n1 = 5;
            int n2 = 10;
            n1 =n1+2;
            n2 =n2-5;

            Console.WriteLine(n1+" "+n2);

            int a1 = 10;
            int b1 = a++;
            int c1 = --b;

            Console.WriteLine("a1:{0}, b1:{1}, c1:{2}", a1, b1, c1);

            TipoPessoa pessoaTipo = TipoPessoa.Fisica;
            
            Console.WriteLine(pessoaTipo);

            int numero__1 = 5;
            int numero_2 = 10;
            numero_1 +=2;
            numero_2 -=5;

            Console.Write(numero__1+" "+numero_2);


        }
        enum TipoPessoa
        {
            Fisica,
            Juridica
        }
    }
}
