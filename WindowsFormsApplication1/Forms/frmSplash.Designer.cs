namespace WindowsFormsApplication1.Forms
{
    partial class frmSplash
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
            this.loading = new System.Windows.Forms.Timer(this.components);
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.Enabled = true;
            this.loading.Interval = 50;
            this.loading.Tick += new System.EventHandler(this.loading_Tick);
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.White;
            this.loadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingBar.Location = new System.Drawing.Point(0, 471);
            this.loadingBar.Maximum = 25;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(1051, 10);
            this.loadingBar.TabIndex = 0;
            this.loadingBar.Visible = false;
            // 
            // picbox
            // 
            this.picbox.Image = global::WindowsFormsApplication1.Properties.Resources.Logo_II_Oficinal;
            this.picbox.Location = new System.Drawing.Point(-339, 136);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(1728, 208);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1051, 481);
            this.ControlBox = false;
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.loadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer loading;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.PictureBox picbox;
    }
}