	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Class Layer                              * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: rul_Cliente                              * 
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 09:42:19                         * 
	 *                                                    *  
	 *                                                    *  
	*********************************************************/

using System;
using System.Data;
using Business_DataBase;

namespace LojaElfez.BusinessClass
{

	/// <summary>
	/// Definicao da Classe cls_Cliente
	/// Esta classe representa o objeto Cliente no banco de dados
	/// Todas as operacoes basicas (Inclusao, Alteracao, Exclusao, Consulta) sao feitas por esta classe
	/// Que utilizada internamente pela clase rul_Cliente
	/// 
	/// Nota: Esta classe nao deve ser instanciada dentro do projeto, pois a arquitetura de camadas
	/// Define a classe rul_Cliente para utilizacao na camada de apresentacao do projeto
	/// 
	/// </summary>
	public class cls_Cliente
	{
        #region "Variaveis" 

			private  int _cliente = -1;
			private  String _cpf_cnpj = String.Empty;
			private  String _nome = String.Empty;
			private  String _email = String.Empty;
			private  String _endereco = String.Empty;
			private  String _bairro = String.Empty;
			private  String _cidade = String.Empty;
			private  String _estado = String.Empty;
			private  String _ddd = String.Empty;
			private  String _telefonefixo = String.Empty;
			private  String _telefonecelular = String.Empty;
			private  String _cep = String.Empty;
			private  String _observacoes = String.Empty;
			private  String _login = String.Empty;
			private  String _senha = String.Empty;
			private  DateTime _datainclusao = new DateTime();

        private String _mensagem = "";

        #endregion

        #region "Construtures" 

        public cls_Cliente()
        {
        }

        /// <summary>
        /// Construtor da Classe Cliente com passagem de parametros da Chave Primaria
        /// </summary>
        public cls_Cliente(  int par_cliente)
        {
            try
            {
					this.cliente = par_cliente;
 
            }
            catch (Exception ex)
            {
                this.mensagem = ex.Message;
            }
        }

        #endregion

        #region "Propriedades" 
			public  int cliente
			{
				get {return _cliente;}
				set {_cliente = value;}
			}

			public  String cpf_cnpj
			{
				get {return _cpf_cnpj;}
				set {_cpf_cnpj = value;}
			}

			public  String nome
			{
				get {return _nome;}
				set {_nome = value;}
			}

			public  String email
			{
				get {return _email;}
				set {_email = value;}
			}

			public  String endereco
			{
				get {return _endereco;}
				set {_endereco = value;}
			}

			public  String bairro
			{
				get {return _bairro;}
				set {_bairro = value;}
			}

			public  String cidade
			{
				get {return _cidade;}
				set {_cidade = value;}
			}

			public  String estado
			{
				get {return _estado;}
				set {_estado = value;}
			}

			public  String ddd
			{
				get {return _ddd;}
				set {_ddd = value;}
			}

			public  String telefonefixo
			{
				get {return _telefonefixo;}
				set {_telefonefixo = value;}
			}

			public  String telefonecelular
			{
				get {return _telefonecelular;}
				set {_telefonecelular = value;}
			}

			public  String cep
			{
				get {return _cep;}
				set {_cep = value;}
			}

			public  String observacoes
			{
				get {return _observacoes;}
				set {_observacoes = value;}
			}

			public  String login
			{
				get {return _login;}
				set {_login = value;}
			}

			public  String senha
			{
				get {return _senha;}
				set {_senha = value;}
			}

			public  DateTime datainclusao
			{
				get {return _datainclusao;}
				set {_datainclusao = value;}
			}


        public String mensagem
            {
                get {	return _mensagem; }
                set {	_mensagem = value; }
            }
        #endregion

        #region "Metodos Basicos"
 
