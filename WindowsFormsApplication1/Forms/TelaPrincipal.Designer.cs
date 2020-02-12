namespace WindowsFormsApplication1
{
    partial class TelaPrincipal
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
            this.btn_addProd = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.Tabelas_dos_Produtos = new System.Windows.Forms.DataGridView();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_ProdNome = new System.Windows.Forms.TextBox();
            this.txt_ProdPreco = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Tabela_do_Carrinho = new System.Windows.Forms.DataGridView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_remCarrinho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Painel_carrinho = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Tabelas_dos_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_do_Carrinho)).BeginInit();
            this.panel1.SuspendLayout();
            this.Painel_carrinho.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addProd
            // 
            this.btn_addProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_addProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(146)))), ((int)(((byte)(20)))));
            this.btn_addProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addProd.Enabled = false;
            this.btn_addProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(124)))), ((int)(((byte)(9)))));
            this.btn_addProd.FlatAppearance.BorderSize = 2;
            this.btn_addProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProd.Location = new System.Drawing.Point(114, 269);
            this.btn_addProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addProd.Name = "btn_addProd";
            this.btn_addProd.Size = new System.Drawing.Size(149, 38);
            this.btn_addProd.TabIndex = 0;
            this.btn_addProd.Text = "Adicionar ao Carrinho";
            this.btn_addProd.UseVisualStyleBackColor = false;
            this.btn_addProd.Click += new System.EventHandler(this.btn_addProd_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(146)))), ((int)(((byte)(20)))));
            this.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(124)))), ((int)(((byte)(9)))));
            this.btn_finalizar.FlatAppearance.BorderSize = 2;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(197, 51);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(149, 38);
            this.btn_finalizar.TabIndex = 1;
            this.btn_finalizar.Text = "Finalizar Compra";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // Tabelas_dos_Produtos
            // 
            this.Tabelas_dos_Produtos.AllowUserToAddRows = false;
            this.Tabelas_dos_Produtos.AllowUserToDeleteRows = false;
            this.Tabelas_dos_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabelas_dos_Produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Tabelas_dos_Produtos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Tabelas_dos_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabelas_dos_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tabelas_dos_Produtos.Enabled = false;
            this.Tabelas_dos_Produtos.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.Tabelas_dos_Produtos.Location = new System.Drawing.Point(22, 122);
            this.Tabelas_dos_Produtos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tabelas_dos_Produtos.MultiSelect = false;
            this.Tabelas_dos_Produtos.Name = "Tabelas_dos_Produtos";
            this.Tabelas_dos_Produtos.ReadOnly = true;
            this.Tabelas_dos_Produtos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabelas_dos_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabelas_dos_Produtos.Size = new System.Drawing.Size(405, 272);
            this.Tabelas_dos_Produtos.TabIndex = 2;
            this.Tabelas_dos_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabelas_dos_Produtos_CellClick);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(44, 174);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(162, 16);
            this.lbl_quantidade.TabIndex = 4;
            this.lbl_quantidade.Text = "Digite quantos quer comprar:";
            // 
            // txt_ProdNome
            // 
            this.txt_ProdNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_ProdNome.BackColor = System.Drawing.Color.LightYellow;
            this.txt_ProdNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdNome.Enabled = false;
            this.txt_ProdNome.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ProdNome.Location = new System.Drawing.Point(47, 26);
            this.txt_ProdNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProdNome.MaxLength = 300;
            this.txt_ProdNome.Name = "txt_ProdNome";
            this.txt_ProdNome.ReadOnly = true;
            this.txt_ProdNome.Size = new System.Drawing.Size(264, 35);
            this.txt_ProdNome.TabIndex = 5;
            this.txt_ProdNome.TextChanged += new System.EventHandler(this.txt_ProdNome_TextChanged);
            // 
            // txt_ProdPreco
            // 
            this.txt_ProdPreco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_ProdPreco.BackColor = System.Drawing.Color.LightYellow;
            this.txt_ProdPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProdPreco.Enabled = false;
            this.txt_ProdPreco.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdPreco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ProdPreco.Location = new System.Drawing.Point(47, 82);
            this.txt_ProdPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProdPreco.MaxLength = 300;
            this.txt_ProdPreco.Name = "txt_ProdPreco";
            this.txt_ProdPreco.ReadOnly = true;
            this.txt_ProdPreco.Size = new System.Drawing.Size(264, 35);
            this.txt_ProdPreco.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.LightYellow;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(16, 47);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(236, 22);
            this.txt_nome.TabIndex = 8;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(15, 24);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(144, 19);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome do Comprador:";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(146)))), ((int)(((byte)(20)))));
            this.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(124)))), ((int)(((byte)(9)))));
            this.btn_iniciar.FlatAppearance.BorderSize = 2;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(604, 27);
            this.btn_iniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(147, 36);
            this.btn_iniciar.TabIndex = 10;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Carrinho:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Quantidade.BackColor = System.Drawing.Color.LightYellow;
            this.txt_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantidade.Enabled = false;
            this.txt_Quantidade.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantidade.Location = new System.Drawing.Point(47, 194);
            this.txt_Quantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Quantidade.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(265, 22);
            this.txt_Quantidade.TabIndex = 13;
            // 
            // Tabela_do_Carrinho
            // 
            this.Tabela_do_Carrinho.AllowUserToAddRows = false;
            this.Tabela_do_Carrinho.AllowUserToDeleteRows = false;
            this.Tabela_do_Carrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabela_do_Carrinho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Tabela_do_Carrinho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Tabela_do_Carrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabela_do_Carrinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tabela_do_Carrinho.Enabled = false;
            this.Tabela_do_Carrinho.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.Tabela_do_Carrinho.Location = new System.Drawing.Point(22, 433);
            this.Tabela_do_Carrinho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tabela_do_Carrinho.MultiSelect = false;
            this.Tabela_do_Carrinho.Name = "Tabela_do_Carrinho";
            this.Tabela_do_Carrinho.ReadOnly = true;
            this.Tabela_do_Carrinho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabela_do_Carrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela_do_Carrinho.Size = new System.Drawing.Size(405, 202);
            this.Tabela_do_Carrinho.TabIndex = 14;
            this.Tabela_do_Carrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabela_do_Carrinho_CellContentClick);
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.LightYellow;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_total.Location = new System.Drawing.Point(19, 19);
            this.txt_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_total.MaxLength = 10;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(347, 31);
            this.txt_total.TabIndex = 15;
            this.txt_total.Text = "Total: ";
            // 
            // btn_remCarrinho
            // 
            this.btn_remCarrinho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_remCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(146)))), ((int)(((byte)(20)))));
            this.btn_remCarrinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remCarrinho.Enabled = false;
            this.btn_remCarrinho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(124)))), ((int)(((byte)(9)))));
            this.btn_remCarrinho.FlatAppearance.BorderSize = 2;
            this.btn_remCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remCarrinho.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remCarrinho.Location = new System.Drawing.Point(21, 51);
            this.btn_remCarrinho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remCarrinho.Name = "btn_remCarrinho";
            this.btn_remCarrinho.Size = new System.Drawing.Size(149, 38);
            this.btn_remCarrinho.TabIndex = 16;
            this.btn_remCarrinho.Text = "Remover ao Carrinho";
            this.btn_remCarrinho.UseVisualStyleBackColor = false;
            this.btn_remCarrinho.Click += new System.EventHandler(this.btn_remCarrinho_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btn_addProd);
            this.panel1.Controls.Add(this.lbl_quantidade);
            this.panel1.Controls.Add(this.txt_Quantidade);
            this.panel1.Controls.Add(this.txt_ProdNome);
            this.panel1.Controls.Add(this.txt_ProdPreco);
            this.panel1.Location = new System.Drawing.Point(449, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 350);
            this.panel1.TabIndex = 17;
            // 
            // Painel_carrinho
            // 
            this.Painel_carrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Painel_carrinho.Controls.Add(this.btn_remCarrinho);
            this.Painel_carrinho.Controls.Add(this.btn_finalizar);
            this.Painel_carrinho.Location = new System.Drawing.Point(449, 488);
            this.Painel_carrinho.Name = "Painel_carrinho";
            this.Painel_carrinho.Size = new System.Drawing.Size(358, 147);
            this.Painel_carrinho.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.Add(this.btn_iniciar);
            this.panel3.Controls.Add(this.txt_nome);
            this.panel3.Controls.Add(this.lbl_nome);
            this.panel3.Location = new System.Drawing.Point(22, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 89);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.txt_total);
            this.panel4.Location = new System.Drawing.Point(22, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 60);
            this.panel4.TabIndex = 20;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(827, 734);
            this.Controls.Add(this.Painel_carrinho);
            this.Controls.Add(this.Tabela_do_Carrinho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabelas_dos_Produtos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabelas_dos_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_do_Carrinho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Painel_carrinho.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addProd;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DataGridView Tabelas_dos_Produtos;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_ProdNome;
        private System.Windows.Forms.TextBox txt_ProdPreco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_Quantidade;
        private System.Windows.Forms.DataGridView Tabela_do_Carrinho;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_remCarrinho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Painel_carrinho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}