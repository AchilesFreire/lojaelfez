	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Rule Layer                               * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_atualizacao                          * 
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
using LojaElfez.BusinessClass;
using LojaElfez.BusinessCollection;


namespace LojaElfez.BusinessRule
{
	public class rul_atualizacao
	{

		#region "Variaveis" 

			private  int _atualizacao = -1;
			private  int _produto = -1;
			private  String _nome = String.Empty;
			private  String _descricao = String.Empty;
			private  Decimal _preco =  new Decimal(-1);
			private  String _diretoriodownload = String.Empty;


			private String _mensagem = "";
			private Boolean _NovoRegistro = true;

		#endregion

		#region "Construtures"
 
		public rul_atualizacao()
		{
		}
		public rul_atualizacao( int par_atualizacao)
		{
			try
				{
					this.atualizacao = par_atualizacao;
 
					this.NovoRegistro = !this.Load();
				}
			catch(Exception ex)
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
				cls_atualizacao atualizacao = new cls_atualizacao();
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

				this.mensagem="";

				Boolean retorno = atualizacao.Insert();

				this.mensagem = atualizacao.mensagem;

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
				cls_atualizacao atualizacao = new cls_atualizacao();
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

				this.mensagem= "";
				
				Boolean retorno = atualizacao.Update();

				this.mensagem = atualizacao.mensagem;

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

				if (  this.produto == -1)
				{
					this.mensagem = "O Campo produto tem que ser preenchido com Inteiro";
					return false;
				}
				if (  this.nome == String.Empty)
				{
					this.mensagem = "O Campo nome tem que ser preenchido com Texto";
					return false;
				}
				if (  this.descricao == String.Empty)
				{
					this.mensagem = "O Campo descricao tem que ser preenchido com Texto";
					return false;
				}
				if (  this.preco ==  new Decimal(-1))
				{
					this.mensagem = "O Campo preco tem que ser preenchido com Número";
					return false;
				}
				if (  this.diretoriodownload == String.Empty)
				{
					this.mensagem = "O Campo diretoriodownload tem que ser preenchido com Texto";
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
				cls_atualizacao atualizacao = new cls_atualizacao();

				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;


				if (VerifyForeignKeys())
					{

						this.mensagem= "";
				
						Boolean retorno = atualizacao.Delete();

						this.mensagem = atualizacao.mensagem;

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
				cls_atualizacao atualizacao = new cls_atualizacao();
				

				this.mensagem= "";
				
				Boolean retorno = atualizacao.DeleteMasterDetail();

				this.mensagem = atualizacao.mensagem;

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public col_atualizacao GetAll()
		{
			try
			{
				cls_atualizacao atualizacao = new cls_atualizacao();
				col_atualizacao colecao = new col_atualizacao();
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

				System.Data.DataSet ds = atualizacao.GetAll();

                		if (atualizacao.mensagem != String.Empty)
		                {
		                    this.mensagem = atualizacao.mensagem;
		                    return null;
		                }

				for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
				{
					rul_atualizacao item = new rul_atualizacao();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.atualizacao = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.descricao = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[4]);

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.diretoriodownload = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();


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
				cls_atualizacao atualizacao = new cls_atualizacao();			
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

				System.Data.DataSet ds = atualizacao.GetAll();

				this.mensagem = atualizacao.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public col_atualizacao FindAll()
		{

			cls_atualizacao atualizacao = new cls_atualizacao();
			col_atualizacao colecao = new col_atualizacao();
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

			System.Data.DataSet ds = atualizacao.FindAll();

               		if (atualizacao.mensagem != String.Empty)
	                {
	                    this.mensagem = atualizacao.mensagem;
	                    return null;
	                }


			for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
			{
				rul_atualizacao item = new rul_atualizacao();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.atualizacao = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1]);

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.descricao = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[4]);

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.diretoriodownload = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();


				item.NovoRegistro = false;
				colecao.Add(item);
			}
			
			return colecao;

		}
		public System.Data.DataSet FindAllInDataSet()
		{
			try
			{
				cls_atualizacao atualizacao = new cls_atualizacao();			
				
				atualizacao.atualizacao = this.atualizacao;
				atualizacao.produto = this.produto;
				atualizacao.nome = this.nome;
				atualizacao.descricao = this.descricao;
				atualizacao.preco = this.preco;
				atualizacao.diretoriodownload = this.diretoriodownload;

				System.Data.DataSet ds = atualizacao.FindAll();

				this.mensagem = atualizacao.mensagem;

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
				cls_atualizacao atualizacao = new cls_atualizacao();			
				

				System.Data.DataSet ds = atualizacao.GetAllMasterDetail();

				this.mensagem = atualizacao.mensagem;

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
				cls_atualizacao atualizacao = new cls_atualizacao();


				
				atualizacao.atualizacao = this.atualizacao;


				System.Data.DataSet ds = atualizacao.Load();


                		if (atualizacao.mensagem != String.Empty)
		                {
		                    this.mensagem = atualizacao.mensagem;
		                    return false;
		                }


				if( ds.Tables[0].Rows.Count ==1)
				{
										if( ds.Tables[0].Rows[0].ItemArray[0].ToString() != String.Empty)
						this.atualizacao = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

					if( ds.Tables[0].Rows[0].ItemArray[1].ToString() != String.Empty)
						this.produto = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[1]);

					if( ds.Tables[0].Rows[0].ItemArray[2].ToString() != String.Empty)
						this.nome = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);

					if( ds.Tables[0].Rows[0].ItemArray[3].ToString() != String.Empty)
						this.descricao = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[3]);

					if( ds.Tables[0].Rows[0].ItemArray[4].ToString() != String.Empty)
						this.preco = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[4]);

					if( ds.Tables[0].Rows[0].ItemArray[5].ToString() != String.Empty)
						this.diretoriodownload = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[5]);


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