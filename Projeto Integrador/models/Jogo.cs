using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
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
        public int J1PTID;
        public int J2PTID;
        public int J3PTID;
        public int J4PTID;
        int minhaOrdem = 1;
        public bool cheio = false;
        public bool partida = false;
        public bool minhaVez = false;
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

        public bool getPartida()
        {
            return partida;
        }
        public bool getMinhaVez()
        {
            return minhaVez;
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

        public void setCriador(bool t)
        {
            criador = t;
        }

        public int criaSala()
        {
            clSalas salas = new clSalas();
            salas.jogadorAtual = Convert.ToInt32(id);
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

            partida.Jogador_ID = Convert.ToInt32(id);
            partida.moedas = 0;
            partida.ordem = nj + 1;
            minhaOrdem = nj + 1;
            partida.CriarPartida();

            numeroJogadores = nj + 1;
            sala.Numero_jogadores = nj + 1;
            sala.Atualizar();


            string[] minhaArrayDeStrings = new string[] { idj1, idj2, idj3, idj4 };
            return minhaArrayDeStrings;
        }

        public string[] verificarJogadores()
        {
            int nj;

            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();
            nj = Convert.ToInt32(dt.Rows[0]["numeroJogadores"]);
            if(nj == 4)
            {
                cheio = true;
            }

            clPartida partida1 = new clPartida();
            partida1.idSala = id_sala;
            partida1.Jogador_ID = Convert.ToInt32(id);
            DataTable dtPartida1 = partida1.PesquisarPor2Itens();

            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            DataTable dtPartida = partida.Pesquisar();

            int idj1 = 0;
            int idj2 = 0;
            int idj3 = 0;
            int idj4 = 0;

            for (int i = 0; i < nj; i++)
            {

                int ordem = Convert.ToInt32(dtPartida.Rows[i]["ordem"]);
                if (ordem == 1)
                {
                    idj1 = Convert.ToInt32(dtPartida.Rows[i]["Jogador_ID"]);
                }
                else if (ordem == 2)
                {
                    idj2 = Convert.ToInt32(dtPartida.Rows[i]["Jogador_ID"]);
                }
                else if (ordem == 3)
                {
                    idj3 = Convert.ToInt32(dtPartida.Rows[i]["Jogador_ID"]);
                }
                else if (ordem == 4)
                {
                    idj4 = Convert.ToInt32(dtPartida.Rows[i]["Jogador_ID"]);
                }
            }

            if(! (idj1 == 0))
            {
                clCliente cliente = new clCliente();

                cliente.idusuario = idj1;
                DataTable dt1 = cliente.PesquisaPorID();
                this.J1ID = Convert.ToString(dt1.Rows[0]["Nome"]);
            }

            if (!(idj2 == 0))
            {
                clCliente cliente = new clCliente();

                cliente.idusuario = idj2;
                DataTable dt1 = cliente.PesquisaPorID();
                this.J2ID = Convert.ToString(dt1.Rows[0]["Nome"]);
            }

            if (!(idj3 == 0))
            {
                clCliente cliente = new clCliente();

                cliente.idusuario = idj3;
                DataTable dt1 = cliente.PesquisaPorID();
                this.J3ID = Convert.ToString(dt1.Rows[0]["Nome"]);
            }

            if (!(idj4 == 0))
            {
                clCliente cliente = new clCliente();

                cliente.idusuario = idj4;
                DataTable dt1 = cliente.PesquisaPorID();
                this.J4ID = Convert.ToString(dt1.Rows[0]["Nome"]);
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

        public void ativarSala2()
        {
            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();

            string jogadorAtual = Convert.ToString(dt.Rows[0]["jogadorAtual"]);


            if (jogadorAtual == id)
            {
                sala.AtivarSala();

            }
        }

        public string[] iniciarPartida()
        {
            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            DataTable dtPartida = partida.Pesquisar();


            

            int id1 = 0;
            int id2 = 0;
            int id3 = 0;
            int id4 = 0;

            clPartida partida1 = new clPartida();
            partida1.idSala = id_sala;
            DataTable dt1 = partida1.Pesquisar();

            int idCriador = Convert.ToInt32(dt1.Rows[0]["Jogador_ID"]);

            /*int contador = 0;
            do
            {

                "J"+contador+"PTID" = Convert.ToInt32(dt1.Rows[contador]["id_partida"]);
                contador++;
                contador = contador % 4;
            }
            while (contador != minhaOrdem - 1);*/


            if (minhaOrdem == 1)
            {

                J1PTID = Convert.ToInt32(dt1.Rows[0]["id_partida"]);
                J2PTID = Convert.ToInt32(dt1.Rows[1]["id_partida"]);
                J3PTID = Convert.ToInt32(dt1.Rows[2]["id_partida"]);
                J4PTID = Convert.ToInt32(dt1.Rows[3]["id_partida"]);

                id1 = Convert.ToInt32(id);
                id2 = Convert.ToInt32(dt1.Rows[1]["Jogador_ID"]);
                id3 = Convert.ToInt32(dt1.Rows[2]["Jogador_ID"]);
                id4 = Convert.ToInt32(dt1.Rows[3]["Jogador_ID"]);
            }else if(minhaOrdem == 2)
            {

                J1PTID = Convert.ToInt32(dt1.Rows[1]["id_partida"]);
                J2PTID = Convert.ToInt32(dt1.Rows[2]["id_partida"]);
                J3PTID = Convert.ToInt32(dt1.Rows[3]["id_partida"]);
                J4PTID = Convert.ToInt32(dt1.Rows[0]["id_partida"]);

                id1 = Convert.ToInt32(id);
                id2 = Convert.ToInt32(dt1.Rows[2]["Jogador_ID"]);
                id3 = Convert.ToInt32(dt1.Rows[3]["Jogador_ID"]);
                id4 = Convert.ToInt32(dt1.Rows[0]["Jogador_ID"]);
            }
            else if (minhaOrdem == 3)
            {

                J1PTID = Convert.ToInt32(dt1.Rows[2]["id_partida"]);
                J2PTID = Convert.ToInt32(dt1.Rows[3]["id_partida"]);
                J3PTID = Convert.ToInt32(dt1.Rows[0]["id_partida"]);
                J4PTID = Convert.ToInt32(dt1.Rows[1]["id_partida"]);

                id1 = Convert.ToInt32(id);
                id2 = Convert.ToInt32(dt1.Rows[3]["Jogador_ID"]);
                id3 = Convert.ToInt32(dt1.Rows[0]["Jogador_ID"]);
                id4 = Convert.ToInt32(dt1.Rows[1]["Jogador_ID"]);
            }
            else if (minhaOrdem == 4)
            {
                J1PTID = Convert.ToInt32(dt1.Rows[3]["id_partida"]);
                J2PTID = Convert.ToInt32(dt1.Rows[0]["id_partida"]);
                J3PTID = Convert.ToInt32(dt1.Rows[1]["id_partida"]);
                J4PTID = Convert.ToInt32(dt1.Rows[2]["id_partida"]);

                id1 = Convert.ToInt32(id);
                id2 = Convert.ToInt32(dt1.Rows[0]["Jogador_ID"]);
                id3 = Convert.ToInt32(dt1.Rows[1]["Jogador_ID"]);
                id4 = Convert.ToInt32(dt1.Rows[2]["Jogador_ID"]);
            }


            string id1s = "";
            string id2s = "";
            string id3s = "";
            string id4s = "";
            string idcs = "";

            clCliente cliente1 = new clCliente();
            cliente1.idusuario = id1;
            DataTable dt1nome = cliente1.PesquisaPorID();
            id1s = Convert.ToString(dt1nome.Rows[0]["Nome"]);

            clCliente cliente2 = new clCliente();
            cliente2.idusuario = id2;
            DataTable dt2nome = cliente2.PesquisaPorID();
            id2s = Convert.ToString(dt2nome.Rows[0]["Nome"]);

            clCliente cliente3 = new clCliente();
            cliente3.idusuario = id3;
            DataTable dt3nome = cliente3.PesquisaPorID();
            id3s = Convert.ToString(dt3nome.Rows[0]["Nome"]);

            clCliente cliente4 = new clCliente();
            cliente4.idusuario = id4;
            DataTable dt4nome = cliente4.PesquisaPorID();
            id4s = Convert.ToString(dt4nome.Rows[0]["Nome"]);

            clCliente clienteC = new clCliente();
            clienteC.idusuario = idCriador;
            DataTable dtCriador = clienteC.PesquisaPorID();
            idcs = Convert.ToString(dtCriador.Rows[0]["Nome"]);

            string[] nomesJogadores = new string[] { id1s, id2s, id3s, id4s, idcs };

            return nomesJogadores;
        }

        public bool verificaUsuarioCriador()
        {
            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            partida.Jogador_ID = Convert.ToInt32(id);
            DataTable dt = partida.Pesquisar();

            int ordem = Convert.ToInt32(dt.Rows[0]["ordem"]);
            if(ordem == 1)
            {
                return true;
            }
            return false;
        }

        public void atualizarPartidaMinhaVez()
        {
            if(verificaVez())
            {
                minhaVez = false;
            }
            else
            {
                minhaVez = true;
            }
        }

        public bool verificaVez()
        {
            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();
            string atual = dt.Rows[0]["jogadorAtual"].ToString();
            Debug.WriteLine("A: " + atual + " ID: " + id);
            if (atual == id)
            {
                return true;
            }
            return false;
        }

        public string verificaVezAlterada(string atual)
        {
            clSalas sala = new clSalas();
            sala.idSala = id_sala;
            DataTable dt = sala.Pesquisar();

            clCliente cliente = new clCliente();
            cliente.idusuario = Convert.ToInt32(dt.Rows[0]["jogadorAtual"]);
            DataTable dtProximo = cliente.PesquisaPorID();

            string novo = Convert.ToString(dtProximo.Rows[0]["Nome"]);

            if (novo == atual)
            {
                return atual;
            }
            return novo;
        }


        public string PassarVez()
        {
            clPartida partida = new clPartida();
            partida.idSala = id_sala;
            DataTable dt = partida.Pesquisar();

            int idProximo;

            if(minhaOrdem == 4)
            {
                idProximo = Convert.ToInt32(dt.Rows[0]["Jogador_ID"]);
            }
            else
            {
                idProximo = Convert.ToInt32(dt.Rows[minhaOrdem]["Jogador_ID"]);
            }

            clSalas sala = new clSalas();
            sala.jogadorAtual = idProximo;
            sala.AtualizarJogadorAtual();

            clCliente cliente = new clCliente();
            cliente.idusuario = idProximo;
            DataTable dtProximo = cliente.PesquisaPorID();
            return Convert.ToString(dtProximo.Rows[0]["Nome"]);
        }

        public string[] AtualizaMoedasPartida()
        {
            string[] moedas = new string[] {
                resgataMoeda(J1PTID),
                resgataMoeda(J2PTID),
                resgataMoeda(J3PTID),
                resgataMoeda(J4PTID)
            }; 
            return moedas;
        }

        public string resgataMoeda(int idPt)
        {
            clPartida partida = new clPartida();
            partida.idPartida = idPt;
            DataTable dt = partida.PesquisarIDPartida();

            return dt.Rows[0]["Moedas"].ToString();
        }

        public void funçãoMineradora()
        {
            clCartas carta = new clCartas();
            carta.ID_partida = J1PTID;
            carta.Mineradora();
        }

        public void funçãoSaqueadorP2()
        {
            clCartas carta = new clCartas();
            carta.ID_partida = J2PTID;
            carta.Saqueador();
        }
        public void funçãoSaqueadorP3()
        {
            clCartas carta = new clCartas();
            carta.ID_partida = J3PTID;
            carta.Saqueador();
        }
        public void funçãoSaqueadorP4()
        {
            clCartas carta = new clCartas();
            carta.ID_partida = J4PTID;
            carta.Saqueador();
        }

        public void funçãoNobre()
        {
            clCartas carta = new clCartas();
            carta.ID_partida = J1PTID;
            carta.Nobre();
        }

        public clUsuario getUsuarioLogado() {
                return this.usuarioLogado;
            }
        }

        public class LoginIncorretoException : Exception {

            public LoginIncorretoException() : base("usuário ou senha incorreta") { }
        }
    }
