
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundo)).BeginInit();
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
            this.ptbAtivarsenha.Image = global::Estacionamento.Properties.Resources.olho;
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
            this.ptbSenha.Image = global::Estacionamento.Properties.Resources.ver;
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
            this.btnSairmenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairmenu.Location = new System.Drawing.Point(278, 386);
            this.btnSairmenu.Name = "btnSairmenu";
            this.btnSairmenu.Size = new System.Drawing.Size(98, 39);
            this.btnSairmenu.TabIndex = 5;
            this.btnSairmenu.Text = "Sair";
            this.btnSairmenu.UseVisualStyleBackColor = true;
            this.btnSairmenu.Click += new System.EventHandler(this.btnSairmenu_Click);
            // 
            // btnLoginfuncionario
            // 
            this.btnLoginfuncionario.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginfuncionario.Location = new System.Drawing.Point(164, 291);
            this.btnLoginfuncionario.Name = "btnLoginfuncionario";
            this.btnLoginfuncionario.Size = new System.Drawing.Size(98, 34);
            this.btnLoginfuncionario.TabIndex = 4;
            this.btnLoginfuncionario.Text = "Login";
            this.btnLoginfuncionario.UseVisualStyleBackColor = true;
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
            this.txtCpf.TabIndex = 1;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
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
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cpf";
            // 
            // ptbFundo
            // 
            this.ptbFundo.Image = global::Estacionamento.Properties.Resources.cidade;
            this.ptbFundo.Location = new System.Drawing.Point(0, -1);
            this.ptbFundo.Name = "ptbFundo";
            this.ptbFundo.Size = new System.Drawing.Size(1923, 1062);
            this.ptbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFundo.TabIndex = 1;
            this.ptbFundo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtivarsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFundo)).EndInit();
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
    }
}