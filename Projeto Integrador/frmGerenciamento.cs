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
    public partial class frmGerenciamento : Form
    {
        public frmGerenciamento()
        {
            InitializeComponent();
        }

        clCliente cliente = new clCliente();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    cliente.nome = txtPesquisa.Text;
                    dgvUsuario.DataSource = cliente.PesquisaPorNome();
                }

                //dgvUsuario.Columns[0].Visible = false;
                //dgvUsuario.Columns[3].Visible = false;
                //dgvUsuario.Columns[4].Visible = false;
                //dgvUsuario.Columns[5].Visible = false;
                //dgvUsuario.Columns[6].Visible = false;
                //dgvUsuario.Columns[7].Visible = false;
                //dgvUsuario.Columns[8].Visible = false;

                dgvUsuario.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvUsuario.SelectedRows;
                cliente.idusuario = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    cliente.Excluir();
                    cliente.CarregaClientes();

                    //txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvUsuario.DataSource = cliente.PesquisaPorNome();
        }

        private void frmGerenciamento_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsuario.DataSource = cliente.CarregaClientes();

                dgvUsuario.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPesquisa.Text == "Nome")
            {
            txtPesquisa.Text = "";
            }
        }
    }
}
