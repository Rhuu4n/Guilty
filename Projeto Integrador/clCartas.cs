using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Integrador
{
    internal class clCartas
    {

        public string Acao;
        public string Jogador_afetado;
        public int ID_partida;
        private string[] players;
        private int currentPlayerIndex;
        private int[] playerCoins = new int[4];

        conectaBD BD = new conectaBD();


        public void Mineradora()
        {

            clPartida carta = new clPartida();

            try
            {
                int exOK = 0;

                BD._sql = "UPDATE Partida SET Acao = '" + Acao + "', Afetado = '" + Jogador_afetado + "' where id_partida = " + ID_partida;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar essa ação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


}
