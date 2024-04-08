using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

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
                BD._sql = "SELECT * FROM Cadastro " + " WHERE Nome LIKE '"+nome+"' and Delete_At IS NOT NULL";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                //ELDES{{
                throw new BdException(ex);
                
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
                
                //}}ELDES

            }
        }


    public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Cadastro  ( Nome, Senha ) " +
                " values ('{0}','{1}')", nome, senha ) + "; SELECT SCOPE_IDENTITY();";

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
