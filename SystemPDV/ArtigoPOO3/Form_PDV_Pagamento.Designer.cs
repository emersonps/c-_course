
namespace ArtigoPOO3
{
    partial class Form_PDV_Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRealizarPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.txtDinheiroRecebido = new System.Windows.Forms.TextBox();
            this.lblInformacoesCaixa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Location = new System.Drawing.Point(101, 179);
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.Size = new System.Drawing.Size(259, 23);
            this.btnRealizarPagamento.TabIndex = 0;
            this.btnRealizarPagamento.Text = "Realizar Pagamento";
            this.btnRealizarPagamento.UseVisualStyleBackColor = true;
            this.btnRealizarPagamento.Click += new System.EventHandler(this.btnRealizarPagamento_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dinheiro Recebido:";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Location = new System.Drawing.Point(227, 51);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(124, 23);
            this.txtValorPagamento.TabIndex = 3;
            // 
            // txtDinheiroRecebido
            // 
            this.txtDinheiroRecebido.Location = new System.Drawing.Point(227, 107);
            this.txtDinheiroRecebido.Name = "txtDinheiroRecebido";
            this.txtDinheiroRecebido.Size = new System.Drawing.Size(124, 23);
            this.txtDinheiroRecebido.TabIndex = 4;
            // 
            // lblInformacoesCaixa
            // 
            this.lblInformacoesCaixa.AutoSize = true;
            this.lblInformacoesCaixa.Location = new System.Drawing.Point(207, 233);
            this.lblInformacoesCaixa.Name = "lblInformacoesCaixa";
            this.lblInformacoesCaixa.Size = new System.Drawing.Size(50, 15);
            this.lblInformacoesCaixa.TabIndex = 5;
            this.lblInformacoesCaixa.Text = "Usuário:";
            // 
            // Form_PDV_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 284);
            this.Controls.Add(this.lblInformacoesCaixa);
            this.Controls.Add(this.txtDinheiroRecebido);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRealizarPagamento);
            this.Name = "Form_PDV_Pagamento";
            this.Text = "Form_PDV_Pagamento";
            this.Load += new System.EventHandler(this.Form_PDV_Pagamento_Load);
            this.Controls.SetChildIndex(this.btnRealizarPagamento, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtValorPagamento, 0);
            this.Controls.SetChildIndex(this.txtDinheiroRecebido, 0);
            this.Controls.SetChildIndex(this.lblInformacoesCaixa, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.TextBox txtDinheiroRecebido;
        private System.Windows.Forms.Label lblInformacoesCaixa;
    }
}