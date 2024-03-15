using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

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
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CADASTRO (NOME,NASCIMENTO, EMAIL, SENHA) " +
                                              " values ('{0}','{1}','{2}','{3}' )",
                                              nome, nascimento, email, senha) + "; SELECT SCOPE_IDENTITY();";

                id = BD.ExecutaComando(false, out id);


                if (id > 0)
                {
                    MessageBox.Show("Usuário  cadastrado com sucesso!", "Cadastro com sucesso", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Usuário", "Erro", MessageBoxButtons.OK, 
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
                int exOK = 0;

                BD._sql = "DELETE FROM CADASTRO WHERE ID_USUARIO = " + idusuario;
                
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

                BD._sql = "UPDATE CLIENTE SET NOME = '" + nome + "', Nascimento = '" + nascimento + "', Email = '" + email +
                    "', Senha = '" + senha + "', where id_cliente = " + idusuario;

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
                BD._sql = "SELECT * FROM CADASTRO " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void PesquisaPorCPFCNPJ()
        {

        }

        public void PesquisaPorRGIE()
        {

        }
        public DataTable CarregaClientes()
        {
            try
            {
                BD._sql = "SELECT * FROM CADASTRO ";

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
