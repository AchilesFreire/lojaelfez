	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Rule Layer                               * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: frm_Cliente                              * 
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
	public class rul_Cliente
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
			private Boolean _NovoRegistro = true;

		#endregion

		#region "Construtures"
 
		public rul_Cliente()
		{
		}
		public rul_Cliente( int par_cliente)
		{
			try
				{
					this.cliente = par_cliente;
 
					this.NovoRegistro = !this.Load();
				}
			catch(Exception ex)
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
				cls_Cliente Cliente = new cls_Cliente();
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = System.DateTime.Now;

				this.mensagem="";

				Boolean retorno = Cliente.Insert();

				this.mensagem = Cliente.mensagem;

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
				cls_Cliente Cliente = new cls_Cliente();
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;

				this.mensagem= "";
				
				Boolean retorno = Cliente.Update();

				this.mensagem = Cliente.mensagem;

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
				if (  this.email == String.Empty)
				{
					this.mensagem = "O Campo email tem que ser preenchido com Texto";
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
				cls_Cliente Cliente = new cls_Cliente();

				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;


				if (VerifyForeignKeys())
					{

						this.mensagem= "";
				
						Boolean retorno = Cliente.Delete();

						this.mensagem = Cliente.mensagem;

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
				cls_Cliente Cliente = new cls_Cliente();
				

				this.mensagem= "";
				
				Boolean retorno = Cliente.DeleteMasterDetail();

				this.mensagem = Cliente.mensagem;

				return retorno;

			}
			catch(Exception ex)
			{
			this.mensagem = ex.Message;
			return false;
			}
		}

		public col_Cliente GetAll()
		{
			try
			{
				cls_Cliente Cliente = new cls_Cliente();
				col_Cliente colecao = new col_Cliente();
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;

				System.Data.DataSet ds = Cliente.GetAll();

                		if (Cliente.mensagem != String.Empty)
		                {
		                    this.mensagem = Cliente.mensagem;
		                    return null;
		                }

				for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
				{
					rul_Cliente item = new rul_Cliente();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.cliente = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.email = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.endereco = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.bairro = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[6].ToString() != String.Empty)
						item.cidade = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[7].ToString() != String.Empty)
						item.estado = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[8].ToString() != String.Empty)
						item.ddd = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[9].ToString() != String.Empty)
						item.telefonefixo = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[10].ToString() != String.Empty)
						item.telefonecelular = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[11].ToString() != String.Empty)
						item.cep = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[11]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[12].ToString() != String.Empty)
						item.observacoes = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[12]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[13].ToString() != String.Empty)
						item.login = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[13]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[14].ToString() != String.Empty)
						item.senha = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[14]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[15].ToString() != String.Empty)
						item.datainclusao = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[15]);


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
				cls_Cliente Cliente = new cls_Cliente();			
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;

				System.Data.DataSet ds = Cliente.GetAll();

				this.mensagem = Cliente.mensagem;

				return ds;
			}
			catch (Exception ex)
			{
				this.mensagem = ex.Message;
				return null;
			}
		}

		public col_Cliente FindAll()
		{

			cls_Cliente Cliente = new cls_Cliente();
			col_Cliente colecao = new col_Cliente();
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;

			System.Data.DataSet ds = Cliente.FindAll();

               		if (Cliente.mensagem != String.Empty)
	                {
	                    this.mensagem = Cliente.mensagem;
	                    return null;
	                }


			for ( int i =0 ; i <  ds.Tables[0].Rows.Count ; i++)
			{
				rul_Cliente item = new rul_Cliente();
					if( ds.Tables[0].Rows[i].ItemArray[0].ToString() != String.Empty)
						item.cliente = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);

					if( ds.Tables[0].Rows[i].ItemArray[1].ToString() != String.Empty)
						item.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[2].ToString() != String.Empty)
						item.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[3].ToString() != String.Empty)
						item.email = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[4].ToString() != String.Empty)
						item.endereco = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[5].ToString() != String.Empty)
						item.bairro = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[6].ToString() != String.Empty)
						item.cidade = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[7].ToString() != String.Empty)
						item.estado = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[8].ToString() != String.Empty)
						item.ddd = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[9].ToString() != String.Empty)
						item.telefonefixo = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[9]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[10].ToString() != String.Empty)
						item.telefonecelular = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[10]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[11].ToString() != String.Empty)
						item.cep = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[11]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[12].ToString() != String.Empty)
						item.observacoes = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[12]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[13].ToString() != String.Empty)
						item.login = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[13]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[14].ToString() != String.Empty)
						item.senha = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[14]).Trim();

					if( ds.Tables[0].Rows[i].ItemArray[15].ToString() != String.Empty)
						item.datainclusao = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[15]);


				item.NovoRegistro = false;
				colecao.Add(item);
			}
			
			return colecao;

		}
		public System.Data.DataSet FindAllInDataSet()
		{
			try
			{
				cls_Cliente Cliente = new cls_Cliente();			
				
				Cliente.cliente = this.cliente;
				Cliente.cpf_cnpj = this.cpf_cnpj;
				Cliente.nome = this.nome;
				Cliente.email = this.email;
				Cliente.endereco = this.endereco;
				Cliente.bairro = this.bairro;
				Cliente.cidade = this.cidade;
				Cliente.estado = this.estado;
				Cliente.ddd = this.ddd;
				Cliente.telefonefixo = this.telefonefixo;
				Cliente.telefonecelular = this.telefonecelular;
				Cliente.cep = this.cep;
				Cliente.observacoes = this.observacoes;
				Cliente.login = this.login;
				Cliente.senha = this.senha;
				Cliente.datainclusao = this.datainclusao;

				System.Data.DataSet ds = Cliente.FindAll();

				this.mensagem = Cliente.mensagem;

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
				cls_Cliente Cliente = new cls_Cliente();			
				

				System.Data.DataSet ds = Cliente.GetAllMasterDetail();

				this.mensagem = Cliente.mensagem;

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
				cls_Cliente Cliente = new cls_Cliente();


				
				Cliente.cliente = this.cliente;


				System.Data.DataSet ds = Cliente.Load();


                		if (Cliente.mensagem != String.Empty)
		                {
		                    this.mensagem = Cliente.mensagem;
		                    return false;
		                }


				if( ds.Tables[0].Rows.Count ==1)
				{
										if( ds.Tables[0].Rows[0].ItemArray[0].ToString() != String.Empty)
						this.cliente = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

					if( ds.Tables[0].Rows[0].ItemArray[1].ToString() != String.Empty)
						this.cpf_cnpj = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[1]);

					if( ds.Tables[0].Rows[0].ItemArray[2].ToString() != String.Empty)
						this.nome = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[2]);

					if( ds.Tables[0].Rows[0].ItemArray[3].ToString() != String.Empty)
						this.email = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[3]);

					if( ds.Tables[0].Rows[0].ItemArray[4].ToString() != String.Empty)
						this.endereco = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[4]);

					if( ds.Tables[0].Rows[0].ItemArray[5].ToString() != String.Empty)
						this.bairro = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[5]);

					if( ds.Tables[0].Rows[0].ItemArray[6].ToString() != String.Empty)
						this.cidade = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[6]);

					if( ds.Tables[0].Rows[0].ItemArray[7].ToString() != String.Empty)
						this.estado = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[7]);

					if( ds.Tables[0].Rows[0].ItemArray[8].ToString() != String.Empty)
						this.ddd = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[8]);

					if( ds.Tables[0].Rows[0].ItemArray[9].ToString() != String.Empty)
						this.telefonefixo = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[9]);

					if( ds.Tables[0].Rows[0].ItemArray[10].ToString() != String.Empty)
						this.telefonecelular = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[10]);

					if( ds.Tables[0].Rows[0].ItemArray[11].ToString() != String.Empty)
						this.cep = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[11]);

					if( ds.Tables[0].Rows[0].ItemArray[12].ToString() != String.Empty)
						this.observacoes = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[12]);

					if( ds.Tables[0].Rows[0].ItemArray[13].ToString() != String.Empty)
						this.login = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[13]);

					if( ds.Tables[0].Rows[0].ItemArray[14].ToString() != String.Empty)
						this.senha = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[14]);

					if( ds.Tables[0].Rows[0].ItemArray[15].ToString() != String.Empty)
						this.datainclusao = Convert.ToDateTime(ds.Tables[0].Rows[0].ItemArray[15]);


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


        public void ValidaCliente()
        {
            try
            {
                cls_Cliente Cliente = new cls_Cliente();
                Cliente.email = this.email;

                Cliente.ValidaCliente();

                _mensagem = Cliente.mensagem;

            }
            catch (Exception ex)
            {
                _mensagem = ex.Message;
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