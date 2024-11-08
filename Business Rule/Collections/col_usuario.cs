	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Collection Layer                         * 
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
using LojaElfez.BusinessRule;

namespace LojaElfez.BusinessCollection
{  
	/// <summary>
	/// Definicao da collection col_usuario
	/// Esta classe representa uma lista de objetos da tabela usuario (representados pela classe rul_usuario) no banco de dados
	/// 
	/// </summary>
	public class col_usuario : System.Collections.CollectionBase 
	{
		public col_usuario()
		{
		}
		public col_usuario( int par_usuario)
		{
			rul_usuario usuario = new rul_usuario();


			usuario.usuario = par_usuario;
 

			col_usuario lista = usuario.GetAll();
				
			foreach (rul_usuario item in lista)
			{
				this.Add(item);
			}

		}

		public void Add (rul_usuario item)
		{
			List.Add( item);
		}

		public void Remove (rul_usuario item)
		{
			List.Remove(item);
		}

		public int Find(rul_usuario item)
		{
			return List.IndexOf(item);
		}

		public rul_usuario Item(int index)
		{
			return (rul_usuario) List[index];
		}
	}
}