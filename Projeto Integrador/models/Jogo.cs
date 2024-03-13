using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador.models
{
    internal sealed class Jogo
    {
        private static Jogo _instance;
        int id_sala; 
        public string J1ID = "jogador1";
        public string J2ID = "jogador2";
        public string J3ID = "jogador3";
        public string J4ID = "jogador4";
        public bool cheio = false;
        public string id;
        public string nome;
        public int numeroJogadores;
        public string novoJogador;
        clUsuario usuarioLogado = null;
        frmLobby frmLobby = null;

        private Jogo() { }

        public static Jogo GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Jogo();
            }
            return _instance;
        }

        public void login(string nome, string senha)
        {
            clUsuario usuario = new clUsuario();
            usuario.nome = nome;

            try
            {
                DataTable dt = usuario.EfetuarLogin();
                


                if (dt.Rows.Count > 0 )
                {
                    id = dt.Rows[0]["id_usuario"].ToString();

                    string dbSenha = dt.Rows[0]["senha"].ToString();
                    if (dbSenha == senha)
                    {
                        this.usuarioLogado = usuario;
                        this.nome = nome;
                    }
                    else
                    {
                        this.usuarioLogado = null;
                        throw new LoginIncorretoException();
                    }
                }
                else
                {
                    this.usuarioLogado = null;
                    throw new LoginIncorretoException();
                }
            }
            catch (BdException ex)
            {
                this.usuarioLogado = null;
                throw ex;
            }
        }

        public bool cadastro(string nome, string senha, string email, string nascimento)
        {
            // código que já tem e salva no b

            clCliente cliente = new clCliente();
            cliente.nome = nome;
            cliente.senha = Convert.ToInt32(senha);
            cliente.email = email;
            cliente.nascimento = nascimento;

            try
            {
                int ret = cliente.Salvar();
            }
            catch (BdException ex)
            {
                this.usuarioLogado = null;
                throw ex;
            }

            return false;

        } 


        public static class emailvalido
        {
            public static bool verificaemail(string email)
            {
                try
                {
                    var enderecoemail = new System.Net.Mail.MailAddress(email);
                    return enderecoemail.Address == email;
                }

                catch
                {
                    return false;
                }
            }
        }

        public int getIdSala()
        {
            return id_sala;
        }

        public int getNumeroJogadores()
        {
            return numeroJogadores;
        }

        public bool setIdSala(int id)
        {
            clSalas sala = new clSalas();
            sala.idSala = id;
            DataTable dt = sala.Pesquisar();
            if (dt.Rows.Count < 1)
            {
                return false;
            }
            this.id_sala = id;
            return true;
        }

        public string getID()
        {
            return id;
        }

        public string getNome()
        {
            return nome;
        }

        public string getNovoJogador()
        {
            return novoJogador;
        }

        public int criaSala()
        {
            clSalas salas = new clSalas();
            salas.idEstadoSala = 1;
            salas.Numero_jogadores = 1;
            salas.J1 = Convert.ToInt32(id);

            /*while (qnt_j < 4)
            {
                salas.idSala = Convert.ToInt32(label5.Text); DataTable dt = salas.Pesquisar();
                nj = Convert.ToInt32(dt.Rows[0]["Numero_jogadores"]);

                qnt_j = nj;

                Thread.Sleep(1000);
            }*/

            return salas.CriarSala();
        }

        public int pesquisarNumeroPlayers()
        {
            int nj;
            clSalas sala = new clSalas();
            sala.idSala = id_sala; 
            DataTable dt = sala.Pesquisar();

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("erro");
                return -1;
            }
            nj = Convert.ToInt32(dt.Rows[0]["Numero_jogadores"]);
            return nj;
        }

        public string[] atualizarSala(int nj) {

            string idj1 = "";
            string idj2 = "";
            string idj3 = "";
            string idj4 = "";

            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();

            if (nj == 1)
            {
                idj1 = dt.Rows[0]["jogador1"].ToString();
                idj2 = id;
                idj3 = "";
                idj4 = "";
                sala.J2 = Convert.ToInt32(id);
                novoJogador = "jogador2";
            }
            else if (nj == 2)
            {
                idj1 = dt.Rows[0]["jogador1"].ToString();
                idj2 = dt.Rows[0]["jogador2"].ToString();
                idj3 = id;
                idj4 = "";

                sala.J3 = Convert.ToInt32(id);
                novoJogador = "jogador3";
            }
            else if (nj == 3)
            {
                idj1 = dt.Rows[0]["jogador1"].ToString();
                idj2 = dt.Rows[0]["jogador2"].ToString();
                idj3 = dt.Rows[0]["jogador3"].ToString();
                idj4 = id;

                sala.J4 = Convert.ToInt32(id);
                novoJogador = "jogador4";
            }

            numeroJogadores = nj;
            sala.Atualizar();

            string[] minhaArrayDeStrings = new string[] { idj1, idj2, idj3, idj4 };
            return minhaArrayDeStrings;
        }

        public void verificarJogadores()
        {
            while (!cheio)
            {
                int nj;



                clSalas sala = new clSalas();
                sala.idSala = id_sala;
                DataTable dt = sala.Pesquisar();



                nj = Convert.ToInt32(dt.Rows[0]["Numero_jogadores"]);
                this.J1ID = Convert.ToString(dt.Rows[0]["jogador1"]);



                if (nj != numeroJogadores)
                {
                    switch (nj)
                    {
                        case 1:
                            this.J2ID = Convert.ToString(dt.Rows[0]["jogador2"]);
                            numeroJogadores++;
                            break;
                        case 2:
                            this.J3ID = Convert.ToString(dt.Rows[0]["jogador3"]);
                            numeroJogadores++;
                            break;
                        case 3:
                            this.J4ID = Convert.ToString(dt.Rows[0]["jogador4"]);
                            numeroJogadores++;
                            break;
                        case 4:
                            cheio = true;
                            break;
                    }

                }
                this.frmLobby.atualizar_nomes(J1ID, J2ID, J3ID, J4ID);
                Thread.Sleep(1000); // Espera 1 segundo antes de imprimir a próxima mensagem
            }

        }

        public void entraSala(frmLobby pai)
        {



            this.frmLobby = pai;
            Thread thread = new Thread(new ThreadStart(verificarJogadores));
        }




        public clUsuario getUsuarioLogado() {
                return this.usuarioLogado;
            }
        }

        public class LoginIncorretoException : Exception {

            public LoginIncorretoException() : base("Nome de usuário ou senha incorretos") { }
        }
    }
