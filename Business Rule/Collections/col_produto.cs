	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Collection Layer                         * 
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
using LojaElfez.BusinessRule;

namespace LojaElfez.BusinessCollection
{  
	/// <summary>
	/// Definicao da collection col_produto
	/// Esta classe representa uma lista de objetos da tabela produto (representados pela classe rul_produto) no banco de dados
	/// 
	/// </summary>
	public class col_produto : System.Collections.CollectionBase 
	{
		public col_produto()
		{
		}
		public col_produto( int par_produto)
		{
			rul_produto produto = new rul_produto();


			produto.produto = par_produto;
 

			col_produto lista = produto.GetAll();
				
			foreach (rul_produto item in lista)
			{
				this.Add(item);
			}

		}

		public void Add (rul_produto item)
		{
			List.Add( item);
		}

		public void Remove (rul_produto item)
		{
			List.Remove(item);
		}

		public int Find(rul_produto item)
		{
			return List.IndexOf(item);
		}

		public rul_produto Item(int index)
		{
			return (rul_produto) List[index];
		}
	}
}