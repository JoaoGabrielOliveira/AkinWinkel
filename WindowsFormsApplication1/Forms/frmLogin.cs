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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            VariaveisGlobais.CadastrarContas();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Alteracao(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                lbl_textemail.Visible = true;
            }

            else
            {
                lbl_textemail.Visible = false;
            }
            
        }

        private void AlteracaoSenha(object sender, EventArgs e)
        {
            if (txt_senha.Text == "")
            {
                lbl_textsenha.Visible = true;
            }           
                        
            else        
            {           
                lbl_textsenha.Visible = false;
            }
        }

        private void AlteracaoNome(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                lbl_textnome.Visible = true;
            }

            else
            {
                lbl_textnome.Visible = false;
            }
        }

        private void ClickEmailText(object sender, EventArgs e)
        {
            lbl_textemail.Visible = false;
            txt_email.Focus();
        }

        private void ClickSenhaText(object sender, EventArgs e)
        {
            lbl_textsenha.Visible = false;
            txt_senha.Focus();
        }

        private void ClickNomeText(object sender, EventArgs e)
        {
            lbl_textnome.Visible = false;
            txt_nome.Focus();
        }



        private void btn_logar_Click(object sender, EventArgs e)
        {
            string condicao = BancoDados.Login(txt_email.Text, txt_senha.Text);
            if (condicao == "100")
            {
                MessageBox.Show("Bem-Vindo ao Akin Winkel!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new TelaPrincipal().Show();
                this.Hide();
            }

            else if (condicao == "101")
            {
                MessageBox.Show("Bem-Vindo " + txt_email.Text, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmPerfilAdmi().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("E-mail ou senha não cadastrados ou incorretos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_logar_Click_Cadastro(object sender, EventArgs e)
        {
            string condicao = BancoDados.Cadastrar(txt_nome.Text, txt_email.Text, txt_senha.Text);

            switch (condicao)
            {
                case "111":
                    MessageBox.Show("E-mail cadastrado com sucesso!");
                    new TelaPrincipal().Show();
                    this.Hide();
                break;

                case "018":
                    MessageBox.Show("Esse e-mail já está cadastrado! Tente outro!");
                break;

                case "001":
                    MessageBox.Show("Ocorreu um erro e seu e-mail não foi cadastrado\nTente novamente mais tarde");
                break;

                default:
                    MessageBox.Show("Um erro inesperado ocorreu.\n Tente novamente mais tarde.");
                break;
            }
        }

        private void CriarConta(object sender, EventArgs e)
        {
            panel_nome.Visible = true;
            btn_logar.Text = "Cadastrar";
            this.btn_logar.Click -= new System.EventHandler(this.btn_logar_Click);
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click_Cadastro);
        }

        private void CriarContaHover(object sender, EventArgs e)
        {
            lbl_criarCadastro.ForeColor = Color.FromArgb(77, 145, 53);
        }

        private void CriarContaLeave(object sender, EventArgs e)
        {
            lbl_criarCadastro.ForeColor = Color.FromArgb(118, 194, 91);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
