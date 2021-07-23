using System;

namespace MeuPrograma4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Pedido pedido = new Pedido();

            pedido.numero = 1;
            pedido.dataHora = DateTime.Now;
            pedido.situacao = (int) Situacao.Aberto;

            Console.WriteLine("Número do pedido: "
            + pedido.numero.ToString());
            Console.WriteLine("Data do Pedido: "
            +pedido.dataHora.ToString());
            Console.WriteLine("Situação do pedido: "
            +pedido.situacao.ToString());    

            Console.ReadLine();  
        }
        class Pedido{
            public int numero;
            public DateTime dataHora;
            public int situacao;       
        }

        enum Situacao{
            Aberto,
            Fechado,
            Cancelado
        }


        
    }
}
