using Projeto_Desktop;
using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
                BD._sql = "INSERT INTO salas (estadoSala, numeroJogadores, jogadorAtual) VALUES (@estadoSala, @numeroJogadores, @jogadorAtual); SELECT LAST_INSERT_ID();";

                // Definindo os parâmetros
                BD.setParameter("@estadoSala", 1);
                BD.setParameter("@numeroJogadores", 1);
                BD.setParameter("@jogadorAtual", jogadorAtual);

                BD.ExecutaComando(false, out id);

                    if (!(id >= 0))
                    {
                        Debug.WriteLine("Erro ao criar sala", "Erro", MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                }

                }

                catch (Exception ex)
                {
                    Debug.WriteLine("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }

                return id;

              }
            

            public DataTable Pesquisar()
            {
                try
                {
                    BD._sql = "SELECT * FROM salas WHERE id_sala = " + idSala + "";


                    return BD.ExecutaSelect();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            public void Atualizar()
            {
                try
                {
                    int exOK = 0;

                    BD._sql = "UPDATE salas SET numeroJogadores = " + Numero_jogadores + "  where id_sala = " + Jogo.GetInstance().getIdSala();

                    exOK = BD.ExecutaComando(false);



                    if (!(exOK == 1))
                    {
                        Debug.WriteLine("Erro ao alterar Usuario, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        public void AtualizarJogadorAtual()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE salas SET jogadorAtual = " + jogadorAtual + "  where id_sala = " + Jogo.GetInstance().getIdSala();

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    Debug.WriteLine("Jogada feita.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Debug.WriteLine("Erro ao alterar Usuario, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void AtivarSala()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE salas SET estadoSala = '" + 2 + "' where id_sala = " + Jogo.GetInstance().getIdSala();

                exOK = BD.ExecutaComando(false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
        
}


