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
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador
{
    public partial class frmLobby : Form
    {

        public static int qnt_j;
        public static int nj;
        public static string newJ;
        public static string nj1;
        public static string nj2;
        public static string nj3;
        public static string nj4;
        public static string idj1;
        public static string idj2;
        public static string idj3;
        public static string idj4;
        string[] nomes;

        public frmLobby()
        {
            InitializeComponent();

            btnVoltar.Load("https://i.imgur.com/J4XhCAH.png");
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbJogadores.Load("https://i.imgur.com/srJs85d.png");
            pbJogadores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbJ1.Load("https://i.imgur.com/srJs85d.png");
            pbJ1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbJ2.Load("https://i.imgur.com/srJs85d.png");
            pbJ2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbJ3.Load("https://i.imgur.com/srJs85d.png");
            pbJ3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbJ4.Load("https://i.imgur.com/srJs85d.png");
            pbJ4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbID.Load("https://i.imgur.com/srJs85d.png");
            pbID.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLbl.Load("https://i.imgur.com/srJs85d.png");
            pbLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            btnIniciar.Load("https://i.imgur.com/BWlFdCI.png");
            btnIniciar.SizeMode = PictureBoxSizeMode.StretchImage;
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
                Jogo.GetInstance().setIdSala(Jogo.GetInstance().criaSala());
                label5.Text = Jogo.GetInstance().getIdSala().ToString();
            }
            else
            {   
                nj = Jogo.GetInstance().pesquisarNumeroPlayers();


                string[] idj = Jogo.GetInstance().atualizarSala(nj);


                label5.Text = Convert.ToString(Jogo.GetInstance().getIdSala());
                atualizar_nomes(idj[0], idj[1], idj[2], idj[3]);
            }


            Thread threadAtualizacaoNomes = new Thread(new ThreadStart(threadAtualizarNomes));
            threadAtualizacaoNomes.Start();
            /*threadAtualizacaoNomes += () => {
                this.Hide();
            };*/


//            Jogo.GetInstance().entraSala(this);

        }


        private void threadAtualizarNomes()
        {
            while (!Jogo.GetInstance().getCheio())
            {
                nomes = Jogo.GetInstance().verificarJogadores();
                AtualizarNomesNaThread(nomes[0]);

                Thread.Sleep(800);

            }

            while (!Jogo.GetInstance().getEstadoSala())
            {
                Jogo.GetInstance().verificaEstadoSala();
                Thread.Sleep(800);
            }

            if (!Jogo.GetInstance().getCriador())
            {
                this.BeginInvoke(new Action(fechaForm));
            }

        }

        public void fechaForm()
        {
            this.Hide();
            frmJogoo frm = new frmJogoo();
            frm.ShowDialog();
            this.Show();
        }

        private void AtualizarNomesNaThread(string Texto)
        {
            if(lblJ1.InvokeRequired)
            {
                lblJ1.BeginInvoke(new Action<string>(AtualizarNomesNaThread), nomes[0]);
                lblJ1.BeginInvoke(new Action<string>(AtualizarNomesNaThread), nomes[1]);
                lblJ1.BeginInvoke(new Action<string>(AtualizarNomesNaThread), nomes[2]);
                lblJ1.BeginInvoke(new Action<string>(AtualizarNomesNaThread), nomes[3]);
            }
            else
            {
                lblJ1.Text = nomes[0];
                lblJ2.Text = nomes[1];
                lblJ3.Text = nomes[2];
                lblJ4.Text = nomes[3];
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbJ4_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (Jogo.GetInstance().numeroJogadores == 4)
            {
                this.Hide();
                frmJogoo frm = new frmJogoo();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("A sala ainda não está cheia");
            }
        }
    }
}
