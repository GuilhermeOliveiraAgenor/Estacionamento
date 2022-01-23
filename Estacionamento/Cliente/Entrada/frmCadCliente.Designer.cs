
namespace Estacionamento.Entrada
{
    partial class frmCadCliente
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
            this.btnPesquisarnome = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisarplaca = new System.Windows.Forms.TextBox();
            this.lblPesquisacodigo = new System.Windows.Forms.Label();
            this.txtPesquisarcodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCadastro = new System.Windows.Forms.DataGridView();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnVoltaraomenu = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.dtpDatanasc = new System.Windows.Forms.DateTimePicker();
            this.lblDatanasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcodVeiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarnome
            // 
            this.btnPesquisarnome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarnome.Location = new System.Drawing.Point(1735, 128);
            this.btnPesquisarnome.Name = "btnPesquisarnome";
            this.btnPesquisarnome.Size = new System.Drawing.Size(98, 34);
            this.btnPesquisarnome.TabIndex = 201;
            this.btnPesquisarnome.Text = "Pesquisar";
            this.btnPesquisarnome.UseVisualStyleBackColor = true;
            this.btnPesquisarnome.Click += new System.EventHandler(this.btnPesquisarnome_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1735, 52);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 36);
            this.btnPesquisar.TabIndex = 200;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1457, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 204;
            this.label2.Text = "Placa";
            // 
            // txtPesquisarplaca
            // 
            this.txtPesquisarplaca.Location = new System.Drawing.Point(1574, 138);
            this.txtPesquisarplaca.Name = "txtPesquisarplaca";
            this.txtPesquisarplaca.Size = new System.Drawing.Size(125, 20);
            this.txtPesquisarplaca.TabIndex = 202;
            // 
            // lblPesquisacodigo
            // 
            this.lblPesquisacodigo.AutoSize = true;
            this.lblPesquisacodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisacodigo.Location = new System.Drawing.Point(1457, 61);
            this.lblPesquisacodigo.Name = "lblPesquisacodigo";
            this.lblPesquisacodigo.Size = new System.Drawing.Size(26, 19);
            this.lblPesquisacodigo.TabIndex = 203;
            this.lblPesquisacodigo.Text = "Cpf";
            // 
            // txtPesquisarcodigo
            // 
            this.txtPesquisarcodigo.Location = new System.Drawing.Point(1574, 62);
            this.txtPesquisarcodigo.Name = "txtPesquisarcodigo";
            this.txtPesquisarcodigo.Size = new System.Drawing.Size(125, 20);
            this.txtPesquisarcodigo.TabIndex = 199;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1359, 892);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 46);
            this.btnCancelar.TabIndex = 181;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvCadastro
            // 
            this.dgvCadastro.AllowUserToAddRows = false;
            this.dgvCadastro.AllowUserToDeleteRows = false;
            this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastro.Location = new System.Drawing.Point(1076, 230);
            this.dgvCadastro.Name = "dgvCadastro";
            this.dgvCadastro.ReadOnly = true;
            this.dgvCadastro.Size = new System.Drawing.Size(665, 397);
            this.dgvCadastro.TabIndex = 197;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(544, 415);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 19);
            this.lblPlaca.TabIndex = 190;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(663, 414);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(154, 20);
            this.txtPlaca.TabIndex = 177;
            // 
            // btnVoltaraomenu
            // 
            this.btnVoltaraomenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaraomenu.Location = new System.Drawing.Point(1574, 892);
            this.btnVoltaraomenu.Name = "btnVoltaraomenu";
            this.btnVoltaraomenu.Size = new System.Drawing.Size(105, 46);
            this.btnVoltaraomenu.TabIndex = 185;
            this.btnVoltaraomenu.Text = "Voltar ao menu";
            this.btnVoltaraomenu.UseVisualStyleBackColor = true;
            this.btnVoltaraomenu.Click += new System.EventHandler(this.btnVoltaraomenu_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(436, 712);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(131, 49);
            this.btnCadastrar.TabIndex = 169;
            this.btnCadastrar.Text = " Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(115, 287);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(26, 19);
            this.lblCpf.TabIndex = 187;
            this.lblCpf.Text = "Cpf";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // dtpDatanasc
            // 
            this.dtpDatanasc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatanasc.Location = new System.Drawing.Point(712, 163);
            this.dtpDatanasc.Name = "dtpDatanasc";
            this.dtpDatanasc.Size = new System.Drawing.Size(105, 22);
            this.dtpDatanasc.TabIndex = 170;
            // 
            // lblDatanasc
            // 
            this.lblDatanasc.AutoSize = true;
            this.lblDatanasc.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatanasc.Location = new System.Drawing.Point(553, 163);
            this.lblDatanasc.Name = "lblDatanasc";
            this.lblDatanasc.Size = new System.Drawing.Size(114, 19);
            this.lblDatanasc.TabIndex = 186;
            this.lblDatanasc.Text = "Data de nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(117, 161);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 19);
            this.lblNome.TabIndex = 184;
            this.lblNome.Text = "Nome";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(230, 284);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(154, 20);
            this.txtCpf.TabIndex = 171;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtNomee
            // 
            this.txtNomee.Location = new System.Drawing.Point(230, 160);
            this.txtNomee.Name = "txtNomee";
            this.txtNomee.Size = new System.Drawing.Size(154, 20);
            this.txtNomee.TabIndex = 206;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 208;
            this.label1.Text = "Veiculo";
            // 
            // cmbcodVeiculo
            // 
            this.cmbcodVeiculo.FormattingEnabled = true;
            this.cmbcodVeiculo.Location = new System.Drawing.Point(230, 417);
            this.cmbcodVeiculo.Name = "cmbcodVeiculo";
            this.cmbcodVeiculo.Size = new System.Drawing.Size(154, 21);
            this.cmbcodVeiculo.TabIndex = 209;
            this.cmbcodVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbcodVeiculo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 211;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(663, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 210;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbcodVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomee);
            this.Controls.Add(this.btnPesquisarnome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisarplaca);
            this.Controls.Add(this.lblPesquisacodigo);
            this.Controls.Add(this.txtPesquisarcodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCadastro);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnVoltaraomenu);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.dtpDatanasc);
            this.Controls.Add(this.lblDatanasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCpf);
            this.Name = "frmCadCliente";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.DoubleClick += new System.EventHandler(this.frmCadCliente_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisarnome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisarplaca;
        private System.Windows.Forms.Label lblPesquisacodigo;
        private System.Windows.Forms.TextBox txtPesquisarcodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCadastro;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnVoltaraomenu;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker dtpDatanasc;
        private System.Windows.Forms.Label lblDatanasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcodVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
    }
}