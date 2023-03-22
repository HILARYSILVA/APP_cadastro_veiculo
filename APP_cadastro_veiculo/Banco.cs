 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace APP_cadastro_veiculo
{
    public class Banco
    {
        
        public static MySqlConnection Conexao;
        
        public static MySqlCommand Comando;
        
        public static MySqlDataAdapter Adaptador;
        
        public static DataTable dataTabela;
        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();

                Comando = new MySqlCommand("USE carros;", Conexao);
                Comando.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS carros; USE carros", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Combustivel " +
                    "(Id integer auto_increment primary key," +
                    "nome varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                    "(Id integer auto_increment primary key, " +
                    "nome varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Fabricante " +
                    "(Id integer auto_increment primary key, " +
                    "nome char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Tipo " +
                    "(Id integer auto_increment primary key, " +
                    "nome varchar(40)) ", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes " +
                    "(Id integer auto_increment primary key, " +
                    "nome varchar(40)) ", Conexao);
                Comando.ExecuteNonQuery();


                FecharConexao();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
