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
        private static string StringConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\Documents\AkinAcessorios\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";



        public static string Login(string email, string senha)
        {
            SqlConnection Conexao = new SqlConnection(StringConexao);
            SqlCommand Comando = new SqlCommand("SELECT * FROM CONTAS WHERE email = '" + email + "' and senha = '" + senha + "'",Conexao);
            Comando.CommandType = CommandType.Text;

            try
            {
                Conexao.Open();
                SqlDataReader render = Comando.ExecuteReader();

                while (render.Read())
                {
                    VariaveisGlobais.NomeUsuario = render.GetString(2);
                    VariaveisGlobais.EmailUsuario = email;
                    VariaveisGlobais.FotoUsuario = render.GetString(3);

                    if (render.GetValue(3).ToString() == "admi")
                    {
                        return "101";
                        //110 - Usuario logado é um administrador
                    }

                    return "100";
                    //100 - Usuario cadastrado com sucesso
                }

                return "010";
                //010 - Usuario não cadastrado

            }

            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("erro " + e);
                return "000";
                //000 - Erro inesperado.
            }

            finally
            {
                Conexao.Close();
            }
            

            
            
        }

        public static string Cadastrar(string nome, string email, string senha)
        {
            SqlConnection Conexao = new SqlConnection(StringConexao);
            SqlCommand Comando = new SqlCommand("INSERT INTO Contas(email, nome, senha, tipoConta) VALUES('" + email + "', '" + nome + "', '" + senha + "', 'user')", Conexao);
            //SqlCommand Comando = new SqlCommand("INSERT INTO Contas(email, nome, senha, tipoConta) VALUES('" + "joaogabrieloliveira@gmail.com" + "', '" + "João Gabriel" + "', '" + "12345678" + "', 'user')", Conexao);
            Comando.CommandType = CommandType.Text;
            Conexao.Open();

            try
            {
                int info = Comando.ExecuteNonQuery();
                if (info > 0)
                {

                    return "111";
                    //E-mail cadastrado com sucesso
                }

                else if (info > 1)
                {
                    return "100";
                    //E-mail cadastrado
                }


                else
                {
                    return "001";
                    //001 - Ocorreu um erro e seu e-mail não foi cadastrado\nTente novamente mais tarde
                }
            }

            catch(Exception)
            {
                return "018";
                //118 - Erro caso já exista um email cadastrado com mesmo nome
            }

            finally
            {
                Conexao.Close();
            }
        }

        public static DataTable PegarContas()
        {
            DataTable table = new DataTable();
            SqlConnection Conexao = new SqlConnection(StringConexao);
            SqlDataAdapter Comando = new SqlDataAdapter("SELECT nome as 'Nome', email as 'E-mail', tipoConta as 'Tipo de conta' FROM CONTAS", Conexao);

            Conexao.Open();
            Comando.Fill(table);

            

            Conexao.Close();
            return table;
        }
    }
}
