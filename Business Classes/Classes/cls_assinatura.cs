	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Class Layer                              * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: rul_boleto                               * 
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
	/// Definicao da Classe cls_boleto
	/// Esta classe representa o objeto boleto no banco de dados
	/// Todas as operacoes basicas (Inclusao, Alteracao, Exclusao, Consulta) sao feitas por esta classe
	/// Que utilizada internamente pela clase rul_boleto
	/// 
	/// Nota: Esta classe nao deve ser instanciada dentro do projeto, pois a arquitetura de camadas
	/// Define a classe rul_boleto para utilizacao na camada de apresentacao do projeto
	/// 
	/// </summary>
	public class cls_assinatura
	{
        #region "Variaveis" 

			private  int _assinatura = -1;
			private  int _cliente = -1;
			private  String _cpf_cnpj = String.Empty;
			private  int _produto = -1;
			private  String _cedente = String.Empty;
			private  String _cnpj = String.Empty;
			private  String _banco = String.Empty;
			private  String _agencia = String.Empty;
			private  String _conta = String.Empty;
			private  String _digito = String.Empty;
			private  String _carteira = String.Empty;
			private  DateTime _vencimento = new DateTime();
			private  int _quantidade = -1;
			private  Decimal _preco =  new Decimal(-1);
			private  DateTime _datacriacao = new DateTime();
			private  DateTime _datapagamento = new DateTime();
			private  int _tipomensalidade = -1;
            private DateTime _datavencimento = new DateTime();

        private String _mensagem = "";

        #endregion

        #region "Construtures" 

        public cls_assinatura()
        {
        }

        /// <summary>
        /// Construtor da Classe boleto com passagem de parametros da Chave Primaria
        /// </summary>
        public cls_assinatura(  int par_boleto)
        {
            try
            {
					this.assinatura = par_boleto;
 
            }
            catch (Exception ex)
            {
                this.mensagem = ex.Message;
            }
        }

        #endregion

        #region "Propriedades" 
			public  int assinatura
			{
				get {return _assinatura;}
				set {_assinatura = value;}
			}

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

			public  int produto
			{
				get {return _produto;}
				set {_produto = value;}
			}

			public  String cedente
			{
				get {return _cedente;}
				set {_cedente = value;}
			}

			public  String cnpj
			{
				get {return _cnpj;}
				set {_cnpj = value;}
			}

			public  String banco
			{
				get {return _banco;}
				set {_banco = value;}
			}

			public  String agencia
			{
				get {return _agencia;}
				set {_agencia = value;}
			}

			public  String conta
			{
				get {return _conta;}
				set {_conta = value;}
			}

			public  String digito
			{
				get {return _digito;}
				set {_digito = value;}
			}

			public  String carteira
			{
				get {return _carteira;}
				set {_carteira = value;}
			}

			public  DateTime vencimento
			{
				get {return _vencimento;}
				set {_vencimento = value;}
			}

			public  int quantidade
			{
				get {return _quantidade;}
				set {_quantidade = value;}
			}

			public  Decimal preco
			{
				get {return _preco;}
				set {_preco = value;}
			}

			public  DateTime datacriacao
			{
				get {return _datacriacao;}
				set {_datacriacao = value;}
			}

			public  DateTime datapagamento
			{
				get {return _datapagamento;}
				set {_datapagamento = value;}
			}

			public  int tipomensalidade
			{
				get {return _tipomensalidade;}
				set {_tipomensalidade = value;}
			}

            public DateTime datavencimento
            {
                get { return _datavencimento; }
                set { _datavencimento = value; }
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
			/// Este metodo realiza o "insert" no objeto boleto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_boleto_Insert
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.ValidateInsert() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Insert()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();

					Boolean retorno = false;

					comando.AddParameter("@boleto", assinatura, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cedente", cedente, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@cnpj", cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@banco", banco, System.Data.OleDb.OleDbType.Char,	4);
					comando.AddParameter("@agencia", agencia, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@conta", conta, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@digito", digito, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@carteira", carteira, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@vencimento", vencimento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@quantidade", quantidade, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 0);
					comando.AddParameter("@datacriacao", datacriacao, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@datapagamento", datapagamento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@atualizacao", tipomensalidade, System.Data.OleDb.OleDbType.Integer);

					comando.Call("sp_boleto_Insert", ConnectionInfo.Conexao );
					
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
			/// Este metodo realiza o "Update" no objeto boleto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_boleto_Update
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.ValidateUpdate() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Update()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;					
					comando.AddParameter("@boleto", assinatura, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cedente", cedente, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@cnpj", cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@banco", banco, System.Data.OleDb.OleDbType.Char,	4);
					comando.AddParameter("@agencia", agencia, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@conta", conta, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@digito", digito, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@carteira", carteira, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@vencimento", vencimento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@quantidade", quantidade, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 0);
					comando.AddParameter("@datacriacao", datacriacao, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@datapagamento", datapagamento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@atualizacao", tipomensalidade, System.Data.OleDb.OleDbType.Integer);


					comando.Call("sp_boleto_Update",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto boleto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_boleto_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean Delete()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;
					comando.AddParameter("@boleto", assinatura, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cliente", cliente, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cpf_cnpj", cpf_cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@produto", produto, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@cedente", cedente, System.Data.OleDb.OleDbType.Char,	200);
					comando.AddParameter("@cnpj", cnpj, System.Data.OleDb.OleDbType.Char,	30);
					comando.AddParameter("@banco", banco, System.Data.OleDb.OleDbType.Char,	4);
					comando.AddParameter("@agencia", agencia, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@conta", conta, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@digito", digito, System.Data.OleDb.OleDbType.Char,	2);
					comando.AddParameter("@carteira", carteira, System.Data.OleDb.OleDbType.Char,	10);
					comando.AddParameter("@vencimento", vencimento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@quantidade", quantidade, System.Data.OleDb.OleDbType.Integer);
					comando.AddParameter("@preco", preco, System.Data.OleDb.OleDbType.Decimal,	0,10, 0);
					comando.AddParameter("@datacriacao", datacriacao, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@datapagamento", datapagamento, System.Data.OleDb.OleDbType.Date);
					comando.AddParameter("@atualizacao", tipomensalidade, System.Data.OleDb.OleDbType.Integer);


					comando.Call("sp_boleto_Delete",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Delete" no objeto boleto do banco de dados
			/// 
			/// o insert e realizado pela Stored Procedure: sp_boleto_Delete
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.ValidateDelete() para utilizacao na camada de apresentacao do projeto
			/// 
			/// </summary>
			public Boolean DeleteMasterDetail()
			{
				try
				{
					cls_comando comando = new cls_comando();
					LojaElfez.ConnectionInfo conexao = new ConnectionInfo();
					Boolean retorno=false;


					comando.Call("sp_boleto_DelMD",ConnectionInfo.Conexao);

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
			/// Este metodo realiza o "Select" no objeto boleto do banco de dados
			/// 
			/// e feito um select nos registros que satisfacam aos parametros da classe
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " boleto,";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " produto,";
					 Query += " cedente,";
					 Query += " cnpj,";
					 Query += " banco,";
					 Query += " agencia,";
					 Query += " conta,";
					 Query += " digito,";
					 Query += " carteira,";
					 Query += " vencimento,";
					 Query += " quantidade,";
					 Query += " preco,";
					 Query += " datacriacao,";
					 Query += " datapagamento,";
					 Query += " atualizacao";
					 Query += " From [boleto]";
					if ( assinatura !=-1  )
					{
						Query += " " + Conector + "boleto = " + assinatura;
						Conector = " And ";
					}
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
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( cedente !=String.Empty  )
					{
						Query += " " + Conector + "cedente = "+"'" + cedente+"'";
						Conector = " And ";
					}
					if ( cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cnpj = "+"'" + cnpj+"'";
						Conector = " And ";
					}
					if ( banco !=String.Empty  )
					{
						Query += " " + Conector + "banco = "+"'" + banco+"'";
						Conector = " And ";
					}
					if ( agencia !=String.Empty  )
					{
						Query += " " + Conector + "agencia = "+"'" + agencia+"'";
						Conector = " And ";
					}
					if ( conta !=String.Empty  )
					{
						Query += " " + Conector + "conta = "+"'" + conta+"'";
						Conector = " And ";
					}
					if ( digito !=String.Empty  )
					{
						Query += " " + Conector + "digito = "+"'" + digito+"'";
						Conector = " And ";
					}
					if ( carteira !=String.Empty  )
					{
						Query += " " + Conector + "carteira = "+"'" + carteira+"'";
						Conector = " And ";
					}
					if ( vencimento !=new DateTime()  )
					{
						Query += " " + Conector + "vencimento = "+"'" + vencimento+"'";
						Conector = " And ";
					}
					if ( quantidade !=-1  )
					{
						Query += " " + Conector + "quantidade = " + quantidade;
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					if ( datacriacao !=new DateTime()  )
					{
						Query += " " + Conector + "datacriacao = "+"'" + datacriacao+"'";
						Conector = " And ";
					}
					if ( datapagamento !=new DateTime()  )
					{
						Query += " " + Conector + "datapagamento = "+"'" + datapagamento+"'";
						Conector = " And ";
					}
					if ( tipomensalidade !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + tipomensalidade;
						Conector = " And ";
					}
					Query += " Order By";
					Query += " boleto ";


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
			/// Este metodo realiza o "Select" no objeto boleto do banco de dados, 
			/// para preenchimento nos formularios 'Master Detail'
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " boleto,";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " produto,";
					 Query += " cedente,";
					 Query += " cnpj,";
					 Query += " banco,";
					 Query += " agencia,";
					 Query += " conta,";
					 Query += " digito,";
					 Query += " carteira,";
					 Query += " vencimento,";
					 Query += " quantidade,";
					 Query += " preco,";
					 Query += " datacriacao,";
					 Query += " datapagamento,";
					 Query += " atualizacao";
					 Query += " From [boleto]";
					if ( assinatura !=-1  )
					{
						Query += " " + Conector + "boleto = " + assinatura;
						Conector = " And ";
					}
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
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( cedente !=String.Empty  )
					{
						Query += " " + Conector + "cedente = "+"'" + cedente+"'";
						Conector = " And ";
					}
					if ( cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cnpj = "+"'" + cnpj+"'";
						Conector = " And ";
					}
					if ( banco !=String.Empty  )
					{
						Query += " " + Conector + "banco = "+"'" + banco+"'";
						Conector = " And ";
					}
					if ( agencia !=String.Empty  )
					{
						Query += " " + Conector + "agencia = "+"'" + agencia+"'";
						Conector = " And ";
					}
					if ( conta !=String.Empty  )
					{
						Query += " " + Conector + "conta = "+"'" + conta+"'";
						Conector = " And ";
					}
					if ( digito !=String.Empty  )
					{
						Query += " " + Conector + "digito = "+"'" + digito+"'";
						Conector = " And ";
					}
					if ( carteira !=String.Empty  )
					{
						Query += " " + Conector + "carteira = "+"'" + carteira+"'";
						Conector = " And ";
					}
					if ( vencimento !=new DateTime()  )
					{
						Query += " " + Conector + "vencimento = "+"'" + vencimento+"'";
						Conector = " And ";
					}
					if ( quantidade !=-1  )
					{
						Query += " " + Conector + "quantidade = " + quantidade;
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + preco;
						Conector = " And ";
					}
					if ( datacriacao !=new DateTime()  )
					{
						Query += " " + Conector + "datacriacao = "+"'" + datacriacao+"'";
						Conector = " And ";
					}
					if ( datapagamento !=new DateTime()  )
					{
						Query += " " + Conector + "datapagamento = "+"'" + datapagamento+"'";
						Conector = " And ";
					}
					if ( tipomensalidade !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + tipomensalidade;
						Conector = " And ";
					}
					Query += " Order By";
					Query += " boleto ";


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
			/// Realiza o "Select" no objeto boleto do banco de dados
			/// 
			/// e feita uma busca avancada nos registros da Tabela. 
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.GetAll() para utilizacao na camada de apresentacao do projeto
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
					 Query += " boleto,";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " produto,";
					 Query += " cedente,";
					 Query += " cnpj,";
					 Query += " banco,";
					 Query += " agencia,";
					 Query += " conta,";
					 Query += " digito,";
					 Query += " carteira,";
					 Query += " vencimento,";
					 Query += " quantidade,";
					 Query += " preco,";
					 Query += " datacriacao,";
					 Query += " datapagamento,";
					 Query += " atualizacao";
					 Query += " From [boleto]";
					if ( assinatura !=-1  )
					{
						Query += " " + Conector + "boleto = " + assinatura;
						Conector = " And ";
					}
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
					if ( produto !=-1  )
					{
						Query += " " + Conector + "produto = " + produto;
						Conector = " And ";
					}
					if ( cedente !=String.Empty  )
					{
						Query += " " + Conector + "cedente Like "+"'%" + cedente+"%'";
						Conector = " And ";
					}
					if ( cnpj !=String.Empty  )
					{
						Query += " " + Conector + "cnpj Like "+"'%" + cnpj+"%'";
						Conector = " And ";
					}
					if ( banco !=String.Empty  )
					{
						Query += " " + Conector + "banco Like "+"'%" + banco+"%'";
						Conector = " And ";
					}
					if ( agencia !=String.Empty  )
					{
						Query += " " + Conector + "agencia Like "+"'%" + agencia+"%'";
						Conector = " And ";
					}
					if ( conta !=String.Empty  )
					{
						Query += " " + Conector + "conta Like "+"'%" + conta+"%'";
						Conector = " And ";
					}
					if ( digito !=String.Empty  )
					{
						Query += " " + Conector + "digito Like "+"'%" + digito+"%'";
						Conector = " And ";
					}
					if ( carteira !=String.Empty  )
					{
						Query += " " + Conector + "carteira Like "+"'%" + carteira+"%'";
						Conector = " And ";
					}
					if ( vencimento !=new DateTime()  )
					{
						Query += " " + Conector + "vencimento = "+"'" +vencimento+"'";
						Conector = " And ";
					}
					if ( quantidade !=-1  )
					{
						Query += " " + Conector + "quantidade = " + quantidade;
						Conector = " And ";
					}
					if ( preco != new Decimal(-1)  )
					{
						Query += " " + Conector + "preco = " + Convert.ToString(preco).Replace(',', '.');
						Conector = " And ";
					}
					if ( datacriacao !=new DateTime()  )
					{
						Query += " " + Conector + "datacriacao = "+"'" +datacriacao+"'";
						Conector = " And ";
					}
					if ( datapagamento !=new DateTime()  )
					{
						Query += " " + Conector + "datapagamento = "+"'" +datapagamento+"'";
						Conector = " And ";
					}
					if ( tipomensalidade !=-1  )
					{
						Query += " " + Conector + "atualizacao = " + tipomensalidade;
						Conector = " And ";
					}
					Query += " Order By";
					Query += " boleto ";


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
			/// Este metodo realiza o "Select" no objeto boleto do banco de dados
			/// 
			/// e feito um select no registro definido pela chave primaria fornececida
			/// 
			/// Nota: Este metodo nao deve ser utilizado dentro do projeto, pois a arquitetura de camadas
			/// Define a classe rul_boleto.Load() para utilizacao na camada de apresentacao do projeto
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
					 Query += " boleto,";
					 Query += " cliente,";
					 Query += " cpf_cnpj,";
					 Query += " produto,";
					 Query += " cedente,";
					 Query += " cnpj,";
					 Query += " banco,";
					 Query += " agencia,";
					 Query += " conta,";
					 Query += " digito,";
					 Query += " carteira,";
					 Query += " vencimento,";
					 Query += " quantidade,";
					 Query += " preco,";
					 Query += " datacriacao,";
					 Query += " datapagamento,";
					 Query += " atualizacao";
					 Query += " From [boleto]";
					if ( assinatura !=-1  )
					{
						Query += " " + Conector + "boleto = " + assinatura;
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
					retorno += "boleto:		" + this.assinatura.ToString().Trim();
					retorno += "cliente:		" + this.cliente.ToString().Trim();
					retorno += "cpf_cnpj:		" + this.cpf_cnpj.ToString().Trim();
					retorno += "produto:		" + this.produto.ToString().Trim();
					retorno += "cedente:		" + this.cedente.ToString().Trim();
					retorno += "cnpj:		" + this.cnpj.ToString().Trim();
					retorno += "banco:		" + this.banco.ToString().Trim();
					retorno += "agencia:		" + this.agencia.ToString().Trim();
					retorno += "conta:		" + this.conta.ToString().Trim();
					retorno += "digito:		" + this.digito.ToString().Trim();
					retorno += "carteira:		" + this.carteira.ToString().Trim();
					retorno += "vencimento:		" + this.vencimento.ToString().Trim();
					retorno += "quantidade:		" + this.quantidade.ToString().Trim();
					retorno += "preco:		" + this.preco.ToString().Trim();
					retorno += "datacriacao:		" + this.datacriacao.ToString().Trim();
					retorno += "datapagamento:		" + this.datapagamento.ToString().Trim();
					retorno += "atualizacao:		" + this.tipomensalidade.ToString().Trim();

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