			/// <summary>
			/// public Boolean Insert()
			/// Este metodo realiza o "insert" no objeto Cliente do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_Cliente_Insert
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.ValidateInsert() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Insert()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					Boolean retorno = false;

					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@email", email, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@endereco", endereco, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@bairro", bairro, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@cidade", cidade, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@estado", estado, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@ddd", ddd, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@telefonefixo", telefonefixo, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@telefonecelular", telefonecelular, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@cep", cep, System.Data.OleDb.OleDbType.Char,	8);
					comando.AddParameter("@observacoes", observacoes, System.Data.OleDb.OleDbType.Char,	4000);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@datainclusao", datainclusao, System.Data.OleDb.OleDbType.Date);

					comando.Call("sp_Cliente_Insert", ConnectionInfo.Conexao );
					
					mensagem = comando.LastError;


					if (this.mensagem == String.Empty)
						retorno = true;
					else
						retorno = false;

					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return false;
				}
			}

			/// <summary>
			/// public Boolean Update()
			/// Este metodo realiza o "Update" no objeto Cliente do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_Cliente_Update
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.ValidateUpdate() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Update()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;					
					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@email", email, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@endereco", endereco, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@bairro", bairro, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@cidade", cidade, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@estado", estado, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@ddd", ddd, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@telefonefixo", telefonefixo, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@telefonecelular", telefonecelular, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@cep", cep, System.Data.OleDb.OleDbType.Char,	8);
					comando.AddParameter("@observacoes", observacoes, System.Data.OleDb.OleDbType.Char,	4000);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@datainclusao", datainclusao, System.Data.OleDb.OleDbType.Date);


					comando.Call("sp_Cliente_Update",ConnectionInfo.Conexao);

					mensagem = comando.LastError;


					if (this.mensagem == String.Empty)
						retorno = true;
					else
						retorno = false;

					return retorno;
				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return false;
				}
			}

			/// <summary>
			/// public Boolean Delete()
			/// Este metodo realiza o "Delete" no objeto Cliente do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_Cliente_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Delete()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;
					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@email", email, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@endereco", endereco, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@bairro", bairro, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@cidade", cidade, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@estado", estado, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@ddd", ddd, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@telefonefixo", telefonefixo, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@telefonecelular", telefonecelular, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@cep", cep, System.Data.OleDb.OleDbType.Char,	8);
					comando.AddParameter("@observacoes", observacoes, System.Data.OleDb.OleDbType.Char,	4000);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	20);
					comando.AddParameter("@datainclusao", datainclusao, System.Data.OleDb.OleDbType.Date);


					comando.Call("sp_Cliente_Delete",ConnectionInfo.Conexao);

					mensagem = comando.LastError;

					if (this.mensagem == String.Empty)
						retorno = true;
					else
						retorno = false;

					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return false;
				}
			}

			/// <summary>
			/// public Boolean DeleteMasterDetail()
			/// Este metodo realiza o "Delete" no objeto Cliente do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_Cliente_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean DeleteMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;


					comando.Call("sp_Cliente_DelMD",ConnectionInfo.Conexao);

					this.mensagem = comando.LastError;


					if (this.mensagem == String.Empty)
						retorno = true;
					else
						retorno = false;

					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return false;
				}
			}

			/// <summary>
			/// public DataSet GetAll()
			/// Este metodo realiza o "Select" no objeto Cliente do banco de dados
			/// 
			/// e feito um select nos registros que satisfacam aos parametros da classe
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.GetAll() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public DataSet GetAll()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					String Query = "";
					String Conector = " Where ";

					 Query += " Select";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " nome,";
					 Query += " email,";
					 Query += " endereco,";
					 Query += " bairro,";
					 Query += " cidade,";
					 Query += " estado,";
					 Query += " ddd,";
					 Query += " telefonefixo,";
					 Query += " telefonecelular,";
					 Query += " cep,";
					 Query += " observacoes,";
					 Query += " login,";
					 Query += " senha,";
					 Query += " datainclusao";
					 Query += " From [Cliente]";
					if ( cliente !=-1  )
					{
						Query += " " + Conector + "cliente = " + cliente;
						Conector = " And ";
					}
					if ( cpf_cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cpf_cnpj = "+"'" + cpf_cnpj+"'";
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
						Conector = " And ";
					}
					if ( email !=String.Empty  )
					{
						Query += " " + Conector + "email = "+"'" + email+"'";
						Conector = " And ";
					}
					if ( endereco !=String.Empty  )
					{
						Query += " " + Conector + "endereco = "+"'" + endereco+"'";
						Conector = " And ";
					}
					if ( bairro !=String.Empty  )
					{
						Query += " " + Conector + "bairro = "+"'" + bairro+"'";
						Conector = " And ";
					}
					if ( cidade !=String.Empty  )
					{
						Query += " " + Conector + "cidade = "+"'" + cidade+"'";
						Conector = " And ";
					}
					if ( estado !=String.Empty  )
					{
						Query += " " + Conector + "estado = "+"'" + estado+"'";
						Conector = " And ";
					}
					if ( ddd !=String.Empty  )
					{
						Query += " " + Conector + "ddd = "+"'" + ddd+"'";
						Conector = " And ";
					}
					if ( telefonefixo !=String.Empty  )
					{
						Query += " " + Conector + "telefonefixo = "+"'" + telefonefixo+"'";
						Conector = " And ";
					}
					if ( telefonecelular !=String.Empty  )
					{
						Query += " " + Conector + "telefonecelular = "+"'" + telefonecelular+"'";
						Conector = " And ";
					}
					if ( cep !=String.Empty  )
					{
						Query += " " + Conector + "cep = "+"'" + cep+"'";
						Conector = " And ";
					}
					if ( observacoes !=String.Empty  )
					{
						Query += " " + Conector + "observacoes = "+"'" + observacoes+"'";
						Conector = " And ";
					}
					if ( login !=String.Empty  )
					{
						Query += " " + Conector + "login = "+"'" + login+"'";
						Conector = " And ";
					}
					if ( senha !=String.Empty  )
					{
						Query += " " + Conector + "senha = "+"'" + senha+"'";
						Conector = " And ";
					}
					if ( datainclusao !=new DateTime()  )
					{
						Query += " " + Conector + "datainclusao = "+"'" + datainclusao+"'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " cliente ";


					DataSet retorno = comando.CallSql(Query,ConnectionInfo.Conexao);

					mensagem = comando.LastError;

					if (this.mensagem !=String.Empty)
						retorno = null;
					
					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return null;
				}
			}

			/// public DataSet GetAllMasterDetail()
			/// Este metodo realiza o "Select" no objeto Cliente do banco de dados, 
			/// para preenchimento nos formularios 'Master Detail'
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.GetAll() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public DataSet GetAllMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					String Query = "";
					String Conector = " Where ";

					 Query += " Select";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " nome,";
					 Query += " email,";
					 Query += " endereco,";
					 Query += " bairro,";
					 Query += " cidade,";
					 Query += " estado,";
					 Query += " ddd,";
					 Query += " telefonefixo,";
					 Query += " telefonecelular,";
					 Query += " cep,";
					 Query += " observacoes,";
					 Query += " login,";
					 Query += " senha,";
					 Query += " datainclusao";
					 Query += " From [Cliente]";
					if ( cliente !=-1  )
					{
						Query += " " + Conector + "cliente = " + cliente;
						Conector = " And ";
					}
					if ( cpf_cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cpf_cnpj = "+"'" + cpf_cnpj+"'";
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
						Conector = " And ";
					}
					if ( email !=String.Empty  )
					{
						Query += " " + Conector + "email = "+"'" + email+"'";
						Conector = " And ";
					}
					if ( endereco !=String.Empty  )
					{
						Query += " " + Conector + "endereco = "+"'" + endereco+"'";
						Conector = " And ";
					}
					if ( bairro !=String.Empty  )
					{
						Query += " " + Conector + "bairro = "+"'" + bairro+"'";
						Conector = " And ";
					}
					if ( cidade !=String.Empty  )
					{
						Query += " " + Conector + "cidade = "+"'" + cidade+"'";
						Conector = " And ";
					}
					if ( estado !=String.Empty  )
					{
						Query += " " + Conector + "estado = "+"'" + estado+"'";
						Conector = " And ";
					}
					if ( ddd !=String.Empty  )
					{
						Query += " " + Conector + "ddd = "+"'" + ddd+"'";
						Conector = " And ";
					}
					if ( telefonefixo !=String.Empty  )
					{
						Query += " " + Conector + "telefonefixo = "+"'" + telefonefixo+"'";
						Conector = " And ";
					}
					if ( telefonecelular !=String.Empty  )
					{
						Query += " " + Conector + "telefonecelular = "+"'" + telefonecelular+"'";
						Conector = " And ";
					}
					if ( cep !=String.Empty  )
					{
						Query += " " + Conector + "cep = "+"'" + cep+"'";
						Conector = " And ";
					}
					if ( observacoes !=String.Empty  )
					{
						Query += " " + Conector + "observacoes = "+"'" + observacoes+"'";
						Conector = " And ";
					}
					if ( login !=String.Empty  )
					{
						Query += " " + Conector + "login = "+"'" + login+"'";
						Conector = " And ";
					}
					if ( senha !=String.Empty  )
					{
						Query += " " + Conector + "senha = "+"'" + senha+"'";
						Conector = " And ";
					}
					if ( datainclusao !=new DateTime()  )
					{
						Query += " " + Conector + "datainclusao = "+"'" + datainclusao+"'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " cliente ";


					DataSet retorno = comando.CallSql(Query,ConnectionInfo.Conexao);

					mensagem = comando.LastError;

					if (this.mensagem !=String.Empty)
						retorno = null;
					
					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return null;
				}
			}
		
			/// <summary>
			/// public DataSet FindAll()
			/// Realiza o "Select" no objeto Cliente do banco de dados
			/// 
			/// e feita uma busca avancada nos registros da Tabela. 
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.GetAll() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public DataSet FindAll()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					String Query = "";
					String Conector = " Where ";

					 Query += " Select";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " nome,";
					 Query += " email,";
					 Query += " endereco,";
					 Query += " bairro,";
					 Query += " cidade,";
					 Query += " estado,";
					 Query += " ddd,";
					 Query += " telefonefixo,";
					 Query += " telefonecelular,";
					 Query += " cep,";
					 Query += " observacoes,";
					 Query += " login,";
					 Query += " senha,";
					 Query += " datainclusao";
					 Query += " From [Cliente]";
					if ( cliente !=-1  )
					{
						Query += " " + Conector + "cliente = " + cliente;
						Conector = " And ";
					}
					if ( cpf_cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cpf_cnpj Like "+"'%" + cpf_cnpj+"%'";
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome Like "+"'%" + nome+"%'";
						Conector = " And ";
					}
					if ( email !=String.Empty  )
					{
						Query += " " + Conector + "email Like "+"'%" + email+"%'";
						Conector = " And ";
					}
					if ( endereco !=String.Empty  )
					{
						Query += " " + Conector + "endereco Like "+"'%" + endereco+"%'";
						Conector = " And ";
					}
					if ( bairro !=String.Empty  )
					{
						Query += " " + Conector + "bairro Like "+"'%" + bairro+"%'";
						Conector = " And ";
					}
					if ( cidade !=String.Empty  )
					{
						Query += " " + Conector + "cidade Like "+"'%" + cidade+"%'";
						Conector = " And ";
					}
					if ( estado !=String.Empty  )
					{
						Query += " " + Conector + "estado Like "+"'%" + estado+"%'";
						Conector = " And ";
					}
					if ( ddd !=String.Empty  )
					{
						Query += " " + Conector + "ddd Like "+"'%" + ddd+"%'";
						Conector = " And ";
					}
					if ( telefonefixo !=String.Empty  )
					{
						Query += " " + Conector + "telefonefixo Like "+"'%" + telefonefixo+"%'";
						Conector = " And ";
					}
					if ( telefonecelular !=String.Empty  )
					{
						Query += " " + Conector + "telefonecelular Like "+"'%" + telefonecelular+"%'";
						Conector = " And ";
					}
					if ( cep !=String.Empty  )
					{
						Query += " " + Conector + "cep Like "+"'%" + cep+"%'";
						Conector = " And ";
					}
					if ( observacoes !=String.Empty  )
					{
						Query += " " + Conector + "observacoes Like "+"'%" + observacoes+"%'";
						Conector = " And ";
					}
					if ( login !=String.Empty  )
					{
						Query += " " + Conector + "login Like "+"'%" + login+"%'";
						Conector = " And ";
					}
					if ( senha !=String.Empty  )
					{
						Query += " " + Conector + "senha Like "+"'%" + senha+"%'";
						Conector = " And ";
					}
					if ( datainclusao !=new DateTime()  )
					{
						Query += " " + Conector + "datainclusao = "+"'" +datainclusao+"'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " cliente ";


					DataSet retorno = comando.CallSql(Query,ConnectionInfo.Conexao);

					mensagem = comando.LastError;

					if (this.mensagem !=String.Empty)
						retorno = null;
					
					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return null;
				}
			}

			/// <summary>
			/// public DataSet Load()
			/// Este metodo realiza o "Select" no objeto Cliente do banco de dados
			/// 
			/// e feito um select no registro definido pela chave primaria fornececida
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_Cliente.Load() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public DataSet Load()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					String Query = "";
					String Conector = " Where ";

					 Query += " Select";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " nome,";
					 Query += " email,";
					 Query += " endereco,";
					 Query += " bairro,";
					 Query += " cidade,";
					 Query += " estado,";
					 Query += " ddd,";
					 Query += " telefonefixo,";
					 Query += " telefonecelular,";
					 Query += " cep,";
					 Query += " observacoes,";
					 Query += " login,";
					 Query += " senha,";
					 Query += " datainclusao";
					 Query += " From [Cliente]";
					if ( cliente !=-1  )
					{
						Query += " " + Conector + "cliente = " + cliente;
						Conector = " And ";
					}


					DataSet retorno = comando.CallSql(Query,ConnectionInfo.Conexao);

					mensagem = comando.LastError;

					if (this.mensagem !=String.Empty)
						retorno = null;
					
					return retorno;

				}
				catch (Exception ex)
				{
					this.mensagem = ex.Message;
					return null;
				}
			}	

			/// <summary>
			/// public String ToString()
			/// Este metodo retorna uma string com os nomes e os valores de todas as propriedades da classe
			/// 
			/// </summary>
			public new String ToString()
			{
				try
				{
					String retorno = "";
					retorno += "cliente:		" + this.cliente.ToString().Trim();
					retorno += "cpf_cnpj:		" + this.cpf_cnpj.ToString().Trim();
					retorno += "nome:		" + this.nome.ToString().Trim();
					retorno += "email:		" + this.email.ToString().Trim();
					retorno += "endereco:		" + this.endereco.ToString().Trim();
					retorno += "bairro:		" + this.bairro.ToString().Trim();
					retorno += "cidade:		" + this.cidade.ToString().Trim();
					retorno += "estado:		" + this.estado.ToString().Trim();
					retorno += "ddd:		" + this.ddd.ToString().Trim();
					retorno += "telefonefixo:		" + this.telefonefixo.ToString().Trim();
					retorno += "telefonecelular:		" + this.telefonecelular.ToString().Trim();
					retorno += "cep:		" + this.cep.ToString().Trim();
					retorno += "observacoes:		" + this.observacoes.ToString().Trim();
					retorno += "login:		" + this.login.ToString().Trim();
					retorno += "senha:		" + this.senha.ToString().Trim();
					retorno += "datainclusao:		" + this.datainclusao.ToString().Trim();

					return retorno;

				}
				catch (Exception ex)
				{
					return ex.Message;
				}
			}

            public void ValidaCliente()
            {

            }
			#endregion
	}
}
