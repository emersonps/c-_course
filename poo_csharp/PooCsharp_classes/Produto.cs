﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComInterface
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private decimal preco;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}