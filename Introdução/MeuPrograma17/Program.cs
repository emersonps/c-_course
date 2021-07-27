using System;

namespace MeuPrograma17
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array1 = new int[5] {1,3,7,12,8}; //Declaração explícita
            // int[] array2 = {1,3,2,7,6}; //Declaração implícita

            // Console.WriteLine(array1+" "+array2);

            // int[] array3 = new int[10];
            // for(int i = 0; i < 10; i++){
            //     Console.WriteLine(array3[i] = i+1); 
            // }

            // int[] array3 = new int[10];
            // for(int i = 0 ; i < 10 ; i++){
            //     Console.WriteLine(array3[i] = i+1);
            // }

            // int[] array = new int[10];
            // int i = 0;
            // while(i < 10){
            //     Console.WriteLine(array[i] = i+1);
            //     i++;
            // }

            // foreach(int x in array){
            //     Console.WriteLine(x);
            // }

            //Sobrescrever valores pelo índice
            // string[] pilotos = new string[4] {"Ayrton Senna", "Michael Schumacher", "Lweis Hamilton", "Alain Post"};
            // Console.WriteLine(pilotos[3]);
            // Console.WriteLine();
            // pilotos[3] = "Rubens Barrichello";
            // foreach(string piloto in pilotos){
            //     Console.WriteLine(piloto);
            // }

            // int pontos = 0;
            // int cestas = 0;

            // while(cestas<20){
            //     cestas++;
            //     if(cestas % 3 == 0){
            //         pontos += pontos;
            //     }else{
            //         pontos++;
            //     }
            // }

            // Console.WriteLine(pontos);

            //Seu código

            // int[] titulos = {1900, 1958, 1962, 1970, 1982, 1994, 2002};

            // int i = 4; //Aqui é int i = 4

            // while(i>=0){
            //     Console.WriteLine(titulos[i]);
            //     i--;
            // }

            //Interromper quando o valor "volante" for encontrado
            // string[] lista = {"lápis", "volante", "caderno", "régua", "borracha"};
            
            // foreach(string material in lista){
            //     if(material == "volante"){
            //         break;
            //     }                
            //     Console.WriteLine(material);
            // }

            
            // int pontos = 0;
            // int cestas = 0;
            
            // while(cestas < 20){
            //     cestas++;
            //     if(cestas % 3 == 0){
            //         pontos += pontos;
            //     }else{
            //     pontos++;
            // }

            //A cada rodada um time ganha +3 pontos
            // int pontos = 20; 
            // for(int rodada = 12; rodada <= 30; rodada++){
            //     pontos += 3;
            // }
            //     Console.WriteLine(pontos);
            // }

            // int cartas = 40;
            // int jogadores = 3;

            // int cartas_por_pessoa = cartas/jogadores; //Aqui o correto é ; e não duas vezes ;;

            // int cartas_restantes = cartas%jogadores;

            // Console.WriteLine("Foi distribuído " + cartas_por_pessoa + " cartas para cada jogador.");
            // Console.WriteLine("Restaram " + cartas_restantes + " cartas no baralho.");

            // for(int x = 1 ; x<=10 ; x++){
            //     if(x % 2 == 0){
            //         continue;
            //     }
            //     Console.WriteLine(x);
            // }


            //Seu código


            // int[] grupo_a = {5, 10, 15, 20, 25};
            // int[] grupo_b = {4, 8, 12, 16, 20};

            // for (int i = 0; i < grupo_a.Length; i++){
            //     for (int j = 0; j < grupo_b.Length; j++){
            //         if(grupo_a[i] == grupo_b[j]){ //Aqui é grupo_a[i] == grupo_b[j]
            //             Console.WriteLine("O número" +grupo_a[i]+ " se encontra nos dois arrays");
            //             break; //Aqui é break;
            //         }
            //     }
            // }

            int pontos = 0;
            int cestas = 0;

            while(pontos<20){
                cestas++;
                if(cestas % 3 == 0){
                    pontos+=pontos;
                }else{
                    pontos++;
                }
            }
            Console.WriteLine(pontos);
        }
    }
}
