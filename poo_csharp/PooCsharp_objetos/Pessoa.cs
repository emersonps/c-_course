using System;
using System.Collections.Generic;
using System.Text;

namespace PooCsharpIntroducao
{
    class Pessoa
    {
        public Pessoa(string cabelo) //valor obrigatório
        {
            Olhos = 2; //Valor default
            Bracos = 2;
            Pernas = 2;
            CorCabelo = cabelo;
        }

        public Pessoa() { 
        }


        public string Nome { get; set; }
        public int Olhos { get; set; } 
        public string CorCabelo { get; set; }
        public int Bracos { get; set; }
        public int Pernas { get; set; }


        /*
        public void andar(int velocidade)
        {
               //Ande um pouco
        }

        public void falar()
        {
            //Fale um pouco
        }

        public void comer(string comida)
        {
            //Alimentar-se mais
        }

        public string getNome()
        {
            return nome; //Retorna o nome da pessoa
        }

        public void setNome(string nome)
        {
            this.nome = nome; //Altera o nome da pessoa
        }*/

    }
}
