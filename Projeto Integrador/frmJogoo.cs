using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projeto_Integrador
{
    public partial class frmJogoo : Form
    {
        private string[] players;
        private int currentPlayerIndex;
        private int[] playerCoins = new int[4];

        public frmJogoo()
        {
            InitializeComponent();
            AjustarControles();
            pbFundomesa.Load("https://i.imgur.com/Gk2e30F.jpg");
            pbFundomesa.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1j1.Load("https://i.imgur.com/zx9oyXi.jpg");
            pb1j1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2j1.Load("https://i.imgur.com/zx9oyXi.jpg");
            pb2j1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1j2.Load("https://i.imgur.com/p8v59pT.png");
            pb1j2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2j2.Load("https://i.imgur.com/p8v59pT.png");
            pb2j2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1j3.Load("https://i.imgur.com/zx9oyXi.jpg");
            pb1j3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2j3.Load("https://i.imgur.com/zx9oyXi.jpg");
            pb2j3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1j4.Load("https://i.imgur.com/oEdSdtt.png");
            pb1j4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2j4.Load("https://i.imgur.com/oEdSdtt.png");
            pb2j4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda1.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda2.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda3.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda4.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMiner1.Load("https://i.imgur.com/q44KeIY.jpeg");
            pbMiner1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMiner2.Load("https://i.imgur.com/q44KeIY.jpeg");
            pbMiner2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSaq1.Load("https://i.imgur.com/opUd1Kc.jpeg");
            pbSaq1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSaq2.Load("https://i.imgur.com/opUd1Kc.jpeg");
            pbSaq2.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEncerrar.Load("https://i.imgur.com/Pnhp3XQ.png");
            btnEncerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRoubar1.Load("https://i.imgur.com/ac5gsVo.png");
            btnRoubar1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRoubar2.Load("https://i.imgur.com/ac5gsVo.pngg");
            btnRoubar2.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRoubar3.Load("https://i.imgur.com/ac5gsVo.png");
            btnRoubar3.SizeMode = PictureBoxSizeMode.StretchImage;
            btnOpcoes.Load("https://i.imgur.com/fh1rTGx.png");
            btnOpcoes.SizeMode = PictureBoxSizeMode.StretchImage;
            btn1j1.Load("https://i.imgur.com/6BAQ6UD.png");
            btn1j1.SizeMode = PictureBoxSizeMode.StretchImage;
            btn2j1.Load("https://i.imgur.com/6BAQ6UD.png");
            btn2j1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnResumir.Load("https://i.imgur.com/mhTTklq.png");
            btnResumir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSair.Load("https://i.imgur.com/EZdHbue.png");
            btnSair.SizeMode= PictureBoxSizeMode.StretchImage;
            btnSairjogo.Load("https://i.imgur.com/NwbfW17.png");
            btnSairjogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbfundoJ1.Load("https://i.imgur.com/8GCxhgw.png");
            pbfundoJ1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbfundoJ2.Load("https://i.imgur.com/8GCxhgw.png");
            pbfundoJ2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbfundoJ3.Load("https://i.imgur.com/8GCxhgw.png");
            pbfundoJ3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbfundoJ4.Load("https://i.imgur.com/8GCxhgw.png");
            pbfundoJ4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFundoJatual.Load("https://i.imgur.com/8GCxhgw.png");
            pbFundoJatual.SizeMode = PictureBoxSizeMode.StretchImage;



            /*
            // Sistema de passar a vez

            players = new string[] { "Jogador 1", "Jogador 2", "Jogador 3", "Jogador 4" };
            currentPlayerIndex = 0;


            // Configurar os rótulos para exibir as moedas dos jogadores
            Label[] coinLabels = { lblMoedaP1, lblMoedaP4, lblMoedaP3, lblMoedaP2 };

            for (int i = 0; i < playerCoins.Length; i++)
            {
                coinLabels[i].Text = $"x{playerCoins[i]}";
            }
            */
        }

        //ajuste

        private void AjustarControles()
        {
            float larguraInicial = 1920;
            float alturaInicial = 1080;

            float larguraFinal = this.Width;
            float alturaFinal = this.Height;

            //location largura e altura inicial
            
            pb1j1.Location = new Point((int) ( 702 - (larguraInicial - larguraFinal)), 702);
            pb1j1.Location = new Point((int)( 466 - (alturaInicial - alturaFinal)), 466);

            //size largura e altura

            float proporcaoLargura = larguraFinal / larguraInicial;
            float proporcaoAltura = alturaFinal / alturaInicial;
            
            pb1j1.Width = (int)(230 * proporcaoLargura);
            pb1j1.Height = (int)(323 * proporcaoAltura);

            //location largura e altura final

            pb1j1.Location = new Point((int) (702 - (larguraInicial / 2 - larguraFinal / 2)), 1218);
            pb1j1.Location = new Point((int) (466 - (alturaInicial / 2 - larguraFinal / 2)), 614);

        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }

        //ajuste

        public void atualizar_nomes(string j1, string j2, string j3, string j4, string jc)
        {
            lblNomej1.Text = j1;
            lblNomej4.Text = j2;
            lblNomej3.Text = j3;
            lblNomej2.Text = j4;
            lblVez.Text = jc;
        }


        private void frmJogoo_Load(object sender, EventArgs e)
        {
            string[] idj = Jogo.GetInstance().iniciarPartida();
            atualizar_nomes(idj[0], idj[1], idj[2], idj[3], idj[4]);


            // lblJ1.BeginInvoke(new Action<string>(AtualizarNomesNaThread), nomes[0]);

            Thread threadPartida = new Thread(new ThreadStart(atualizacaoPartida));
            threadPartida.Start();
        }

        void atualizacaoPartida()
        {
            while(!Jogo.GetInstance().getPartida()){
                Jogo.GetInstance().atualizarPartidaMinhaVez();

                // quando é sua vez
                while (!Jogo.GetInstance().getMinhaVez())
                {
                    Debug.WriteLine("minha vez");
                    Jogo.GetInstance().atualizarPartidaMinhaVez();
                    Thread.Sleep(1000);
                } 
                
                // quando não é sua vez
                while (Jogo.GetInstance().getMinhaVez())
                {
                    Debug.WriteLine("n é minha vez ");
                    string parametro = lblVez.Text;
                    string resposta = Jogo.GetInstance().verificaVezAlterada(parametro);

                    if(!(parametro == resposta))
                    {
                        atualizaVez(resposta);
                        Jogo.GetInstance().AtualizaMoedasPartida();
                    }

                    Thread.Sleep(1000);
                }
            }
        }

        public void atualizaVez(string param)
        {
            if(lblVez.InvokeRequired)
            {
                lblVez.BeginInvoke(new Action<string>(atualizaVez), param);
            }else
            {
                lblVez.Text = param;
            }
        }

        public void adcCoins(int player)
        {

        }

        public void removeCoins(int player, int player2)
        {
            
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pbFundomesa.Load("https://i.imgur.com/MU36yPp.jpg");
            btnOpcoes.Visible = false;
            btnResumir.Visible = true;
            btnSair.Visible = true;
            btnSairjogo.Visible = true;
            btn1j1.Visible = false;
            btn2j1.Visible = false;
            btnEncerrar.Visible = false;

            //frmOpcoes frm = new frmOpcoes();
            //frm.ShowDialog();
            //this.Show();



            /*Image grayscaleImage = new Bitmap(this.BackgroundImage.Width, this.BackgroundImage.Height, this.BackgroundImage.PixelFormat);
            ImageAttributes attributes = new ImageAttributes();
            ColorMatrix grayscaleMatrix = new ColorMatrix(new float[][] {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] {      0,      0,      0, 1, 0 },
                new float[] {      0,      0,      0, 0, 1 },
            });

            attributes.SetColorMatrix(grayscaleMatrix);

            using (Graphics g = Graphics.FromImage(grayscaleImage))
            {
                g.DrawImage(this.BackgroundImage, new Rectangle(0, 0, grayscaleImage.Width, grayscaleImage.Height),
                0, 0, grayscaleImage.Width, grayscaleImage.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            */
            //this.BackgroundImage = grayscaleImage;
        }

            private void button4_Click(object sender, EventArgs e)
        {
            //btnResumir.Visible = false;
            //btnSair.Visible = false;
            //btnSairjogo.Visible = false;
            btn1j1.Visible = true;
            btn2j1.Visible = true;
            btnEncerrar.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         ;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (pb1j1.Visible == true)
            {
                pb2j1.Visible = false;
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
            }
            else
            {
            }


            
        }

        private void btn1j1_Click(object sender, EventArgs e)
        {
            if (pb2j1.Visible == true)
            {
                pb1j1.Visible = false;
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
            }
            else
            {
            }



            Random RandomClass = new Random();

            num1.Text = RandomClass.Next(1, 4).ToString();

            if (num1.Text == "1") // mineradora
            {
                clCartas cartas = new clCartas();
                cartas.Acao = "1";
                cartas.Jogador_afetado = "1";
                //cartas.ID_partida = Convert.ToInt32(.id);

                cartas.Mineradora();

            }
            else if (num1.Text == "2")
            {
                if (pb1j1.Visible == true)
                {
                    pb2j1.Visible = false;
                    btn1j1.Enabled = false;
                    btn2j1.Enabled = false;
                }
                else
                {
                }

                btnRoubar1.Visible = true;
                btnRoubar2.Visible = true;
                btnRoubar3.Visible = true;


            }

            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
            //Application.Exit();
        }
        private void btnRoubar1_Click(object sender, EventArgs e)
        {

            clCartas cartas = new clCartas();
            cartas.Acao = "1";
            cartas.Jogador_afetado = "1";
            //cartas.ID_partida = Convert.ToInt32(frmLogin.id);

            cartas.Mineradora();
        }

        private void btnRoubar3_Click(object sender, EventArgs e)
        {

        }

        private void btnResumir_Click(object sender, EventArgs e)
        {
            pbFundomesa.Load("https://i.imgur.com/Gk2e30F.jpg");
            btnOpcoes.Visible = true;
            btnResumir.Visible = false;
            btnSair.Visible = false;
            btnSairjogo.Visible = false;
            btn1j1.Visible = true;
            btn2j1.Visible = true;
            btnEncerrar.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSairjogo_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btnSairjogo_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(1);
        }

        private void btnSairjogo_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(1);
        }

        private void pbFundomesa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Jogo.GetInstance().verificaVez())
            {
                btn1j1.Enabled = true;
                btn2j1.Enabled = true;
                btnEncerrar.Enabled = true;
                Jogo.GetInstance().PassarVez();
            }
            else
            {
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
            }
            pb1j1.Visible = true;
            pb2j1.Visible = true;
            btnRoubar1.Visible = false;
            btnRoubar2.Visible = false;
            btnRoubar3.Visible = false;
        }

        private void btnRoubar2_Click(object sender, EventArgs e)
        {

        }

        private void btnRoubar2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn1j1_Click_1(object sender, EventArgs e)
        {
            if (pb2j1.Visible == true)
            {
                pb1j1.Visible = false;
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
            }
            else
            {
            }



            Random RandomClass = new Random();

            num1.Text = RandomClass.Next(1, 4).ToString();

            if (num1.Text == "1") // mineradora
            {
                clCartas cartas = new clCartas();
                cartas.Acao = "1";
                cartas.Jogador_afetado = "1";
                //cartas.ID_partida = Convert.ToInt32(.id);

                cartas.Mineradora();

            }
            else if (num1.Text == "2")
            {
                if (pb1j1.Visible == true)
                {
                    pb2j1.Visible = false;
                    btn1j1.Enabled = false;
                    btn2j1.Enabled = false;
                }
                else
                {
                }

                btnRoubar1.Visible = true;
                btnRoubar2.Visible = true;
                btnRoubar3.Visible = true;


            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pb1j1.Visible == true)
            {
                pb2j1.Visible = false;
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
            }
            else
            {
            }



            
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            pbFundomesa.Load("https://i.imgur.com/MU36yPp.jpg");
            btnOpcoes.Visible = false;
            btnResumir.Visible = true;
            btnSair.Visible = true;
            btnSairjogo.Visible = true;
            btn1j1.Visible = false;
            btn2j1.Visible = false;
            btnEncerrar.Visible = false;

            //frmOpcoes frm = new frmOpcoes();
            //frm.ShowDialog();
            //this.Show();



            /*Image grayscaleImage = new Bitmap(this.BackgroundImage.Width, this.BackgroundImage.Height, this.BackgroundImage.PixelFormat);
            ImageAttributes attributes = new ImageAttributes();
            ColorMatrix grayscaleMatrix = new ColorMatrix(new float[][] {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] {      0,      0,      0, 1, 0 },
                new float[] {      0,      0,      0, 0, 1 },
            });

            attributes.SetColorMatrix(grayscaleMatrix);

            using (Graphics g = Graphics.FromImage(grayscaleImage))
            {
                g.DrawImage(this.BackgroundImage, new Rectangle(0, 0, grayscaleImage.Width, grayscaleImage.Height),
                0, 0, grayscaleImage.Width, grayscaleImage.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            */
            //this.BackgroundImage = grayscaleImage;
        }

        private void btnResumir_Click_1(object sender, EventArgs e)
        {
            pbFundomesa.Load("https://i.imgur.com/Gk2e30F.jpg");
            btnOpcoes.Visible = true;
            btnResumir.Visible = false;
            btnSair.Visible = false;
            btnSairjogo.Visible = false;
            btn1j1.Visible = true;
            btn2j1.Visible = true;
            btnEncerrar.Visible = true;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSairjogo_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(1);
        }

        private void pbMoeda2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}