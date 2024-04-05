using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Integrador
{
        class clSalas
        {

            // atributos
            public int idSala;
            public int EstadoSala;
            public int Numero_jogadores;
            public int J1;
            public int J2;
            public int J3;
            public int J4;
            public int jogadorAtual;

        conectaBD BD = new conectaBD();

            public int CriarSala()
            {
                int id = 0;
                try
                {
                    BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Sala  (estadoSala, numeroJogadores, jogadorAtual) " +
                    " values ('{0}','{1}','{2}')", 1, 1, jogadorAtual) + "; SELECT SCOPE_IDENTITY();";

                    BD.ExecutaComando(false, out id);

                    if (!(id >= 0))
                    {
                        MessageBox.Show("Erro ao criar sala", "Erro", MessageBoxButtons.OK,
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
            

            public DataTable Pesquisar()
            {
                try
                {
                    BD._sql = "SELECT * FROM Sala " +
                             " WHERE id_sala = " + idSala + "";


                    return BD.ExecutaSelect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            public void Atualizar()
            {
                try
                {
                    int exOK = 0;

                    BD._sql = "UPDATE Sala SET numeroJogadores = " + Numero_jogadores + "  where id_sala = " + Jogo.GetInstance().getIdSala();

                    exOK = BD.ExecutaComando(false);



                    if (exOK == 1)  
                    {
                        MessageBox.Show("Entrou na sala!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void AtualizarJogadorAtual()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE Sala SET jogadorAtual = " + jogadorAtual + "  where id_sala = " + Jogo.GetInstance().getIdSala();

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Entrou na sala!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void AtivarSala()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE Sala SET estadoSala = '" + 2 + "' where id_sala = " + Jogo.GetInstance().getIdSala();

                exOK = BD.ExecutaComando(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
        
}


