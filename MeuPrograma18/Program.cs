using System;

namespace MeuPrograma18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CRIANDO UMA STRING*/
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            
            /*ALTERANDO STRING - REPLACE()*/
            // blog = blog.Replace("Alexandre","Emerson");
            
            /*OBTEND UMA PARTE DA STRING - SUBSTRING()*/
            // blog = blog.Substring(20, blog.Length - 20);
            // Console.WriteLine(blog);

            /*OBTENDO TEXTOS SEPARADOS POR UM SEPARADOR = SPLIT()*/
            // string[] textos = blog.Split('-');
            // foreach(string t in textos){
            //     Console.WriteLine("texto: "+t);
            // }

            /*JUNTANDO UM TEXTO E SEPARANDO POR UM SINAL DE = - JOIN()*/
            // string textosComIgual = String.Join("=",textos);
            // Console.WriteLine("texto separado por um sinal de = "+textosComIgual);

            /*CONTAINER - USADO PARA COMPARAR STRINGS,RETORNANDO TRUE OU FALSE - CONTAINS()*/
            // Console.WriteLine("o texto contem a palavra Tadashi: "+blog.Contains("Tadashi"));

            /*ADICIONANDO OU REMOVENDO STRING - INSERT E REMOVE*/
            // blog = blog.Remove(18, 1);
            // Console.WriteLine("Removendo o traço através do remove: "+blog);

            // blog = blog.Insert(19, "http://");
            // Console.WriteLine("adicionado http: "+blog);

            /*STATRTWITH - LOCALIZA A PRIMEIRA PALAVRA DA STRING: 
                ENDWITH - LOCALIZA A ÚLTIMA PALAVRA DA STRING 
            - RETORNANDO TRUE OU FALSE */
            //string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            // if(blog.StartsWith("Alexandre"))
            // {
            //     Console.WriteLine("Inicia com Alexandre");
            // }
            // else
            // {
            //     Console.WriteLine("Não inicia com Alexandre");
            // }
            // if(blog.EndsWith(".net"))
            // {
            //     Console.WriteLine("Finaliza com .net");
            // }else{
            //     Console.WriteLine("Não finaliza com .net");
            // }

            /*COMPARANDO STRINGS:
            ATRIBUTO.EQUALS(string) - RETORNA TRUE OU FALSO
            STRING == STRING - APENAS QUANDO A REFERÊNCIA É REFERENTE A UM OBJETO, POIS É COMPARADO O VALOR OU A REFERÊNCIA
            COMPARETO(STRING, STRING).TOSTRING() - COMPARA SE A STRING É IGUAL, MAIOR OU MENOR QUE A OUTRA RETORNANDO UM NÚMERO:
            -> -1 SE A PRIMEIRA STRING FOR MAIOR QUE A SEGUNDA; 
            -> 0 SE AS DUAS STRINGS FOREM IGUAIS; 
            -> 1 SE A PRIMEIRA STRING FOR MAIOR QUE A SEGUNDA)
            //string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            //string blog2 = "Alexandre Tadashi - www.alexandretadashi.net";*/
            // Console.WriteLine("blog.Equals(blog2) = "+blog.Equals(blog2));
            // Console.WriteLine("blog2.Equals(blog) = "+blog2.Equals(blog));
            // Console.WriteLine("blog2 == blog) = "+(blog2 == blog).ToString());
            // Console.WriteLine("string.Compare(blog, blog2) = "+string.Compare(blog, blog2).ToString());
            // Console.WriteLine("blog.CompareTo(blog2) = "+blog.CompareTo(blog2));

            /*INDEXOF E LASTINDEXOF
            MOSTRA A PRIMEIRA E A ÚLTIMA OCORRÊNCIA DE UM CHAR ESPECÍFICO EM UMA STRING*/
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            // int IndicePrimeiro = blog.IndexOf('w');
            // int IndiceFinal = blog.LastIndexOf('w');
            // Console.WriteLine(
            //     "\nPrimeira ocorrência da letra w: "+IndicePrimeiro.ToString()+
            //     "\n\nÚltima ocorrência da letra w: "+IndiceFinal.ToString()
            // );

            /*GETTYPE E GETTYPECODE
            ESPECIFICA QUAL O TIPO DE UM DETERMINADO ELEMENTO
            RECURSO UTILIZADO QUANDO QUEREMOS SABER QUAL O TIPO, ANTES DE EFETUAR ALGUMA TAREFA
            PODEMOS SABER SE O ELEMENTO DERIVA DE ALGUMA TAREFA
            STRING.GETTYPECODE() - OBTEM O TIPO (STRING)
            STRING.GETTYPE() - OBTEMOS A CLASSE DA QUAL ELA DERIVA (SYSTEM STRING)*/
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            // string tipo = blog.GetType().ToString().ToString();
            // string codigo_tipo = blog.GetTypeCode().ToString();
            // Console.WriteLine("O tipo : "+codigo_tipo+" é = "+tipo);

            /*IsNullOrEmpty - verifica se a string está vazio ou não tem valor iniciado*/
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            // if(!String.IsNullOrEmpty(blog)){
            //     Console.WriteLine("Blog não está vazio ou nulo!");
            // }
            // blog = null;
            // if(String.IsNullOrEmpty(blog)){
            //     Console.WriteLine("blog = null");
            // }

            /*ToUpper e ToLower*/
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";

            // string maiuscula = blog.ToUpper();
            // Console.WriteLine(maiuscula+"\n");
            // string minuscula = blog.ToLower();
            // Console.WriteLine(minuscula+"\n");

            /*Trim, TrimStart. TrimEnd
            Utilizados para tirar espaços desnecessários*/
            // string blog = "        Alexandre Tadashi - www.alexandretadashi.net     ";
            // Console.WriteLine("Espaços no início e no fim: "+blog.Trim());
            // Console.WriteLine("Espaços no início: "+blog.TrimStart());
            // Console.WriteLine("Espaços no fim: "+blog.TrimEnd());
            
            /*PadLeft e PadRight
            Inserir elementos repetidas vezes em uma determinada posição */
            // string blog = "Alexandre Tadashi - www.alexandretadashi.net";
            // string acessos = "12900";
            // acessos = acessos.PadLeft(8, '0');
            // acessos = acessos.PadRight(9, 'E'+'P'+'S');

            // Console.WriteLine("Acesso do blog " + blog + " = " + acessos);

            /*EXERCICIOS
            Percorra o array utilizando um loop for enquanto 'i' for menor que o tamanho do array 'funcionarios' 
            e, utilizando um método de retorno booleano para checar, imprima apenas os nomes que tenham pelo
            menos uma letra 'e':
            */


            // int[] ilimitado = {2,4,6,8,10};

            /*Declare um array seguindo as instruções definidas na lista abaixo:
            - Criar um array do tipo inteiro com limite de 4 itens.
            - Os itens devem ser definidos no momento da declaração. São eles: 3 , 8 , 4, 7
            - o Array deve se chamar 'numerais'*/
            // int[] numerais = new int[4] {3,8,4,7};

            // int[] numeros = new int[5] {10,12,15,15,0};  

            /* Separar a string url pelos '.' e em 4 partes, por fim, imprimir apenas a palavra DEVMEDI em maiúscula */
            // string url = "www.devmedia.com.br";
            // string[] url_split = url.Split('.');
            // url = url_split[1].ToUpper();
            // Console.WriteLine(url);

            /*Observe o código abaixo e selecione a alternativa que armazena em uma variável chamada 'sobrenome' a string 'Hoppus':*/
            // string nome = "Mark Hoppus";
            // string[] nome_separado = nome.Split(' ');
            // string sobrenome = nome_separado[1];
            // Console.WriteLine(sobrenome);


            // string[] pessoas = {"Diego", "Cleber", "Fernanda", "Gustavo"};

            // foreach(string pessoa in pessoas)
            // {
            //     if(pessoa.IndexOf('a') != -1)
            //     {
            //         Console.WriteLine(pessoa);
            //     }
            // }

            /*PERCORRER O ARRAY JOGOS E IMPRIMIR APENAS OS NOMES COM O TAMANHO MENOR OU IGUAL */
            // string[] jogos = {"Jet Set Radio", "Shenmue", "Sega Rally", "Sakura Wars"};
            // foreach(string jogo in jogos){
            //     if(jogo.Length <= 10){
            //         Console.WriteLine(jogo);
            //     }
            // }

            // string pessoa = "Marcos-Santos";

            // if(pessoa.GetTypeCode().ToString().Equals("String")){
            //     pessoa = pessoa.Replace("-"," ");
            //     Console.WriteLine(pessoa);
            // }

            // string[] produtos = {"TV Samsung 2020", "iPhone 12", "Xbox Series X", "PS5"};
            
            // foreach(string produto in produtos){
            //     Console.WriteLine("Produto:"+produto);
            // }

            // int limite = 100;
            // int valor = 10; 
            // string compra = limite >= valor ? "Aprovado" : "Recusado";
            // Console.WriteLine(compra);

            // string veiculo = "Moto";
            // if(!String.IsNullOrEmpty(veiculo))
            // {
            //     if(!String.Equals(veiculo, "Carro"))
            //     {
            //         Console.WriteLine(veiculo);
            //     }
            // }
            // string[] produtos = {"Produto Galaxy S20", "Produto iPhone 12", "Produto Xbox Series X"};
            // foreach(string produto in produtos){
            //     Console.WriteLine(produto.Replace("Produto", "").Trim());
            // }

            /* REMOVENDO STRING E MANTENDO PARTE ESPECÍFICA*/
            // string dispositivo = "Smartphone Microsoft Surface Duo";
            // Console.WriteLine(dispositivo.Remove(0,21));

            // string produto = "TV Samsung RU7100 4K 2019      ";
            // produto = produto.TrimEnd();
            // Console.WriteLine(produto);

            // string[] funcionarios = {"Carlos", "Michele", "Rodolfo", "Helena", "Fernando"};
            
            // for(int i = 0; i< funcionarios.Length; i++){
            //     if(!String.IsNullOrEmpty(funcionarios[i]) && funcionarios[i].Contains('e')){
            //         Console.WriteLine(funcionarios[i]);
            //     }
            // }

            // string[] frases = {"Estes são os exercícios de C#", "Você está na plataforma DevMedia"};

            // foreach(string frase in frases)
            // {
            //     Console.WriteLine(frase.Insert(frase.Length, "."));
            // }

            // string status = "Aprovado Reprovado";
            // status = status.Insert(status.IndexOf(' '),",");
            // Console.WriteLine(status);

            // string[] votos = {"X", "Y", "X", "X", "Y" ,"X", "Y", "Y", "X", "X", "X"};

            // int votoX = 0;
            // int votoY = 0;

            // for(int i=0; i<votos.Length; i++){
            //     if(votos[i] == "X"){
            //         votoX++;
            //     }else{
            //         votoY++;
            //     }
            // }
            // Console.WriteLine("Voto X: "+votoX+"\nVoto Y: "+votoY);


            // string produto = "Celular Samsung Galaxy S20";

            // if(produto.StartsWith("Celular"))
            // {
            //     produto = produto.Replace("Celular", "Smartphone");
            // }
            // Console.WriteLine(produto);


            // int numero=2;
            // switch(numero){
            //     case 1:
            //         Console.WriteLine("Primavera");
            //         break;
            //     case 2:
            //         Console.WriteLine("Verão");
            //         break;
            //     case 3:
            //         Console.WriteLine("Outono");
            //         break;
            //     case 4:
            //         Console.WriteLine("Inverno");
            //         break;
            // }

            /*Percorra o array abaixo e imprima todos os nomes no console, verificando para que nomes que comecem com 
            a letra A tenham todas as letras maiúsculas:*/
            // string[] nomes = {"Tiago", "Juliana", "Ana Paula", "Carlos", "Amanda"};
            // for(int i = 0; i < nomes.Length ; i++){
            //     if(nomes[i].StartsWith("A")){
            //         nomes[i] = nomes[i].ToUpper();
            //     }
            //     Console.WriteLine(nomes[i]);
            // }
           
            /*Substituir '/' por '-' */
            // string data = "10/11/2020";
            // data = data.Replace("/","-");
            // Console.WriteLine(data);

            // int[] numeros = new int[5] {7,32,23,84,39};

            // foreach (var numero in numeros){
            //     Console.WriteLine(numero);
            // }

            // string pessoas = "Diego, Cleber, Fernanda , Gustavo,";
            // var index = pessoas.Remove(pessoas.LastIndexOf(','),1);
            // Console.WriteLine(index);

            // int nota1 = 7;
            // int nota2 = 8;
            // int soma = nota1+nota2;

            // if(soma >= 15){
            //     Console.WriteLine("Aprovado");
            // }else{
            //     Console.WriteLine("Reprovado");
            // }

            //REFAZER
            // string smartphone = "Samsung Galaxy S20 Ultra";
            // smartphone = smartphone.Substring(8, 10);

            // Console.WriteLine(smartphone);

            // int marcador = 140;
            // string status = marcador >= 135 ? "novo" : "antigo";
            // Console.WriteLine(status);

            //REFAZER
            // string[] nomes = new string[4] {"Mateus", "Fernando", "Diego", "Vitor"};
            // foreach(string nome in nomes){
            //     Console.WriteLine(nome);
            // }


            //    string nome = "Marcus Fenix";
            //    if(nome.Contains("Fenix")){ 
            //         Console.WriteLine(nome.ToUpper());
            //     }

            /*Qual das alternativas abaixo cria uma URL amigável separando uma string que está dividida 
            por espaço e a junta novamente utilizando "-" (traço) como separador?*/
            // string titulo = "Javascript para iniciantes";
            // Console.WriteLine(titulo_separado[1]);//pega uma palavra após ' ' e adiciona por indice

            // string titulo_amigavel = String.Join("-", titulo_separado); //junta todos os valores pelo indice  

            // Console.WriteLine(titulo_amigavel.ToLower());

            // string marcador = "1234567891";
            // if(marcador.Length < 10){
            //     marcador = marcador.PadRight(10, '0');
            // }
            // Console.WriteLine(marcador);

            // string[] favoritos = {"Xbox Series X", "PS5", "Xbox Series S", "Samsung Galaxy S20 Ultra", "iPhone 12"};

            // foreach(string favorito in favoritos){
            //     Console.WriteLine(favorito);
            // }

            // string[] funcionarios = {"Carlos", "Michele", "Rodolfo", "Helena", "Fernando"};

            // for(int i = 0; i < funcionarios.Length; i++){
            //     if(funcionarios[i].Contains("e")){
            //         Console.WriteLine(funcionarios[i]);
            //     }
            // }

            // string autor = "Makoto Shinkai";
            // string[] autor_divide = autor.Split(' ');
            // autor = autor_divide[1]+", "+autor_divide[0];
            // Console.WriteLine(autor);

            // string[] tecnologia = {"Apple", "Microsoft", "Oracle", "Amazon"};
            // Console.WriteLine(tecnologia[2]);

            // string[] novidades = {"iPhone 12", "iPhone 12 Pro", "iPhone 12 Mini", "iPhone X", "Galaxy S20 Ultra", "Surfa Duo"};
            // foreach(string novidade in novidades){ 
            //     if(novidade.Contains("iPhone 12")){
            //         Console.WriteLine(novidade.ToUpper());
            //     }else{
            //         Console.WriteLine(novidade);
            //     }
            // }

            // string[] estados = new string[2] {"Correto", "Incorreto"};
            // for(int i = 0; i < estados.Length; i++){
            //     Console.WriteLine(estados[i]);
            // }

            // string[] nomes = {"Carlos_000", "Rodrigo_001", "Marcos_002", "Paulo_000"};
            // foreach(string nome in nomes)
            // {
            //     if(!nome.EndsWith("_000"))
            //     {
            //         Console.WriteLine(nome);
            //     }
            // }
            
            // string nome = "JOSÉ";
            // string sobrenome = "santos";
            // Console.WriteLine(nome.ToLower());
            // Console.WriteLine(sobrenome.ToUpper());

            string[] nomes = new string[4]{"Mateus", "Fernando", "Diego", "Victor"};
            foreach(string nome in nomes){
                Console.WriteLine(nome);
            }
        }
    }
}
