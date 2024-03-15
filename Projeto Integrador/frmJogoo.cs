using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
            pbMiner1.Load("https://i.imgur.com/UBNX8Js.jpeg");
            pbMiner1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMiner2.Load("https://i.imgur.com/UBNX8Js.jpeg");
            pbMiner2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSaq1.Load("https://i.imgur.com/wqB1ms3.jpeg"); 
            pbSaq1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSaq2.Load("https://i.imgur.com/wqB1ms3.jpeg");
            pbSaq2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda1.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda2.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda3.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda4.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda4.SizeMode = PictureBoxSizeMode.StretchImage;



            // Sistema de passar a vez

            players = new string[] { "Jogador 1", "Jogador 2", "Jogador 3", "Jogador 4" };
            currentPlayerIndex = 0;


            // Configurar os rótulos para exibir as moedas dos jogadores
            Label[] coinLabels = { lblMoedaP1, lblMoedaP2, lblMoedaP3, lblMoedaP4 };

            for (int i = 0; i < playerCoins.Length; i++)
            {
                coinLabels[i].Text = $"x{playerCoins[i]}";
            }

        }

        private void frmJogoo_Load(object sender, EventArgs e)
        {
            Jogo.GetInstance().iniciarPartida();
        }

        public void adcCoins(int player)
        {
            if (player >= 0 && player < 4)
            {
                if (playerCoins[player] < 10)
                {
                    playerCoins[player]++;
                    MessageBox.Show($"O jogador {player + 1} agora possui {playerCoins[player]} moeda(s).", "Moedas Atualizadas");

                    // Atualizar o rótulo correspondente
                    Label[] coinLabels = { lblMoedaP1, lblMoedaP2, lblMoedaP3, lblMoedaP4 };
                    coinLabels[player].Text = $"x{playerCoins[player]}";

                    //números aleatórios



                }
                else
                {
                    MessageBox.Show($"O Jogador {player + 1} juntou 10 moedas e ganhou o jogo, parabéns!");
                }
            }
            else
            {
                MessageBox.Show("Jogador inválido. Escolha um número de jogador entre 1 e 4.", "Jogador Inválido");
            }
        }

        public void removeCoins(int player, int player2)
        {
            if (player >= 0 && player < 4)
            {
                if (playerCoins[player] < 10)
                {
                    playerCoins[player]++;
                    MessageBox.Show($"O jogador {player + 1} agora possui {playerCoins[player]} moeda(s).", "Moedas Atualizadas");

                    // Atualizar o rótulo correspondente
                    Label[] coinLabels = { lblMoedaP1, lblMoedaP2, lblMoedaP3, lblMoedaP4 };
                    coinLabels[player].Text = $"x{playerCoins[player]}";

                    //números aleatórios



                }
                else
                {
                    MessageBox.Show($"O Jogador {player + 1} juntou 10 moedas e ganhou o jogo, parabéns!");
                }
            }
            else
            {
                MessageBox.Show("Jogador inválido. Escolha um número de jogador entre 1 e 4.", "Jogador Inválido");
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
            MessageBox.Show($"{players[currentPlayerIndex]}, é a sua vez.");
            lblVez.Text = players[currentPlayerIndex];
            nudPlayer.Value = currentPlayerIndex;

            //vez jogador 1
            if (nudPlayer.Value == 0)
            {
                btn1j1.Enabled = true;
                btn2j1.Enabled = true;
                btnEncerrar.Enabled = true;
            }
            else
            {
                btn1j1.Enabled = false;
                btn2j1.Enabled = false;
                //btnEncerrar.Enabled = false;
            }
            /*btn1j1.Enabled = false;
            btn2j1.Enabled = false;
            btnEncerrar.Enabled = false;*/
            pb1j1.Visible = true;
            pb2j1.Visible = true;
            btnRoubar1.Visible = false;
            btnRoubar2.Visible = false;
            btnRoubar3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

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


            int player = (int)nudPlayer.Value;

            if (player >= 0 && player < 4)
            {
                if (playerCoins[player] < 10)
                {
                    playerCoins[player]++;
                    MessageBox.Show($"O jogador {player + 1} agora possui {playerCoins[player]} moeda(s).", "Moedas Atualizadas");

                    //mostrar botões de roubo

                    btnRoubar1.Visible = true;
                    btnRoubar2.Visible = true;
                    btnRoubar3.Visible = true;

                    // Atualizar o rótulo correspondente
                    Label[] coinLabels = { lblMoedaP1, lblMoedaP2, lblMoedaP3, lblMoedaP4 };
                    coinLabels[player].Text = $"x{playerCoins[player]}";
                }
                else
                {
                    MessageBox.Show($"O Jogador {player + 1} juntou 10 moedas e ganhou o jogo, parabéns!");
                }
            }
            else
            {
                MessageBox.Show("Jogador inválido. Escolha um número de jogador entre 1 e 4.", "Jogador Inválido");
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


            int player = (int)nudPlayer.Value;

            Random RandomClass = new Random();

            num1.Text = RandomClass.Next(1, 4).ToString();

            if (num1.Text == "1") // mineradora
            {
                adcCoins(player);
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbFundo1_Click(object sender, EventArgs e)
        {

        }

        private void pbFundo2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void btnRoubar1_Click(object sender, EventArgs e)
        {
            int player = (int)nudPlayer.Value;

            removeCoins(player, player);
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

        private void pbFundomesa_Click(object sender, EventArgs e)
        {

        }

        private void btnSairjogo_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit ();
        }
    }
}