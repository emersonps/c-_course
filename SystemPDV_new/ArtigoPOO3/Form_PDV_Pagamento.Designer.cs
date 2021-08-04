
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
            this.lblInformacoesCaixa = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.txtDinheiroRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRealizarPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacoesCaixa
            // 
            this.lblInformacoesCaixa.AutoSize = true;
            this.lblInformacoesCaixa.Location = new System.Drawing.Point(364, 328);
            this.lblInformacoesCaixa.Name = "lblInformacoesCaixa";
            this.lblInformacoesCaixa.Size = new System.Drawing.Size(46, 15);
            this.lblInformacoesCaixa.TabIndex = 0;
            this.lblInformacoesCaixa.Text = "TROCO";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Location = new System.Drawing.Point(194, 133);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(216, 23);
            this.txtValorPagamento.TabIndex = 1;
            // 
            // txtDinheiroRecebido
            // 
            this.txtDinheiroRecebido.Location = new System.Drawing.Point(194, 205);
            this.txtDinheiroRecebido.Name = "txtDinheiroRecebido";
            this.txtDinheiroRecebido.Size = new System.Drawing.Size(216, 23);
            this.txtDinheiroRecebido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dinheiro Recebido";
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Location = new System.Drawing.Point(279, 259);
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.Size = new System.Drawing.Size(131, 49);
            this.btnRealizarPagamento.TabIndex = 5;
            this.btnRealizarPagamento.Text = "Realizar Pagamento";
            this.btnRealizarPagamento.UseVisualStyleBackColor = true;
            // 
            // Form_PDV_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btnRealizarPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDinheiroRecebido);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.lblInformacoesCaixa);
            this.Name = "Form_PDV_Pagamento";
            this.Text = "Form_PDV_Pagamento";
            this.Load += new System.EventHandler(this.Form_PDV_Pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacoesCaixa;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.TextBox txtDinheiroRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRealizarPagamento;
    }
}