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

namespace Projeto_Integrador
{
    public partial class frmSalas : Form
    {
        public frmSalas()
        {
            InitializeComponent();

            btnCancelar.Load("https://i.imgur.com/ugKj9Rj.png");
            btnCancelar.SizeMode = PictureBoxSizeMode.StretchImage;

            btnEntrar.Load("https://i.imgur.com/AgYr59d.png");
            btnEntrar.SizeMode = PictureBoxSizeMode.StretchImage;

            pbEntrar.Load("https://i.imgur.com/srJs85d.png");
            pbEntrar.SizeMode = PictureBoxSizeMode.StretchImage;

            btnCriar.Load("https://i.imgur.com/mc4z2Z6.png");
            btnCriar.SizeMode= PictureBoxSizeMode.StretchImage;

            pbLogo.Load("https://i.imgur.com/4M8Eu4t.png");
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalas_Resize(object sender, EventArgs e)
        {
            //pnlSalas.Left = (this.Width / 2) - (pnlSalas.Width / 2);
            //pbGuilty.Left = (this.Width / 2) - (pbGuilty.Width / 2);
        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            Jogo.GetInstance().setIdSala(0);
            
            this.Hide();
            frmLobby frm = new frmLobby();
            frm.ShowDialog();
            this.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEntrar.Text.Length >= 6 && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo só aceita até 6 caracteres");
            }
        }

        private void txtEntrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Jogo.GetInstance().setIdSala(Convert.ToInt32(txtEntrar.Text));

            this.Hide();
            frmLobby frm = new frmLobby();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Jogo.GetInstance().setIdSala(Convert.ToInt32(txtEntrar.Text));

            this.Hide();
            frmLobby frm = new frmLobby();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            Jogo.GetInstance().setIdSala(0);

            this.Hide();
            frmLobby frm = new frmLobby();
            frm.ShowDialog();
            this.Show();
        }
    }
}
