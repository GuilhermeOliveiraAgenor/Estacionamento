
namespace Estacionamento.Funcionario.Relatorio
{
    partial class frmRelatorio
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
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btnSairmenu = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAno = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesqAno = new System.Windows.Forms.TextBox();
            this.cmbPesqMes = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblPeriodocarro = new System.Windows.Forms.Label();
            this.lblCarros = new System.Windows.Forms.Label();
            this.lbl7dias = new System.Windows.Forms.Label();
            this.lblPdf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(616, 224);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(671, 358);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // btnSairmenu
            // 
            this.btnSairmenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairmenu.Location = new System.Drawing.Point(823, 814);
            this.btnSairmenu.Name = "btnSairmenu";
            this.btnSairmenu.Size = new System.Drawing.Size(93, 42);
            this.btnSairmenu.TabIndex = 182;
            this.btnSairmenu.Text = "Voltar";
            this.btnSairmenu.UseVisualStyleBackColor = true;
            this.btnSairmenu.Click += new System.EventHandler(this.btnSairmenu_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(1703, 315);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 24);
            this.lblValor.TabIndex = 183;
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "7 dias",
            "30 dias",
            "Total"});
            this.cmbPesquisa.Location = new System.Drawing.Point(1672, 94);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(159, 21);
            this.cmbPesquisa.TabIndex = 184;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(168, 178);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(165, 21);
            this.cmbMes.TabIndex = 185;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(168, 117);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(165, 20);
            this.txtAno.TabIndex = 186;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(92, 111);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(34, 18);
            this.lblAno.TabIndex = 187;
            this.lblAno.Text = "Ano";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(92, 177);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(37, 18);
            this.lblMes.TabIndex = 188;
            this.lblMes.Text = "Mês";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1613, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 189;
            this.label1.Text = "Valor ganho nesse período";
            // 
            // btnAno
            // 
            this.btnAno.Location = new System.Drawing.Point(354, 111);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(88, 35);
            this.btnAno.TabIndex = 190;
            this.btnAno.Text = "Pesquisar";
            this.btnAno.UseVisualStyleBackColor = true;
            this.btnAno.Click += new System.EventHandler(this.btnAno_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(354, 177);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 35);
            this.btnPesquisar.TabIndex = 191;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1581, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 192;
            this.label2.Text = "Período";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 193;
            this.label3.Text = "Período";
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(260, 595);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(88, 35);
            this.btnPesq.TabIndex = 204;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 203;
            this.label4.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 202;
            this.label5.Text = "Ano";
            // 
            // txtPesqAno
            // 
            this.txtPesqAno.Location = new System.Drawing.Point(206, 466);
            this.txtPesqAno.Name = "txtPesqAno";
            this.txtPesqAno.Size = new System.Drawing.Size(165, 20);
            this.txtPesqAno.TabIndex = 201;
            // 
            // cmbPesqMes
            // 
            this.cmbPesqMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesqMes.FormattingEnabled = true;
            this.cmbPesqMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbPesqMes.Location = new System.Drawing.Point(206, 527);
            this.cmbPesqMes.Name = "cmbPesqMes";
            this.cmbPesqMes.Size = new System.Drawing.Size(165, 21);
            this.cmbPesqMes.TabIndex = 200;
            this.cmbPesqMes.SelectedIndexChanged += new System.EventHandler(this.cmbPesqMes_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(255, 358);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 18);
            this.lblHora.TabIndex = 205;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(70, 358);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(174, 18);
            this.lblHoras.TabIndex = 207;
            this.lblHoras.Text = "Hora mais movimentada:";
            this.lblHoras.Click += new System.EventHandler(this.lblHoras_Click_1);
            // 
            // lblPeriodocarro
            // 
            this.lblPeriodocarro.AutoSize = true;
            this.lblPeriodocarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodocarro.Location = new System.Drawing.Point(115, 395);
            this.lblPeriodocarro.Name = "lblPeriodocarro";
            this.lblPeriodocarro.Size = new System.Drawing.Size(133, 18);
            this.lblPeriodocarro.TabIndex = 209;
            this.lblPeriodocarro.Text = "Carros no período:";
            // 
            // lblCarros
            // 
            this.lblCarros.AutoSize = true;
            this.lblCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarros.Location = new System.Drawing.Point(255, 395);
            this.lblCarros.Name = "lblCarros";
            this.lblCarros.Size = new System.Drawing.Size(0, 18);
            this.lblCarros.TabIndex = 208;
            // 
            // lbl7dias
            // 
            this.lbl7dias.AutoSize = true;
            this.lbl7dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7dias.Location = new System.Drawing.Point(165, 704);
            this.lbl7dias.Name = "lbl7dias";
            this.lbl7dias.Size = new System.Drawing.Size(238, 18);
            this.lbl7dias.TabIndex = 210;
            this.lbl7dias.Text = "Hora mais movimentada em 7 dias";
            this.lbl7dias.Click += new System.EventHandler(this.lbl7dias_Click);
            // 
            // lblPdf
            // 
            this.lblPdf.AutoSize = true;
            this.lblPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdf.Location = new System.Drawing.Point(1490, 733);
            this.lblPdf.Name = "lblPdf";
            this.lblPdf.Size = new System.Drawing.Size(168, 18);
            this.lblPdf.TabIndex = 212;
            this.lblPdf.Text = "Quadro de Funcionários";
            this.lblPdf.Click += new System.EventHandler(this.lblPdf_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lblPdf);
            this.Controls.Add(this.lbl7dias);
            this.Controls.Add(this.lblPeriodocarro);
            this.Controls.Add(this.lblCarros);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesqAno);
            this.Controls.Add(this.cmbPesqMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnSairmenu);
            this.Controls.Add(this.dgvRelatorio);
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnSairmenu;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesqAno;
        private System.Windows.Forms.ComboBox cmbPesqMes;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblPeriodocarro;
        private System.Windows.Forms.Label lblCarros;
        private System.Windows.Forms.Label lbl7dias;
        private System.Windows.Forms.Label lblPdf;
    }
}