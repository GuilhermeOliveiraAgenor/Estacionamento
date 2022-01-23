
namespace Estacionamento.editarPedidos
{
    partial class frmAlterarCliente
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
            this.btnPesquisarcodigo = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPesquisarcodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPesquisarnome = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltaraomenu = new System.Windows.Forms.Button();
            this.btnAlterarcliente = new System.Windows.Forms.Button();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblNomee = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarcodigo
            // 
            this.btnPesquisarcodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarcodigo.Location = new System.Drawing.Point(1117, 106);
            this.btnPesquisarcodigo.Name = "btnPesquisarcodigo";
            this.btnPesquisarcodigo.Size = new System.Drawing.Size(95, 31);
            this.btnPesquisarcodigo.TabIndex = 175;
            this.btnPesquisarcodigo.Text = "Pesquisar";
            this.btnPesquisarcodigo.UseVisualStyleBackColor = true;
            this.btnPesquisarcodigo.Click += new System.EventHandler(this.btnPesquisarcodigo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(884, 111);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(26, 19);
            this.lblCodigo.TabIndex = 187;
            this.lblCodigo.Text = "Cpf";
            // 
            // txtPesquisarcodigo
            // 
            this.txtPesquisarcodigo.Location = new System.Drawing.Point(945, 108);
            this.txtPesquisarcodigo.Name = "txtPesquisarcodigo";
            this.txtPesquisarcodigo.Size = new System.Drawing.Size(154, 20);
            this.txtPesquisarcodigo.TabIndex = 174;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1117, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 28);
            this.btnPesquisar.TabIndex = 173;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(884, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 19);
            this.lblNome.TabIndex = 186;
            this.lblNome.Text = "Nome";
            // 
            // txtPesquisarnome
            // 
            this.txtPesquisarnome.Location = new System.Drawing.Point(945, 70);
            this.txtPesquisarnome.Name = "txtPesquisarnome";
            this.txtPesquisarnome.Size = new System.Drawing.Size(154, 20);
            this.txtPesquisarnome.TabIndex = 172;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(790, 202);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(660, 270);
            this.dgvClientes.TabIndex = 185;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1021, 559);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 48);
            this.btnCancelar.TabIndex = 171;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVoltaraomenu
            // 
            this.btnVoltaraomenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltaraomenu.Location = new System.Drawing.Point(1150, 559);
            this.btnVoltaraomenu.Name = "btnVoltaraomenu";
            this.btnVoltaraomenu.Size = new System.Drawing.Size(120, 48);
            this.btnVoltaraomenu.TabIndex = 176;
            this.btnVoltaraomenu.Text = "Voltar ao menu";
            this.btnVoltaraomenu.UseVisualStyleBackColor = true;
            this.btnVoltaraomenu.Click += new System.EventHandler(this.btnVoltaraomenu_Click);
            // 
            // btnAlterarcliente
            // 
            this.btnAlterarcliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarcliente.Location = new System.Drawing.Point(507, 484);
            this.btnAlterarcliente.Name = "btnAlterarcliente";
            this.btnAlterarcliente.Size = new System.Drawing.Size(87, 39);
            this.btnAlterarcliente.TabIndex = 161;
            this.btnAlterarcliente.Text = "Alterar";
            this.btnAlterarcliente.UseVisualStyleBackColor = true;
            this.btnAlterarcliente.Click += new System.EventHandler(this.btnAlterarcliente_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(371, 306);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 19);
            this.lblCelular.TabIndex = 183;
            this.lblCelular.Text = "Celular";
            // 
            // lblNomee
            // 
            this.lblNomee.AutoSize = true;
            this.lblNomee.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomee.Location = new System.Drawing.Point(362, 253);
            this.lblNomee.Name = "lblNomee";
            this.lblNomee.Size = new System.Drawing.Size(38, 19);
            this.lblNomee.TabIndex = 177;
            this.lblNomee.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(480, 308);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 169;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(480, 252);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(151, 20);
            this.txtCliente.TabIndex = 163;
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnPesquisarcodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtPesquisarcodigo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPesquisarnome);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVoltaraomenu);
            this.Controls.Add(this.btnAlterarcliente);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblNomee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCliente);
            this.Name = "frmAlterarCliente";
            this.Text = "frmAlterarCliente";
            this.Load += new System.EventHandler(this.frmAlterarCliente_Load);
            this.DoubleClick += new System.EventHandler(this.frmAlterarCliente_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisarcodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPesquisarcodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisarnome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltaraomenu;
        private System.Windows.Forms.Button btnAlterarcliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblNomee;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCliente;
    }
}