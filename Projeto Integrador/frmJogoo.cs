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
        string[] moedas;
        private int currentPlayerIndex;
        private int[] playerCoins = new int[4];
        int acao1;
        int acao2;

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
            pbMoeda1.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda2.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda3.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoeda4.Load("https://i.imgur.com/g01U3w0.png");
            pbMoeda4.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pbFfundo.Load("https://i.imgur.com/8GCxhgw.png");
            pbFfundo.SizeMode = PictureBoxSizeMode.StretchImage;
            



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

        /*ajuste

        private void AjustarControles()
        {
            //1300; 788
            
            float larguraInicial = 1300;
            float alturaInicial = 788;

            float larguraFinal = this.Width;
            float alturaFinal = this.Height;

            //location largura e altura inicial
            
            pb1j1.Location = new Point((int) ( 702 - (larguraInicial - larguraFinal)), 598);
            pb1j1.Location = new Point((int)( 466 - (alturaInicial - alturaFinal)), 322);

            //size largura e altura

            float proporcaoLargura = larguraFinal / larguraInicial;
            float proporcaoAltura = alturaFinal / alturaInicial;
            
            pb1j1.Width = (int)(230 * proporcaoLargura);
            pb1j1.Height = (int)(323 * proporcaoAltura);

            //location largura e altura final

            pb1j1.Location = new Point((int) (702 - (larguraInicial / 2 - larguraFinal / 2)), 598);
            pb1j1.Location = new Point((int) (466 - (alturaInicial / 2 - larguraFinal / 2)), 322);

        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }

*/        

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
            while(!Jogo.GetInstance().getPartida())
            {
                Jogo.GetInstance().atualizarPartidaMinhaVez();

                if (Jogo.GetInstance().verificaVez())
                {
                    Debug.WriteLine("Agora é sua vez");
                    this.BeginInvoke(new Action(aparecer_cartas));
                }

                // quando é sua vez
                while (!Jogo.GetInstance().getMinhaVez())
                {
                    //Debug.WriteLine("Agora é sua vez");
                    Jogo.GetInstance().atualizarPartidaMinhaVez();
                    Thread.Sleep(1000);
                }

                moedas = Jogo.GetInstance().AtualizaMoedasPartida();
                atualizaMoedasTela();

                // quando não é sua vez
                while (Jogo.GetInstance().getMinhaVez())
                {
                    //Debug.WriteLine("Vez de outro jogador");
                    string parametro = lblVez.Text;
                    string resposta = Jogo.GetInstance().verificaVezAlterada(parametro);

                    if(!(parametro == resposta))
                    {
                        atualizaVez(resposta);
                        moedas = Jogo.GetInstance().AtualizaMoedasPartida();
                        atualizaMoedasTela();
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

        public void atualizaMoedasTela()
        {
            if (lblMP1.InvokeRequired)
            {
                lblMP1.BeginInvoke(new Action(atualizaMoedasTela));
                lblMP2.BeginInvoke(new Action(atualizaMoedasTela));
                lblMP3.BeginInvoke(new Action(atualizaMoedasTela));
                lblMP4.BeginInvoke(new Action(atualizaMoedasTela));
            }
            else
            {
                lblMP1.Text = moedas[0];
                lblMP2.Text = moedas[1];
                lblMP3.Text = moedas[2];
                lblMP4.Text = moedas[3];
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

            num1.Text = RandomClass.Next(1, 2).ToString();

            if (num1.Text == "1") // mineradora
            {
                clCartas cartas = new clCartas();
                cartas.Acao = "1";
                cartas.Jogador_afetado = "1";
                //cartas.ID_partida = Convert.ToInt32(.id);

                Jogo.GetInstance().funçãoMineradora();


                Jogo.GetInstance().PassarVez();

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
            Jogo.GetInstance().funçãoSaqueadorP3();
            esconder_icones();
            Jogo.GetInstance().PassarVez();
        }

        private async void btn1j1_Click_1(object sender, EventArgs e)
        {
            if (Jogo.GetInstance().verificaVez())
            {

                if (acao1 == 1) // mineradora
                {
                    Jogo.GetInstance().funçãoMineradora();

                    Jogo.GetInstance().PassarVez();
                    esconder_icones();

                }

                else if (acao1 == 2) // saqueador
                {
                    btnRoubar1.Visible = true;
                    btnRoubar2.Visible = true;
                    btnRoubar3.Visible = true;

                }
                else if (acao1 == 3) // nobre
                {
                    Jogo.GetInstance().funçãoNobre();

                    Jogo.GetInstance().PassarVez();
                    esconder_icones();
                }
            }


            
            
        }
        
        Random RandomClass = new Random();

        async void aparecer_cartas()
        {
           

            acao1 = this.RandomClass.Next(1, 4);
            acao2 = this.RandomClass.Next(1, 4);

            if (acao1 == 1) // mineradora
            {
                pb1j1.Load("https://i.imgur.com/q44KeIY.jpg");
            }

            else if (acao1 == 2) // saqueador
            {
                pb1j1.Load("https://i.imgur.com/opUd1Kc.jpg");

            }
            else if (acao1 == 3) // nobre
            {
                pb1j1.Load("https://i.imgur.com/jOmLsCD.jpg");
            }

            if (acao2 == 1) // mineradora 2
            {


                pb2j1.Load("https://i.imgur.com/q44KeIY.jpg");

            }

            else if (acao2 == 2) // saqueador 2
            {
                pb2j1.Load("https://i.imgur.com/opUd1Kc.jpg");

            }
            else if (acao2 == 3) // nobre 2
            {
                pb2j1.Load("https://i.imgur.com/jOmLsCD.jpg");
            }

        }

        void esconder_icones()
        {
            pb1j1.Load("https://i.imgur.com/zx9oyXi.jpg");
            pb2j1.Load("https://i.imgur.com/zx9oyXi.jpg");
            btnRoubar1.Visible = false;
            btnRoubar2.Visible = false;
            btnRoubar3.Visible = false;
        }

        private async void pictureBox1_Click_1(object sender, EventArgs e)
        {

            if (Jogo.GetInstance().verificaVez())
            {
                if (acao2 == 1) // mineradora
                {
                    Jogo.GetInstance().funçãoMineradora();
                    await Task.Delay(1000);

                    Jogo.GetInstance().PassarVez();
                    esconder_icones();

                }

                else if (acao2 == 2) // saqueador
                {
                    btnRoubar1.Visible = true;
                    btnRoubar2.Visible = true;
                    btnRoubar3.Visible = true;

                }
                else if (acao2 == 3) // nobre
                {
                    Jogo.GetInstance().funçãoNobre();

                    await Task.Delay(1000);

                    Jogo.GetInstance().PassarVez();
                    esconder_icones();
                }
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

        private void lblNomej3_Click(object sender, EventArgs e)
        {

        }

        private void btnRoubar1_Click_1(object sender, EventArgs e)
        {
            Jogo.GetInstance().funçãoSaqueadorP4();
            esconder_icones();
            Jogo.GetInstance().PassarVez();
        }

        private void pbFundomesa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRoubar3_Click_1(object sender, EventArgs e)
        {
            Jogo.GetInstance().funçãoSaqueadorP2();
            esconder_icones();
            Jogo.GetInstance().PassarVez();
        }
    }
}