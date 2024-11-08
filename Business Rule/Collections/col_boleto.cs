	/********************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Collection Layer                         * 
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
using LojaElfez.BusinessRule;

namespace LojaElfez.BusinessCollection
{  
	/// <summary>
	/// Definicao da collection col_boleto
	/// Esta classe representa uma lista de objetos da tabela boleto (representados pela classe rul_boleto) no banco de dados
	/// 
	/// </summary>
	public class col_boleto : System.Collections.CollectionBase 
	{
		public col_boleto()
		{
		}
		public col_boleto( int par_boleto)
		{
			rul_assinatura boleto = new rul_assinatura();


			boleto.assinatura = par_boleto;
 

			col_boleto lista = boleto.GetAll();
				
			foreach (rul_assinatura item in lista)
			{
				this.Add(item);
			}

		}

		public void Add (rul_assinatura item)
		{
			List.Add( item);
		}

		public void Remove (rul_assinatura item)
		{
			List.Remove(item);
		}

		public int Find(rul_assinatura item)
		{
			return List.IndexOf(item);
		}

		public rul_assinatura Item(int index)
		{
			return (rul_assinatura) List[index];
		}
	}
}