using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
            LoadCustomFont();

            /*imagem fundo
            pbLoginfundo.Load("https://i.imgur.com/f0xYqNO.jpg");
            pbLoginfundo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoginfundo.BackColor = Color.Transparent;*/

            pbGuilty.Load("https://i.imgur.com/4M8Eu4t.png");
            pbGuilty.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGuilty.BackColor = Color.Transparent;

            pbLogin.Load("https://i.imgur.com/srJs85d.png");
            pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin.BackColor = Color.Transparent;

            pbSenha.Load("https://i.imgur.com/srJs85d.png");
            pbSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSenha.BackColor = Color.Transparent;

            btnCancelar.Load("https://i.imgur.com/xLH1qbP.png");
            btnCancelar.SizeMode = PictureBoxSizeMode.StretchImage;

            btnConfirmar.Load("https://i.imgur.com/cMcSMRP.png");
            btnConfirmar.SizeMode = PictureBoxSizeMode.StretchImage;

            btnCadastro.Load("https://i.imgur.com/hZRjJ4T.png");
            btnCadastro.SizeMode = PictureBoxSizeMode.StretchImage;

            pbLogo.Load("https://i.imgur.com/K771TBD.png");
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadCustomFont()
        {
            // Caminho para o arquivo .ttf (considere ajustar conforme necessário)
            string fontPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Minecraft.ttf");

            // Verifica se o arquivo da fonte existe
            if (System.IO.File.Exists(fontPath))
            {
                // Carrega a fonte personalizada
                PrivateFontCollection privateFonts = new PrivateFontCollection();
                privateFonts.AddFontFile(fontPath);

                // Define a fonte personalizada para o controle Label
                if (privateFonts.Families.Length > 0)
                {
                    Font customFont = new Font(privateFonts.Families[0], 16f);
                    label1.Font = customFont;
                    label2.Font = customFont;
                    btnTeste.Font = customFont;
                    btnTeste.Font = new Font(privateFonts.Families[0], 12f);
                    btnGerenciador.Font = customFont;
                    btnGerenciador.Font = new Font(privateFonts.Families[0], 12f);
                }
                else
                {
                    MessageBox.Show("Falha ao carregar a fonte personalizada.");
                }
            }
            else
            {
                MessageBox.Show("O arquivo da fonte personalizada não foi encontrado.");
            }

        }

        bool logado = false;

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCadastro frm = new frmCadastro();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cbSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSenha.Text.Length >= 8 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 8 caracteres");
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text.Length >= 12 && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 12 caracteres");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //pbGuilty.Width= 532;
            //pbGuilty.Height= 412;

            //pnlLogin.Width= 300;
           // pnlLogin.Height= 100;

           // pnlGuilty.Width = 400;
          //  pnlGuilty.Height = 180;

            //pictureBox1.Width = 204;
            //pictureBox1.Height = 96;

          //  txtUsuario.Width = 300;
//txtUsuario.Height = 62;

           // pictureBox2.Width = 204;
           // pictureBox2.Height = 60;

          //  txtSenha.Width = 300;
          //  txtSenha.Height = 62;

          //  cbSenha.Width = 200;
          //  cbSenha.Height = 32;

         //   btnConfirmar.Width = 286;
          //  btnConfirmar.Height = 48;

          //  btnCadastro.Width = 286;
          //  btnCadastro.Height = 48;

            Form1_Resize(null, null);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbGuilty.Left = (this.Width / 2) - (pbGuilty.Width / 2);
           // lblLogin.Left = (this.Width / 2) - (lblLogin.Width / 2);
            //pnlLogin.Left =(this.Width / 2) - (pnlLogin.Width / 2);
           // pnlLogin.Top = (this.Height / 2) - (pnlLogin.Height / 2);
            //pnlGuilty.Left = (this.Width / 2) - (pnlGuilty.Width / 2);
        }

        private void btnCadastro_KeyUp(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clUsuario usuario = new clUsuario();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                     
     //ELDES{{
            try {
                Jogo.GetInstance().login(txtUsuario.Text, txtSenha.Text);
                if (Jogo.GetInstance().getUsuarioLogado() != null)
                {
                    logado = true;
                    this.Close();
                } 
                
            }
            catch (LoginIncorretoException ex) {
                MessageBox.Show("Erro, usúario ou senha inválidos", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (BdException ex)
            {
                MessageBox.Show(ex.ToString(), "Erro de conexão com servidor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            
            /*
            usuario.nome = txtUsuario.Text;
            DataTable dt = usuario.EfetuarLogin();

            frmLogin.id = dt.Rows[0]["id_usuario"].ToString();
            frmLogin.nome = dt.Rows[0]["nome"].ToString();

            try
            {

                if (dt.Rows.Count > 0)
                {
                    string senha = dt.Rows[0]["senha"].ToString();
                    if (txtSenha.Text == senha)
                    {
                        logado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro, senha inválida", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Erro, login inválido", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                //this.Hide();
                //frmSalas frm = new frmSalas();
                //frm.ShowDialog();
                //this.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            //}}ELDES


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmJogoo frm = new frmJogoo();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGerenciamento frm = new frmGerenciamento();
            frm.ShowDialog();
            this.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logado == false)
            {
                Application.Exit();
            }
            
        }

        private void btnGerenciador_Click(object sender, EventArgs e)
        {
            frmGerenciamento frm = new frmGerenciamento();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin")
            {
                btnTeste.Visible = true;
                btnGerenciador.Visible = true;
            }
            else
            {
                btnTeste.Visible = false;
                btnGerenciador.Visible = false;
            }

            //ELDES{{
            try
            {
                Jogo.GetInstance().login(txtUsuario.Text, txtSenha.Text);
                if (Jogo.GetInstance().getUsuarioLogado() != null)
                {
                    logado = true;
                    this.Close();
                }

            }
            catch (LoginIncorretoException ex)
            {
                MessageBox.Show("Erro, usúario ou senha inválidos", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (BdException ex)
            {
                MessageBox.Show(ex.ToString(), "Erro de conexão com servidor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            /*
            usuario.nome = txtUsuario.Text;
            DataTable dt = usuario.EfetuarLogin();

            frmLogin.id = dt.Rows[0]["id_usuario"].ToString();
            frmLogin.nome = dt.Rows[0]["nome"].ToString();

            try
            {

                if (dt.Rows.Count > 0)
                {
                    string senha = dt.Rows[0]["senha"].ToString();
                    if (txtSenha.Text == senha)
                    {
                        logado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro, senha inválida", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Erro, login inválido", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                //this.Hide();
                //frmSalas frm = new frmSalas();
                //frm.ShowDialog();
                //this.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            //}}ELDES
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmCadastro frm = new frmCadastro();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pbGuilty_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
