namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.lbl_textnome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel_senha = new System.Windows.Forms.Panel();
            this.lbl_textsenha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.panel_email = new System.Windows.Forms.Panel();
            this.lbl_textemail = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_criarCadastro = new System.Windows.Forms.Label();
            this.lbl_text1 = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_nome.SuspendLayout();
            this.panel_senha.SuspendLayout();
            this.panel_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.panel_nome);
            this.panel1.Controls.Add(this.panel_senha);
            this.panel1.Controls.Add(this.panel_email);
            this.panel1.Controls.Add(this.lbl_criarCadastro);
            this.panel1.Controls.Add(this.lbl_text1);
            this.panel1.Controls.Add(this.btn_logar);
            this.panel1.Location = new System.Drawing.Point(152, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 7;
            // 
            // panel_nome
            // 
            this.panel_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.panel_nome.Controls.Add(this.lbl_textnome);
            this.panel_nome.Controls.Add(this.txt_nome);
            this.panel_nome.Location = new System.Drawing.Point(134, 60);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(333, 38);
            this.panel_nome.TabIndex = 16;
            this.panel_nome.Visible = false;
            // 
            // lbl_textnome
            // 
            this.lbl_textnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_textnome.AutoSize = true;
            this.lbl_textnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lbl_textnome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textnome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_textnome.Location = new System.Drawing.Point(9, 9);
            this.lbl_textnome.Name = "lbl_textnome";
            this.lbl_textnome.Size = new System.Drawing.Size(56, 21);
            this.lbl_textnome.TabIndex = 8;
            this.lbl_textnome.Text = "Nome:";
            this.lbl_textnome.Click += new System.EventHandler(this.ClickNomeText);
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_nome.Location = new System.Drawing.Point(14, 9);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(307, 21);
            this.txt_nome.TabIndex = 7;
            this.txt_nome.Leave += new System.EventHandler(this.AlteracaoNome);
            // 
            // panel_senha
            // 
            this.panel_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.panel_senha.Controls.Add(this.lbl_textsenha);
            this.panel_senha.Controls.Add(this.txt_senha);
            this.panel_senha.Location = new System.Drawing.Point(134, 198);
            this.panel_senha.Name = "panel_senha";
            this.panel_senha.Size = new System.Drawing.Size(333, 38);
            this.panel_senha.TabIndex = 15;
            this.panel_senha.Click += new System.EventHandler(this.ClickSenhaText);
            // 
            // lbl_textsenha
            // 
            this.lbl_textsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_textsenha.AutoSize = true;
            this.lbl_textsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lbl_textsenha.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_textsenha.Location = new System.Drawing.Point(9, 9);
            this.lbl_textsenha.Name = "lbl_textsenha";
            this.lbl_textsenha.Size = new System.Drawing.Size(56, 21);
            this.lbl_textsenha.TabIndex = 8;
            this.lbl_textsenha.Text = "Senha:";
            this.lbl_textsenha.Click += new System.EventHandler(this.ClickSenhaText);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_senha.Location = new System.Drawing.Point(14, 9);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(307, 21);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.Click += new System.EventHandler(this.ClickSenhaText);
            this.txt_senha.Leave += new System.EventHandler(this.AlteracaoSenha);
            // 
            // panel_email
            // 
            this.panel_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.panel_email.Controls.Add(this.lbl_textemail);
            this.panel_email.Controls.Add(this.txt_email);
            this.panel_email.Location = new System.Drawing.Point(134, 129);
            this.panel_email.Name = "panel_email";
            this.panel_email.Size = new System.Drawing.Size(333, 38);
            this.panel_email.TabIndex = 14;
            this.panel_email.Click += new System.EventHandler(this.ClickEmailText);
            // 
            // lbl_textemail
            // 
            this.lbl_textemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_textemail.AutoSize = true;
            this.lbl_textemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.lbl_textemail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_textemail.Location = new System.Drawing.Point(9, 9);
            this.lbl_textemail.Name = "lbl_textemail";
            this.lbl_textemail.Size = new System.Drawing.Size(57, 21);
            this.lbl_textemail.TabIndex = 8;
            this.lbl_textemail.Text = "E-mail:";
            this.lbl_textemail.Click += new System.EventHandler(this.ClickEmailText);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(207)))), ((int)(((byte)(203)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_email.Location = new System.Drawing.Point(14, 9);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(307, 21);
            this.txt_email.TabIndex = 7;
            this.txt_email.Click += new System.EventHandler(this.ClickEmailText);
            this.txt_email.Leave += new System.EventHandler(this.Alteracao);
            // 
            // lbl_criarCadastro
            // 
            this.lbl_criarCadastro.AutoSize = true;
            this.lbl_criarCadastro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lbl_criarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.lbl_criarCadastro.Location = new System.Drawing.Point(326, 337);
            this.lbl_criarCadastro.Name = "lbl_criarCadastro";
            this.lbl_criarCadastro.Size = new System.Drawing.Size(116, 21);
            this.lbl_criarCadastro.TabIndex = 13;
            this.lbl_criarCadastro.Text = "Crie sua aconta";
            this.lbl_criarCadastro.Click += new System.EventHandler(this.CriarConta);
            this.lbl_criarCadastro.MouseLeave += new System.EventHandler(this.CriarContaLeave);
            this.lbl_criarCadastro.MouseHover += new System.EventHandler(this.CriarContaHover);
            // 
            // lbl_text1
            // 
            this.lbl_text1.AutoSize = true;
            this.lbl_text1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.lbl_text1.Location = new System.Drawing.Point(175, 337);
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Size = new System.Drawing.Size(154, 21);
            this.lbl_text1.TabIndex = 12;
            this.lbl_text1.Text = "Não tem uma conta?";
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(67)))));
            this.btn_logar.FlatAppearance.BorderSize = 0;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.ForeColor = System.Drawing.Color.White;
            this.btn_logar.Location = new System.Drawing.Point(134, 267);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(333, 36);
            this.btn_logar.TabIndex = 11;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "©Grupo Akin - Administração e Desenvolvimento";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(854, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 106);
            this.label2.TabIndex = 19;
            this.label2.Text = "Akin Winkel";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(194)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(905, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_nome.ResumeLayout(false);
            this.panel_nome.PerformLayout();
            this.panel_senha.ResumeLayout(false);
            this.panel_senha.PerformLayout();
            this.panel_email.ResumeLayout(false);
            this.panel_email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label lbl_textemail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_criarCadastro;
        private System.Windows.Forms.Label lbl_text1;
        private System.Windows.Forms.Panel panel_senha;
        private System.Windows.Forms.Label lbl_textsenha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Panel panel_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.Label lbl_textnome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}