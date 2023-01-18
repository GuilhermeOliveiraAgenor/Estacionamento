
namespace Estacionamento.Usuarios
{
    partial class frmConfirmarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmarSenha));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.ptbAtivarsenha = new System.Windows.Forms.PictureBox();
            this.ptbSenha = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ptbNormal = new System.Windows.Forms.PictureBox();
            this.ptbMaximar = new System.Windows.Forms.PictureBox();
            this.ptbSair = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.sessaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(412, 306);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 39);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(322, 213);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(56, 25);
            this.lblAno.TabIndex = 195;
            this.lblAno.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(387, 212);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(165, 30);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // ptbAtivarsenha
            // 
            this.ptbAtivarsenha.Image = global::UI.Properties.Resources.olho;
            this.ptbAtivarsenha.Location = new System.Drawing.Point(558, 212);
            this.ptbAtivarsenha.Name = "ptbAtivarsenha";
            this.ptbAtivarsenha.Size = new System.Drawing.Size(38, 39);
            this.ptbAtivarsenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAtivarsenha.TabIndex = 198;
            this.ptbAtivarsenha.TabStop = false;
            this.ptbAtivarsenha.Click += new System.EventHandler(this.ptbAtivarsenha_Click);
            // 
            // ptbSenha
            // 
            this.ptbSenha.Image = global::UI.Properties.Resources.ver;
            this.ptbSenha.Location = new System.Drawing.Point(558, 212);
            this.ptbSenha.Name = "ptbSenha";
            this.ptbSenha.Size = new System.Drawing.Size(38, 39);
            this.ptbSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSenha.TabIndex = 197;
            this.ptbSenha.TabStop = false;
            this.ptbSenha.Click += new System.EventHandler(this.ptbSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(761, 437);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 48);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ptbNormal
            // 
            this.ptbNormal.BackColor = System.Drawing.SystemColors.Window;
            this.ptbNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbNormal.Image = global::UI.Properties.Resources.maximizar;
            this.ptbNormal.Location = new System.Drawing.Point(816, 5);
            this.ptbNormal.Name = "ptbNormal";
            this.ptbNormal.Size = new System.Drawing.Size(32, 27);
            this.ptbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNormal.TabIndex = 276;
            this.ptbNormal.TabStop = false;
            this.ptbNormal.Click += new System.EventHandler(this.ptbNormal_Click);
            // 
            // ptbMaximar
            // 
            this.ptbMaximar.BackColor = System.Drawing.SystemColors.Window;
            this.ptbMaximar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMaximar.Image = global::UI.Properties.Resources.icons8_maximizar_janela_50;
            this.ptbMaximar.Location = new System.Drawing.Point(816, 5);
            this.ptbMaximar.Name = "ptbMaximar";
            this.ptbMaximar.Size = new System.Drawing.Size(32, 27);
            this.ptbMaximar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMaximar.TabIndex = 275;
            this.ptbMaximar.TabStop = false;
            this.ptbMaximar.Click += new System.EventHandler(this.ptbMaximar_Click);
            // 
            // ptbSair
            // 
            this.ptbSair.BackColor = System.Drawing.Color.MidnightBlue;
            this.ptbSair.Image = global::UI.Properties.Resources.fechar;
            this.ptbSair.Location = new System.Drawing.Point(861, -1);
            this.ptbSair.Name = "ptbSair";
            this.ptbSair.Size = new System.Drawing.Size(40, 40);
            this.ptbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSair.TabIndex = 274;
            this.ptbSair.TabStop = false;
            this.ptbSair.Click += new System.EventHandler(this.ptbSair_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.BackColor = System.Drawing.SystemColors.Window;
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = global::UI.Properties.Resources.icons8_subtração_64;
            this.ptbMinimizar.Location = new System.Drawing.Point(761, 5);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(32, 27);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 273;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // sessaoToolStripMenuItem
            // 
            this.sessaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.vagasToolStripMenuItem});
            this.sessaoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.sessaoToolStripMenuItem.Name = "sessaoToolStripMenuItem";
            this.sessaoToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.sessaoToolStripMenuItem.Text = "Sessão";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.saídaToolStripMenuItem.Text = "Saída";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.editarToolStripMenuItem.Text = "Alterar";
            // 
            // vagasToolStripMenuItem
            // 
            this.vagasToolStripMenuItem.Name = "vagasToolStripMenuItem";
            this.vagasToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.vagasToolStripMenuItem.Text = "Vagas";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veiculoToolStripMenuItem});
            this.editarToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(72, 27);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.veiculoToolStripMenuItem.Text = "Veículo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(127, 28);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(127, 28);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.loginToolStripMenuItem.Text = "Logout";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(139, 28);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessaoToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(912, 39);
            this.menuStrip1.TabIndex = 217;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmConfirmarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 522);
            this.Controls.Add(this.ptbMaximar);
            this.Controls.Add(this.ptbSair);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ptbAtivarsenha);
            this.Controls.Add(this.ptbSenha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.ptbNormal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfirmarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox ptbAtivarsenha;
        private System.Windows.Forms.PictureBox ptbSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox ptbNormal;
        private System.Windows.Forms.PictureBox ptbMaximar;
        private System.Windows.Forms.PictureBox ptbSair;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.ToolStripMenuItem sessaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}