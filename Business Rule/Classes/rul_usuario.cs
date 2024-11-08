	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Rule Layer                               * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_usuario                              * 
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
using LojaElfez.BusinessClass;
using LojaElfez.BusinessCollection;


namespace LojaElfez.BusinessRule
{
	public class rul_usuario
	{

		#region "Variaveis" 

			private  int _usuario = -1;
			private  String _nome = String.Empty;
			private  String _login = String.Empty;
			private  String _senha = String.Empty;


			private String _mensagem = "";
			private Boolean _NovoRegistro = true;

		#endregion

		#region "Construtures"
 
		public rul_usuario()
		{
		}
		public rul_usuario( int par_usuario)
		{
			try
				{
					this.usuario = par_usuario;
 
					this.NovoRegistro = !this.Load();
				}
			catch(Exception ex)
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
				cls_usuario usuario = new cls_usuario();
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

				this.mensagem="";

				Boolean retorno = usuario.Insert();

				this.mensagem = usuario.mensagem;

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
				cls_usuario usuario = new cls_usuario();
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

				this.mensagem= "";
				
				Boolean retorno = usuario.Update();

				this.mensagem = usuario.mensagem;

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
				if (  this.login == String.Empty)
				{
					this.mensagem = "O Campo login tem que ser preenchido com Texto";
					return false;
				}
				if (  this.senha == String.Empty)
				{
					this.mensagem = "O Campo senha tem que ser preenchido com Texto";
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
				cls_usuario usuario = new cls_usuario();

				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;


				if (VerifyForeignKeys())
					{

						this.mensagem= "";
				
						Boolean retorno = usuario.Delete();

						this.mensagem = usuario.mensagem;

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
				cls_usuario usuario = new cls_usuario();
				

				this.mensagem= "";
				
				Boolean retorno = usuario.DeleteMasterDetail();

				this.mensagem = usuario.mensagem;

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public col_usuario GetAll()
		{
			try
			{
				cls_usuario usuario = new cls_usuario();
				col_usuario colecao = new col_usuario();
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

				System.Data.DataSet ds = usuario.GetAll();

                		if (usuario.mensagem != String.Empty)
		                {
		                    this.mensagem = usuario.mensagem;
		                    return null;
		                }

				for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
				{
					rul_usuario item = new rul_usuario();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.usuario = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.login = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.senha = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();


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
				cls_usuario usuario = new cls_usuario();			
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

				System.Data.DataSet ds = usuario.GetAll();

				this.mensagem = usuario.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public col_usuario FindAll()
		{

			cls_usuario usuario = new cls_usuario();
			col_usuario colecao = new col_usuario();
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

			System.Data.DataSet ds = usuario.FindAll();

               		if (usuario.mensagem != String.Empty)
	                {
	                    this.mensagem = usuario.mensagem;
	                    return null;
	                }


			for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
			{
				rul_usuario item = new rul_usuario();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.usuario = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.login = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.senha = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();


				item.NovoRegistro = false;
				colecao.Add(item);
			}
			
			return colecao;

		}
		public System.Data.DataSet FindAllInDataSet()
		{
			try
			{
				cls_usuario usuario = new cls_usuario();			
				
				usuario.usuario = this.usuario;
				usuario.nome = this.nome;
				usuario.login = this.login;
				usuario.senha = this.senha;

				System.Data.DataSet ds = usuario.FindAll();

				this.mensagem = usuario.mensagem;

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
				cls_usuario usuario = new cls_usuario();			
				

				System.Data.DataSet ds = usuario.GetAllMasterDetail();

				this.mensagem = usuario.mensagem;

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
				cls_usuario usuario = new cls_usuario();


				
				usuario.usuario = this.usuario;


				System.Data.DataSet ds = usuario.Load();


                		if (usuario.mensagem != String.Empty)
		                {
		                    this.mensagem = usuario.mensagem;
		                    return false;
		                }


				if( ds.Tables[0].Rows.Count ==1)
				{
										if( ds.Tables[0].Rows[0].ItemArray[0].ToString() != String.Empty)
						this.usuario = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

					if( ds.Tables[0].Rows[0].ItemArray[1].ToString() != String.Empty)
						this.nome = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[1]);

					if( ds.Tables[0].Rows[0].ItemArray[2].ToString() != String.Empty)
						this.login = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);

					if( ds.Tables[0].Rows[0].ItemArray[3].ToString() != String.Empty)
						this.senha = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[3]);


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