	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Class Layer                              * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: rul_produto                              * 
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
	/// Definicao da Classe cls_produto
	/// Esta classe representa o objeto produto no banco de dados
	/// Todas as operacoes basicas (Inclusao, Alteracao, Exclusao, Consulta) sao feitas por esta classe
	/// Que utilizada internamente pela clase rul_produto
	/// 
	/// Nota: Esta classe nao deve ser instanciada dentro do projeto, pois a arquitetura de camadas
	/// Define a classe rul_produto para utilizacao na camada de apresentacao do projeto
	/// 
	/// </summary>
	public class cls_produto
	{
        #region "Variaveis" 

			private  int _produto = -1;
			private  String _nome = String.Empty;
			private  String _versaoatual = String.Empty;
			private  Decimal _preco =  new Decimal(-1);

        private String _mensagem = "";

        #endregion

        #region "Construtures" 

        public cls_produto()
        {
        }

        /// <summary>
        /// Construtor da Classe produto com passagem de parametros da Chave Primaria
        /// </summary>
        public cls_produto(  int par_produto)
        {
            try
            {
					this.produto = par_produto;
 
            }
            catch (Exception ex)
            {
                this.mensagem = ex.Message;
            }
        }

        #endregion

        #region "Propriedades" 
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

			public  String versaoatual
			{
				get {return _versaoatual;}
				set {_versaoatual = value;}
			}

			public  Decimal preco
			{
				get {return _preco;}
				set {_preco = value;}
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
			/// Este metodo realiza o "insert" no objeto produto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_produto_Insert
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.ValidateInsert() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Insert()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					Boolean retorno = false;

					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@versaoatual", versaoatual, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);

					comando.Call("sp_produto_Insert", ConnectionInfo.Conexao );
					
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
			/// Este metodo realiza o "Update" no objeto produto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_produto_Update
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.ValidateUpdate() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Update()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;					
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@versaoatual", versaoatual, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);


					comando.Call("sp_produto_Update",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto produto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_produto_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Delete()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@nome", nome, System.Data.OleDb.OleDbType.Char,	100);
					comando.AddParameter("@versaoatual", versaoatual, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 2);


					comando.Call("sp_produto_Delete",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto produto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_produto_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean DeleteMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;


					comando.Call("sp_produto_DelMD",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Select" no objeto produto do banco de dados
			/// 
			/// e feito um select nos registros que satisfacam aos parametros da classe
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " produto,";
					 Query += " nome,";
					 Query += " versaoatual,";
					 Query += " preco";
					 Query += " From [produto]";
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
					if ( versaoatual !=String.Empty  )
					{
						Query += " " + Conector + "versaoatual = "+"'" + versaoatual+"'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					Query += " Order By";
					Query += " produto ";


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
			/// Este metodo realiza o "Select" no objeto produto do banco de dados, 
			/// para preenchimento nos formularios 'Master Detail'
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " produto,";
					 Query += " nome,";
					 Query += " versaoatual,";
					 Query += " preco";
					 Query += " From [produto]";
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
					if ( versaoatual !=String.Empty  )
					{
						Query += " " + Conector + "versaoatual = "+"'" + versaoatual+"'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					Query += " Order By";
					Query += " produto ";


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
			/// Realiza o "Select" no objeto produto do banco de dados
			/// 
			/// e feita uma busca avancada nos registros da Tabela. 
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " produto,";
					 Query += " nome,";
					 Query += " versaoatual,";
					 Query += " preco";
					 Query += " From [produto]";
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
					if ( versaoatual !=String.Empty  )
					{
						Query += " " + Conector + "versaoatual Like "+"'%" + versaoatual+"%'";
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + Convert.ToString(preco).Replace(',', '.');
						Conector = " And ";
					}
					Query += " Order By";
					Query += " produto ";


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
			/// Este metodo realiza o "Select" no objeto produto do banco de dados
			/// 
			/// e feito um select no registro definido pela chave primaria fornececida
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_produto.Load() para utilizacao na camada de apresentacao do projeto
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
					 Query += " produto,";
					 Query += " nome,";
					 Query += " versaoatual,";
					 Query += " preco";
					 Query += " From [produto]";
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
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
					retorno += "produto:		" + this.produto.ToString().Trim();
					retorno += "nome:		" + this.nome.ToString().Trim();
					retorno += "versaoatual:		" + this.versaoatual.ToString().Trim();
					retorno += "preco:		" + this.preco.ToString().Trim();

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
