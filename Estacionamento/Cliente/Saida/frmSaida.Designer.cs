
namespace Estacionamento.Saida
{
    partial class frmSaida
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.lblpesquisa = new System.Windows.Forms.Label();
            this.btnSaida = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormadepagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecohora = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.dgvEstacionamento = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPatio1 = new System.Windows.Forms.Label();
            this.lblPatio2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(1631, 47);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(121, 20);
            this.txtPesquisar.TabIndex = 204;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1096, 876);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 201;
            this.label3.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(1151, 875);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(88, 22);
            this.dtpData.TabIndex = 200;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1164, 849);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 23);
            this.lblHora.TabIndex = 199;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 197;
            this.label2.Text = "Placa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1549, 904);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 50);
            this.btnCancelar.TabIndex = 191;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1679, 904);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 50);
            this.btnVoltar.TabIndex = 190;
            this.btnVoltar.Text = "Voltar para o menu";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 185;
            this.label5.Text = "Tempo permanecido";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(165, 395);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(102, 19);
            this.lblPreco.TabIndex = 183;
            this.lblPreco.Text = "Total a pagar : R$";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.Location = new System.Drawing.Point(1769, 39);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(100, 37);
            this.btnCodigo.TabIndex = 182;
            this.btnCodigo.Text = "Pesquisar";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // lblpesquisa
            // 
            this.lblpesquisa.AutoSize = true;
            this.lblpesquisa.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisa.Location = new System.Drawing.Point(1575, 47);
            this.lblpesquisa.Name = "lblpesquisa";
            this.lblpesquisa.Size = new System.Drawing.Size(40, 19);
            this.lblpesquisa.TabIndex = 181;
            this.lblpesquisa.Text = "Placa";
            // 
            // btnSaida
            // 
            this.btnSaida.Enabled = false;
            this.btnSaida.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Location = new System.Drawing.Point(273, 470);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(89, 48);
            this.btnSaida.TabIndex = 171;
            this.btnSaida.Text = "Efetuar \r\nsaida";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 206;
            this.label1.Text = "Entrada";
            // 
            // cmbFormadepagamento
            // 
            this.cmbFormadepagamento.FormattingEnabled = true;
            this.cmbFormadepagamento.Location = new System.Drawing.Point(1151, 118);
            this.cmbFormadepagamento.Name = "cmbFormadepagamento";
            this.cmbFormadepagamento.Size = new System.Drawing.Size(121, 21);
            this.cmbFormadepagamento.TabIndex = 207;
            this.cmbFormadepagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormadepagamento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(978, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 208;
            this.label4.Text = "Forma de pagamento";
            // 
            // lblPrecohora
            // 
            this.lblPrecohora.AutoSize = true;
            this.lblPrecohora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecohora.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrecohora.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecohora.Location = new System.Drawing.Point(312, 395);
            this.lblPrecohora.Name = "lblPrecohora";
            this.lblPrecohora.Size = new System.Drawing.Size(0, 25);
            this.lblPrecohora.TabIndex = 209;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHoraEntrada.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(299, 204);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(0, 25);
            this.lblHoraEntrada.TabIndex = 210;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Enabled = false;
            this.lblPlaca.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(312, 118);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(0, 19);
            this.lblPlaca.TabIndex = 211;
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.Location = new System.Drawing.Point(268, 322);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(0, 25);
            this.lblCalcular.TabIndex = 212;
            // 
            // dgvEstacionamento
            // 
            this.dgvEstacionamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionamento.Location = new System.Drawing.Point(169, 556);
            this.dgvEstacionamento.Name = "dgvEstacionamento";
            this.dgvEstacionamento.Size = new System.Drawing.Size(648, 339);
            this.dgvEstacionamento.TabIndex = 214;
            this.dgvEstacionamento.SelectionChanged += new System.EventHandler(this.dgvEstacionamento_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1110, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 220;
            this.label6.Text = "Vagas disponiveis";
            // 
            // lblPatio1
            // 
            this.lblPatio1.AutoSize = true;
            this.lblPatio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio1.Location = new System.Drawing.Point(1124, 699);
            this.lblPatio1.Name = "lblPatio1";
            this.lblPatio1.Size = new System.Drawing.Size(0, 24);
            this.lblPatio1.TabIndex = 219;
            // 
            // lblPatio2
            // 
            this.lblPatio2.AutoSize = true;
            this.lblPatio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatio2.Location = new System.Drawing.Point(1124, 735);
            this.lblPatio2.Name = "lblPatio2";
            this.lblPatio2.Size = new System.Drawing.Size(0, 24);
            this.lblPatio2.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1049, 741);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 217;
            this.label7.Text = "Patio 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1050, 705);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 216;
            this.label8.Text = "Patio 1";
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPatio1);
            this.Controls.Add(this.lblPatio2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEstacionamento);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPrecohora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFormadepagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.lblpesquisa);
            this.Controls.Add(this.btnSaida);
            this.Name = "frmSaida";
            this.Text = "frmSaida";
            this.Load += new System.EventHandler(this.frmSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Label lblpesquisa;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormadepagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecohora;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.DataGridView dgvEstacionamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatio1;
        private System.Windows.Forms.Label lblPatio2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}