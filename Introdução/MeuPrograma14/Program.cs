using System;

namespace MeuPrograma14
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes = "Abril";
            switch(mes){
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine("Este mês tem 31 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Este mês tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mês tem 30 dias");
                    break;
            }

            double valor = 10%2;

            if(valor == 1)
                Console.WriteLine("Impar.");
            else if(valor > 1)
                Console.WriteLine("Valor é maior que 1.");
            else if(valor < 1)
                Console.WriteLine("Valor é menor que 1.");
            else    
                Console.WriteLine("valor é "+valor);

            int numero = 35;
            string mensagem = numero%2 == 0 ? "Par" : "Ímpar";
            Console.WriteLine(mensagem);

          
            double aluguel = 600.00;
            double condominio = 200.00;
            double comida = 150.00;
            double luz = 80.00;
            
            if( aluguel+condominio <= 700 && luz+comida < 300.00)
            {
                Console.WriteLine("Pagável");
            }
            else
            {
                Console.WriteLine("Não Pagável");
            }


            string palavra = "Lingu";

            if(palavra.Length >= 5){
                Console.WriteLine("A palavra tem pelo menos 5 letras");
            }
            else{
                Console.WriteLine("A palavra tem menos de 5 letras");
            }



            string medida = "Gramas";
            switch(medida){
                case "Gramas":
                case "Quilogramas":
                    Console.WriteLine("Medida de massa");
                    break;
                case "Centímetros":
                case "Metros":
                    Console.WriteLine("Medida de comprimento");
                    break;
                default: 
                    Console.WriteLine("Outra medida");
                    break;
            }


            int time_a = 5;
            int time_b = 4;
            if(time_a > time_b){
               Console.WriteLine("Time A é o vencedor!");
            }
            else if(time_a < time_b){
                Console.WriteLine("Time B é o vencedor!");
            }
            else{   
                Console.WriteLine("Os dois times empataram!");
            }

            string dia = "Sábado";
            switch(dia){
                case "Segunda":
                case "Quarta":
                case "Sexta":
                    Console.WriteLine("Dia de treino!");
                    break;
                default:
                    Console.WriteLine("Dia de descanso.");
                    break;
            }


            int idade = 19;
            string mensagem_1 = idade >= 18 ? "É maior de idade"  : "É menor de idade";
            Console.WriteLine(mensagem_1);

            int a = 5;
            int b = a--;
            int multiplicacao = a * b;

            if(multiplicacao > 20)
            {
                Console.WriteLine("Multiplicação é maior que 20.");
            }
            else if(multiplicacao < 20)
            {
                Console.WriteLine("Multiplicação é menor que 20.");

            }else{
                Console.WriteLine("Multiplicação é igual a 20.");
            }

            
            int temperatura = 30;
            string mensagem_2;
            mensagem_2 = temperatura > 25 ? "Quente" : "Frio";    
            Console.WriteLine(mensagem_2);


            int assentos = 40;
            int pessoas = 40;

            if(assentos > pessoas){
                Console.WriteLine("Assentos livres");
            }else{
                Console.WriteLine("Assentos ocupados");
            }

            string carro = "SemiNovo";
            int seguro = 300;

            switch(carro){
                case "Novo":
                    seguro-=20;
                    break;
                case "SemiNovo":
                    seguro+=50;
                    break;
            }


            CoresBase cor = CoresBase.Azul;
            switch(cor){
                case CoresBase.Vermelho:
                    Console.WriteLine("A cor é vermelho.");
                    break;
                case CoresBase.Verde:
                    Console.WriteLine("A cor é verde.");
                    break;
                case CoresBase.Azul:
                    Console.WriteLine("A cor é azul.");
                    break;
            }



            TipoMascote mascote = TipoMascote.Cachorro;

            switch(mascote)
            {
                case TipoMascote.Cachorro:
                    Console.WriteLine("Seu mascote é um cachorro");
                    break;
                case TipoMascote.Gato:
                    Console.WriteLine("Seu mascote é um gato");
                    break;
                case TipoMascote.Lhama:
                    Console.WriteLine("Seu mascote é uma lhama");
                    break;
            }

            string palavra_3 = "Plataforma";
            Console.WriteLine(palavra_3[8]);

           string empresa = "Sony";

            switch(empresa){
                case "Sony":
                    Console.WriteLine("PS4");
                    break;
                case "Microsoft":
                    Console.WriteLine("Xbox One X");
                    break;
                case "Nintendo":
                    Console.WriteLine("Switch");
                    break;
                default:
                    Console.WriteLine("Videogame não encontrado");
                    break;
            }
                    

            int a1 = 32, b1 = 20, c1 = 40;

            if (a1 < b1){
                Console.WriteLine("Saída A");
            }
            else if ( a1 > b1 && a1 < c1){
                Console.WriteLine("Saída B");
            }
            else if (a1 > c1){
                Console.WriteLine("Saída C");
            }
            else{
                Console.WriteLine("Saída d");
            }

            int dificuldade = 1;

            switch(dificuldade){
                case 1:
                    Console.WriteLine("Fácil");
                    break;
                case 2:
                    Console.WriteLine("Médio");
                    break;
                case 3:
                    Console.WriteLine("Difícil");
                    break;
            }

            TipoPessoa pessoa = TipoPessoa.Juridica;
            switch(pessoa){
                case TipoPessoa.Fisica:
                    Console.WriteLine("Pessoa Física");    
                    break;
                case TipoPessoa.Juridica :
                    Console.WriteLine("Pessoa Jurídica");
                    break;
            }

            bool socio = false;
            double preco = socio == true ? 8.50 : 19.50;
            Console.WriteLine(preco);



            double marca = 5;
            
            switch(marca){
                case 1:
                    Console.WriteLine("Playstation");
                    break;
                case 2:
                    Console.WriteLine("Xbox");
                    break;
                case 3:
                    Console.WriteLine("Nintendo");
                    break;
                default:
                    Console.WriteLine("Sega");
                    break;
            }
        }

        enum CoresBase
        {
            Vermelho,
            Verde,
            Azul
        }

        enum TipoMascote
        {
            Cachorro,
            Gato,
            Lhama
        }

        enum TipoPessoa
        {
            Fisica,
            Juridica
        }
    }
}
