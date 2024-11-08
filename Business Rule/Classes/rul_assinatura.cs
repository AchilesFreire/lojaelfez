	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Rule Layer                               * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_boleto                               * 
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
using LojaElfez.BusinessClass;
using LojaElfez.BusinessCollection;


namespace LojaElfez.BusinessRule
{
	public class rul_assinatura
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
			private Boolean _NovoRegistro = true;

		#endregion

		#region "Construtures"
 
		public rul_assinatura()
		{
		}
		public rul_assinatura( int par_boleto)
		{
			try
				{
					this.assinatura = par_boleto;
 
					this.NovoRegistro = !this.Load();
				}
			catch(Exception ex)
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

			public  DateTime datavencimento
			{
				get {return _datavencimento;}
                set { _datavencimento = value; }
			}

			public String mensagem
			{
				get { return _mensagem; }
				set { _mensagem = value; }
			}
	
			public Boolean NovoRegistro
			{
				get { return _NovoRegistro; }
				set { _NovoRegistro = value;  }
			}

		#endregion

		#region "Metodos Publicos" 

		public Boolean ValidateInsert()
		{
			try
			{
				// Validacao para o insert e o update
				if (! Validate())
					return false;
				
				//
				// TODO: Adicionar regras de validacao aqui
				//
				cls_assinatura boleto = new cls_assinatura();
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				this.mensagem="";

				Boolean retorno = boleto.Insert();

				this.mensagem = boleto.mensagem;

				return retorno;
			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public Boolean ValidateUpdate()
		{
			try
			{
				// Validacao para o insert e o update
				if (! Validate())
					return false;
				
				//
				// TODO: Adicionar regras de validacao aqui
				//
				cls_assinatura boleto = new cls_assinatura();
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				this.mensagem= "";
				
				Boolean retorno = boleto.Update();

				this.mensagem = boleto.mensagem;

				return retorno;
			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public Boolean Validate()
		{
			try
			{

				if (  this.cliente == -1)
				{
					this.mensagem = "O Campo cliente tem que ser preenchido com Inteiro";
					return false;
				}
				if (  this.cpf_cnpj == String.Empty)
				{
					this.mensagem = "O Campo cpf_cnpj tem que ser preenchido com Texto";
					return false;
				}
				if (  this.produto == -1)
				{
					this.mensagem = "O Campo produto tem que ser preenchido com Inteiro";
					return false;
				}
				if (  this.cedente == String.Empty)
				{
					this.mensagem = "O Campo cedente tem que ser preenchido com Texto";
					return false;
				}
				if (  this.cnpj == String.Empty)
				{
					this.mensagem = "O Campo cnpj tem que ser preenchido com Texto";
					return false;
				}
				if (  this.banco == String.Empty)
				{
					this.mensagem = "O Campo banco tem que ser preenchido com Texto";
					return false;
				}
				if (  this.agencia == String.Empty)
				{
					this.mensagem = "O Campo agencia tem que ser preenchido com Texto";
					return false;
				}
				if (  this.conta == String.Empty)
				{
					this.mensagem = "O Campo conta tem que ser preenchido com Texto";
					return false;
				}
				if (  this.digito == String.Empty)
				{
					this.mensagem = "O Campo digito tem que ser preenchido com Texto";
					return false;
				}
				if (  this.carteira == String.Empty)
				{
					this.mensagem = "O Campo carteira tem que ser preenchido com Texto";
					return false;
				}
				if (  this.vencimento == new DateTime())
				{
					this.mensagem = "O Campo vencimento tem que ser preenchido com Data";
					return false;
				}
				if (  this.quantidade == -1)
				{
					this.mensagem = "O Campo quantidade tem que ser preenchido com Inteiro";
					return false;
				}
				if (  this.preco ==  new Decimal(-1))
				{
					this.mensagem = "O Campo preco tem que ser preenchido com Número";
					return false;
				}
				if (  this.datacriacao == new DateTime())
				{
					this.mensagem = "O Campo datacriacao tem que ser preenchido com Data";
					return false;
				}
				if (  this.datapagamento == new DateTime())
				{
					this.mensagem = "O Campo datapagamento tem que ser preenchido com Data";
					return false;
				}
				if (  this.tipomensalidade == -1)
				{
					this.mensagem = "O Campo atualizacao tem que ser preenchido com Inteiro";
					return false;
				}


				return true;
			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public Boolean ValidateDelete()
		{
			try
			{
				
				//
				// TODO: Adicionar regras de validacao aqui
				//
				cls_assinatura boleto = new cls_assinatura();

				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				if (VerifyForeignKeys())
					{

						this.mensagem= "";
				
						Boolean retorno = boleto.Delete();

						this.mensagem = boleto.mensagem;

						return retorno;
					}	
				else
					{
						return false;
					}

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public Boolean ValidateDeleteMasterDetail()
		{
			try
			{
				
				//
				// TODO: Adicionar regras de validacao aqui
				//
				cls_assinatura boleto = new cls_assinatura();
				

				this.mensagem= "";
				
				Boolean retorno = boleto.DeleteMasterDetail();

				this.mensagem = boleto.mensagem;

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public col_boleto GetAll()
		{
			try
			{
				cls_assinatura boleto = new cls_assinatura();
				col_boleto colecao = new col_boleto();
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				System.Data.DataSet ds = boleto.GetAll();

                		if (boleto.mensagem != String.Empty)
		                {
		                    this.mensagem = boleto.mensagem;
		                    return null;
		                }

				for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
				{
					rul_assinatura item = new rul_assinatura();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.assinatura = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.cliente = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.cedente = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[6].ToString() != String.Empty)
						item.banco = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[7].ToString() != String.Empty)
						item.agencia = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[8].ToString() != String.Empty)
						item.conta = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[9].ToString() != String.Empty)
						item.digito = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[10].ToString() != String.Empty)
						item.carteira = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[11].ToString() != String.Empty)
						item.vencimento = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[11]);

					if( ds.Tables[0].Rows[i].ItemArray[12].ToString() != String.Empty)
						item.quantidade = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[12]);

					if( ds.Tables[0].Rows[i].ItemArray[13].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[13]);

					if( ds.Tables[0].Rows[i].ItemArray[14].ToString() != String.Empty)
						item.datacriacao = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[14]);

					if( ds.Tables[0].Rows[i].ItemArray[15].ToString() != String.Empty)
						item.datapagamento = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[15]);

					if( ds.Tables[0].Rows[i].ItemArray[16].ToString() != String.Empty)
						item.tipomensalidade = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[16]);

                    if (ds.Tables[0].Rows[i].ItemArray[17].ToString() != String.Empty)
                        item.datavencimento = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[17]);

					item.NovoRegistro = false;
					colecao.Add(item);
				}
				
				return colecao;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public System.Data.DataSet GetAllInDataSet()
		{
			try
			{
				cls_assinatura boleto = new cls_assinatura();			
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				System.Data.DataSet ds = boleto.GetAll();

				this.mensagem = boleto.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public col_boleto FindAll()
		{

			cls_assinatura boleto = new cls_assinatura();
			col_boleto colecao = new col_boleto();
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

			System.Data.DataSet ds = boleto.FindAll();

               		if (boleto.mensagem != String.Empty)
	                {
	                    this.mensagem = boleto.mensagem;
	                    return null;
	                }


			for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
			{
				rul_assinatura item = new rul_assinatura();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.assinatura = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.cliente = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3]);

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.cedente = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[6].ToString() != String.Empty)
						item.banco = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[7].ToString() != String.Empty)
						item.agencia = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[8].ToString() != String.Empty)
						item.conta = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[9].ToString() != String.Empty)
						item.digito = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[10].ToString() != String.Empty)
						item.carteira = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[11].ToString() != String.Empty)
						item.vencimento = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[11]);

					if( ds.Tables[0].Rows[i].ItemArray[12].ToString() != String.Empty)
						item.quantidade = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[12]);

					if( ds.Tables[0].Rows[i].ItemArray[13].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[13]);

					if( ds.Tables[0].Rows[i].ItemArray[14].ToString() != String.Empty)
						item.datacriacao = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[14]);

					if( ds.Tables[0].Rows[i].ItemArray[15].ToString() != String.Empty)
						item.datapagamento = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[15]);

					if( ds.Tables[0].Rows[i].ItemArray[16].ToString() != String.Empty)
						item.tipomensalidade = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[16]);


				item.NovoRegistro = false;
				colecao.Add(item);
			}
			
			return colecao;

		}
		
        public System.Data.DataSet FindAllInDataSet()
		{
			try
			{
				cls_assinatura boleto = new cls_assinatura();			
				
				boleto.assinatura = this.assinatura;
				boleto.cliente = this.cliente;
				boleto.cpf_cnpj = this.cpf_cnpj;
				boleto.produto = this.produto;
				boleto.cedente = this.cedente;
				boleto.cnpj = this.cnpj;
				boleto.banco = this.banco;
				boleto.agencia = this.agencia;
				boleto.conta = this.conta;
				boleto.digito = this.digito;
				boleto.carteira = this.carteira;
				boleto.vencimento = this.vencimento;
				boleto.quantidade = this.quantidade;
				boleto.preco = this.preco;
				boleto.datacriacao = this.datacriacao;
				boleto.datapagamento = this.datapagamento;
				boleto.tipomensalidade = this.tipomensalidade;
                boleto.datavencimento = this.datavencimento;

				System.Data.DataSet ds = boleto.FindAll();

				this.mensagem = boleto.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public System.Data.DataSet GetAllMasterDetail()
		{
			try
			{
				cls_assinatura boleto = new cls_assinatura();			
				

				System.Data.DataSet ds = boleto.GetAllMasterDetail();

				this.mensagem = boleto.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public Boolean Load()
		{
			try
			{
				cls_assinatura boleto = new cls_assinatura();


				
				boleto.assinatura = this.assinatura;


				System.Data.DataSet ds = boleto.Load();


                		if (boleto.mensagem != String.Empty)
		                {
		                    this.mensagem = boleto.mensagem;
		                    return false;
		                }


				if( ds.Tables[0].Rows.Count ==1)
				{
										if( ds.Tables[0].Rows[0].ItemArray[0].ToString() != String.Empty)
						this.assinatura = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

					if( ds.Tables[0].Rows[0].ItemArray[1].ToString() != String.Empty)
						this.cliente = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[1]);

					if( ds.Tables[0].Rows[0].ItemArray[2].ToString() != String.Empty)
						this.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);

					if( ds.Tables[0].Rows[0].ItemArray[3].ToString() != String.Empty)
						this.produto = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[3]);

					if( ds.Tables[0].Rows[0].ItemArray[4].ToString() != String.Empty)
						this.cedente = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[4]);

					if( ds.Tables[0].Rows[0].ItemArray[5].ToString() != String.Empty)
						this.cnpj = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[5]);

					if( ds.Tables[0].Rows[0].ItemArray[6].ToString() != String.Empty)
						this.banco = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[6]);

					if( ds.Tables[0].Rows[0].ItemArray[7].ToString() != String.Empty)
						this.agencia = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[7]);

					if( ds.Tables[0].Rows[0].ItemArray[8].ToString() != String.Empty)
						this.conta = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[8]);

					if( ds.Tables[0].Rows[0].ItemArray[9].ToString() != String.Empty)
						this.digito = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[9]);

					if( ds.Tables[0].Rows[0].ItemArray[10].ToString() != String.Empty)
						this.carteira = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[10]);

					if( ds.Tables[0].Rows[0].ItemArray[11].ToString() != String.Empty)
						this.vencimento = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[11]);

					if( ds.Tables[0].Rows[0].ItemArray[12].ToString() != String.Empty)
						this.quantidade = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[12]);

					if( ds.Tables[0].Rows[0].ItemArray[13].ToString() != String.Empty)
						this.preco = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[13]);

					if( ds.Tables[0].Rows[0].ItemArray[14].ToString() != String.Empty)
						this.datacriacao = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[14]);

					if( ds.Tables[0].Rows[0].ItemArray[15].ToString() != String.Empty)
						this.datapagamento = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[15]);

					if( ds.Tables[0].Rows[0].ItemArray[16].ToString() != String.Empty)
						this.tipomensalidade = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[16]);

                    if (ds.Tables[0].Rows[0].ItemArray[17].ToString() != String.Empty)
                        this.datavencimento = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[17]);

					this.NovoRegistro = false;
					return true;
				}
				else
				{
					this.mensagem = "Load retornou mais de uma linha";
					this.NovoRegistro = true;
					return false;
				}

			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return false;
			}
		}

		#endregion

		#region "Metodos Privados"

		private Boolean VerifyForeignKeys()
		{
			try
			{
				
				Boolean retorno = true;

				

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		#endregion
	}
}