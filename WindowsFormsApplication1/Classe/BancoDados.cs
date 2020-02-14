using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BancoDados
    {
        private static string StringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\Documents\AkinAcessorios\WindowsFormsApplication1\Database1.mdf;Integrated Security=True;";
        public static bool Login(string email, string senha)
        {
            SqlConnection Conexao = new SqlConnection(StringConexao);
            SqlCommand Comando = new SqlCommand("SELECT * FROM Contas",Conexao);
            Comando.CommandType = CommandType.Text;

            Conexao.Open();
            int info = Comando.ExecuteNonQuery();

            if (info > 0)
            {
                Conexao.Close();
                return true;
            }

            else
            {
                Conexao.Close();
                return false;
            }
            
        }
    }
}
