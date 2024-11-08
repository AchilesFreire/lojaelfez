	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Class Layer                              * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: rul_atualizacao                          * 
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 09:42:18                         * 
	 *                                                    *  
	 *                                                    *  
	*********************************************************/

using System;
using System.Data;
using Business_DataBase;

namespace LojaElfez.BusinessClass
{

	/// <summary>
	/// Definicao da Classe cls_atualizacao
	/// Esta classe representa o objeto atualizacao no banco de dados
	/// Todas as operacoes basicas (Inclusao, Alteracao, Exclusao, Consulta) sao feitas por esta classe
	/// Que utilizada internamente pela clase rul_atualizacao
	/// 
	/// Nota: Esta classe nao deve ser instanciada dentro do projeto, pois a arquitetura de camadas
	/// Define a classe rul_atualizacao para utilizacao na camada de apresentacao do projeto
	/// 
	/// </summary>
	public class cls_atualizacao
	{
        #region "Variaveis" 

			private  int _atualizacao = -1;
			private  int _produto = -1;
			private  String _nome = String.Empty;
			private  String _descricao = String.Empty;
			private  Decimal _preco =  new Decimal(-1);
			private  String _diretoriodownload = String.Empty;

        private String _mensagem = "";

        #endregion

        #region "Construtures" 

        public cls_atualizacao()
        {
        }

        /// <summary>
        /// Construtor da Classe atualizacao com passagem de parametros da Chave Primaria
        /// </summary>
        public cls_atualizacao(  int par_atualizacao)
        {
            try
            {
					this.atualizacao = par_atualizacao;
 
            }
            catch (Exception ex)
            {
                this.mensagem = ex.Message;
            }
        }

        #endregion

        #region "Propriedades" 
			public  int atualizacao
			{
				get {return _atualizacao;}
				set {_atualizacao = value;}
			}

			public  int produto
			{
				get {return _produto;}
				set {_produto = value;}
			}

			public  String nome
			{
				get {return _nome;}
				set {_nome = value;}
			}

			public  String descricao
			{
				get {return _descricao;}
				set {_descricao = value;}
			}

			public  Decimal preco
			{
				get {return _preco;}
				set {_preco = value;}
			}

			public  String diretoriodownload
			{
				get {return _diretoriodownload;}
				set {_diretoriodownload = value;}
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
			/// Este metodo realiza o "insert" no objeto atualizacao do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_atualizacao_Insert
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.ValidateInsert() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Insert()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					Boolean retorno = false;

					comando.AddParameter("@atualizacao", atualizacao, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@descricao", descricao, System.Data.OleDb.OleDbType.Char,	8000);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);
					comando.AddParameter("@diretoriodownload", diretoriodownload, System.Data.OleDb.OleDbType.Char,	1000);

					comando.Call("sp_atualizacao_Insert", ConnectionInfo.Conexao );
					
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
			/// Este metodo realiza o "Update" no objeto atualizacao do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_atualizacao_Update
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.ValidateUpdate() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Update()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;					
					comando.AddParameter("@atualizacao", atualizacao, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@descricao", descricao, System.Data.OleDb.OleDbType.Char,	8000);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);
					comando.AddParameter("@diretoriodownload", diretoriodownload, System.Data.OleDb.OleDbType.Char,	1000);


					comando.Call("sp_atualizacao_Update",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto atualizacao do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_atualizacao_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Delete()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;
					comando.AddParameter("@atualizacao", atualizacao, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@descricao", descricao, System.Data.OleDb.OleDbType.Char,	8000);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);
					comando.AddParameter("@diretoriodownload", diretoriodownload, System.Data.OleDb.OleDbType.Char,	1000);


					comando.Call("sp_atualizacao_Delete",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto atualizacao do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_atualizacao_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean DeleteMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;


					comando.Call("sp_atualizacao_DelMD",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Select" no objeto atualizacao do banco de dados
			/// 
			/// e feito um select nos registros que satisfacam aos parametros da classe
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " atualizacao,";
					 Query += " produto,";
					 Query += " nome,";
					 Query += " descricao,";
					 Query += " preco,";
					 Query += " diretoriodownload";
					 Query += " From [atualizacao]";
					if ( atualizacao !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + atualizacao;
						Conector = " And ";
					}
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
						Conector = " And ";
					}
					if ( descricao !=String.Empty  )
					{
						Query += " " + Conector + "descricao = "+"'" + descricao+"'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					if ( diretoriodownload !=String.Empty  )
					{
						Query += " " + Conector + "diretoriodownload = "+"'" + diretoriodownload+"'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " atualizacao ";


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
			/// Este metodo realiza o "Select" no objeto atualizacao do banco de dados, 
			/// para preenchimento nos formularios 'Master Detail'
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " atualizacao,";
					 Query += " produto,";
					 Query += " nome,";
					 Query += " descricao,";
					 Query += " preco,";
					 Query += " diretoriodownload";
					 Query += " From [atualizacao]";
					if ( atualizacao !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + atualizacao;
						Conector = " And ";
					}
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome = "+"'" + nome+"'";
						Conector = " And ";
					}
					if ( descricao !=String.Empty  )
					{
						Query += " " + Conector + "descricao = "+"'" + descricao+"'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					if ( diretoriodownload !=String.Empty  )
					{
						Query += " " + Conector + "diretoriodownload = "+"'" + diretoriodownload+"'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " atualizacao ";


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
			/// Realiza o "Select" no objeto atualizacao do banco de dados
			/// 
			/// e feita uma busca avancada nos registros da Tabela. 
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " atualizacao,";
					 Query += " produto,";
					 Query += " nome,";
					 Query += " descricao,";
					 Query += " preco,";
					 Query += " diretoriodownload";
					 Query += " From [atualizacao]";
					if ( atualizacao !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + atualizacao;
						Conector = " And ";
					}
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( nome !=String.Empty  )
					{
						Query += " " + Conector + "nome Like "+"'%" + nome+"%'";
						Conector = " And ";
					}
					if ( descricao !=String.Empty  )
					{
						Query += " " + Conector + "descricao Like "+"'%" + descricao+"%'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + Convert.ToString(preco).Replace(',', '.');
						Conector = " And ";
					}
					if ( diretoriodownload !=String.Empty  )
					{
						Query += " " + Conector + "diretoriodownload Like "+"'%" + diretoriodownload+"%'";
						Conector = " And ";
					}
					Query += " Order By";
					Query += " atualizacao ";


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
			/// Este metodo realiza o "Select" no objeto atualizacao do banco de dados
			/// 
			/// e feito um select no registro definido pela chave primaria fornececida
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_atualizacao.Load() para utilizacao na camada de apresentacao do projeto
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
					 Query += " atualizacao,";
					 Query += " produto,";
					 Query += " nome,";
					 Query += " descricao,";
					 Query += " preco,";
					 Query += " diretoriodownload";
					 Query += " From [atualizacao]";
					if ( atualizacao !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + atualizacao;
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
					retorno += "atualizacao:		" + this.atualizacao.ToString().Trim();
					retorno += "produto:		" + this.produto.ToString().Trim();
					retorno += "nome:		" + this.nome.ToString().Trim();
					retorno += "descricao:		" + this.descricao.ToString().Trim();
					retorno += "preco:		" + this.preco.ToString().Trim();
					retorno += "diretoriodownload:		" + this.diretoriodownload.ToString().Trim();

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
