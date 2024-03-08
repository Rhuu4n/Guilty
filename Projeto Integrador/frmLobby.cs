using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Threading;
using Projeto_Integrador.models;
using System.Diagnostics;

namespace Projeto_Integrador
{
    public partial class frmLobby : Form
    {

        public static int qnt_j;
        public static string newJ;
        public static int nj;
        public static string nj1;
        public static string nj2;
        public static string nj3;
        public static string nj4;

        public static string idj1;
        public static string idj2;
        public static string idj3;
        public static string idj4;
        
        public frmLobby()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(ExecutarTarefa));

            // Iniciando a execução da thread
            thread.Start();

            for (int j = 0; j < 5; j++)
            {
                Debug.WriteLine("Principal executando... " + j);
                Thread.Sleep(1000); // Espera 1 segundo antes de imprimir a próxima mensagem
            }

            // Espera a thread terminar antes de encerrar o programa
            thread.Join();

            Debug.WriteLine("Programa principal terminou.");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void atualizar_nomes(string j1, string j2, string j3, string j4)
        {

            if (j1 != "")
            {
                lblJ1.Text = j1;    
            }

            if (j2 != "")
            {
                lblJ2.Text = j2;
            }

            if (j3 != "")
            {
                lblJ3.Text = j3;
            }

            if (j4 != "")
            {
                lblJ4.Text = j4;
            }
        }

        static void ExecutarTarefa()
        {
            for (int j = 0; j < 5; j++)
            {
                Debug.WriteLine("Thread executando... " + j);
                Thread.Sleep(1000); // Espera 1 segundo antes de imprimir a próxima mensagem

            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJogoo frm = new frmJogoo();
            frm.ShowDialog();
            this.Show();
        }

        private void frmLobby_Load(object sender, EventArgs e)
        {
            if(Jogo.GetInstance().getIdSala() == 0)
            {
                lblJ1.Text = Jogo.GetInstance().getNome();

                label5.Text = Convert.ToString(Jogo.GetInstance().criaSala());
            }
            else
            {   
                nj = Jogo.GetInstance().pesquisarNumeroPlayers();


                string[] idj = Jogo.GetInstance().atualizarSala(nj);


                label5.Text = Convert.ToString(Jogo.GetInstance().getIdSala());
                atualizar_nomes(idj[0], idj[1], idj[2], idj[3]);
            }

            Jogo.GetInstance().entraSala(this);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
