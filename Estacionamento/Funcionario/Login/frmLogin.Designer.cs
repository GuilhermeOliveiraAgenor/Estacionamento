
namespace Estacionamento.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAtivarsenha = new System.Windows.Forms.PictureBox();
            this.ptbSenha = new System.Windows.Forms.PictureBox();
            this.btnSairmenu = new System.Windows.Forms.Button();
            this.btnLoginfuncionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptbFundo = new System.Windows.Forms.PictureBox();
            this.ptbNormal = new System.Windows.Forms.PictureBox();
            this.ptbMaximar = new System.Windows.Forms.PictureBox();
            this.ptbSair = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptbAtivarsenha);
            this.panel1.Controls.Add(this.ptbSenha);
            this.panel1.Controls.Add(this.btnSairmenu);
            this.panel1.Controls.Add(this.btnLoginfuncionario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCpf);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(759, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 453);
            this.panel1.TabIndex = 2;
            // 
            // ptbAtivarsenha
            // 
            this.ptbAtivarsenha.Image = global::UI.Properties.Resources.olho;
            this.ptbAtivarsenha.Location = new System.Drawing.Point(309, 216);
            this.ptbAtivarsenha.Name = "ptbAtivarsenha";
            this.ptbAtivarsenha.Size = new System.Drawing.Size(38, 39);
            this.ptbAtivarsenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAtivarsenha.TabIndex = 159;
            this.ptbAtivarsenha.TabStop = false;
            this.ptbAtivarsenha.Click += new System.EventHandler(this.ptbAtivarsenha_Click);
            // 
            // ptbSenha
            // 
            this.ptbSenha.Image = global::UI.Properties.Resources.ver;
            this.ptbSenha.Location = new System.Drawing.Point(309, 216);
            this.ptbSenha.Name = "ptbSenha";
            this.ptbSenha.Size = new System.Drawing.Size(38, 39);
            this.ptbSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSenha.TabIndex = 158;
            this.ptbSenha.TabStop = false;
            this.ptbSenha.Click += new System.EventHandler(this.ptbSenha_Click);
            // 
            // btnSairmenu
            // 
            this.btnSairmenu.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSairmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairmenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairmenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSairmenu.Location = new System.Drawing.Point(278, 386);
            this.btnSairmenu.Name = "btnSairmenu";
            this.btnSairmenu.Size = new System.Drawing.Size(98, 39);
            this.btnSairmenu.TabIndex = 3;
            this.btnSairmenu.Text = "Sair";
            this.btnSairmenu.UseVisualStyleBackColor = false;
            this.btnSairmenu.Click += new System.EventHandler(this.btnSairmenu_Click);
            // 
            // btnLoginfuncionario
            // 
            this.btnLoginfuncionario.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLoginfuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginfuncionario.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginfuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoginfuncionario.Location = new System.Drawing.Point(164, 291);
            this.btnLoginfuncionario.Name = "btnLoginfuncionario";
            this.btnLoginfuncionario.Size = new System.Drawing.Size(104, 44);
            this.btnLoginfuncionario.TabIndex = 2;
            this.btnLoginfuncionario.Text = "Login";
            this.btnLoginfuncionario.UseVisualStyleBackColor = false;
            this.btnLoginfuncionario.Click += new System.EventHandler(this.btnLoginfuncionario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estacionamento Alfa Park";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(143, 139);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(153, 30);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(143, 216);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(153, 30);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cpf";
            // 
            // ptbFundo
            // 
            this.ptbFundo.Image = global::UI.Properties.Resources.cidade;
            this.ptbFundo.Location = new System.Drawing.Point(3, -1);
            this.ptbFundo.Name = "ptbFundo";
            this.ptbFundo.Size = new System.Drawing.Size(1923, 1062);
            this.ptbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFundo.TabIndex = 1;
            this.ptbFundo.TabStop = false;
            // 
            // ptbNormal
            // 
            this.ptbNormal.BackColor = System.Drawing.SystemColors.Window;
            this.ptbNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbNormal.Image = global::UI.Properties.Resources.maximizar;
            this.ptbNormal.Location = new System.Drawing.Point(1798, 12);
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
            this.ptbMaximar.Location = new System.Drawing.Point(1798, 12);
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
            this.ptbSair.Location = new System.Drawing.Point(1849, 4);
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
            this.ptbMinimizar.Location = new System.Drawing.Point(1740, 12);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(32, 27);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimizar.TabIndex = 273;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UI.Properties.Resources.maximizar;
            this.pictureBox1.Location = new System.Drawing.Point(1798, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 277;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.ptbMaximar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptbSair);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbFundo);
            this.Controls.Add(this.ptbNormal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbAtivarsenha;
        private System.Windows.Forms.PictureBox ptbSenha;
        private System.Windows.Forms.Button btnSairmenu;
        private System.Windows.Forms.Button btnLoginfuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptbNormal;
        private System.Windows.Forms.PictureBox ptbMaximar;
        private System.Windows.Forms.PictureBox ptbSair;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}