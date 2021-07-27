using System;

namespace MeuPrograma3
{
    class Nascimento
    {
        int _anoAtual;
        int _nascimento;
        int _idade;
        public void setAnoNascimento(int anoAtual)
        {
            _anoAtual = anoAtual;
        }

        public void setDtNascimento(int nascimento)
        {
            _nascimento = nascimento;
        }

        public int getAnoAtual(){
            return _anoAtual;
        }

        public int getDtNascimento(){
            return _nascimento;
        }

        public int getIdade(){
            _idade = _anoAtual - _nascimento;
            return _idade;
        }
    }
}
