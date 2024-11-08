	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Class Layer                              * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: rul_usuario                              * 
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 11:46:38                         * 
	 *                                                    *  
	 *                                                    *  
	*********************************************************/

using System;
using System.Data;
using Business_DataBase;

namespace LojaElfez.BusinessClass
{

	/// <summary>
	/// Definicao da Classe cls_usuario
	/// Esta classe representa o objeto usuario no banco de dados
	/// Todas as operacoes basicas (Inclusao, Alteracao, Exclusao, Consulta) sao feitas por esta classe
	/// Que utilizada internamente pela clase rul_usuario
	/// 
	/// Nota: Esta classe nao deve ser instanciada dentro do projeto, pois a arquitetura de camadas
	/// Define a classe rul_usuario para utilizacao na camada de apresentacao do projeto
	/// 
	/// </summary>
	public class cls_usuario
	{
        #region "Variaveis" 

			private  int _usuario = -1;
			private  String _nome = String.Empty;
			private  String _login = String.Empty;
			private  String _senha = String.Empty;

        private String _mensagem = "";

        #endregion

        #region "Construtures" 

        public cls_usuario()
        {
        }

        /// <summary>
        /// Construtor da Classe usuario com passagem de parametros da Chave Primaria
        /// </summary>
        public cls_usuario(  int par_usuario)
        {
            try
            {
					this.usuario = par_usuario;
 
            }
            catch (Exception ex)
            {
                this.mensagem = ex.Message;
            }
        }

        #endregion

        #region "Propriedades" 
			public  int usuario
			{
				get {return _usuario;}
				set {_usuario = value;}
			}

			public  String nome
			{
				get {return _nome;}
				set {_nome = value;}
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


        public String mensagem
            {
                get {	return _mensagem; }
                set {	_mensagem = value; }
            }
        #endregion

        #region "Metodos Basicos"
 
			/// <summary>
			/// public Boolean Insert()
			/// Este metodo realiza o "insert" no objeto usuario do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_usuario_Insert
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.ValidateInsert() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Insert()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					Boolean retorno = false;

					comando.AddParameter("@usuario", usuario, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	10);

					comando.Call("sp_usuario_Insert", ConnectionInfo.Conexao );
					
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
			/// Este metodo realiza o "Update" no objeto usuario do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_usuario_Update
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.ValidateUpdate() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Update()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;					
					comando.AddParameter("@usuario", usuario, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	10);


					comando.Call("sp_usuario_Update",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto usuario do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_usuario_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Delete()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;
					comando.AddParameter("@usuario", usuario, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@login", login, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@senha", senha, System.Data.OleDb.OleDbType.Char,	10);


					comando.Call("sp_usuario_Delete",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto usuario do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_usuario_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean DeleteMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;


					comando.Call("sp_usuario_DelMD",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Select" no objeto usuario do banco de dados
			/// 
			/// e feito um select nos registros que satisfacam aos parametros da classe
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " usuario,";
					 Query += " nome,";
					 Query += " login,";
					 Query += " senha";
					 Query += " From [usuario]";
					if ( usuario !=-1  )
					{
						Query += " " + Conector + "usuario = " + usuario;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
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
					Query += " Order By";
					Query += " usuario ";


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
			/// Este metodo realiza o "Select" no objeto usuario do banco de dados, 
			/// para preenchimento nos formularios 'Master Detail'
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " usuario,";
					 Query += " nome,";
					 Query += " login,";
					 Query += " senha";
					 Query += " From [usuario]";
					if ( usuario !=-1  )
					{
						Query += " " + Conector + "usuario = " + usuario;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
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
					Query += " Order By";
					Query += " usuario ";


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
			/// Realiza o "Select" no objeto usuario do banco de dados
			/// 
			/// e feita uma busca avancada nos registros da Tabela. 
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " usuario,";
					 Query += " nome,";
					 Query += " login,";
					 Query += " senha";
					 Query += " From [usuario]";
					if ( usuario !=-1  )
					{
						Query += " " + Conector + "usuario = " + usuario;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome Like "+"'%" + nome+"%'";
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
					Query += " Order By";
					Query += " usuario ";


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
			/// Este metodo realiza o "Select" no objeto usuario do banco de dados
			/// 
			/// e feito um select no registro definido pela chave primaria fornececida
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_usuario.Load() para utilizacao na camada de apresentacao do projeto
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
					 Query += " usuario,";
					 Query += " nome,";
					 Query += " login,";
					 Query += " senha";
					 Query += " From [usuario]";
					if ( usuario !=-1  )
					{
						Query += " " + Conector + "usuario = " + usuario;
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
					retorno += "usuario:		" + this.usuario.ToString().Trim();
					retorno += "nome:		" + this.nome.ToString().Trim();
					retorno += "login:		" + this.login.ToString().Trim();
					retorno += "senha:		" + this.senha.ToString().Trim();

					return retorno;

				}
				catch (Exception ex)
				{
					return ex.Message;
				}
			}

			#endregion
	}
}
