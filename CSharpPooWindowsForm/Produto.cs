using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO
{
    public class Produto
    {
        private int codigo;
        public int _codigo { get => codigo; set => codigo = value; }

        private string nome;
        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private decimal preco_compra;
        public decimal _preco_compra
        {
            get { return preco_compra; }
            set { preco_compra = value; }
        }
        
        private decimal preco_venda;
        public decimal _preco_venda
        {
            get { return preco_venda; }
            set { preco_venda = value; }
        }
        
        private int quantidade_estoque;
        public int _quantidade_estoque
        {
            get{ return quantidade_estoque; }
            set { quantidade_estoque = value; }
        }

        private bool ativo;
        public bool _ativo
        {
            get {return ativo; }
            set { ativo = value; }
        }

        private DateTime data_cadastro;
        public DateTime _data_cadastro
        {
            get{ return data_cadastro; }
            set { data_cadastro = value; }
        }

/*
        public int inserir(Produto objNovoProduto)
        {
            //**Codigo para inserir um novo produto***

            return 20;
        }

        public bool alterar(Produto objAlterarProduto)
        {
            //**Código para alterar um produto***
            if(true)//Um teste verificando se o produto foi utilizado
            {
                //Returna "true" se obtiver sucesso na alteração
                return true;
            }
            else
            {
                //Retorna "false" se não obtiver sucesso na alteração
                return false;
            }
        }

        public void excluir(int codExcluirProduto)
        {
            //***Realiza a exclusão do produto***
        }

        public List<produto> pesquisar(int codProduto, string nomeProduto)
        {
            List<Produto> listaProdutoRetorno = new List<Produto>();

            if(CodProduto > 0)
            {
                //***Pesquisa produto pelo código***
                return ListaProdutoRetorno;
            }
            else
            {
                //***Pesquisa produto pelo nome***
                return ListaProdutoRetorno;
            }
        }*/
    }
}
