using System;

namespace MeuPrograma13
{
    //Condicional IF e ELSE
    class Program
    {
        static void Main(string[] args)
        {
            double media = 8;

            if(media >= 7){
                Console.WriteLine("Aluno Aprovado!");
            }
            else if(media < 7 && media >= 5){
                Console.WriteLine("Aluno em recuperação!");
            }
            else{
                Console.WriteLine("Aluno reprovado!");
            }

            double media1 = 8;
            string resultado = "Olá aluno, você foi ";
            resultado += media1 >= 7 ? "aprovado" : "reprovado";
            Console.WriteLine(resultado);
        }
    }
}
