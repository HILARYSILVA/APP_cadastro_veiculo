using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace APP_cadastro_veiculo.Model
{
    public  class Combustivel
    {
        public int Id { get; set; }

        public string Nome { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                //Fazendo o insert no banco na tabela de cidades
                Banco.Comando = new MySql.Data.MySqlClient.MySqlCommand("USE carros; INSERT INTO Combustivel (nome) VALUES (@nome)", Banco.Conexao);
                //Criando os parâmetros
                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                //Executando o Comando
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();

                MessageBox.Show("TESTE", "CHEGFUEI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
              
                Banco.Comando = new MySql.Data.MySqlClient.MySqlCommand("delete from Combustivel where Id = @Id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySql.Data.MySqlClient.MySqlCommand("UPDATE Combustivel SET nome = @nome where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

    }

}

