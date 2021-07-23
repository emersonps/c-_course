using System;

namespace MeuPrograma3
{
    class Principal
    {
        static void Main(string[] args){
            int _anoAtual = 2021;
            int _nascimento = 1982;

            Nascimento nasc = new Nascimento();
            
            nasc.setAnoNascimento(_anoAtual);
            nasc.setDtNascimento(_nascimento); 

            Console.WriteLine("Ano atual é: "+nasc.getAnoAtual() + " e o ano de Nascimento é: "+nasc.getDtNascimento()+" a idade é: "+nasc.getIdade());
        }
    }
}
