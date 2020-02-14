using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class TelaPrincipal : Form
    {
        public string CodigoCarrinho;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            VariaveisGlobais.CadastrarProdutos();
            lbl_nome.Text = "Comprador: " + VariaveisGlobais.NomeUsuario;
        }

        public void Atualizar()
        {
            Tabelas_dos_Produtos.DataSource = VariaveisGlobais.CriarTabela();
            Tabela_do_Carrinho.DataSource   = VariaveisGlobais.CriarCarrinho();
            txt_total.Text = "Total: " + VariaveisGlobais.CarrinhoTotal.ToString("C");
        }

        private void btn_addProd_Click(object sender, EventArgs e)
        {
            int PosicaoVetor = int.Parse(VariaveisGlobais.ProdutoCodigo);
            uint QuantidadeProdutos = Decimal.ToUInt16(txt_Quantidade.Value);

            //Se ESTOQUE for maior que a quantidade que o usuario digitou, execute
            if (VariaveisGlobais.ProdutosEstoque[PosicaoVetor] >= txt_Quantidade.Value)
            {  

                if (VariaveisGlobais.ProdutosAuxiliar[PosicaoVetor] > 0)
                {

                    VariaveisGlobais.ProdutosAuxiliar[PosicaoVetor] += QuantidadeProdutos;
                }

                else
                {
                    VariaveisGlobais.ProdutosAuxiliar[PosicaoVetor] = QuantidadeProdutos;
                }
            
                VariaveisGlobais.ProdutosEstoque[PosicaoVetor] -= QuantidadeProdutos;
                VariaveisGlobais.CarrinhoTotal += VariaveisGlobais.ProdutosPreco[PosicaoVetor] * QuantidadeProdutos;

            }

            //Se não, ESTOQUE for menor que a quantidade que o usuario digitou, execute
            else
            {
                MessageBox.Show("Não há ESTOQUE suficiente para a QUANTIDADE digitada.");
            }

            Atualizar();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
                Atualizar();

                Tabelas_dos_Produtos.Enabled = true;
                  Tabela_do_Carrinho.Enabled = true;
                        txt_ProdNome.Enabled = true;
                       txt_ProdPreco.Enabled = true;
                      txt_Quantidade.Enabled = true;
                           txt_total.Enabled = true;
                         btn_addProd.Enabled = true;
                       btn_finalizar.Enabled = true;
                
                btn_iniciar.Enabled = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.RegistroCompra ="  Nome do Comprador:" + VariaveisGlobais.NomeUsuario;

            for (int i = 1; i < 11; i++)
            {
                if (VariaveisGlobais.ProdutosAuxiliar[i] > 0)
                {
                    if (VariaveisGlobais.ProdutosAuxiliar[i] < 10)
                    {
                        VariaveisGlobais.RegistroCompra += string.Format("\nCOD: {0}  | NOME: {1} | PREÇO:  {2} | QTDE: {3} | SUBTOTAL: {4}", VariaveisGlobais.ProdutosCodigo[i], VariaveisGlobais.ProdutosNome[i], VariaveisGlobais.ProdutosPreco[i].ToString("C"), VariaveisGlobais.ProdutosAuxiliar[i], (VariaveisGlobais.ProdutosPreco[i] * VariaveisGlobais.ProdutosAuxiliar[i]).ToString("C"));
                    }    
                    
                    else if(VariaveisGlobais.ProdutosPreco[i] < 10)
                    {
                        VariaveisGlobais.RegistroCompra += string.Format("\nCOD: {0}  | NOME: {1} | PREÇO:  {2} | QTDE: {3} | SUBTOTAL: {4}", VariaveisGlobais.ProdutosCodigo[i], VariaveisGlobais.ProdutosNome[i], VariaveisGlobais.ProdutosPreco[i].ToString("C"), VariaveisGlobais.ProdutosAuxiliar[i], (VariaveisGlobais.ProdutosPreco[i] * VariaveisGlobais.ProdutosAuxiliar[i]).ToString("C"));
                    }                                                               
                                                                                        
                    else                                                                
                    {                                                                   
                        VariaveisGlobais.RegistroCompra += string.Format("\nCOD: {0}  | NOME: {1} | PREÇO: {2} | QTDE: {3} | SUBTOTAL: {4}", VariaveisGlobais.ProdutosCodigo[i], VariaveisGlobais.ProdutosNome[i], VariaveisGlobais.ProdutosPreco[i].ToString("C"), VariaveisGlobais.ProdutosAuxiliar[i], (VariaveisGlobais.ProdutosPreco[i] * VariaveisGlobais.ProdutosAuxiliar[i]).ToString("C"));
                    }
                }
            }


            MessageBox.Show(VariaveisGlobais.RegistroCompra);

            Tabelas_dos_Produtos.Enabled = false;
            Tabela_do_Carrinho.Enabled = false;
            txt_ProdNome.Enabled = false;
            txt_ProdPreco.Enabled = false;
            txt_Quantidade.Enabled = false;
            btn_addProd.Enabled = false;
            btn_finalizar.Enabled = false;
            txt_total.Enabled = false;

            btn_iniciar.Enabled = true;

            Tabelas_dos_Produtos.DataSource = null;
            Tabela_do_Carrinho.DataSource = null;
        }

        private void Tabelas_dos_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VariaveisGlobais.ProdutoCodigo = Tabelas_dos_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString();

            txt_ProdNome.Text  = Tabelas_dos_Produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ProdPreco.Text = Tabelas_dos_Produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Tabela_do_Carrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoCarrinho = Tabela_do_Carrinho.Rows[e.RowIndex].Cells[0].Value.ToString();            
            this.btn_remCarrinho.Enabled = true;
        }

        private void btn_remCarrinho_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer excluir o produto?", "Decida", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                VariaveisGlobais.ProdutosEstoque[int.Parse(CodigoCarrinho)] += VariaveisGlobais.ProdutosAuxiliar[int.Parse(CodigoCarrinho)];
                VariaveisGlobais.ProdutosAuxiliar[int.Parse(CodigoCarrinho)] = 0;
                this.btn_remCarrinho.Enabled = false;
                Atualizar();
            }
        }

        private void txt_ProdNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
