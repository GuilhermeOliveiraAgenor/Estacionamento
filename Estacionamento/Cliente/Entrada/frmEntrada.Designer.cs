
namespace Estacionamento.Entrada
{
    partial class frmEntrada
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
            this.components = new System.ComponentModel.Container();
            this.btnPesquisarcodigo = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.btnCancelarfuncionario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodigocarro = new System.Windows.Forms.Label();
            this.lblPatio = new System.Windows.Forms.Label();
            this.lblCodigodocliente = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbcodigoVeiculo = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmbPatio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatio2 = new System.Windows.Forms.Label();
            this.lblPatio1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarcodigo
            // 
            this.btnPesquisarcodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarcodigo.Location = new System.Drawing.Point(1138, 51);
            this.btnPesquisarcodigo.Name = "btnPesquisarcodigo";
            this.btnPesquisarcodigo.Size = new System.Drawing.Size(97, 38);
            this.btnPesquisarcodigo.TabIndex = 190;
            this.btnPesquisarcodigo.Text = "Pesquisar";
            this.btnPesquisarcodigo.UseVisualStyleBackColor = true;
            this.btnPesquisarcodigo.Click += new System.EventHandler(this.btnPesquisarcodigo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(1010, 58);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(118, 20);
            this.txtPesquisar.TabIndex = 189;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(945, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(26, 19);
            this.lblNome.TabIndex = 191;
            this.lblNome.Text = "Cpf";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(790, 755);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 22);
            this.dtpData.TabIndex = 185;
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AllowUserToDeleteRows = false;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(738, 153);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.Size = new System.Drawing.Size(939, 361);
            this.dgvCadastro.TabIndex = 182;
            // 
            // btnCancelarfuncionario
            // 
            this.btnCancelarfuncionario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarfuncionario.Location = new System.Drawing.Point(1068, 657);
            this.btnCancelarfuncionario.Name = "btnCancelarfuncionario";
            this.btnCancelarfuncionario.Size = new System.Drawing.Size(107, 47);
            this.btnCancelarfuncionario.TabIndex = 181;
            this.btnCancelarfuncionario.Text = "Cancelar";
            this.btnCancelarfuncionario.UseVisualStyleBackColor = true;
            this.btnCancelarfuncionario.Click += new System.EventHandler(this.btnCancelarfuncionario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1189, 657);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 47);
            this.btnSair.TabIndex = 180;
            this.btnSair.Text = "Sair para o menu";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(385, 449);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(80, 35);
            this.btnGravar.TabIndex = 179;
            this.btnGravar.Text = " Entrada";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(482, 449);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 35);
            this.btnVoltar.TabIndex = 178;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodigocarro
            // 
            this.lblCodigocarro.AutoSize = true;
            this.lblCodigocarro.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigocarro.Location = new System.Drawing.Point(279, 302);
            this.lblCodigocarro.Name = "lblCodigocarro";
            this.lblCodigocarro.Size = new System.Drawing.Size(40, 19);
            this.lblCodigocarro.TabIndex = 176;
            this.lblCodigocarro.Text = "Placa";
            // 
            // lblPatio
            // 
            this.lblPatio.AutoSize = true;
            this.lblPatio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio.Location = new System.Drawing.Point(293, 246);
            this.lblPatio.Name = "lblPatio";
            this.lblPatio.Size = new System.Drawing.Size(36, 19);
            this.lblPatio.TabIndex = 175;
            this.lblPatio.Text = "Patio";
            // 
            // lblCodigodocliente
            // 
            this.lblCodigodocliente.AutoSize = true;
            this.lblCodigodocliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigodocliente.Location = new System.Drawing.Point(429, 188);
            this.lblCodigodocliente.Name = "lblCodigodocliente";
            this.lblCodigodocliente.Size = new System.Drawing.Size(0, 19);
            this.lblCodigodocliente.TabIndex = 174;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(785, 723);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 29);
            this.lblHora.TabIndex = 199;
            // 
            // cmbcodigoVeiculo
            // 
            this.cmbcodigoVeiculo.FormattingEnabled = true;
            this.cmbcodigoVeiculo.Location = new System.Drawing.Point(422, 300);
            this.cmbcodigoVeiculo.Name = "cmbcodigoVeiculo";
            this.cmbcodigoVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbcodigoVeiculo.TabIndex = 200;
            this.cmbcodigoVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbcodigoVeiculo_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(293, 188);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(26, 19);
            this.lblCodigo.TabIndex = 202;
            this.lblCodigo.Text = "Cpf";
            // 
            // cmbPatio
            // 
            this.cmbPatio.FormattingEnabled = true;
            this.cmbPatio.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPatio.Location = new System.Drawing.Point(422, 248);
            this.cmbPatio.Name = "cmbPatio";
            this.cmbPatio.Size = new System.Drawing.Size(121, 21);
            this.cmbPatio.TabIndex = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 204;
            this.label1.Text = "Patio 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 205;
            this.label2.Text = "Patio 2";
            // 
            // lblPatio2
            // 
            this.lblPatio2.AutoSize = true;
            this.lblPatio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio2.Location = new System.Drawing.Point(785, 628);
            this.lblPatio2.Name = "lblPatio2";
            this.lblPatio2.Size = new System.Drawing.Size(0, 24);
            this.lblPatio2.TabIndex = 206;
            // 
            // lblPatio1
            // 
            this.lblPatio1.AutoSize = true;
            this.lblPatio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio1.Location = new System.Drawing.Point(785, 592);
            this.lblPatio1.Name = "lblPatio1";
            this.lblPatio1.Size = new System.Drawing.Size(0, 24);
            this.lblPatio1.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 208;
            this.label3.Text = "Vagas disponiveis";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPatio1);
            this.Controls.Add(this.lblPatio2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPatio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cmbcodigoVeiculo);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnPesquisarcodigo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.btnCancelarfuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCodigocarro);
            this.Controls.Add(this.lblPatio);
            this.Controls.Add(this.lblCodigodocliente);
            this.Name = "frmEntrada";
            this.Text = "frmEntrada";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.DoubleClick += new System.EventHandler(this.frmEntrada_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisarcodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Button btnCancelarfuncionario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodigocarro;
        private System.Windows.Forms.Label lblPatio;
        private System.Windows.Forms.Label lblCodigodocliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbcodigoVeiculo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbPatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatio2;
        private System.Windows.Forms.Label lblPatio1;
        private System.Windows.Forms.Label label3;
    }
}