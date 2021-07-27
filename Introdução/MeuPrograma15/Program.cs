using System;

namespace MeuPrograma15
{
    class Program
    {
        static void Main(string[] args)
        {
            //For
            for (int contador = 0; contador < 5; Console.WriteLine(contador), contador++){};

            //Foreach
            string[] nomes = {"André", "Bruna", "Carla", "Daniel"};
            foreach(string nome in nomes){
                Console.WriteLine(nome);
            }

            int condition = 1;
            while(condition < 10){
                if(condition == 5)
                    break;

                Console.WriteLine("Teste: "+condition);
                condition++;
            }

            //Numeros divisíveis por 2 - Que não são números pares, mas ímpares.
            int i_ = 0;
            while(i_ < 10){
                i_++;

                if(i_ % 2 == 0)
                    continue; //Volta pro inicio do while (pra próxima iteração.
                Console.WriteLine(i_);
            }    

            string[] cores = {"Azul", "Verde", "Marrom", "Laranja"};

            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            string tamanho = "G";
            double valor = 0;

            switch(tamanho){
                case "P":
                    valor  = 10.50;
                    break;
                case "M":
                    valor = 15.50;
                    break;
                case "G":
                    valor = 20.50;
                        break;
                default:
                    valor = 30.50;    
                    break;
            }
            Console.WriteLine(valor);


            // int municao = 200;
            // while (municao > 0){
            //     Console.WriteLine("Atira!");
            //     municao--;
            // }

            int[] numeros = {10, 20, 30, 40, 50};
            Console.WriteLine(numeros[numeros.Length - 1]);
            
                

            // string[] linguagens = {"C#", "Java", "PHP", "Javascript"};
            // string linguagem = linguagens[1];
            
            // switch(linguagem){
            //     case "C#":
            //     case "Java":
            //         Console.WriteLine("Linguagem Compilada");
            //         break;
            //     case "PHP":
            //     case "Javascript":
            //         Console.WriteLine("Linguagem de Script");
            //         break;
            //     }
            // }


            //Calcular pedágios e saldo
            double saldo = 25;
            double pedagio = 3.50;
            int viagens = 0;

            do{
                saldo -= pedagio;
                viagens++;
            }while(saldo>=pedagio);
            Console.WriteLine(viagens);



            //Imprimir medalhas a seus respectivos times
            string[] medalhas = {"Bronze", "Prata", "Ouro"};

            string time_a = medalhas[1];
            Console.WriteLine(time_a);
            string time_b = medalhas[2];
            Console.WriteLine(time_b);
            string time_c = medalhas[0];
            Console.WriteLine(time_c);


            Console.WriteLine("O time B recebeu a medalha de " + time_b);
            Console.WriteLine("O time A recebeu a medalha de " + time_a);
            Console.WriteLine("O time C recebeu a medalha de " + time_c);

            //Somar pontos de cestas
            int pontos = 0;
            int cestas = 0;

            while(cestas < 20){
                cestas++;
                
                if(cestas % 3 == 0){
                    pontos = 3*3;
                }else{
                    pontos++;
                }
            }

            Console.WriteLine(pontos);

            
            //Imprimir números que se encontram nos dois arrays            
            int[] grupo_a = {5, 10, 15, 20, 25};
            int[] grupo_b = {4, 8, 12, 16, 20};

            for(int i = 0; i < grupo_a.Length; i++){
                for (int j = 0; j < grupo_b.Length; j++){
                    if(grupo_a[i] == grupo_b[j]){
                        Console.WriteLine("O número" + grupo_b[i] +" se encontra nos dois arrays");
                        break;
                    }
                }
            }


            //Imprimir nome que possui menos de 6 letras
            string[] nomes_ = {"Victor", "Mateus", "Diego", "Eduardo", "Fernando"};

            foreach(string n_ in nomes_){
                if(n_.Length < 6 )
                {
                    Console.WriteLine(n_+" possui menos de 6 letras!");
                    break;
                }
            }


            //Somar todos os valores do Array
            int[] numeros_ = {1,10,15,20};
            int soma = 0;
            int x = 0;
            
            while(x < numeros_.Length){
                soma+= numeros_[x];
                x++;
            }
            Console.WriteLine(soma);


            //Imprimir cracter da palavra
            string palavras = "Janeiro";

            foreach(char caractere in palavras){
                Console.WriteLine(caractere);
            }

            //Imprimir números pares
            int[] numeros__ = {14, 65, 31, 8, 68};

            foreach(int n in numeros__){
                if(n % 2 == 0){
                    Console.WriteLine(n);
                }
            }


            //Imprimir valores do array em ordem decrescente
            int[] titulos = {1958, 1962, 1970, 1994, 2002};

            int i = titulos.Length-1;

            while(i>=0){	
                Console.WriteLine(titulos[i]);
                i--;
            }


            //Imprimir "Notebook" invertido
            string palavra = "Notebook";

            int i__ = palavra.Length - 1;
            while(i__ >= 0){
                Console.WriteLine(palavra[i__--]);
            }


            //Imprimir as letras 'P's
            string frase = "Plataforma para programadores";
            Console.WriteLine(frase[0]);
            Console.WriteLine(frase[11]);
            Console.WriteLine(frase[16]);


            //Imprimir alavras que sejam formadas por no máximo 7 letras
            string[] lista = {"celular", "notebook", "modem", "nobreak", "monitor"};
		
            foreach(string objeto in lista){
                if(objeto.Length <= 7){
                    Console.WriteLine(objeto);
                }
            }
            
            //Imprimir a ultima letra do segundo item do array palavras_
            string[] palavras_ = {"Plataforma", "Framework", "Desenvolvimento"};
            string palavra_ = palavras_[1];
            char letra = palavra[palavra_.Length-1];

            Console.WriteLine(letra);

            //Aumento de 50,00 no salário até 3 anos 
            int ano = 0;
            double salario = 1700;
            
            do{
                salario += 50*ano;
                ano++;
            }while(ano < 3);
            
            Console.WriteLine(salario);


            //Imprimir uma letra específica conformo os animais forem encontrados no array
            string[] animais = {"Tigre", "Girafa", "Vaca", "Lobo", "Leão"};

            foreach (string animal in animais){
                switch (animal){
                    case "Leão":
                    case "Lobo":
                    case "Tigre":
                        Console.WriteLine("C");
                        break;
                    case "Vaca":
                    case "Girafa":
                        Console.WriteLine("H");
                        break;
                }
            }




            int numero_1 = 10;
            int numero_2 = 4;

            TipoOperacoes operacao = TipoOperacoes.Multiplicao;

            switch(operacao)
            {
            case TipoOperacoes.Adicao :
                Console.WriteLine(numero_1 + numero_2);
                break;
            case TipoOperacoes.Subtracao:
                Console.WriteLine(numero_1 - numero_2);
                break;
            case TipoOperacoes.Multiplicao:
                Console.WriteLine(numero_1 * numero_2);
                break;
            case 
                TipoOperacoes.Divisao:
                Console.WriteLine(numero_1 / numero_2);
                break;
            }

            //Contagem regressiva
            for(int contagem = 5; contagem >= 0; contagem--)
            {
                Console.WriteLine(
                    contagem
                );
            }


            //Imprimir elementos, exceto a bola
            string[] talheres = {"garfo", "faca", "bola", "colher"};

            foreach (var talher in talheres)
            {
                if(talher == "bola")
                {
                    continue;
                }

                Console.WriteLine(talher);
            }




            //Quantas cartas foram distribuídas e quantas restaram
            int cartas = 40;
            int jogadores = 3;

            int cartas_por_pessoa = cartas/jogadores;
            int cartas_restantes = cartas % jogadores;

            Console.WriteLine("Foi distribuído " + cartas_por_pessoa + " cartas para cada jogador.");
            Console.WriteLine("Restaram " + cartas_restantes + " cartas no baralho.");


            for(int x = 1; x<10; x++){
 			if(x % 2 == 0){
				continue;
 			}
                Console.WriteLine(x);
            }
            
        }
        enum TipoOperacoes{
            Adicao
            Subtracao
            Divisao
            Multiplicacao
        }  
    }
   
}
