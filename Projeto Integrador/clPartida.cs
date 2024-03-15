using System;
using System.Collections.Generic;
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
        public int idSala;
        public int Num_jogadores;
        public int Jogador_atual;
        public int Acao;
        public int Jogador_afetado;

        conectaBD BD = new conectaBD();

        public int CriarPartida()
        {
            int id = 0;
            try
            {

                Debug.WriteLine("Funfou ");

                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO Partida  (ID_sala, Num_jogadores, Jogador_atual) " +
                " values ('{0}','{1}','{2}')", idSala, Num_jogadores, Jogador_atual) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id >= 0)
                {
                    MessageBox.Show("Sala criada com sucesso!", " Sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
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
    }
}
