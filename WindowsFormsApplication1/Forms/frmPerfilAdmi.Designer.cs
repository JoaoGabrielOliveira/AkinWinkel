namespace WindowsFormsApplication1.Forms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UserNome = new System.Windows.Forms.Label();
            this.lbl_UserEmail = new System.Windows.Forms.Label();
            this.btn_verProdutos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_UserNome
            // 
            this.lbl_UserNome.AutoSize = true;
            this.lbl_UserNome.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNome.Location = new System.Drawing.Point(181, 19);
            this.lbl_UserNome.Name = "lbl_UserNome";
            this.lbl_UserNome.Size = new System.Drawing.Size(97, 25);
            this.lbl_UserNome.TabIndex = 1;
            this.lbl_UserNome.Text = "Jonathan";
            // 
            // lbl_UserEmail
            // 
            this.lbl_UserEmail.AutoSize = true;
            this.lbl_UserEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEmail.Location = new System.Drawing.Point(195, 48);
            this.lbl_UserEmail.Name = "lbl_UserEmail";
            this.lbl_UserEmail.Size = new System.Drawing.Size(102, 16);
            this.lbl_UserEmail.TabIndex = 2;
            this.lbl_UserEmail.Text = "jojo@gmail.com";
            // 
            // btn_verProdutos
            // 
            this.btn_verProdutos.Location = new System.Drawing.Point(181, 119);
            this.btn_verProdutos.Name = "btn_verProdutos";
            this.btn_verProdutos.Size = new System.Drawing.Size(150, 43);
            this.btn_verProdutos.TabIndex = 3;
            this.btn_verProdutos.Text = "Ver Produtos";
            this.btn_verProdutos.UseVisualStyleBackColor = true;
            this.btn_verProdutos.Click += new System.EventHandler(this.btn_verProdutos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(412, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(113, 24);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar perfil";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPerfilAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 187);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_verProdutos);
            this.Controls.Add(this.lbl_UserEmail);
            this.Controls.Add(this.lbl_UserNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPerfilAdmi";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UserNome;
        private System.Windows.Forms.Label lbl_UserEmail;
        private System.Windows.Forms.Button btn_verProdutos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_editar;
    }
}