using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class frmProdutosAdmi : Form
    {
        public frmProdutosAdmi()
        {
            InitializeComponent();
        }

        private void frmProdutosAdmi_Load(object sender, EventArgs e)
        {
            VariaveisGlobais.CadastrarProdutos();
            Tabelas_dos_Produtos.DataSource =  VariaveisGlobais.CriarTabela();
        }
    }
}
