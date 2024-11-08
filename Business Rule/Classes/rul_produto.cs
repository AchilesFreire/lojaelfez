	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Rule Layer                               * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_produto                              * 
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
	public class rul_produto
	{

		#region "Variaveis" 

			private  int _produto = -1;
			private  String _nome = String.Empty;
			private  String _versaoatual = String.Empty;
			private  Decimal _preco =  new Decimal(-1);


			private String _mensagem = "";
			private Boolean _NovoRegistro = true;

		#endregion

		#region "Construtures"
 
		public rul_produto()
		{
		}
		public rul_produto( int par_produto)
		{
			try
				{
					this.produto = par_produto;
 
					this.NovoRegistro = !this.Load();
				}
			catch(Exception ex)
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
				cls_produto produto = new cls_produto();
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

				this.mensagem="";

				Boolean retorno = produto.Insert();

				this.mensagem = produto.mensagem;

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
				cls_produto produto = new cls_produto();
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

				this.mensagem= "";
				
				Boolean retorno = produto.Update();

				this.mensagem = produto.mensagem;

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

				if (  this.nome == String.Empty)
				{
					this.mensagem = "O Campo nome tem que ser preenchido com Texto";
					return false;
				}
				if (  this.versaoatual == String.Empty)
				{
					this.mensagem = "O Campo versaoatual tem que ser preenchido com Texto";
					return false;
				}
				if (  this.preco ==  new Decimal(-1))
				{
					this.mensagem = "O Campo preco tem que ser preenchido com Número";
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
				cls_produto produto = new cls_produto();

				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;


				if (VerifyForeignKeys())
					{

						this.mensagem= "";
				
						Boolean retorno = produto.Delete();

						this.mensagem = produto.mensagem;

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
				cls_produto produto = new cls_produto();
				

				this.mensagem= "";
				
				Boolean retorno = produto.DeleteMasterDetail();

				this.mensagem = produto.mensagem;

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public col_produto GetAll()
		{
			try
			{
				cls_produto produto = new cls_produto();
				col_produto colecao = new col_produto();
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

				System.Data.DataSet ds = produto.GetAll();

                		if (produto.mensagem != String.Empty)
		                {
		                    this.mensagem = produto.mensagem;
		                    return null;
		                }

				for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
				{
					rul_produto item = new rul_produto();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.versaoatual = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[3]);


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
				cls_produto produto = new cls_produto();			
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

				System.Data.DataSet ds = produto.GetAll();

				this.mensagem = produto.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public col_produto FindAll()
		{

			cls_produto produto = new cls_produto();
			col_produto colecao = new col_produto();
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

			System.Data.DataSet ds = produto.FindAll();

               		if (produto.mensagem != String.Empty)
	                {
	                    this.mensagem = produto.mensagem;
	                    return null;
	                }


			for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
			{
				rul_produto item = new rul_produto();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.produto = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.versaoatual = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[3]);


				item.NovoRegistro = false;
				colecao.Add(item);
			}
			
			return colecao;

		}
		
        public System.Data.DataSet FindAllInDataSet()
		{
			try
			{
				cls_produto produto = new cls_produto();			
				
				produto.produto = this.produto;
				produto.nome = this.nome;
				produto.versaoatual = this.versaoatual;
				produto.preco = this.preco;

				System.Data.DataSet ds = produto.FindAll();

				this.mensagem = produto.mensagem;

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
				cls_produto produto = new cls_produto();			
				

				System.Data.DataSet ds = produto.GetAllMasterDetail();

				this.mensagem = produto.mensagem;

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
				cls_produto produto = new cls_produto();


				
				produto.produto = this.produto;


				System.Data.DataSet ds = produto.Load();


                		if (produto.mensagem != String.Empty)
		                {
		                    this.mensagem = produto.mensagem;
		                    return false;
		                }


				if( ds.Tables[0].Rows.Count ==1)
				{
										if( ds.Tables[0].Rows[0].ItemArray[0].ToString() != String.Empty)
						this.produto = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

					if( ds.Tables[0].Rows[0].ItemArray[1].ToString() != String.Empty)
						this.nome = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[1]);

					if( ds.Tables[0].Rows[0].ItemArray[2].ToString() != String.Empty)
						this.versaoatual = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);

					if( ds.Tables[0].Rows[0].ItemArray[3].ToString() != String.Empty)
						this.preco = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[3]);


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