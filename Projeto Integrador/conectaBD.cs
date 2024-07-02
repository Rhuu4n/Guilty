using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop
{
    public class conectaBD
    {
        public string _strConexao;
        public string _sql;
        private MySqlCommand _comandoSQL;
        private MySqlConnection _conn;
        private MySqlTransaction _transacao;

        private MySqlCommand ComandoSQL
        {
            get { return _comandoSQL; }
            set { _comandoSQL = value; }
        }

        public conectaBD()
        {
            try
            {
                using (StreamReader str = new StreamReader("conexao.ini"))
                {
                    _strConexao = str.ReadLine();
                    if (string.IsNullOrEmpty(_strConexao))
                    {
                        throw new Exception("5 String de conexão está vazia.");
                    }
                    _conn = new MySqlConnection(_strConexao);
                    _comandoSQL = new MySqlCommand();
                    _comandoSQL.Connection = _conn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("6 Erro ao ler a string de conexão: " + ex.Message);
            }
        }

        public conectaBD(string stringConexao)
        {
            try
            {
                _strConexao = stringConexao;
                if (string.IsNullOrEmpty(_strConexao))
                {
                    throw new Exception("7 String de conexão está vazia.");
                }
                _conn = new MySqlConnection(_strConexao);
                _comandoSQL = new MySqlCommand();
                _comandoSQL.Connection = _conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("8 Erro ao inicializar a conexão: " + ex.Message);
            }
        }

        public void setParameter(String var, object foto)
        {
            _comandoSQL.Parameters.AddWithValue(var, foto);
        }

        public bool AbreConexao(bool transacao)
        {
            try
            {
                _conn.Open();
                if (transacao)
                {
                    _transacao = _conn.BeginTransaction();
                    _comandoSQL.Transaction = _transacao;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("9 Erro ao abrir a conexão: " + ex.Message);
                return false;
            }
        }

        public bool FechaConexao()
        {
            try
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("10 Erro ao fechar a conexão: " + ex.Message);
                return false;
            }
        }

        public void FinalizaTransacao(bool commit)
        {
            try
            {
                if (commit)
                    _transacao.Commit();
                else
                    _transacao.Rollback();
                FechaConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("11 Erro ao finalizar a transação: " + ex.Message);
            }
        }

        ~conectaBD()
        {
            FechaConexao();
        }

        public int ExecutaComando(bool transacao = false)
        {
            int retorno = -1;
            try
            {
                AbreConexao(transacao);
                _comandoSQL.CommandText = _sql;
                retorno = _comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("12 Erro ao executar o comando: " + ex.Message);
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        public int ExecutaComando(bool transacao, out int ultimoCodigo)
        {
            int retorno = -1;
            ultimoCodigo = 0;
            try
            {
                AbreConexao(transacao);
                _comandoSQL.CommandText = _sql;
                ultimoCodigo = Convert.ToInt32(_comandoSQL.ExecuteScalar());
                retorno = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("13 Erro ao executar o comando com retorno: " + ex.Message);
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        public DataTable ExecutaSelect()
        {
            DataTable dt = new DataTable();
            try
            {
                AbreConexao(false);
                _comandoSQL.CommandText = _sql;
                dt.Load(_comandoSQL.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("14 Erro ao executar o select: " + ex.Message);
                dt = null;
            }
            finally
            {
                FechaConexao();
            }
            return dt;
        }

        public double ExecutaScalar()
        {
            double retorno = -1;
            try
            {
                AbreConexao(false);
                _comandoSQL.CommandText = _sql;
                retorno = Convert.ToDouble(_comandoSQL.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("15 Erro ao executar o scalar: " + ex.Message);
            }
            finally
            {
                FechaConexao();
            }
            return retorno;
        }
    }
}
