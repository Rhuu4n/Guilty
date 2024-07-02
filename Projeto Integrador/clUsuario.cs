using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using Projeto_Desktop;

namespace Projeto_Integrador
{
    class clUsuario
    {

        // atributos
        public int idusuario;
        public string nome;
        public string senha;

        conectaBD BD = new conectaBD();

        public DataTable EfetuarLogin()
        {
            try
            {
                // Definindo a consulta SQL com parâmetros para evitar SQL Injection
                BD._sql = "SELECT * FROM user WHERE nome = @nome AND delete_at IS NULL";

                // Definindo o parâmetro para a consulta
                BD.setParameter("@nome", nome);

                // Executando a consulta e retornando o resultado
                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                // Lidando com exceções e encapsulando-as em BdException
                throw new Exception();

                // Exibindo uma mensagem de erro (este código não será alcançado devido ao throw anterior)
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = "INSERT INTO user (nome, senha) VALUES (@nome, @senha); SELECT LAST_INSERT_ID();";

                // Definindo os parâmetros
                BD.setParameter("@nome", nome);
                BD.setParameter("@senha", senha);

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Usuario com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Usuario", "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            return id;

        }
    }
}
