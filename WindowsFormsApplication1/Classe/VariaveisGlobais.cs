using System;
using System.Data;
using MySql.Data;
using System.Data.Common;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class VariaveisGlobais
    {
        public static string[,] NomeUsuarios = new string[11,11];


        public static string NomeUsuario;
        public static string EmailUsuario;
        public static string FotoUsuario = "";

        public static uint[]    ProdutosEstoque  = new uint[11];
        public static string[]  ProdutosNome     = new string[11];
        public static double[]  ProdutosPreco    = new double[11];
        public static uint[]    ProdutosCodigo   = new uint[11];
        public static uint[]    ProdutosAuxiliar = new uint[11];

        public static string ProdutoCodigo; //Quando o usuario clica no produto, a variavel gaurda o códgo do produto clicado.

        public static double CarrinhoTotal = 0;

        public static string RegistroCompra = ""; //Cupum fiscal da compra.

        public static void CadastrarProdutos()
        {
            //Atribuição de Valores as Variaveis
            for (int i = 0; i < ProdutosAuxiliar.Length; i++)
            {
                ProdutosAuxiliar[i] = 0;
            }

            ProdutosCodigo[0] = 0;
            ProdutosCodigo[1] = 0001;
            ProdutosCodigo[2] = 0002;
            ProdutosCodigo[3] = 0003;
            ProdutosCodigo[4] = 0004;
            ProdutosCodigo[5] = 0005;
            ProdutosCodigo[6] = 0006;
            ProdutosCodigo[7] = 0007;
            ProdutosCodigo[8] = 0008;
            ProdutosCodigo[9] = 0009;
            ProdutosCodigo[10] = 0010;
                   
            ProdutosPreco[0] = 0;
            ProdutosPreco[1] = 10.00;
            ProdutosPreco[2] = 15.50;
            ProdutosPreco[3] = 79.99;
            ProdutosPreco[4] = 25.00;
            ProdutosPreco[5] = 30.90;
            ProdutosPreco[6] = 7.00;
            ProdutosPreco[7] = 5.00;
            ProdutosPreco[8] = 10.00;
            ProdutosPreco[9] = 20.90;
            ProdutosPreco[10] = 105.90;
                   
            ProdutosEstoque[0] = 0;
            ProdutosEstoque[1] = 10;
            ProdutosEstoque[2] = 15;
            ProdutosEstoque[3] = 19;
            ProdutosEstoque[4] = 12;
            ProdutosEstoque[5] = 10;
            ProdutosEstoque[6] = 14;
            ProdutosEstoque[7] = 13;
            ProdutosEstoque[8] = 16;
            ProdutosEstoque[9] = 20;
            ProdutosEstoque[10] = 20;
                   
            ProdutosNome[0] = "";
                   
            ProdutosNome[1]  = "Brinco";
            ProdutosNome[2]  = "Bolsa";
            ProdutosNome[3]  = "Turbante";
            ProdutosNome[4]  = "Capulana";
            ProdutosNome[5]  = "Anel";
            ProdutosNome[6]  = "Tiara";
            ProdutosNome[7]  = "Colar";
            ProdutosNome[8]  = "Estojo";
            ProdutosNome[9]  = "Óculos";
            ProdutosNome[10] = "Pulseira";
        }

        public static void CadastrarContas()
        {
            NomeUsuarios[1,0] = "joao@gmail.com";
            NomeUsuarios[1, 1] = "12345678";
        }

        public static DataTable CriarTabela()
        {
            DataTable dbTabela = new DataTable();

            dbTabela.Columns.Add("Código", typeof(uint));
            dbTabela.Columns.Add("Nome", typeof(string));
            dbTabela.Columns.Add("Preço", typeof(string));
            dbTabela.Columns.Add("Estoque", typeof(uint));


            for (int i = 1; i < 11; i++)
            {
                dbTabela.Rows.Add(ProdutosCodigo[i], ProdutosNome[i], ProdutosPreco[i].ToString("C"), ProdutosEstoque[i]);

                
            }

            return dbTabela;
        }

        public static DataTable CriarCarrinho()
        {
            DataTable dbProdutos = new DataTable();

            dbProdutos.Columns.Add("Código", typeof(uint));
            dbProdutos.Columns.Add("Nome", typeof(string));
            dbProdutos.Columns.Add("Preço", typeof(string));
            dbProdutos.Columns.Add("Quantidade", typeof(uint));
            dbProdutos.Columns.Add("SubTotal", typeof(string));

            for (int i = 1; i < 11; i++)
            {
                if (ProdutosAuxiliar[i] > 0)
                {
                    dbProdutos.Rows.Add(ProdutosCodigo[i], ProdutosNome[i].Trim(), ProdutosPreco[i].ToString("C"), ProdutosAuxiliar[i], (ProdutosPreco[i] * ProdutosAuxiliar[i]).ToString("C"));
                }
            }

            return dbProdutos;
        }

        public static bool Login(string email, string senha)
        {
            for (int i = 0; i < 11; i++)
            {
                if (VariaveisGlobais.NomeUsuarios[i,0] == email && VariaveisGlobais.NomeUsuarios[i,1] == senha)
                {
                    NomeUsuario = NomeUsuarios[i, 0];
                    return true;
                }
            }
            
            return false;
        }
    }

}
