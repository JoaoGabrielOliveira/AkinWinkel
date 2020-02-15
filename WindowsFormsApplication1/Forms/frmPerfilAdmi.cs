using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPerfilAdmi : Form
    {
        public frmPerfilAdmi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_verProdutos_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilAdmi_Load(object sender, EventArgs e)
        {
            this.Size = new Size(755,314);
            VariaveisGlobais.CadastrarProdutos();
            lbl_UserNome.Text = VariaveisGlobais.NomeUsuario;
            lbl_UserEmail.Text = VariaveisGlobais.EmailUsuario;
            try
            {
                pic_fotousuario.Image = Image.FromFile(VariaveisGlobais.FotoUsuario);
            }

            catch(Exception)
            {

            }

            
        }

        private void pic_fotousuario_Click(object sender, EventArgs e)
        {
           
            if  (dialog_FotoPerfil.ShowDialog() == DialogResult.OK)
            {
                pic_fotousuario.Image = Image.FromFile(dialog_FotoPerfil.FileName);
            }
        }

        private void btn_verProdutos_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(755, 619);
            Tabela_universal.DataSource = VariaveisGlobais.CriarTabela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(755, 619);
            Tabela_universal.DataSource = BancoDados.PegarContas();
            int admi = 0, user = 0;
            for (int i = 0; i < Tabela_universal.Rows.Count; i++)
            {
                if(Tabela_universal.Rows[i].Cells[2].ToString() == "admi")
                {
                    admi++;
                }

                else if (Tabela_universal.Rows[i].Cells[2].ToString() == "user")
                {
                    user++;
                }
            }
            
            lbl_resultado.Text = "Total de Usuarios: " + Tabela_universal.Rows.Count + "       Total de Adm: " + admi + "      Total de usuarios padrão:" + user;

            
        }
    }
}
