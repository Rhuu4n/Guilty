using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using Projeto_Desktop;

namespace Projeto_Integrador
{
    public class clCliente
    {
        // atributos
        public int idusuario;
        public string nome;
        public string nascimento;
        public string email;
        public int senha;
        // public string cpf;
        // public string cep;
        // public string endereco;
        // public string complemento;
        // public string bairro;
        // public string uf;
        // public string cidade;
        // public string telefone;

        conectaBD BD = new conectaBD();

        // métodos
        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = "INSERT INTO user (nome, nascimento, email, senha) VALUES (@nome, @nascimento, @email, @senha); SELECT LAST_INSERT_ID(); ";

                // Definindo os parâmetros
                BD.setParameter("@nome", nome);
                BD.setParameter("@nascimento", nascimento);
                BD.setParameter("@email", email);
                BD.setParameter("@senha", senha);

                id = BD.ExecutaComando(false, out id);


                if (id > 0)
                {
                    MessageBox.Show("Usuário  cadastrado com sucesso!", "Cadastro com sucesso", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar UsuárioTESTE", "Erro", MessageBoxButtons.OK, 
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

        public void Excluir()
        {
            try
            {
                DateTime agora = DateTime.Now;
                DateTime dt = Convert.ToDateTime(agora);
                string agoraFormatado = agora.ToString("yyyy-MM-dd HH:mm");
                int exOK = 0;

                BD._sql = "UPDATE user SET delete_at = @agoraFormatado WHERE ID = @idusuario";

                // Definindo os parâmetros
                BD.setParameter("@agoraFormatado", agoraFormatado);
                BD.setParameter("@idusuario", idusuario);

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Usuario deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE user SET nome = '" + nome + "', nascimento = '" + nascimento + "', email = '" + email +
                    "', senha = '" + senha + "', where id = " + idusuario;

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Usuario Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Usuario, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         

        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM user WHERE nome LIKE @nome";

                // Definindo o parâmetro
                BD.setParameter("@nome", "%" + nome + "%");

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PesquisaPorID()
        {
            try
            {
                BD._sql = "SELECT * FROM user WHERE id LIKE @idusuario";

                // Definindo o parâmetro
                BD.setParameter("@idusuario", "%" + idusuario + "%");

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable CarregaClientes()
        {
            try
            {
                BD._sql = "SELECT id, nome, email, nascimento FROM user WHERE delete_at IS NULL";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



    }
}
