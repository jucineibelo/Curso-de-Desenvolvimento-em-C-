namespace ConFin.View
{
    partial class frmContaNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaNova));
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.edtDescricao = new System.Windows.Forms.TextBox();
            this.edtValor = new System.Windows.Forms.TextBox();
            this.edtDataVecimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVecimento = new System.Windows.Forms.Label();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.edtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(40, 39);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(419, 39);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // edtDescricao
            // 
            this.edtDescricao.Location = new System.Drawing.Point(43, 59);
            this.edtDescricao.Name = "edtDescricao";
            this.edtDescricao.Size = new System.Drawing.Size(350, 20);
            this.edtDescricao.TabIndex = 2;
            // 
            // edtValor
            // 
            this.edtValor.Location = new System.Drawing.Point(422, 59);
            this.edtValor.Name = "edtValor";
            this.edtValor.Size = new System.Drawing.Size(117, 20);
            this.edtValor.TabIndex = 3;
            // 
            // edtDataVecimento
            // 
            this.edtDataVecimento.Location = new System.Drawing.Point(43, 120);
            this.edtDataVecimento.Mask = "00/00/0000";
            this.edtDataVecimento.Name = "edtDataVecimento";
            this.edtDataVecimento.Size = new System.Drawing.Size(113, 20);
            this.edtDataVecimento.TabIndex = 4;
            this.edtDataVecimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataVecimento
            // 
            this.lblDataVecimento.AutoSize = true;
            this.lblDataVecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVecimento.Location = new System.Drawing.Point(40, 100);
            this.lblDataVecimento.Name = "lblDataVecimento";
            this.lblDataVecimento.Size = new System.Drawing.Size(116, 17);
            this.lblDataVecimento.TabIndex = 5;
            this.lblDataVecimento.Text = "Data Vencimento";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPagamento.Location = new System.Drawing.Point(181, 100);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(114, 17);
            this.lblDataPagamento.TabIndex = 7;
            this.lblDataPagamento.Text = "Data Pagamento";
            // 
            // edtDataPagamento
            // 
            this.edtDataPagamento.Location = new System.Drawing.Point(184, 120);
            this.edtDataPagamento.Mask = "00/00/0000";
            this.edtDataPagamento.Name = "edtDataPagamento";
            this.edtDataPagamento.Size = new System.Drawing.Size(111, 20);
            this.edtDataPagamento.TabIndex = 6;
            this.edtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "À Pagar",
            "À Receber"});
            this.cbTipo.Location = new System.Drawing.Point(322, 119);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(129, 21);
            this.cbTipo.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(319, 100);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(476, 100);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(63, 17);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Aberta",
            "Paga"});
            this.cbSituacao.Location = new System.Drawing.Point(479, 119);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(128, 21);
            this.cbSituacao.TabIndex = 10;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(40, 161);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(55, 17);
            this.lblPessoa.TabIndex = 12;
            this.lblPessoa.Text = "Pessoa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(220, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Location = new System.Drawing.Point(43, 181);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(414, 21);
            this.cbPessoa.TabIndex = 16;
            // 
            // frmContaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 302);
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
            this.Name = "frmContaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox edtDescricao;
        private System.Windows.Forms.TextBox edtValor;
        private System.Windows.Forms.MaskedTextBox edtDataVecimento;
        private System.Windows.Forms.Label lblDataVecimento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.MaskedTextBox edtDataPagamento;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbPessoa;
    }
}