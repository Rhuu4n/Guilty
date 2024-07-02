using Projeto_Desktop;
using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    class clPartida
    {
        // atributos
        public int idPartida;
        public int Jogador_ID;
        public int idSala;
        public int Num_jogadores;
        public int Jogador_atual;
        public int Acao;
        public int Jogador_afetado;
        public int moedas;
        public int ordem;

        private string[] players;
        private int currentPlayerIndex;
        private int[] playerCoins = new int[4];

        conectaBD BD = new conectaBD();

        public int CriarPartida()
        {
            int id = 0;
            try
            {

                BD._sql = "INSERT INTO matches (id_sala, Jogador_ID, Ordem, Moedas) VALUES (@idSala, @Jogador_ID, @Ordem, @Moedas); SELECT LAST_INSERT_ID();";

                // Definindo os parâmetros
                BD.setParameter("@idSala", idSala);
                BD.setParameter("@Jogador_ID", Jogador_ID);
                BD.setParameter("@Ordem", ordem);
                BD.setParameter("@Moedas", moedas);

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
                BD._sql = "SELECT * FROM matches WHERE id_sala =" + idSala + " ORDER BY Ordem";



                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PesquisarPor2Itens()
        {
            try
            {
                BD._sql = "SELECT * FROM matches WHERE id_sala = @idSala AND Jogador_ID = @Jogador_ID";

                // Definindo os parâmetros
                BD.setParameter("@idSala", idSala);
                BD.setParameter("@Jogador_ID", Jogador_ID);


                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public  DataTable PesquisarIDPartida()
        {
            try
            {
                conectaBD BD = new conectaBD();
                BD._sql = "SELECT * FROM matches " +
                         " WHERE id_partida = " + idPartida + "";


                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }





        public static void adcCoins(int player, int moedas, int idSala)
        {
            conectaBD BD = new conectaBD();
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE matches SET Moedas = '" + moedas + "'where id_sala = " + idSala + "' and Jogador_ID ='" + player;

                exOK = BD.ExecutaComando(false);

                /*if (exOK == 1)
                {

                }
                else
                {
                    MessageBox.Show("Erro ao alterar Cliente, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public  void removeCoins(int player, int idSala, int moedas)
        {
            conectaBD BD = new conectaBD();
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE matches SET Moedas = '" + (moedas - 2) + "'where id_sala = " + idSala + "' and Jogador_ID ='" + player;

                exOK = BD.ExecutaComando(false);

                /*if (exOK == 1)
                {

                }
                else
                {
                    MessageBox.Show("Erro ao alterar Cliente, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


}
