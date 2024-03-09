namespace ConFin.View
{
    partial class FrmContaAltera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContaAltera));
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.edtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVecimento = new System.Windows.Forms.Label();
            this.edtDataVecimento = new System.Windows.Forms.MaskedTextBox();
            this.edtValor = new System.Windows.Forms.TextBox();
            this.edtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.edtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPessoa
            // 
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(24, 190);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(414, 21);
            this.cbPessoa.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(327, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(201, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(21, 170);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(55, 17);
            this.lblPessoa.TabIndex = 29;
            this.lblPessoa.Text = "Pessoa";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(457, 114);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(63, 17);
            this.lblSituacao.TabIndex = 28;
            this.lblSituacao.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Aberta",
            "Paga"});
            this.cbSituacao.Location = new System.Drawing.Point(460, 133);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(128, 21);
            this.cbSituacao.TabIndex = 27;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(300, 114);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "À Pagar",
            "À Receber"});
            this.cbTipo.Location = new System.Drawing.Point(303, 133);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(129, 21);
            this.cbTipo.TabIndex = 25;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPagamento.Location = new System.Drawing.Point(162, 114);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(114, 17);
            this.lblDataPagamento.TabIndex = 24;
            this.lblDataPagamento.Text = "Data Pagamento";
            // 
            // edtDataPagamento
            // 
            this.edtDataPagamento.Location = new System.Drawing.Point(165, 134);
            this.edtDataPagamento.Mask = "00/00/0000";
            this.edtDataPagamento.Name = "edtDataPagamento";
            this.edtDataPagamento.Size = new System.Drawing.Size(111, 20);
            this.edtDataPagamento.TabIndex = 23;
            this.edtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataVecimento
            // 
            this.lblDataVecimento.AutoSize = true;
            this.lblDataVecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVecimento.Location = new System.Drawing.Point(21, 114);
            this.lblDataVecimento.Name = "lblDataVecimento";
            this.lblDataVecimento.Size = new System.Drawing.Size(116, 17);
            this.lblDataVecimento.TabIndex = 22;
            this.lblDataVecimento.Text = "Data Vencimento";
            // 
            // edtDataVecimento
            // 
            this.edtDataVecimento.Location = new System.Drawing.Point(24, 134);
            this.edtDataVecimento.Mask = "00/00/0000";
            this.edtDataVecimento.Name = "edtDataVecimento";
            this.edtDataVecimento.Size = new System.Drawing.Size(113, 20);
            this.edtDataVecimento.TabIndex = 21;
            this.edtDataVecimento.ValidatingType = typeof(System.DateTime);
            // 
            // edtValor
            // 
            this.edtValor.Location = new System.Drawing.Point(403, 84);
            this.edtValor.Name = "edtValor";
            this.edtValor.Size = new System.Drawing.Size(117, 20);
            this.edtValor.TabIndex = 20;
            // 
            // edtDescricao
            // 
            this.edtDescricao.Location = new System.Drawing.Point(24, 84);
            this.edtDescricao.Name = "edtDescricao";
            this.edtDescricao.Size = new System.Drawing.Size(350, 20);
            this.edtDescricao.TabIndex = 19;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(400, 64);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(21, 64);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição";
            // 
            // edtId
            // 
            this.edtId.Location = new System.Drawing.Point(24, 29);
            this.edtId.Name = "edtId";
            this.edtId.ReadOnly = true;
            this.edtId.Size = new System.Drawing.Size(49, 20);
            this.edtId.TabIndex = 34;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(21, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 17);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Código";
            // 
            // FrmContaAltera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 302);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbPessoa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.edtDataPagamento);
            this.Controls.Add(this.lblDataVecimento);
            this.Controls.Add(this.edtDataVecimento);
            this.Controls.Add(this.edtValor);
            this.Controls.Add(this.edtDescricao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContaAltera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.MaskedTextBox edtDataPagamento;
        private System.Windows.Forms.Label lblDataVecimento;
        private System.Windows.Forms.MaskedTextBox edtDataVecimento;
        private System.Windows.Forms.TextBox edtValor;
        private System.Windows.Forms.TextBox edtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Label lblId;
    }
}