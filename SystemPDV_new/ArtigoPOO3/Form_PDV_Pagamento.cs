using System;
using System.Windows.Forms;

namespace ArtigoPOO3
{
    public partial class Form_PDV_Pagamento : Form1
    {
        PDV_Pagamento objPdvPagamento;

        public Form_PDV_Pagamento()
        {
            InitializeComponent();
        }

        private void Form_PDV_Pagamento_Load(object sender, EventArgs e)
        {
            //Cria a instância do PDV
            objPdvPagamento = new PDV_Pagamento(10, "DEVMEDIA", "Manhã");

            //Seta valores para a abertura do caixa
            objPdvPagamento.status_PDV = true;
            objPdvPagamento.valor_dinheiro_abertura = 100;
            objPdvPagamento.data_hora_abertura = DateTime.Now;

            //Mostra o nome do usuário do PDV no from
            lblInformacoesCaixa.Text = "Usuário: " + objPdvPagamento.getNomeUsuarioCaixa();
        }

        private void btnRealizarPagamento_Click(object sender, EventArgs e)
        {
            double valorPagamento = double.Parse(txtValorPagamento.Text);
            double valorDinheiroRecebido = double.Parse(txtDinheiroRecebido.Text);

            double trocoCliente = objPdvPagamento.pagarConta(valorPagamento, valorDinheiroRecebido);

            MessageBox.Show("O troco do cliente é: " + trocoCliente);
        }
    }
}