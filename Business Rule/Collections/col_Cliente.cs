	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Collection Layer                         * 
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
using LojaElfez.BusinessRule;

namespace LojaElfez.BusinessCollection
{  
	/// <summary>
	/// Definicao da collection col_Cliente
	/// Esta classe representa uma lista de objetos da tabela Cliente (representados pela classe rul_Cliente) no banco de dados
	/// 
	/// </summary>
	public class col_Cliente : System.Collections.CollectionBase 
	{
		public col_Cliente()
		{
		}
		public col_Cliente( int par_cliente)
		{
			rul_Cliente Cliente = new rul_Cliente();


			Cliente.cliente = par_cliente;
 

			col_Cliente lista = Cliente.GetAll();
				
			foreach (rul_Cliente item in lista)
			{
				this.Add(item);
			}

		}

		public void Add (rul_Cliente item)
		{
			List.Add( item);
		}

		public void Remove (rul_Cliente item)
		{
			List.Remove(item);
		}

		public int Find(rul_Cliente item)
		{
			return List.IndexOf(item);
		}

		public rul_Cliente Item(int index)
		{
			return (rul_Cliente) List[index];
		}
	}
}