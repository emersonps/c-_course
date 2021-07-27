using System;
using System.Collections.Generic;
using System.Text;

namespace ComInterface
{
    public class Assinatura : Produto, IExpiravel
    {
        private DateTime dataExpiracao;

        public DateTime DataExpiracao { get => dataExpiracao; set => dataExpiracao = value; }

        public TimeSpan GetTempoRestante()
        {
            return dataExpiracao - DateTime.Today;
        }
    }
}