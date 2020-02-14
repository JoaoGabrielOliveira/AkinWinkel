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

        private void button2_Click(object sender, EventArgs e)
        {
            if (BancoDados.Login(txt_email.Text, txt_senha.Text))
            {
                MessageBox.Show("E-mail cadastrado!");
                new TelaPrincipal().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("E-mail não cadastrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDados.Login(txt_email.Text, txt_senha.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
