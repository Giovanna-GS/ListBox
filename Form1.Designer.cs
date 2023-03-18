namespace ListBox
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnimais = new System.Windows.Forms.Label();
            this.cmbAnimais = new System.Windows.Forms.ComboBox();
            this.btnGeraNovaLista = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemoverSelect = new System.Windows.Forms.Button();
            this.btnDesselecionar = new System.Windows.Forms.Button();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.pnlNumeros = new System.Windows.Forms.Panel();
            this.btnLimparNum = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.pnlNumeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimais.Location = new System.Drawing.Point(12, 21);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(238, 16);
            this.lblAnimais.TabIndex = 0;
            this.lblAnimais.Text = "Selecionar itens para adicionar na lista";
            // 
            // cmbAnimais
            // 
            this.cmbAnimais.FormattingEnabled = true;
            this.cmbAnimais.Location = new System.Drawing.Point(33, 51);
            this.cmbAnimais.Name = "cmbAnimais";
            this.cmbAnimais.Size = new System.Drawing.Size(185, 21);
            this.cmbAnimais.TabIndex = 1;
            this.cmbAnimais.SelectedIndexChanged += new System.EventHandler(this.cmbAnimais_SelectedIndexChanged);
            // 
            // btnGeraNovaLista
            // 
            this.btnGeraNovaLista.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGeraNovaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraNovaLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeraNovaLista.Location = new System.Drawing.Point(67, 78);
            this.btnGeraNovaLista.Name = "btnGeraNovaLista";
            this.btnGeraNovaLista.Size = new System.Drawing.Size(114, 49);
            this.btnGeraNovaLista.TabIndex = 2;
            this.btnGeraNovaLista.Text = "Gerar nova listagem";
            this.btnGeraNovaLista.UseVisualStyleBackColor = false;
            this.btnGeraNovaLista.Click += new System.EventHandler(this.btnGeraNovaLista_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(33, 201);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(185, 20);
            this.txtItem.TabIndex = 3;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(67, 241);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 50);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Adicionar Novo Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNovaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovaLista.Location = new System.Drawing.Point(67, 133);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(114, 53);
            this.btnNovaLista.TabIndex = 5;
            this.btnNovaLista.Text = "Gerar Alimentos";
            this.btnNovaLista.UseVisualStyleBackColor = false;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.Location = new System.Drawing.Point(255, 21);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAnimais.Size = new System.Drawing.Size(225, 446);
            this.lstAnimais.TabIndex = 6;
            this.lstAnimais.SelectedIndexChanged += new System.EventHandler(this.lstAnimais_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DeepPink;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(510, 36);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 48);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemoverSelect
            // 
            this.btnRemoverSelect.BackColor = System.Drawing.Color.DeepPink;
            this.btnRemoverSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverSelect.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnRemoverSelect.Location = new System.Drawing.Point(510, 90);
            this.btnRemoverSelect.Name = "btnRemoverSelect";
            this.btnRemoverSelect.Size = new System.Drawing.Size(106, 62);
            this.btnRemoverSelect.TabIndex = 8;
            this.btnRemoverSelect.Text = "Remover Selecionados";
            this.btnRemoverSelect.UseVisualStyleBackColor = false;
            this.btnRemoverSelect.Click += new System.EventHandler(this.btnRemoverSelect_Click);
            // 
            // btnDesselecionar
            // 
            this.btnDesselecionar.BackColor = System.Drawing.Color.DeepPink;
            this.btnDesselecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesselecionar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDesselecionar.Location = new System.Drawing.Point(510, 158);
            this.btnDesselecionar.Name = "btnDesselecionar";
            this.btnDesselecionar.Size = new System.Drawing.Size(106, 64);
            this.btnDesselecionar.TabIndex = 9;
            this.btnDesselecionar.Text = "Desselecionar item";
            this.btnDesselecionar.UseVisualStyleBackColor = false;
            this.btnDesselecionar.Click += new System.EventHandler(this.btnDesselecionar_Click);
            // 
            // btnClassificar
            // 
            this.btnClassificar.BackColor = System.Drawing.Color.DeepPink;
            this.btnClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassificar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnClassificar.Location = new System.Drawing.Point(510, 228);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(106, 66);
            this.btnClassificar.TabIndex = 10;
            this.btnClassificar.Text = "Classificar Lista";
            this.btnClassificar.UseVisualStyleBackColor = false;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.BackColor = System.Drawing.Color.DeepPink;
            this.btnSelecionarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarTudo.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSelecionarTudo.Location = new System.Drawing.Point(510, 300);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(106, 54);
            this.btnSelecionarTudo.TabIndex = 11;
            this.btnSelecionarTudo.Text = "Selecionar Tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = false;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // pnlNumeros
            // 
            this.pnlNumeros.Controls.Add(this.btnLimparNum);
            this.pnlNumeros.Controls.Add(this.lstNumeros);
            this.pnlNumeros.Controls.Add(this.btnNumeros);
            this.pnlNumeros.Controls.Add(this.txtNumeros);
            this.pnlNumeros.Controls.Add(this.lblNumeros);
            this.pnlNumeros.ForeColor = System.Drawing.Color.Crimson;
            this.pnlNumeros.Location = new System.Drawing.Point(633, 21);
            this.pnlNumeros.Name = "pnlNumeros";
            this.pnlNumeros.Size = new System.Drawing.Size(225, 475);
            this.pnlNumeros.TabIndex = 12;
            // 
            // btnLimparNum
            // 
            this.btnLimparNum.BackColor = System.Drawing.Color.PowderBlue;
            this.btnLimparNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparNum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLimparNum.Location = new System.Drawing.Point(66, 405);
            this.btnLimparNum.Name = "btnLimparNum";
            this.btnLimparNum.Size = new System.Drawing.Size(107, 56);
            this.btnLimparNum.TabIndex = 4;
            this.btnLimparNum.Text = "Limpar Números";
            this.btnLimparNum.UseVisualStyleBackColor = false;
            this.btnLimparNum.Click += new System.EventHandler(this.btnLimparNum_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(28, 122);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(173, 277);
            this.lstNumeros.TabIndex = 3;
            // 
            // btnNumeros
            // 
            this.btnNumeros.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumeros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNumeros.Location = new System.Drawing.Point(53, 58);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(124, 47);
            this.btnNumeros.TabIndex = 2;
            this.btnNumeros.Text = "GerarNumero";
            this.btnNumeros.UseVisualStyleBackColor = false;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(28, 31);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(173, 20);
            this.txtNumeros.TabIndex = 1;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeros.Location = new System.Drawing.Point(67, 13);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(106, 15);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Digite um número";
            this.lblNumeros.Click += new System.EventHandler(this.lblNumeros_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(937, 528);
            this.Controls.Add(this.pnlNumeros);
            this.Controls.Add(this.btnSelecionarTudo);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.btnDesselecionar);
            this.Controls.Add(this.btnRemoverSelect);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstAnimais);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnGeraNovaLista);
            this.Controls.Add(this.cmbAnimais);
            this.Controls.Add(this.lblAnimais);
            this.Name = "JanelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.pnlNumeros.ResumeLayout(false);
            this.pnlNumeros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimais;
        private System.Windows.Forms.ComboBox cmbAnimais;
        private System.Windows.Forms.Button btnGeraNovaLista;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.ListBox lstAnimais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemoverSelect;
        private System.Windows.Forms.Button btnDesselecionar;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.Panel pnlNumeros;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnLimparNum;
    }
}

