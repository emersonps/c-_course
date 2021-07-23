using System;

namespace MeuPrograma2
{
    public class Principal
    {
        static void Main(string[] args)
        {            
            int v1 = 20;
            int v2 = 20;

            Calculadora calc = new Calculadora();
            calc.SetNumber1(v1);
            calc.SetNumber2(v2);

            Console.WriteLine(calc.GetNumber1()+calc.GetNumber2());
        } 
    } 
}