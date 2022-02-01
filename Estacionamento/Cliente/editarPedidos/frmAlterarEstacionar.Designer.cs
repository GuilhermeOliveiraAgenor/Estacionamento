
namespace Estacionamento.editarPedidos
{
    partial class frmAlterarEstacionar
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatio1 = new System.Windows.Forms.Label();
            this.lblPatio2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPatio = new System.Windows.Forms.ComboBox();
            this.btnPesquisarcodigo = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvEstacionar = new System.Windows.Forms.DataGridView();
            this.btnCancelarfuncionario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodigocarro = new System.Windows.Forms.Label();
            this.lblPatio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 227;
            this.label3.Text = "Vagas disponiveis";
            // 
            // lblPatio1
            // 
            this.lblPatio1.AutoSize = true;
            this.lblPatio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio1.Location = new System.Drawing.Point(691, 586);
            this.lblPatio1.Name = "lblPatio1";
            this.lblPatio1.Size = new System.Drawing.Size(0, 24);
            this.lblPatio1.TabIndex = 226;
            // 
            // lblPatio2
            // 
            this.lblPatio2.AutoSize = true;
            this.lblPatio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio2.Location = new System.Drawing.Point(691, 622);
            this.lblPatio2.Name = "lblPatio2";
            this.lblPatio2.Size = new System.Drawing.Size(0, 24);
            this.lblPatio2.TabIndex = 225;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 224;
            this.label2.Text = "Patio 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 223;
            this.label1.Text = "Patio 1";
            // 
            // cmbPatio
            // 
            this.cmbPatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatio.FormattingEnabled = true;
            this.cmbPatio.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPatio.Location = new System.Drawing.Point(326, 304);
            this.cmbPatio.Name = "cmbPatio";
            this.cmbPatio.Size = new System.Drawing.Size(121, 21);
            this.cmbPatio.TabIndex = 222;
            // 
            // btnPesquisarcodigo
            // 
            this.btnPesquisarcodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarcodigo.Location = new System.Drawing.Point(1686, 58);
            this.btnPesquisarcodigo.Name = "btnPesquisarcodigo";
            this.btnPesquisarcodigo.Size = new System.Drawing.Size(97, 38);
            this.btnPesquisarcodigo.TabIndex = 218;
            this.btnPesquisarcodigo.Text = "Pesquisar";
            this.btnPesquisarcodigo.UseVisualStyleBackColor = true;
            this.btnPesquisarcodigo.Click += new System.EventHandler(this.btnPesquisarcodigo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(1558, 65);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(118, 20);
            this.txtPesquisar.TabIndex = 217;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(1493, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(26, 19);
            this.lblNome.TabIndex = 219;
            this.lblNome.Text = "Cpf";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // dgvEstacionar
            // 
            this.dgvEstacionar.AllowUserToAddRows = false;
            this.dgvEstacionar.AllowUserToDeleteRows = false;
            this.dgvEstacionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionar.Location = new System.Drawing.Point(644, 147);
            this.dgvEstacionar.Name = "dgvEstacionar";
            this.dgvEstacionar.ReadOnly = true;
            this.dgvEstacionar.Size = new System.Drawing.Size(939, 361);
            this.dgvEstacionar.TabIndex = 216;
            // 
            // btnCancelarfuncionario
            // 
            this.btnCancelarfuncionario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarfuncionario.Location = new System.Drawing.Point(974, 651);
            this.btnCancelarfuncionario.Name = "btnCancelarfuncionario";
            this.btnCancelarfuncionario.Size = new System.Drawing.Size(107, 47);
            this.btnCancelarfuncionario.TabIndex = 215;
            this.btnCancelarfuncionario.Text = "Cancelar";
            this.btnCancelarfuncionario.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1095, 651);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 47);
            this.btnSair.TabIndex = 214;
            this.btnSair.Text = "Sair para o menu";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(172, 559);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 35);
            this.btnAlterar.TabIndex = 213;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(480, 559);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 35);
            this.btnVoltar.TabIndex = 212;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodigocarro
            // 
            this.lblCodigocarro.AutoSize = true;
            this.lblCodigocarro.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigocarro.Location = new System.Drawing.Point(238, 356);
            this.lblCodigocarro.Name = "lblCodigocarro";
            this.lblCodigocarro.Size = new System.Drawing.Size(40, 19);
            this.lblCodigocarro.TabIndex = 211;
            this.lblCodigocarro.Text = "Placa";
            // 
            // lblPatio
            // 
            this.lblPatio.AutoSize = true;
            this.lblPatio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio.Location = new System.Drawing.Point(252, 300);
            this.lblPatio.Name = "lblPatio";
            this.lblPatio.Size = new System.Drawing.Size(36, 19);
            this.lblPatio.TabIndex = 210;
            this.lblPatio.Text = "Patio";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(383, 248);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 19);
            this.lblData.TabIndex = 232;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(383, 186);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 19);
            this.lblHora.TabIndex = 231;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(272, 559);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 35);
            this.btnExcluir.TabIndex = 233;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(377, 559);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(83, 35);
            this.btnGravar.TabIndex = 234;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(326, 358);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaca.TabIndex = 235;
            this.cmbPlaca.SelectedIndexChanged += new System.EventHandler(this.cmbPlaca_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessaoToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 236;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessaoToolStripMenuItem
            // 
            this.sessaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.sessaoToolStripMenuItem.Name = "sessaoToolStripMenuItem";
            this.sessaoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sessaoToolStripMenuItem.Text = "Sessao";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click_1);
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saídaToolStripMenuItem.Text = "Saída";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.saídaToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editarToolStripMenuItem.Text = "Alterar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veiculoToolStripMenuItem});
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click_1);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click_1);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click_1);
            // 
            // frmAlterarEstacionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPatio1);
            this.Controls.Add(this.lblPatio2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPatio);
            this.Controls.Add(this.btnPesquisarcodigo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvEstacionar);
            this.Controls.Add(this.btnCancelarfuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCodigocarro);
            this.Controls.Add(this.lblPatio);
            this.Name = "frmAlterarEstacionar";
            this.Text = "frmAlterarEstacionar";
            this.Load += new System.EventHandler(this.frmAlterarEstacionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatio1;
        private System.Windows.Forms.Label lblPatio2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPatio;
        private System.Windows.Forms.Button btnPesquisarcodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvEstacionar;
        private System.Windows.Forms.Button btnCancelarfuncionario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodigocarro;
        private System.Windows.Forms.Label lblPatio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sessaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}