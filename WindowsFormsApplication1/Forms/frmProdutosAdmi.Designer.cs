namespace WindowsFormsApplication1.Forms
{
    partial class frmProdutosAdmi
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
            this.Tabelas_dos_Produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabelas_dos_Produtos)).BeginInit();
            this.SuspendLayout();
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
            this.Tabelas_dos_Produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabelas_dos_Produtos.Enabled = false;
            this.Tabelas_dos_Produtos.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.Tabelas_dos_Produtos.Location = new System.Drawing.Point(0, 0);
            this.Tabelas_dos_Produtos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tabelas_dos_Produtos.MultiSelect = false;
            this.Tabelas_dos_Produtos.Name = "Tabelas_dos_Produtos";
            this.Tabelas_dos_Produtos.ReadOnly = true;
            this.Tabelas_dos_Produtos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabelas_dos_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabelas_dos_Produtos.Size = new System.Drawing.Size(453, 300);
            this.Tabelas_dos_Produtos.TabIndex = 3;
            // 
            // frmProdutosAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.Tabelas_dos_Produtos);
            this.Name = "frmProdutosAdmi";
            this.Text = "frmProdutosAdmi";
            this.Load += new System.EventHandler(this.frmProdutosAdmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabelas_dos_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabelas_dos_Produtos;
    }
}