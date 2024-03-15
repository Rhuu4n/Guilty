using Projeto_Integrador.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Integrador.models.Jogo;

namespace Projeto_Integrador
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();

            btnVoltar.Load("https://i.imgur.com/J4XhCAH.png");
            btnVoltar.SizeMode = PictureBoxSizeMode.StretchImage;

            btnCadastrar.Load("https://i.imgur.com/hZRjJ4T.png");
            btnCadastrar.SizeMode = PictureBoxSizeMode.StretchImage;

            pbGuilty.Load("https://i.imgur.com/4M8Eu4t.png");
            pbGuilty.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGuilty.BackColor = Color.Transparent;

            pb1.Load("https://i.imgur.com/srJs85d.png");
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.BackColor = Color.Transparent;

            pb2.Load("https://i.imgur.com/srJs85d.png");
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.BackColor = Color.Transparent;

            pb3.Load("https://i.imgur.com/srJs85d.png");
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.BackColor = Color.Transparent;

            pb4.Load("https://i.imgur.com/srJs85d.png");
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.BackColor = Color.Transparent;

            pb5.Load("https://i.imgur.com/srJs85d.png");
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.BackColor = Color.Transparent;

            pbMsenha1.Load("https://i.imgur.com/srJs85d.png");
            pbMsenha1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMsenha1.BackColor = Color.Transparent;

            pbMsenha2.Load("https://i.imgur.com/srJs85d.png");
            pbMsenha2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMsenha2.BackColor = Color.Transparent;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtSenha.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 8 caracteres");
            }

            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("insira apenas números");
            }
        }

        private void cbSenha2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSenha2.Checked)
            {
                txtSenha2.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha2.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSenha2.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 8 caracteres");
            }
        }


        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text.Length >= 12 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 12 caracteres", "Erro");
            }

        }

        private void frmCadastro_Resize(object sender, EventArgs e)
        {
            //pnlCadastro.Left = (this.Width / 2) - (pnlCadastro.Width / 2);
            pbGuilty.Left = (this.Width / 2) - (pbGuilty.Width / 2);
            //btnCadastrar2.Left = (this.Width / 2) - (btnCadastrar2.Width / 2);
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha2.Text == txtSenha.Text)
                {


                    Jogo.GetInstance().cadastro(txtUsuario.Text, txtSenha.Text, txtEmail.Text, txtIdad.Text);

                    // txtID.Text = Convert.ToString(cliente.Salvar());
                    /*
                    if (txtID.Text == "")
                    {

                    }
                    else
                    {
                        cliente.idcliente = int.Parse(txtID.Text);
                     //   cliente.Atualizar();
                    }
                    //MessageBox.Show("Você foi cadastrado com sucesso");
                    */
                }
                else
                {
                    MessageBox.Show("As Senhas não correspondem", "Confirme sua senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            }

        }

        private void txtSenha2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira apenas números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtSenha2.Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 8 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_2(object sender, EventArgs e)
        {
            if (Jogo.emailvalido.verificaemail(txtEmail.Text) && txtUsuario.Text != "")
            {
                try
                { 
                    if (txtSenha2.Text == txtSenha.Text)
                    {
                        Jogo.GetInstance().cadastro(txtUsuario.Text, txtSenha.Text, txtEmail.Text, txtIdad.Text);
                    }

                    else
                    {
                        MessageBox.Show("As senhas não correspondem ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Email ou Nome de Usuario inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            }
        }




        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

