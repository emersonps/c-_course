using System;
using System.Collections.Generic;
using System.Text;

namespace ArtigoPOO3
{
    public class PDV_Pagamento : PDV
    {
        PDV_Pagamento(int p_codigo_PDV, String p_nome_usuario_caixa, String p_turno) //classe local
            : base(p_codigo_PDV, p_nome_usuario_caixa, p_turno) //chamando a class base PDV 
        {

        }

        public double pagarConta(double valorPagamento, double valorRecebido)
        {
            double troco = (valorRecebido - valorPagamento);
            
            return troco;
        }
    }
}
