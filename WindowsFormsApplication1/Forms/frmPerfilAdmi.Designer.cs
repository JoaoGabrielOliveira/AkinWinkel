namespace WindowsFormsApplication1
{
    partial class frmPerfilAdmi
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
            this.pic_fotousuario = new System.Windows.Forms.PictureBox();
            this.dialog_FotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.lbl_UserNome = new System.Windows.Forms.Label();
            this.lbl_UserEmail = new System.Windows.Forms.Label();
            this.btn_verProdutos = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Tabela_universal = new System.Windows.Forms.DataGridView();
            this.lbl_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotousuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_universal)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_fotousuario
            // 
            this.pic_fotousuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.pic_fotousuario.Location = new System.Drawing.Point(26, 36);
            this.pic_fotousuario.Name = "pic_fotousuario";
            this.pic_fotousuario.Size = new System.Drawing.Size(200, 200);
            this.pic_fotousuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_fotousuario.TabIndex = 0;
            this.pic_fotousuario.TabStop = false;
            this.pic_fotousuario.Click += new System.EventHandler(this.pic_fotousuario_Click);
            // 
            // lbl_UserNome
            // 
            this.lbl_UserNome.AutoSize = true;
            this.lbl_UserNome.BackColor = System.Drawing.Color.Gold;
            this.lbl_UserNome.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNome.ForeColor = System.Drawing.Color.White;
            this.lbl_UserNome.Location = new System.Drawing.Point(27, 24);
            this.lbl_UserNome.Name = "lbl_UserNome";
            this.lbl_UserNome.Size = new System.Drawing.Size(179, 48);
            this.lbl_UserNome.TabIndex = 6;
            this.lbl_UserNome.Text = "Jonathan";
            // 
            // lbl_UserEmail
            // 
            this.lbl_UserEmail.AutoSize = true;
            this.lbl_UserEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEmail.ForeColor = System.Drawing.Color.White;
            this.lbl_UserEmail.Location = new System.Drawing.Point(83, 72);
            this.lbl_UserEmail.Name = "lbl_UserEmail";
            this.lbl_UserEmail.Size = new System.Drawing.Size(162, 26);
            this.lbl_UserEmail.TabIndex = 7;
            this.lbl_UserEmail.Text = "jojo@gmail.com";
            // 
            // btn_verProdutos
            // 
            this.btn_verProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(154)))), ((int)(((byte)(18)))));
            this.btn_verProdutos.FlatAppearance.BorderSize = 0;
            this.btn_verProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verProdutos.Location = new System.Drawing.Point(93, 215);
            this.btn_verProdutos.Name = "btn_verProdutos";
            this.btn_verProdutos.Size = new System.Drawing.Size(150, 36);
            this.btn_verProdutos.TabIndex = 8;
            this.btn_verProdutos.Text = "Ver Produtos";
            this.btn_verProdutos.UseVisualStyleBackColor = false;
            this.btn_verProdutos.Click += new System.EventHandler(this.btn_verProdutos_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(354, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(113, 24);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar perfil";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_verProdutos);
            this.panel1.Controls.Add(this.lbl_UserEmail);
            this.panel1.Controls.Add(this.lbl_UserNome);
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 293);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(154)))), ((int)(((byte)(18)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(305, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ver Usuarios";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tabela_universal
            // 
            this.Tabela_universal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela_universal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela_universal.Location = new System.Drawing.Point(-1, 351);
            this.Tabela_universal.Name = "Tabela_universal";
            this.Tabela_universal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabela_universal.Size = new System.Drawing.Size(743, 269);
            this.Tabela_universal.TabIndex = 2;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(12, 325);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(624, 23);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Total de Usuarios: 10          Total de Adm: 3      Total de usuarios padrão: 5";
            // 
            // frmPerfilAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(739, 621);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.Tabela_universal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_fotousuario);
            this.Name = "frmPerfilAdmi";
            this.Text = "Perfil Administrativo";
            this.Load += new System.EventHandler(this.frmPerfilAdmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotousuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_universal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_fotousuario;
        private System.Windows.Forms.OpenFileDialog dialog_FotoPerfil;
        private System.Windows.Forms.Label lbl_UserNome;
        private System.Windows.Forms.Label lbl_UserEmail;
        private System.Windows.Forms.Button btn_verProdutos;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Tabela_universal;
        private System.Windows.Forms.Label lbl_resultado;
    }
}