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
        int id_partida;
        public string J1ID = "jogador1";
        public string J2ID = "jogador2";
        public string J3ID = "jogador3";
        public string J4ID = "jogador4";
        public bool cheio = false;
        public string id;
        public string nome;
        public int numeroJogadores;
        public bool estadoSala = false;
        bool criador = false;
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
                    id = dt.Rows[0]["ID"].ToString();

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
            // código que já tem e salva no bd

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
        public bool getCheio()
        {
            return cheio;
        }
        public bool getEstadoSala()
        {
            return estadoSala;
        }

        public string getNovoJogador()
        {
            return novoJogador;
        }

        public bool getCriador()
        {
            return criador;
        }

        public int criaSala()
        {
            clSalas salas = new clSalas();
            id_sala = salas.CriarSala();

            numeroJogadores = 1;

            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            partida.Jogador_ID = Convert.ToInt32(id);
            partida.moedas = 0;

            salas.idSala = id_sala;
            DataTable dt =  salas.Pesquisar();
            partida.ordem = Convert.ToInt32(dt.Rows[0]["numeroJogadores"]);
            partida.CriarPartida();

            return id_sala;
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
            nj = Convert.ToInt32(dt.Rows[0]["numeroJogadores"]);
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

            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            DataTable dtPartida = partida.Pesquisar();

            for(int i = 0; i < nj; i++)
            {
                Debug.WriteLine("Funfou ");

                int ordem = Convert.ToInt32(dtPartida.Rows[i]["ordem"]);
                if (ordem == 1)
                {
                    idj1 = Convert.ToString(dtPartida.Rows[i]["Jogador_ID"]);
                }else if (ordem == 2)
                {
                    idj2 = Convert.ToString(dtPartida.Rows[i]["Jogador_ID"]);
                }else if (ordem == 3)
                {
                    idj3 = Convert.ToString(dtPartida.Rows[i]["Jogador_ID"]);
                }else if(ordem == 4)
                {
                    idj4 = Convert.ToString(dtPartida.Rows[i]["Jogador_ID"]);
                }
            }

            numeroJogadores = nj + 1;
            sala.Numero_jogadores = nj + 1;
            sala.Atualizar();

            partida.Jogador_ID = Convert.ToInt32(id);
            partida.moedas = 0;
            partida.ordem = nj + 1;
            partida.CriarPartida();

            string[] minhaArrayDeStrings = new string[] { idj1, idj2, idj3, idj4 };
            return minhaArrayDeStrings;
        }

        public string[] verificarJogadores()
        {
                int nj;

                clSalas sala = new clSalas();
                sala.idSala = id_sala;
                DataTable dt = sala.Pesquisar();

                /*if(Convert.ToString(dt.Rows[0]["jogador1"]) == id)
                {
                    criador = true;
                }*/


                nj = Convert.ToInt32(dt.Rows[0]["numeroJogadores"]);

                clPartida partida = new clPartida();
                partida.idSala = id_sala;
                DataTable dtPartida = partida.Pesquisar();

            clCliente cliente = new clCliente();

                cliente.idusuario = Convert.ToInt32(dt.Rows[0]["jogador1"]);
                DataTable dt1 = cliente.PesquisaPorID();
                this.J1ID = Convert.ToString(dt1.Rows[0]["Nome"]);


            if (nj != numeroJogadores)
                {
                    switch (numeroJogadores + 1)
                    {
                        case 2:
                            cliente.idusuario = Convert.ToInt32(dt.Rows[0]["jogador2"]);
                            DataTable dt2 = cliente.PesquisaPorID();
                            this.J2ID = Convert.ToString(dt2.Rows[0]["Nome"]);
                            numeroJogadores++;
                            break;
                        case 3:
                            cliente.idusuario = Convert.ToInt32(dt.Rows[0]["jogador3"]);
                            DataTable dt3 = cliente.PesquisaPorID();
                            this.J3ID = Convert.ToString(dt3.Rows[0]["Nome"]);
                            numeroJogadores++;
                            break;
                        case 4:
                            cliente.idusuario = Convert.ToInt32(dt.Rows[0]["jogador4"]);
                            DataTable dt4 = cliente.PesquisaPorID();
                            this.J4ID = Convert.ToString(dt4.Rows[0]["Nome"]);
                            numeroJogadores++;
                            cheio = true;
                            break;
                    }

                   }
                string[] nomesJogadores = new string[] { J1ID, J2ID, J3ID, J4ID };
            return nomesJogadores;

        }

        public void verificaEstadoSala() {
            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();

            if (Convert.ToInt32(dt.Rows[0]["estadoSala"]) == 2)
            {
                estadoSala = true;
            }
        }

        public void iniciarPartida()
        {
            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            sala.AtivarSala();
            DataTable dt = sala.Pesquisar();

            string j1Verifica = Convert.ToString(dt.Rows[0]["jogador1"]);

            if (j1Verifica == id)
            {
                Debug.WriteLine("Funfou " + j1Verifica);

                clPartida partida = new clPartida();
                partida.idSala = id_sala;
                partida.Num_jogadores = numeroJogadores;
                partida.Jogador_atual = 1;
                id_partida = partida.CriarPartida();
            }
            else
            {
                clPartida partida = new clPartida();
                partida.idSala = id_sala;
                DataTable dts = partida.Pesquisar();

                id_partida = Convert.ToInt32(dts.Rows[0]["ID_partida"]);
            }
        }


        public clUsuario getUsuarioLogado() {
                return this.usuarioLogado;
            }
        }

        public class LoginIncorretoException : Exception {

            public LoginIncorretoException() : base("usuário ou senha incorreta") { }
        }
    }
